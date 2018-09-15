using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweening.Tweaks
{
    public sealed class TweakFloat : Tweak<float>
    {
        private TweakFloat() { }

        public TweakFloat(float from, float to, Action<float> setter) : base(from, to, setter) { }

        protected override float Evaluate(float normalizedPassedTime, Ease ease) => Easing.Ease(From, To, normalizedPassedTime, ease);

        protected override float EvaluateBackward(float normalizedPassedTime, Ease ease) => Easing.Ease(To, From, normalizedPassedTime, ease);

        protected override float Evaluate(float normalizedTime, AnimationCurve curve) => Easing.Ease(From, To, normalizedTime, curve);

        protected override float EvaluateBackward(float normalizedTime, AnimationCurve curve) => Easing.Ease(To, From, normalizedTime, curve);
    }
}