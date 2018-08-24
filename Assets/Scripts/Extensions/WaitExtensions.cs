using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static UnityEngine.Debug;
using Numba.Await.Engine;
using System.Runtime.CompilerServices;

namespace Numba.Await.Extensions
{
    public static class WaitExtensions
    {
        #region Wait classes
        public static TaskAwaiter GetAwaiter(this WaitForEndOfFrame waitForEndOfFrame) => GetAwaiter<YieldInstruction>(waitForEndOfFrame);

        public static TaskAwaiter GetAwaiter(this WaitForFixedUpdate waitForFixedUpdate) => GetAwaiter<YieldInstruction>(waitForFixedUpdate);

        public static TaskAwaiter GetAwaiter(this WaitForSeconds waitForSeconds) => GetAwaiter<YieldInstruction>(waitForSeconds);

        public static TaskAwaiter GetAwaiter(this WaitForSecondsRealtime waitForSecondsRealtime) => GetAwaiter<CustomYieldInstruction>(waitForSecondsRealtime);

        public static TaskAwaiter GetAwaiter(this WaitUntil waitUntil) => GetAwaiter<CustomYieldInstruction>(waitUntil);

        public static TaskAwaiter GetAwaiter(this WaitWhile waitWhile) => GetAwaiter<CustomYieldInstruction>(waitWhile);
        #endregion

        private static TaskAwaiter GetAwaiter<T>(T instruction)
        {
            TaskCompletionSource<object> taskSource = new TaskCompletionSource<object>();
            RoutineHelper.Instance.StartCoroutine(WaitForRoutine(instruction, taskSource));

            return ((Task)(taskSource.Task)).GetAwaiter();
        }

        private static IEnumerator WaitForRoutine<T>(T instruction, TaskCompletionSource<object> taskSource)
        {
            yield return instruction;
            taskSource.SetResult(null);
        }
    }
}