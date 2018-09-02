using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static UnityEngine.Debug;
using System;

namespace Numba.Tweening.Tweaks
{
    public sealed class TweakLong : Tweak<long>
    {
        private TweakLong() { }

        public TweakLong(long from, long to, Action<long> setter) : base(from, to, setter) { }

        public override void Increment()
        {
            long change = To - From;
            From = To;
            To = To + change;
        }

        protected override long Evaluate(float normalizedPassedTime, Ease ease) => (long)Easing.Ease(From, To, normalizedPassedTime, ease);

        protected override long EvaluateBackward(float normalizedPassedTime, Ease ease) => (long)Easing.Ease(To, From, normalizedPassedTime, ease);
    }
}