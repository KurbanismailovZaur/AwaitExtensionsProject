using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static UnityEngine.Debug;
using System.Runtime.CompilerServices;
using System;

namespace Numba.Awaiting.Engine
{
    /// <summary>
    /// Helps create awaiters for awaitable objects.
    /// </summary>
	public static class ExtensionsHelper
    {
        /// <summary>
        /// Create awaiter for any instruction.
        /// </summary>
        /// <param name="instruction">Instruction for yielding.</param>
        /// <returns>Awaiter which awaiting passed instruction.</returns>
        public static ManualAwaiter GetAwaiterForInstuction(object instruction)
        {
            ManualAwaiter awaiter = new ManualAwaiter();

            if (ContextHelper.IsMainThread) RoutineHelper.Instance.StartCoroutine(WaitForInstructionAndRunContinuation(instruction, awaiter));
            else ContextHelper.UnitySynchronizationContext.Post((state) => { RoutineHelper.Instance.StartCoroutine(WaitForInstructionAndRunContinuation(instruction, awaiter)); }, null);
            
            return awaiter;
        }

        private static IEnumerator WaitForInstructionAndRunContinuation(object instruction, ManualAwaiter awaiter)
        {
            yield return instruction;
            awaiter.RunContinuation();
        }

        /// <summary>
        /// Create awaiter for enumerable object.
        /// </summary>
        /// <param name="enumerator">Object which can enumerate.</param>
        /// <returns>Awaiter which awaiting passed enumerator.</returns>
        public static ManualAwaiter GetAwaiterForEnumerator(IEnumerator enumerator)
        {
            ManualAwaiter awaiter = new ManualAwaiter();
            
            if (ContextHelper.IsMainThread) RoutineHelper.Instance.StartCoroutine(WaitForEnumeratorAndContinueRoutine(enumerator, awaiter));
            else ContextHelper.UnitySynchronizationContext.Post((state) => { RoutineHelper.Instance.StartCoroutine(WaitForEnumeratorAndContinueRoutine(enumerator, awaiter)); }, null);

            return awaiter;
        }

        private static IEnumerator WaitForEnumeratorAndContinueRoutine(IEnumerator enumerator, ManualAwaiter awaiter)
        {
            while (enumerator.MoveNext()) yield return enumerator.Current;
            awaiter.RunContinuation();
        }

        /// <summary>
        /// Create awaiter with result value for any instruction.
        /// </summary>
        /// <param name="instruction">Instruction for yielding.</param>
        /// <returns>Awaiter which awaiting passed instruction.</returns>
        public static ManualAwaiter<T> GetAwaiterWithResultForInstuction<T>(T instruction)
        {
            ManualAwaiter<T> awaiter = new ManualAwaiter<T>();
            awaiter.SetResultGetter(() => instruction);

            RoutineHelper.Instance.StartCoroutine(WaitForInstructionAndRunContinuation(instruction, awaiter));

            return awaiter;
        }

        private static IEnumerator WaitForInstructionWithResultAndRunContinuation(object instruction, ManualAwaiter awaiter)
        {
            yield return instruction;
            awaiter.RunContinuation();
        }
    }
}