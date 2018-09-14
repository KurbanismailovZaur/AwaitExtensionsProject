using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweening.Tweaks
{
    public sealed class TweakVector2 : Tweak<Vector2>
    {
        private TweakVector2() { }

        public TweakVector2(Vector2 from, Vector2 to, Action<Vector2> setter) : base(from, to, setter) { }

        public override void Increment()
        {
            Vector2 change = To - From;
            From = To;
            To = To + change;
        }

        protected override Vector2 Evaluate(float normalizedPassedTime, Ease ease) => Easing.Ease(From, To, normalizedPassedTime, ease);

        protected override Vector2 EvaluateBackward(float normalizedPassedTime, Ease ease) => Easing.Ease(To, From, normalizedPassedTime, ease);

        protected override Vector2 Evaluate(float normalizedTime, AnimationCurve curve) => Easing.Ease(From, To, normalizedTime, curve);

        protected override Vector2 EvaluateBackward(float normalizedTime, AnimationCurve curve) => Easing.Ease(To, From, normalizedTime, curve);
    }
}