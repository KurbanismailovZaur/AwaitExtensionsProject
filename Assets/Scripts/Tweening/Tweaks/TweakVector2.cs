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

        protected override Vector2 Evaluate(float normalizedPassedTime, Ease ease) => Evaluate(From.x, From.y, To.x, To.y, normalizedPassedTime, ease);

        protected override Vector2 EvaluateBackward(float normalizedPassedTime, Ease ease) => Evaluate(To.x, To.y, From.x, From.y, normalizedPassedTime, ease);

        private Vector2 Evaluate(float fromX, float fromY, float toX, float toY, float normalizedPassedTime, Ease ease)
        {
            float x = Easing.Ease(fromX, toX, normalizedPassedTime, ease);
            float y = Easing.Ease(fromY, toY, normalizedPassedTime, ease);

            return new Vector2(x, y);
        }
    }
}