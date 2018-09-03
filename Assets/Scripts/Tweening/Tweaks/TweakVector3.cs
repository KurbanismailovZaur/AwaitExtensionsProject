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
    public sealed class TweakVector3 : Tweak<Vector3>
    {
        private TweakVector3() { }

        public TweakVector3(Vector3 from, Vector3 to, Action<Vector3> setter) : base(from, to, setter) { }

        public override void Increment()
        {
            Vector3 change = To - From;
            From = To;
            To = To + change;
        }

        protected override Vector3 Evaluate(float normalizedPassedTime, Ease ease) => Easing.Ease(From, To, normalizedPassedTime, ease);

        protected override Vector3 EvaluateBackward(float normalizedPassedTime, Ease ease) => Easing.Ease(To, From, normalizedPassedTime, ease);
    }
}