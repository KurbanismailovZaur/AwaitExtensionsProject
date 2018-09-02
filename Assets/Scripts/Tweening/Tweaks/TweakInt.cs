using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static UnityEngine.Debug;
using System;

namespace Numba.Tweening.Tweaks
{
    public sealed class TweakInt : Tweak<int>
    {
        private TweakInt() { }

        public TweakInt(int from, int to, Action<int> setter) : base(from, to, setter) { }

        public override void Increment()
        {
            int change = To - From;
            From = To;
            To = To + change;
        }

        protected override int Evaluate(float normalizedPassedTime, Ease ease) => (int)Easing.Ease(From, To, normalizedPassedTime, ease);

        protected override int EvaluateBackward(float normalizedPassedTime, Ease ease) => (int)Easing.Ease(To, From, normalizedPassedTime, ease);
    }
}