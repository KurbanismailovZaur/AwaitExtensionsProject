using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static UnityEngine.Debug;
using static UnityEngine.Mathf;
using System;

namespace Numba.Tweening
{
    /// <summary>
    /// Represent a tweens container. May play them all sequentially.
    /// </summary>
	public class Sequence
    {
        #region Structures and classes
        private struct TweenData
        {
            public Tween Tween { get; private set; }

            public float StartTime { get; private set; }

            public TweenData(Tween tween, float startTime)
            {
                Tween = tween;
                StartTime = startTime;
            }
        }

        private struct CallbackData
        {
            public Action Callback { get; private set; }

            public float StartTime { get; private set; }

            public CallbackData(Action callback, float startTime)
            {
                Callback = callback;
                StartTime = startTime;
            }
        }

        private struct FilteredTweensAndCallbacks
        {
            public List<TweenData> StartedTweens { get; set; }

            public List<TweenData> ContinuousTweens { get; set; }

            public List<TweenData> CompletedTweens { get; set; }

            public List<CallbackData> CompletedCallbacks { get; set; }

            public FilteredTweensAndCallbacks(List<TweenData> startedTweens, List<TweenData> continuousTweens, List<TweenData> completedTweens, List<CallbackData> completedCallbacks)
            {
                StartedTweens = startedTweens;
                ContinuousTweens = continuousTweens;
                CompletedTweens = completedTweens;
                CompletedCallbacks = completedCallbacks;
            }
        }
        #endregion

        #region Fields
        private List<TweenData> _tweensDatas = new List<TweenData>();

        private List<CallbackData> _callbacksDatas = new List<CallbackData>();

        private float _endTime;

        private bool _isPlaying;

        private TaskCompletionSource<object> _taskSource;

        private Dictionary<Tween, float> _tweenDurations = new Dictionary<Tween, float>();
        #endregion

        #region Constructors
        /// <summary>
        /// Create empty sequence.
        /// </summary>
        public Sequence() : this(string.Empty) { }

        /// <summary>
        /// Create empty sequence with name.
        /// </summary>
        public Sequence(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Create sequence and add all tweens in zero time position.
        /// </summary>
        /// <param name="tweens">Tweens which will be added.</param>
        public Sequence(params Tween[] tweens) : this(string.Empty, tweens) { }

        /// <summary>
        /// Create sequence with name and add all tweens in zero time position.
        /// </summary>
        /// <param name="tweens">Tweens which will be added.</param>
        public Sequence(string name, params Tween[] tweens)
        {
            foreach (var tween in tweens)
            {
                Insert(0f, tween);
            }
        }
        #endregion

        #region Properties
        public string Name { get; private set; }

        public int LoopsCount { get; set; } = 1;

        public LoopType LoopType { get; set; }
        #endregion

        #region Methods
        public void Append(Tween tween)
        {
            _tweensDatas.Add(new TweenData(tween, _endTime));
            _endTime += CalculateAndCacheDuration(tween);
        }

        public void Append(Action callback)
        {
            _callbacksDatas.Add(new CallbackData(callback, _endTime));
        }

        public void Insert(float time, Tween tween)
        {
            _tweensDatas.Add(new TweenData(tween, time));
            _endTime = Max(_endTime, time + CalculateAndCacheDuration(tween));
        }

        public void Insert(float time, Action callback)
        {
            _callbacksDatas.Add(new CallbackData(callback, time));
            _endTime = Max(_endTime, time);
        }

        private float CalculateAndCacheDuration(Tween tween)
        {
            int loopsCount = tween.LoopsCount == -1 ? 1 : tween.LoopsCount;
            float duration = loopsCount * tween.Duration;
            if (tween.LoopType == LoopType.Yoyo || tween.LoopType == LoopType.ReversedYoyo) duration *= 2f;

            _tweenDurations.Add(tween, duration);

            return duration;
        }

        private float GetTweenDuration(Tween tween) => _tweenDurations[tween];

        public Task PlayAsync()
        {
            if (_isPlaying)
            {
                LogWarning($"Sequence with name \"{Name}\"is already playing.");
                return _taskSource.Task;
            }

            _isPlaying = true;
            _taskSource = new TaskCompletionSource<object>();

            PlayTimeAsync().CatchErrors();

            return _taskSource.Task;
        }

        private async Task PlayTimeAsync()
        {
            #region Catching class data for prevent changing
            int loopsCount = LoopsCount;
            LoopType loopType = LoopType;
            #endregion

            float startTime = Time.time;
            float endTime = startTime + _endTime;
            float previousTime = -1f;

            while (Time.time < endTime)
            {
                float timePassed = Time.time - startTime;

                FilteredTweensAndCallbacks filteredTweensAndCallbacks = FindTweensAndCallbacksBetween(previousTime, timePassed);

                foreach (var tweenData in filteredTweensAndCallbacks.StartedTweens)
                    tweenData.Tween.Tweak.SetTime((timePassed - tweenData.StartTime) / GetTweenDuration(tweenData.Tween), tweenData.Tween.Ease);

                foreach (var tweenData in filteredTweensAndCallbacks.ContinuousTweens)
                    tweenData.Tween.Tweak.SetTime((timePassed - tweenData.StartTime) / GetTweenDuration(tweenData.Tween), tweenData.Tween.Ease);

                foreach (var tweenData in filteredTweensAndCallbacks.CompletedTweens)
                    tweenData.Tween.Tweak.SetTime(1f, tweenData.Tween.Ease);

                foreach (var callbackData in filteredTweensAndCallbacks.CompletedCallbacks) callbackData.Callback();

                previousTime = timePassed;
                await new WaitForUpdate();
            }

            _isPlaying = false;
            _taskSource.SetResult(null);
        }

        private FilteredTweensAndCallbacks FindTweensAndCallbacksBetween(float startTime, float endTime)
        {
            List<TweenData> startedTweens = new List<TweenData>();
            List<TweenData> continuousTweens = new List<TweenData>();
            List<TweenData> completedTweens = new List<TweenData>();
            List<CallbackData> completedCallbacks = new List<CallbackData>();

            foreach (var tweenData in _tweensDatas)
            {
                float tweenEndTime = tweenData.StartTime + GetTweenDuration(tweenData.Tween);

                if (IsValueBetween(tweenEndTime, startTime, endTime) && tweenEndTime != startTime)
                {
                    completedTweens.Add(tweenData);
                    continue;
                }

                if (tweenEndTime <= startTime || tweenData.StartTime > endTime) continue;

                if (tweenData.StartTime > startTime && tweenData.StartTime <= endTime) startedTweens.Add(tweenData);
                else continuousTweens.Add(tweenData);
            }

            foreach (var callbackData in _callbacksDatas)
                if (IsValueBetween(callbackData.StartTime, startTime, endTime) && callbackData.StartTime != startTime) completedCallbacks.Add(callbackData);

            startedTweens.Sort((x, y) => x.StartTime.CompareTo(y.StartTime));
            continuousTweens.Sort((x, y) => x.StartTime.CompareTo(y.StartTime));
            completedTweens.Sort((x, y) => (x.StartTime + GetTweenDuration(x.Tween)).CompareTo(y.StartTime + GetTweenDuration(y.Tween)));
            completedCallbacks.Sort((x, y) => x.StartTime.CompareTo(y.StartTime));

            return new FilteredTweensAndCallbacks(startedTweens, continuousTweens, completedTweens, completedCallbacks);
        }

        private bool IsValueBetween(float value, float startTime, float endTime) => value >= startTime && value <= endTime;
        #endregion
    }
}