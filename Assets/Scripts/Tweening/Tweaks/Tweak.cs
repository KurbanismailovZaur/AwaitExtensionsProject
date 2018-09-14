using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweening.Tweaks
{
    public abstract class Tweak
    {
        public abstract void SetTime(float normalizedTime, Ease ease);

        public abstract void SetTime(float normalizedTime, AnimationCurve curve);

        public abstract void SetTimeBackward(float normalizedTime, Ease ease);

        public abstract void SetTimeBackward(float normalizedTime, AnimationCurve curve);

        public abstract void Increment();
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