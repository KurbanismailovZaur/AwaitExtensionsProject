using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static UnityEngine.Debug;
using Numba.Tweening.Tweaks;
using Numba.Tweening;
using System;

namespace Numba.Tweening.Tweaks
{
	public sealed class TweakFloat : Tweak<float> 
	{
        private TweakFloat() { }

        public TweakFloat(float from, float to, Action<float> setter) : base(from, to, setter) { }

        protected override float Evaluate(float normalizedPassedTime, Ease ease, bool backward = false)
        {
            return backward ? Easing.Ease(To, From, normalizedPassedTime, ease) : Easing.Ease(From, To, normalizedPassedTime, ease);
        }
    }
}