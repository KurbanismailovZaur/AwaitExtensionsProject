using System.Collections;
using UnityEngine;
using Numba.Tweening.Tweaks;
using Numba.Tweening.Engine;
using System;

namespace Numba.Tweening
{
    public class Tween
    {
        #region Create
        #region Float
        public static Tween Create(float from, float to, Action<float> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Create(null, from, to, setter, duration, ease, loopsCount, loopType);

        public static Tween Create(string name, float from, float to, Action<float> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Create(name, Tweak.Create(from, to, setter), duration, ease, loopsCount, loopType);
        #endregion

        #region Double
        public static Tween Create(double from, double to, Action<double> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Create(null, from, to, setter, duration, ease, loopsCount, loopType);

        public static Tween Create(string name, double from, double to, Action<double> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Create(name, Tweak.Create(from, to, setter), duration, ease, loopsCount, loopType);
        #endregion

        #region Int
        public static Tween Create(int from, int to, Action<int> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Create(null, from, to, setter, duration, ease, loopsCount, loopType);

        public static Tween Create(string name, int from, int to, Action<int> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Create(name, Tweak.Create(from, to, setter), duration, ease, loopsCount, loopType);
        #endregion

        #region Long
        public static Tween Create(long from, long to, Action<long> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Create(null, from, to, setter, duration, ease, loopsCount, loopType);

        public static Tween Create(string name, long from, long to, Action<long> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Create(name, Tweak.Create(from, to, setter), duration, ease, loopsCount, loopType);
        #endregion

        #region Vector2
        public static Tween Create(Vector2 from, Vector2 to, Action<Vector2> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Create(null, from, to, setter, duration, ease, loopsCount, loopType);

        public static Tween Create(string name, Vector2 from, Vector2 to, Action<Vector2> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Create(name, Tweak.Create(from, to, setter), duration, ease, loopsCount, loopType);
        #endregion

        #region Vector3
        public static Tween Create(Vector3 from, Vector3 to, Action<Vector3> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Create(null, from, to, setter, duration, ease, loopsCount, loopType);

        public static Tween Create(string name, Vector3 from, Vector3 to, Action<Vector3> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Create(name, Tweak.Create(from, to, setter), duration, ease, loopsCount, loopType);
        #endregion

        #region Vector4
        public static Tween Create(Vector4 from, Vector4 to, Action<Vector4> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Create(null, from, to, setter, duration, ease, loopsCount, loopType);

        public static Tween Create(string name, Vector4 from, Vector4 to, Action<Vector4> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Create(name, Tweak.Create(from, to, setter), duration, ease, loopsCount, loopType);
        #endregion

        #region Quaternion
        public static Tween Create(Quaternion from, Quaternion to, Action<Quaternion> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Create(null, from, to, setter, duration, ease, loopsCount, loopType);

        public static Tween Create(string name, Quaternion from, Quaternion to, Action<Quaternion> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Create(name, Tweak.Create(from, to, setter), duration, ease, loopsCount, loopType);
        #endregion

        #region Color
        public static Tween Create(Color from, Color to, Action<Color> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Create(null, from, to, setter, duration, ease, loopsCount, loopType);

        public static Tween Create(string name, Color from, Color to, Action<Color> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Create(name, Tweak.Create(from, to, setter), duration, ease, loopsCount, loopType);
        #endregion

        #region Color32
        public static Tween Create(Color32 from, Color32 to, Action<Color32> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Create(null, from, to, setter, duration, ease, loopsCount, loopType);

        public static Tween Create(string name, Color32 from, Color32 to, Action<Color32> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Create(name, Tweak.Create(from, to, setter), duration, ease, loopsCount, loopType);
        #endregion

        #region DateTime
        public static Tween Create(DateTime from, DateTime to, Action<DateTime> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Create(null, from, to, setter, duration, ease, loopsCount, loopType);

        public static Tween Create(string name, DateTime from, DateTime to, Action<DateTime> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Create(name, Tweak.Create(from, to, setter), duration, ease, loopsCount, loopType);
        #endregion

        #region Rect
        public static Tween Create(Rect from, Rect to, Action<Rect> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Create(null, from, to, setter, duration, ease, loopsCount, loopType);

        public static Tween Create(string name, Rect from, Rect to, Action<Rect> setter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Create(name, Tweak.Create(from, to, setter), duration, ease, loopsCount, loopType);
        #endregion

        #region Tweak
        public static Tween Create(Tweak tweak, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Create(null, tweak, duration, ease, loopsCount, loopType);

        public static Tween Create(string name, Tweak tweak, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => new Tween(name, tweak, duration).SetEase(ease).SetLoops(loopsCount, loopType);
        #endregion
        #endregion

        #region Fields
        private Coroutine _playTimeRoutine;

        private int _loopsCount = 1;

        private bool _stopRequested;

        private Ease _ease;

        private AnimationCurve _curve = new AnimationCurve();
        #endregion

        #region Constructors
        private Tween() { }

        public Tween(Tweak tweak, float duration) : this(null, tweak, duration) { }

        public Tween(string name, Tweak tweak, float duration)
        {
            Name = name?? "[Noname]";
            Tweak = tweak;
            Duration = Mathf.Max(0f, duration);
        }
        #endregion

        #region Properties
        public string Name { get; private set; }

        public Tweak Tweak { get; private set; }

        public bool IsPlaying { get { return _playTimeRoutine != null; } }

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

        public Coroutine Play()
        {
            if (IsPlaying)
            {
                Debug.LogWarning($"Tween with name \"{Name}\" already playing.");
                return _playTimeRoutine;
            }

            return _playTimeRoutine = RoutineHelper.Instance.StartCoroutine(PlayTime(UsedEaseType, Ease, new AnimationCurve(_curve.keys), LoopsCount, LoopType));
        }

        private IEnumerator PlayTime(EaseType usedEaseType, Ease ease, AnimationCurve curve, int loopsCount, LoopType loopType)
        {
            float startTime = Time.time;

            bool isInfinityLoops = loopsCount == -1;
            if (isInfinityLoops) loopsCount = 1;

            float duration = Duration * loopsCount;
            if (loopType == LoopType.Yoyo || loopType == LoopType.ReversedYoyo) duration *= 2f;

            float endTime = startTime + duration;

            while (isInfinityLoops)
            {
                yield return null;

                if (_stopRequested)
                {
                    HandleStop();
                    yield break;
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
                yield return null;
                SetTime((Mathf.Min(Time.time, endTime) - startTime) / duration, usedEaseType, ease, curve, loopsCount, loopType);

                if (_stopRequested)
                {
                    HandleStop();
                    yield break;
                }
            }

            _playTimeRoutine = null;
        }

        public void Stop()
        {
            if (!IsPlaying)
            {
                Debug.LogWarning($"Tween with name \"{Name}\" already stoped.");
                return;
            }

            _stopRequested = true;
        }

        private void HandleStop()
        {
            _stopRequested = false;
            _playTimeRoutine = null;
        }
        #endregion
    }
}