using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static UnityEngine.Debug;
using System;

namespace Numba.Tweening
{
    public class Tween
    {
        #region Fields
        private bool _isPlaying;

        private TaskCompletionSource<object> _taskSource;

        private int _loopsCount = 1;
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
                    normalizedPassedTime = normalizedPassedTime * loopsCount * 2;
                    bool isReversed = IsYoyoBackward(normalizedPassedTime);

                    if (isReversed)
                    {
                        float value = Tweak.Evaluate(1f - Wrap01(normalizedPassedTime), ease);
                        Tweak.SetTime(Wrap01(value), ease);
                    }
                    else Tweak.SetTime(Wrap01(normalizedPassedTime), ease);

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

            _isPlaying = true;
            _taskSource = new TaskCompletionSource<object>();

            PlayTimeAsync().CatchErrors();

            return _taskSource.Task;
        }

        private async Task PlayTimeAsync()
        {
            #region Catching class data for prevent changing
            float duration = Duration;
            Ease ease = Ease;
            int loopsCount = _loopsCount;
            LoopType loopType = LoopType;
            #endregion

            while (loopsCount != 0)
            {
                float startTime = Time.time;

                switch (loopType)
                {
                    case LoopType.Forward:
                        await PlayTimeForwardAsync(startTime, ease);
                        break;
                    case LoopType.Backward:
                        await PlayTimeBackwardAsync(startTime, ease);
                        break;
                    case LoopType.Reversed:
                        await PlayTimeReversedAsync(startTime, ease);
                        break;
                    case LoopType.Yoyo:
                        await PlayTimeYoyoAsync(startTime, ease);
                        break;
                    case LoopType.ReversedYoyo:
                        await PlayTimeReversedYoyoAsync(startTime, ease);
                        break;
                }

                if (loopsCount != -1) --loopsCount;
            }

            _isPlaying = false;
            _taskSource.SetResult(null);
        }

        #region Play ways
        private async Task PlayTimeForwardAsync(float startTime, Ease ease)
        {
            float endTime = startTime + Duration;

            while (Time.time < endTime)
            {
                Tweak.SetTime((Time.time - startTime) / Duration, ease);

                await new WaitForUpdate();
            }

            Tweak.SetTime(1f, ease);
        }

        private async Task PlayTimeBackwardAsync(float startTime, Ease ease)
        {
            float endTime = startTime + Duration;

            while (Time.time < endTime)
            {
                Tweak.SetTime((Time.time - startTime) / Duration, ease, true);

                await new WaitForUpdate();
            }

            Tweak.SetTime(1f, ease, true);
        }

        private async Task PlayTimeReversedAsync(float startTime, Ease ease)
        {
            float endTime = startTime + Duration;

            while (Time.time < endTime)
            {
                CalculateReverseAndCallSetter(startTime, ease);
                await new WaitForUpdate();
            }

            Tweak.SetTime(0f, ease);
        }

        private void CalculateReverseAndCallSetter(float startTime, Ease ease)
        {
            float reverseValue = Tweak.Evaluate(1f - ((Time.time - startTime) / Duration), ease);
            Tweak.CallSetter(reverseValue);
        }

        private async Task PlayTimeYoyoAsync(float startTime, Ease ease)
        {
            await PlayTimeForwardAsync(startTime, ease);
            await PlayTimeBackwardAsync(startTime + Duration, ease);
        }

        private async Task PlayTimeReversedYoyoAsync(float startTime, Ease ease)
        {
            await PlayTimeForwardAsync(startTime, ease);
            await PlayTimeReversedAsync(startTime + Duration, ease);
        }
        #endregion
        #endregion
    }
}