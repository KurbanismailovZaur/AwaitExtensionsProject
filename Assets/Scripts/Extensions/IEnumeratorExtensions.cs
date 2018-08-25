using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static UnityEngine.Debug;
using Numba.Await.Engine;
using System.Runtime.CompilerServices;

/// <summary>
/// Extension for awaiting IEnumerator interface (use unity coroutines engine).
/// </summary>
public static class IEnumeratorExtensions
{
    public static TaskAwaiter GetAwaiter(this IEnumerator enumerator)
    {
        TaskCompletionSource<object> taskSource = new TaskCompletionSource<object>();
        RoutineHelper.Instance.StartCoroutine(WrapEnumerator(enumerator, taskSource));

        return ((Task)(taskSource.Task)).GetAwaiter();
    }

    private static IEnumerator WrapEnumerator(IEnumerator enumerator, TaskCompletionSource<object> taskSource)
    {
        while (enumerator.MoveNext()) yield return enumerator.Current;

        taskSource.SetResult(null);
    }
}