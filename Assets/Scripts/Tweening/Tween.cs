using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static UnityEngine.Debug;
using System;
using System.Threading;
using Numba.Tweening.Tweaks;

namespace Numba.Tweening
{
    public class Tween
    {
        #region Fields
        private bool _isPlaying;

        private TaskCompletionSource<object> _taskSource;

        private int _loopsCount = 1;

        private bool _stopRequested;

        private Ease _ease;

        private AnimationCurve _curve = new AnimationCurve();
        #endregion

        #region Constructors
        private Tween() { }

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

        public EaseType UsedEaseType { get; set; }

        public Ease Ease
        {
            get { return _ease; }
            set
            {
                _ease = value;
                UsedEaseType = EaseType.Formula;
            }
        }

        public AnimationCurve Curve
        {
            get { return _curve; }
            set
            {
                _curve.keys = value.keys;
                UsedEaseType = EaseType.Curve;
            }
        }

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

        public Tween SetEase(AnimationCurve curve)
        {
            Curve = curve;
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

        public void SetTime(float normalizedTime) => SetTime(normalizedTime, UsedEaseType, Ease, _curve, _loopsCount, LoopType);

        private void SetTime(float normalizedTime, EaseType usedEaseType, Ease ease, AnimationCurve curve, int loopsCount, LoopType loopType)
        {
            if (loopsCount == -1) loopsCount = 1;

            switch (loopType)
            {
                case LoopType.Forward:
                    if (usedEaseType == EaseType.Formula) Tweak.SetTime(Wrap01(normalizedTime * loopsCount), ease);
                    else Tweak.SetTime(Wrap01(normalizedTime * loopsCount), curve);
                    break;
                case LoopType.Backward:
                    if (usedEaseType == EaseType.Formula) Tweak.SetTimeBackward(Wrap01(normalizedTime * loopsCount), ease);
                    else Tweak.SetTimeBackward(Wrap01(normalizedTime * loopsCount), curve);
                    break;
                case LoopType.Reversed:
                    if (usedEaseType == EaseType.Formula) Tweak.SetTime(1f - Wrap01(normalizedTime * loopsCount), ease);
                    else Tweak.SetTime(1f - Wrap01(normalizedTime * loopsCount), curve);
                    break;
                case LoopType.Yoyo:
                    normalizedTime = normalizedTime * loopsCount * 2;

                    if (IsYoyoBackward(normalizedTime))
                    {
                        if (usedEaseType == EaseType.Formula) Tweak.SetTimeBackward(Wrap01(normalizedTime), ease);
                        else Tweak.SetTimeBackward(Wrap01(normalizedTime), curve);
                    }
                    else
                    {
                        if (usedEaseType == EaseType.Formula) Tweak.SetTime(Wrap01(normalizedTime), ease);
                        else Tweak.SetTime(Wrap01(normalizedTime), curve);
                    }

                    break;
                case LoopType.ReversedYoyo:
                    float scaledTime = normalizedTime * loopsCount * 2;

                    if (IsYoyoBackward(scaledTime))
                    {
                        if (usedEaseType == EaseType.Formula) Tweak.SetTime(1f - Wrap01(scaledTime), ease);
                        else Tweak.SetTime(1f - Wrap01(scaledTime), curve);
                    }
                    else
                    {
                        if (usedEaseType == EaseType.Formula) Tweak.SetTime(Wrap01(scaledTime), ease);
                        else Tweak.SetTime(Wrap01(scaledTime), curve);
                    }
                    
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

            PlayTimeAsync(UsedEaseType, Ease, new AnimationCurve(_curve.keys), LoopsCount, LoopType).CatchErrors();

            return _taskSource.Task;
        }

        private async Task PlayTimeAsync(EaseType usedEaseType, Ease ease, AnimationCurve curve, int loopsCount, LoopType loopType)
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
                await new WaitForUpdate();

                if (_stopRequested)
                {
                    HandleStop();
                    return;
                }

                float normalizedTime = (Time.time - startTime) / duration;
                SetTime(normalizedTime, usedEaseType, ease, curve, loopsCount, loopType);

                while (endTime < Time.time)
                {
                    startTime = endTime;
                    endTime = startTime + duration;
                }
            }

            while (Time.time < endTime)
            {
                await new WaitForUpdate();
                SetTime((Mathf.Min(Time.time, endTime) - startTime) / duration, usedEaseType, ease, curve, loopsCount, loopType);

                if (_stopRequested)
                {
                    HandleStop();
                    return;
                }
            }

            _isPlaying = false;
            _taskSource.SetResult(null);
        }

        public void Stop()
        {
            if (!_isPlaying)
            {
                LogWarning($"Tween with name \"{Name}\" already stoped.");
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