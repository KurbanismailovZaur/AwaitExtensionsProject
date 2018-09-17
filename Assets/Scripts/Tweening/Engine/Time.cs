using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static UnityEngine.Debug;

namespace Numba.Tweening.Engine
{
	public class Time
    {
		public Tween DoTimeScale(float timeScale, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(UnityEngine.Time.timeScale, timeScale, (ts) => UnityEngine.Time.timeScale = ts, duration, ease, loopsCount, loopType);
        }
	}
}