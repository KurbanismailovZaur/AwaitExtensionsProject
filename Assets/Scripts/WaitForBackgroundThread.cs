using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static UnityEngine.Debug;
using System.Runtime.CompilerServices;
using System;

/// <summary>
/// This class allows run code after awaiting in background thread.
/// </summary>
public class WaitForBackgroundThread
{
    public struct Awaiter : INotifyCompletion
    {
        public bool IsCompleted => false;

        public void OnCompleted(Action continuation) => Task.Run(continuation).ConfigureAwait(false);

        public void GetResult() { }
    }

    public Awaiter GetAwaiter()
    {
        return new Awaiter();
    }
}