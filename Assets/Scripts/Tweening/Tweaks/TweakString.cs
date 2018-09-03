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
    public sealed class TweakString : Tweak<string>
    {
        private TweakString() { }

        public TweakString(string from, string to, Action<string> setter) : base(from, to, setter) { }

        public override void Increment()
        {
            From = To;
            To = To + To;
        }

        protected override string Evaluate(float normalizedPassedTime, Ease ease) => To;

        protected override string EvaluateBackward(float normalizedPassedTime, Ease ease) => From;
    }
}