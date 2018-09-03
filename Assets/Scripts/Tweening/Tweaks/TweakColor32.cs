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
    public sealed class TweakColor32 : Tweak<Color32>
    {
        private TweakColor32() { }

        public TweakColor32(Color32 from, Color32 to, Action<Color32> setter) : base(from, to, setter) { }

        public override void Increment()
        {
            Color32 change = ((Color)To) - From;
            From = To;
            To = ((Color)To) + change;
        }

        protected override Color32 Evaluate(float normalizedPassedTime, Ease ease) => (Color)Easing.Ease((Color)From, (Color)To, normalizedPassedTime, ease);

        protected override Color32 EvaluateBackward(float normalizedPassedTime, Ease ease) => (Color)Easing.Ease((Color)To, (Color)From, normalizedPassedTime, ease);

        protected override Color32 Evaluate(float normalizedTime, AnimationCurve curve) => Easing.Ease(From, To, normalizedTime, curve);

        protected override Color32 EvaluateBackward(float normalizedTime, AnimationCurve curve) => Easing.Ease(To, From, normalizedTime, curve);
    }
}