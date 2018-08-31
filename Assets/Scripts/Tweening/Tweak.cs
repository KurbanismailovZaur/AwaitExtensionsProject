using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static UnityEngine.Debug;
using Numba.Tweening;
using System;

namespace Numba.Tweening
{
	public class Tweak 
	{
        #region Properties
        public float From { get; set; }

        public float To { get; set; }

        private Action<float> _setter;
        #endregion

        #region Constructors
        private Tweak() { }

        public Tweak(float from, float to, Action<float> setter)
        {
            From = from;
            To = to;
            _setter = setter;
        }
        #endregion

        public void SetSetter(Action<float> setter)
        {
            _setter = setter;
        }

        public void CallSetter(float value)
        {
            _setter?.Invoke(value);
        }

        public float Evaluate(float normalizedPassedTime, Ease ease, bool backward = false)
        {
            return backward ? Easing.Ease(To, From, normalizedPassedTime, ease) : Easing.Ease(From, To, normalizedPassedTime, ease);
        }

        public void SetTime(float normalizedPassedTime, Ease ease, bool backward = false)
        {
            _setter?.Invoke(Evaluate(normalizedPassedTime, ease, backward));
        }
    }
}