using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static UnityEngine.Debug;
using Numba.Await.Engine;
using System.Runtime.CompilerServices;

namespace Numba.Await.Extensions
{
	public static class WaitForExtension 
	{
		public static TaskAwaiter GetAwaiter(this WaitForSeconds waitForSeconds)
        {
            TaskCompletionSource<object> taskSource = new TaskCompletionSource<object>();
            RoutineHelper.Instance.StartCoroutine(WaitForRoutine(waitForSeconds, taskSource));

            return ((Task)(taskSource.Task)).GetAwaiter();
        }

        private static IEnumerator WaitForRoutine(YieldInstruction instruction, TaskCompletionSource<object> taskSource)
        {
            yield return instruction;
            taskSource.SetResult(null);
        }
	}
}