using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static UnityEngine.Debug;
using System;
using System.Threading;

namespace Numba.Tweening
{
    public class Tween
    {
        #region Fields
        private bool _isPlaying;

        private TaskCompletionSource<object> _taskSource;

        private int _loopsCount = 1;

        private bool _stopRequested;
        #endregion

        #region Constructors
        private Tween() { }

        public Tween(float from, float to, Action<float> setter, float duration) : this(string.Empty, from, to, setter, duration) { }

        public Tween(string name, float from, float to, Action<float> setter, float duration) : this(name, new Tweak(from, to, setter), duration) { }

        public Tween(Tweak tweak, float duration) : this(string.Empty, tweak, duration) { }

        public Tween(string name, Tweak tweak, float duration)
        {
            Name = name;
            Tweak = tweak;
            Duration = Mathf.Max(0f, duration);
        }
        #endregion

        #region Properties
        public string Name { get; private set; }

        public Tweak Tweak { get; private set; }

        public float Duration { get; private set; }

        public Ease Ease { get; set; }

        public int LoopsCount
        {
            get { return _loopsCount; }
            set { _loopsCount = Mathf.Max(value, -1); }
        }

        public LoopType LoopType { get; set; }
        #endregion

        #region Methods
        public Tween SetEase(Ease ease)
        {
            Ease = ease;
            return this;
        }

        public Tween SetLoopsCount(int count)
        {
            LoopsCount = count;
            return this;
        }

        public Tween SetLoopType(LoopType loopType)
        {
            LoopType = loopType;
            return this;
        }

        public Tween SetLoops(int count, LoopType loopType)
        {
            SetLoopsCount(count);
            SetLoopType(loopType);

            return this;
        }

        public void SetTime(float normalizedPassedTime) => SetTime(normalizedPassedTime, Ease, _loopsCount, LoopType);

        private void SetTime(float normalizedPassedTime, Ease ease, int loopsCount, LoopType loopType)
        {
            if (loopsCount == -1) loopsCount = 1;

            switch (loopType)
            {
                case LoopType.Forward:
                    Tweak.SetTime(Wrap01(normalizedPassedTime * loopsCount), ease);
                    break;
                case LoopType.Backward:
                    Tweak.SetTime(Wrap01(normalizedPassedTime * loopsCount), ease, true);
                    break;
                case LoopType.Reversed:
                    float reverseValue = Tweak.Evaluate(1f - Wrap01(normalizedPassedTime * loopsCount), ease);
                    Tweak.CallSetter(reverseValue);
                    break;
                case LoopType.Yoyo:
                    normalizedPassedTime = normalizedPassedTime * loopsCount * 2;
                    Tweak.SetTime(Wrap01(normalizedPassedTime), ease, IsYoyoBackward(normalizedPassedTime));
                    break;
                case LoopType.ReversedYoyo:
                    float scaledTime = normalizedPassedTime * loopsCount * 2;
                    Tweak.SetTime(IsYoyoBackward(scaledTime) ? 1f - Wrap01(scaledTime) : Wrap01(scaledTime), ease);
                    break;
            }
        }

        private float Wrap01(float value)
        {
            int intPart = (int)value;
            float fraction = value - intPart;

            return (intPart != 0 && fraction == 0) ? 1f : fraction;
        }

        private bool IsYoyoBackward(float value)
        {
            int intPart = (int)value;
            if (intPart == 0) return false;

            float fraction = value - intPart;
            bool isEven = (intPart % 2) == 0;

            return (!isEven && fraction == 0f) || (isEven && fraction != 0f) ? false : true;
        }

        public Task PlayAsync()
        {
            if (_isPlaying)
            {
                LogWarning($"Tween with name \"{Name}\" already playing.");
                return _taskSource.Task;
            }

            PlayTimeAsync(Ease, LoopsCount, LoopType).CatchErrors();

            return _taskSource.Task;
        }

        private async Task PlayTimeAsync(Ease ease, int loopsCount, LoopType loopType)
        {
            _isPlaying = true;
            _taskSource = new TaskCompletionSource<object>();

            float startTime = Time.time;

            bool isInfinityLoops = loopsCount == -1;
            if (isInfinityLoops) loopsCount = 1;

            float duration = Duration * loopsCount;
            if (loopType == LoopType.Yoyo || loopType == LoopType.ReversedYoyo) duration *= 2f;
            
            float endTime = startTime + duration;

            while (isInfinityLoops)
            {
                float normalizedPassedTime = (Time.time - startTime) / duration;

                SetTime(normalizedPassedTime, ease, loopsCount, loopType);
                await new WaitForUpdate();

                while (endTime < Time.time)
                {
                    startTime = endTime;
                    endTime = startTime + duration;
                }

                if (_stopRequested)
                {
                    HandleStop();
                    return;
                }
            }

            while (Time.time < endTime)
            {
                SetTime((Time.time - startTime) / duration, ease, loopsCount, loopType);
                await new WaitForUpdate();

                if (_stopRequested)
                {
                    HandleStop();
                    return;
                }
            }

            SetTime(1f, ease, loopsCount, loopType);

            _isPlaying = false;
            _taskSource.SetResult(null);
        }

        public void Stop()
        {
            if (!_isPlaying)
            {
                LogWarning($"Tween with name \"{Name}\" already playing.");
                return;
            }

            _stopRequested = true;
        }

        private void HandleStop()
        {
            _stopRequested = false;
            _isPlaying = false;
            _taskSource.SetResult(null);
        }
        #endregion
    }
}