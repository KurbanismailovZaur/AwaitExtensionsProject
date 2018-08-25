using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static UnityEngine.Debug;
using Numba.Await.Engine;
using System.Runtime.CompilerServices;

/// <summary>
/// Extensions for awaiting unity Wait* classes.
/// </summary>
public static class WaitExtensions
{
    #region Wait classes awaiters
    public static TaskAwaiter GetAwaiter(this WaitForEndOfFrame waitForEndOfFrame) => GetAwaiterForInstuction(waitForEndOfFrame);

    public static TaskAwaiter GetAwaiter(this WaitForFixedUpdate waitForFixedUpdate) => GetAwaiterForInstuction(waitForFixedUpdate);

    public static TaskAwaiter GetAwaiter(this WaitForSeconds waitForSeconds) => GetAwaiterForInstuction(waitForSeconds);

    public static TaskAwaiter GetAwaiter(this WaitForSecondsRealtime waitForSecondsRealtime) => GetAwaiterForInstuction(waitForSecondsRealtime);

    public static TaskAwaiter GetAwaiter(this WaitUntil waitUntil) => GetAwaiterForInstuction(waitUntil);

    public static TaskAwaiter GetAwaiter(this WaitWhile waitWhile) => GetAwaiterForInstuction(waitWhile);
    #endregion

    private static TaskAwaiter GetAwaiterForInstuction(object instruction)
    {
        TaskCompletionSource<object> taskSource = new TaskCompletionSource<object>();
        RoutineHelper.Instance.StartCoroutine(WaitForRoutine(instruction, taskSource));

        return ((Task)(taskSource.Task)).GetAwaiter();
    }

    private static IEnumerator WaitForRoutine(object instruction, TaskCompletionSource<object> taskSource)
    {
        yield return instruction;
        taskSource.SetResult(null);
    }
}