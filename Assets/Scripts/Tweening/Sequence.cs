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
        #region Structures
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
        #endregion

        #region Fields
        private List<TweenData> _tweensDatas = new List<TweenData>();

        private List<CallbackData> _callbacks = new List<CallbackData>(); 

        private float _endTime;

        private bool _isPlaying;

        private TaskCompletionSource<object> _taskSource;
        #endregion

        /// <summary>
        /// Create empty sequence.
        /// </summary>
        public Sequence() { }

        /// <summary>
        /// Create sequence and add all tweens in zero time position.
        /// </summary>
        /// <param name="tweens">Tweens which will be added.</param>
        public Sequence(params Tween[] tweens)
        {
            foreach (var tween in tweens)
            {
                Insert(0f, tween);
            }
        }

        public void Append(Tween tween)
        {
            _tweensDatas.Add(new TweenData(tween, _endTime));
            _endTime += tween.Duration;
        }

        public void Append(Action callback)
        {
            _callbacks.Add(new CallbackData(callback, _endTime));
        }

        public void Insert(float time, Tween tween)
        {
            _tweensDatas.Add(new TweenData(tween, time));
            _endTime = Max(_endTime, time + tween.Duration);
        }

        public void Insert(float time, Action callback)
        {
            _callbacks.Add(new CallbackData(callback, time));
            _endTime = Max(_endTime, time);
        }

        public Task PlayAsync()
        {
            if (_isPlaying)
            {
                LogWarning("Sequence is already playing.");
                return _taskSource.Task;
            }

            CreateRoutineAsync().CatchErrors();

            return _taskSource.Task;
        }

        private async Task CreateRoutineAsync()
        {
            _isPlaying = true;
            TaskCompletionSource<object> taskSource = new TaskCompletionSource<object>();

            

            _isPlaying = false;
            _taskSource.SetResult(null);
        }
	}
}