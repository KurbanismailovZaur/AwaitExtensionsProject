using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

namespace Numba.Tweening.Tweaks
{
    public abstract class Tweak
    {
        #region Create
        public static Tweak Create(float from, float to, Action<float> setter) => new TweakFloat(from, to, setter);

        public static Tweak Create(double from, double to, Action<double> setter) => new TweakDouble(from, to, setter);

        public static Tweak Create(int from, int to, Action<int> setter) => new TweakInt(from, to, setter);

        public static Tweak Create(long from, long to, Action<long> setter) => new TweakLong(from, to, setter);

        public static Tweak Create(Vector2 from, Vector2 to, Action<Vector2> setter) => new TweakVector2(from, to, setter);

        public static Tweak Create(Vector3 from, Vector3 to, Action<Vector3> setter) => new TweakVector3(from, to, setter);

        public static Tweak Create(Vector4 from, Vector4 to, Action<Vector4> setter) => new TweakVector4(from, to, setter);

        public static Tweak Create(Quaternion from, Quaternion to, Action<Quaternion> setter) => new TweakQuaternion(from, to, setter);

        public static Tweak Create(Color from, Color to, Action<Color> setter) => new TweakColor(from, to, setter);

        public static Tweak Create(Color32 from, Color32 to, Action<Color32> setter) => new TweakColor32(from, to, setter);

        public static Tweak Create(DateTime from, DateTime to, Action<DateTime> setter) => new TweakDateTime(from, to, setter);

        public static Tweak Create(Rect from, Rect to, Action<Rect> setter) => new TweakRect(from, to, setter);

        public static Tweak Create(Bounds from, Bounds to, Action<Bounds> setter) => new TweakBounds(from, to, setter);

        public static Tweak Create(ColorBlock from, ColorBlock to, Action<ColorBlock> setter) => new TweakColorBlock(from, to, setter);
        #endregion

        public abstract void SetTime(float normalizedTime, Ease ease);

        public abstract void SetTime(float normalizedTime, AnimationCurve curve);

        public abstract void SetTimeBackward(float normalizedTime, Ease ease);

        public abstract void SetTimeBackward(float normalizedTime, AnimationCurve curve);
    }

    public abstract class Tweak<T> : Tweak
	{
        #region Properties
        public T From { get; protected set; }

        public T To { get; protected set; }

        protected Action<T> _setter;
        #endregion

        #region Constructors
        protected Tweak() { }

        protected Tweak(T from, T to, Action<T> setter)
        {
            From = from;
            To = to;
            _setter = setter;
        }
        #endregion

        public void SetSetter(Action<T> setter)
        {
            _setter = setter;
        }

        public void CallSetter(T value)
        {
            _setter?.Invoke(value);
        }

        protected abstract T Evaluate(float normalizedTime, Ease ease);

        protected abstract T Evaluate(float normalizedTime, AnimationCurve curve);

        protected abstract T EvaluateBackward(float normalizedTime, Ease ease);

        protected abstract T EvaluateBackward(float normalizedTime, AnimationCurve curve);

        public sealed override void SetTime(float normalizedTime, Ease ease)
        {
            CallSetter(Evaluate(normalizedTime, ease));
        }

        public override void SetTime(float normalizedTime, AnimationCurve curve)
        {
            CallSetter(Evaluate(normalizedTime, curve));
        }

        public sealed override void SetTimeBackward(float normalizedTime, Ease ease)
        {
            CallSetter(EvaluateBackward(normalizedTime, ease));
        }

        public sealed override void SetTimeBackward(float normalizedTime, AnimationCurve curve)
        {
            CallSetter(EvaluateBackward(normalizedTime, curve));
        }
    }
}