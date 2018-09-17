using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweening.Tweaks
{
    public sealed class TweakBounds : Tweak<Bounds>
    {
        private TweakBounds() { }

        public TweakBounds(Bounds from, Bounds to, Action<Bounds> setter) : base(from, to, setter) { }

        protected override Bounds Evaluate(float normalizedPassedTime, Ease ease) => new Bounds(Easing.Ease(From.center, To.center, normalizedPassedTime, ease), Easing.Ease(From.size, To.size, normalizedPassedTime, ease));

        protected override Bounds EvaluateBackward(float normalizedPassedTime, Ease ease) => new Bounds(Easing.Ease(To.center, From.center, normalizedPassedTime, ease), Easing.Ease(To.size, From.size, normalizedPassedTime, ease));

        protected override Bounds Evaluate(float normalizedTime, AnimationCurve curve) => new Bounds(Easing.Ease(From.center, To.center, normalizedTime, curve), Easing.Ease(From.size, To.size, normalizedTime, curve));

        protected override Bounds EvaluateBackward(float normalizedTime, AnimationCurve curve) => new Bounds(Easing.Ease(To.center, From.center, normalizedTime, curve), Easing.Ease(To.size, From.size, normalizedTime, curve));
    }
}