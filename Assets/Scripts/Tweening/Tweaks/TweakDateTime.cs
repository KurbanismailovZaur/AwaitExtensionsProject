using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweening.Tweaks
{
    public sealed class TweakDateTime : Tweak<DateTime>
    {
        private TweakDateTime() { }

        public TweakDateTime(DateTime from, DateTime to, Action<DateTime> setter) : base(from, to, setter) { }

        public override void Increment()
        {
            TimeSpan change = To - From;
            From = To;
            To = To + change;
        }

        protected override DateTime Evaluate(float normalizedPassedTime, Ease ease) => Easing.Ease(From, To, normalizedPassedTime, ease);

        protected override DateTime EvaluateBackward(float normalizedPassedTime, Ease ease) => Easing.Ease(To, From, normalizedPassedTime, ease);

        protected override DateTime Evaluate(float normalizedTime, AnimationCurve curve) => Easing.Ease(From, To, normalizedTime, curve);

        protected override DateTime EvaluateBackward(float normalizedTime, AnimationCurve curve) => Easing.Ease(To, From, normalizedTime, curve);
    }
}