using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static UnityEngine.Debug;
using System;

namespace Numba.Tweening.Tweaks
{
    public abstract class Tweak
    {
        public abstract void SetTime(float normalizedPassedTime, Ease ease);

        public abstract void SetTimeBackward(float normalizedPassedTime, Ease ease);

        public abstract void Increment();
    }

    public abstract class Tweak<T> : Tweak
	{
        #region Properties
        public T From { get; set; }

        public T To { get; set; }

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

        protected abstract T Evaluate(float normalizedPassedTime, Ease ease);

        protected abstract T EvaluateBackward(float normalizedPassedTime, Ease ease);

        public sealed override void SetTime(float normalizedPassedTime, Ease ease)
        {
            CallSetter(Evaluate(normalizedPassedTime, ease));
        }

        public sealed override void SetTimeBackward(float normalizedPassedTime, Ease ease)
        {
            CallSetter(EvaluateBackward(normalizedPassedTime, ease));
        }
    }
}