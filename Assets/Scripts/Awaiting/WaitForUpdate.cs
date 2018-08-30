using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static UnityEngine.Debug;
using System.Runtime.CompilerServices;
using System;
using System.Threading;
using Numba.Awaiting.Engine;

/// <summary>
/// This class allows run code after awaiting in update cycle from main thread.
/// </summary>
public class WaitForUpdate
{
    public TurnableAwaiter GetAwaiter()
    {
        TurnableAwaiter awaiter = new TurnableAwaiter();

        if (ContextHelper.IsMainThread) RoutineHelper.Instance.StartCoroutine(WaitOneFrameAndRunContinuationRoutine(awaiter));
        else ContextHelper.UnitySynchronizationContext.Post((state)=> { awaiter.RunContinuation(); }, null);

        return awaiter;
    }

    private IEnumerator WaitOneFrameAndRunContinuationRoutine(TurnableAwaiter awaiter)
    {
        yield return null;
        awaiter.RunContinuation();
    }
}