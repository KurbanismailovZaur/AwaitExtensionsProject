using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static UnityEngine.Debug;
using System.Runtime.CompilerServices;
using System;
using System.Threading;
using Numba.Await.Engine;

/// <summary>
/// This class allows run code after awaiting in update cycle from main thread.
/// </summary>
public class WaitForUpdate
{
    public struct Awaiter : INotifyCompletion
    {
        public bool IsCompleted => false;

        public void OnCompleted(Action continuation)
        {
            if (SynchronizationContext.Current == ContextHelper.UnitySynchronizationContext) RoutineHelper.Instance.StartCoroutine(WaitOneFrameAndContinueRoutine(continuation));
            else ContextHelper.UnitySynchronizationContext.Post(s => continuation(), null);
        }

        public void GetResult() { }

        private IEnumerator WaitOneFrameAndContinueRoutine(Action continuation)
        {
            yield return null;
            continuation();
        }
    }
    

    public Awaiter GetAwaiter()
    {
        return new Awaiter();
    }
}