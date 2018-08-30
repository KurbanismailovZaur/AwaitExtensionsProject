using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static UnityEngine.Debug;
using System.Runtime.CompilerServices;
using System;

namespace Numba.Awaiting.Engine
{
    public class TurnableAwaiter : INotifyCompletion
    {
        private Action _continuation;

        public bool IsCompleted => false;

        public void OnCompleted(Action continuation) { _continuation = continuation; }

        public void GetResult() { }

        public void RunContinuation() { _continuation(); }
    }
}