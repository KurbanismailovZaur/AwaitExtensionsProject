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
    public sealed class TweakColor : Tweak<Color>
    {
        private TweakColor() { }

        public TweakColor(Color from, Color to, Action<Color> setter) : base(from, to, setter) { }

        public override void Increment()
        {
            Color change = To- From;
            From = To;
            To = To + change;
        }

        protected override Color Evaluate(float normalizedPassedTime, Ease ease) => Easing.Ease(From, To, normalizedPassedTime, ease);

        protected override Color EvaluateBackward(float normalizedPassedTime, Ease ease) => Easing.Ease(To, From, normalizedPassedTime, ease);
    }
}