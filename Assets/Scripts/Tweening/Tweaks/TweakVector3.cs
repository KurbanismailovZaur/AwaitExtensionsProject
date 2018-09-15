using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweening.Tweaks
{
    public sealed class TweakVector3 : Tweak<Vector3>
    {
        private TweakVector3() { }

        public TweakVector3(Vector3 from, Vector3 to, Action<Vector3> setter) : base(from, to, setter) { }

        protected override Vector3 Evaluate(float normalizedPassedTime, Ease ease) => Easing.Ease(From, To, normalizedPassedTime, ease);

        protected override Vector3 EvaluateBackward(float normalizedPassedTime, Ease ease) => Easing.Ease(To, From, normalizedPassedTime, ease);

        protected override Vector3 Evaluate(float normalizedTime, AnimationCurve curve) => Easing.Ease(From, To, normalizedTime, curve);

        protected override Vector3 EvaluateBackward(float normalizedTime, AnimationCurve curve) => Easing.Ease(To, From, normalizedTime, curve);
    }
}