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
        #endregion

        #region Properties
        public string Name { get; private set; }

        public Tweak Tweak { get; private set; }

        public float Duration { get; private set; }

        public Ease Ease { get; set; }

        public int LoopCount { get; set; }

        public LoopType LoopType { get; set; }
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
            Duration = duration;
        }
        #endregion

        public Tween SetEase(Ease ease)
        {
            Ease = ease;
            return this;
        }

        public Tween SetLoopsCount(int count)
        {
            LoopCount = count;
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
            Ease ease = Ease;
            int loopsCount = LoopCount;
            LoopType loopType = LoopType;
            #endregion
            
            float startTime = Time.time;
            float endTime = startTime + Duration;

            if (loopType == LoopType.Forward)
            {
                await PlayTimeForwardAsync(startTime, endTime, ease);
            }
            else if (loopType == LoopType.Backward)
            {
                await PlayTimeBackwardAsync(startTime, endTime, ease);
            }
            else if (loopType == LoopType.Reverse)
            {
                await PlayTimeReversedAsync(startTime, endTime, ease);
            }

            _isPlaying = false;
            _taskSource.SetResult(null);
        }

        #region Play ways
        private async Task PlayTimeForwardAsync(float startTime, float endTime, Ease ease)
        {
            while (Time.time < endTime)
            {
                Tweak.SetTime((Time.time - startTime) / Duration, ease);

                await new WaitForUpdate();
            }

            Tweak.SetTime(1f, ease);
        }

        private async Task PlayTimeBackwardAsync(float startTime, float endTime, Ease ease)
        {
            while (Time.time < endTime)
            {
                Tweak.SetTime((Time.time - startTime) / Duration, ease, true);

                await new WaitForUpdate();
            }

            Tweak.SetTime(1f, ease, true);
        }

        private async Task PlayTimeReversedAsync(float startTime, float endTime, Ease ease)
        {
            while (Time.time < endTime)
            {
                CalculateReverseAndCallSetter(startTime, ease);
                await new WaitForUpdate();
            }

            CalculateReverseAndCallSetter(startTime, ease);
        }

        private void CalculateReverseAndCallSetter(float startTime, Ease ease)
        {
            float reversedPassedNormalizedTime = 1f - ((Time.time - startTime) / Duration);
            float reverseValue = Tweak.Evaluate(reversedPassedNormalizedTime, ease);

            Tweak.CallSetter(reverseValue);
        }
        #endregion
    }
}