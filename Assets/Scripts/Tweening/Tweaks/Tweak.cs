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
        public abstract void SetTime(float normalizedPassedTime, Ease ease, bool backward = false);

        //public abstract void SetTimeReverse(float normalizedPassedTime, Ease ease, bool backward = false);

        //public static Tweak Create(float from, float to, Action<float> setter)
        //{
        //    return new TweakFloat(from, to, setter);
        //}
    }

    public abstract class Tweak<T> : Tweak
	{
        #region Properties
        public T From { get; set; }

        public T To { get; set; }

        private Action<T> _setter;
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

        protected abstract T Evaluate(float normalizedPassedTime, Ease ease, bool backward = false);

        public sealed override void SetTime(float normalizedPassedTime, Ease ease, bool backward = false)
        {
            CallSetter(Evaluate(normalizedPassedTime, ease, backward));
        }

        
    }
}