using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweening.Tweaks
{
    public sealed class TweakLong : Tweak<long>
    {
        private TweakLong() { }

        public TweakLong(long from, long to, Action<long> setter) : base(from, to, setter) { }

        protected override long Evaluate(float normalizedPassedTime, Ease ease) => (long)Easing.Ease(From, To, normalizedPassedTime, ease);

        protected override long EvaluateBackward(float normalizedPassedTime, Ease ease) => (long)Easing.Ease(To, From, normalizedPassedTime, ease);

        protected override long Evaluate(float normalizedTime, AnimationCurve curve) => Easing.Ease(From, To, normalizedTime, curve);

        protected override long EvaluateBackward(float normalizedTime, AnimationCurve curve) => Easing.Ease(To, From, normalizedTime, curve);
    }
}