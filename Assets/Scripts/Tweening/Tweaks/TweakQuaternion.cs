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
    public sealed class TweakQuaternion : Tweak<Quaternion>
    {
        private TweakQuaternion() { }

        public TweakQuaternion(Quaternion from, Quaternion to, Action<Quaternion> setter) : base(from, to, setter) { }

        public override void Increment()
        {
            Quaternion oldFrom = From;
            From = To;
            To = To * oldFrom;
        }

        protected override Quaternion Evaluate(float normalizedPassedTime, Ease ease) => Easing.Ease(From, To, normalizedPassedTime, ease);

        protected override Quaternion EvaluateBackward(float normalizedPassedTime, Ease ease) => Easing.Ease(To, From, normalizedPassedTime, ease);
    }
}