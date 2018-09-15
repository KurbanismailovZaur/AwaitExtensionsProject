using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweening.Tweaks
{
    public sealed class TweakInt : Tweak<int>
    {
        private TweakInt() { }

        public TweakInt(int from, int to, Action<int> setter) : base(from, to, setter) { }

        protected override int Evaluate(float normalizedPassedTime, Ease ease) => (int)Easing.Ease(From, To, normalizedPassedTime, ease);

        protected override int EvaluateBackward(float normalizedPassedTime, Ease ease) => (int)Easing.Ease(To, From, normalizedPassedTime, ease);

        protected override int Evaluate(float normalizedTime, AnimationCurve curve) => Easing.Ease(From, To, normalizedTime, curve);

        protected override int EvaluateBackward(float normalizedTime, AnimationCurve curve) => Easing.Ease(To, From, normalizedTime, curve);
    }
}