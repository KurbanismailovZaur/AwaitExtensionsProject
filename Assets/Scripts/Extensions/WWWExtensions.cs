using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static UnityEngine.Debug;
using System.Runtime.CompilerServices;
using Numba.Await.Engine;

/// <summary>
/// Extensions for awaiting WWW download operations.
/// </summary>
public static class WWWExtensions
{
    public static TaskAwaiter<WWW> GetAwaiter(this WWW www)
    {
        TaskCompletionSource<WWW> taskSource = new TaskCompletionSource<WWW>();
        RoutineHelper.Instance.StartCoroutine(WaitForRoutine(www, taskSource));

        return taskSource.Task.GetAwaiter();
    }

    private static IEnumerator WaitForRoutine(WWW www, TaskCompletionSource<WWW> taskSource)
    {
        yield return www;
        taskSource.SetResult(www);
    }
}