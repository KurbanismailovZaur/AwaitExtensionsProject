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
/// This class allows run code after awaiting in main thread.
/// </summary>
public class WaitForUpdate
{
    public struct Awaiter : INotifyCompletion
    {
        public bool IsCompleted => false;

        public async void OnCompleted(Action continuation)
        {
            if (SynchronizationContext.Current == ContextHelper.UnitySynchronizationContext) continuation();
            else ContextHelper.UnitySynchronizationContext.Post(s => continuation(), null);
        }

        public void GetResult() { }
    }

    public Awaiter GetAwaiter()
    {
        return new Awaiter();
    }
}