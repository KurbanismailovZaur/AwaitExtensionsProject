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
    public sealed class TweakRect : Tweak<Rect>
    {
        private TweakRect() { }

        public TweakRect(Rect from, Rect to, Action<Rect> setter) : base(from, to, setter) { }

        public override void Increment()
        {
            Vector2 positionChange = To.position - From.position;
            Vector2 sizeChange = To.size - From.size;

            From = To;
            To = new Rect(To.position + positionChange, To.size + sizeChange);
        }

        protected override Rect Evaluate(float normalizedPassedTime, Ease ease) => Easing.Ease(From, To, normalizedPassedTime, ease);

        protected override Rect EvaluateBackward(float normalizedPassedTime, Ease ease) => Easing.Ease(To, From, normalizedPassedTime, ease);

        protected override Rect Evaluate(float normalizedTime, AnimationCurve curve) => Easing.Ease(From, To, normalizedTime, curve);

        protected override Rect EvaluateBackward(float normalizedTime, AnimationCurve curve) => Easing.Ease(To, From, normalizedTime, curve);
    }
}