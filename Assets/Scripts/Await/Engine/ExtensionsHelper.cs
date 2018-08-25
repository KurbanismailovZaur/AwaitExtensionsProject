using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static UnityEngine.Debug;
using System.Runtime.CompilerServices;
using System;

namespace Numba.Await.Engine
{
    /// <summary>
    /// Helps create awaiters for awaitable objects.
    /// </summary>
	public static class ExtensionsHelper 
	{
        /// <summary>
        /// Create awaiter for any object.
        /// </summary>
        /// <param name="instruction">Instruction for yielding.</param>
        /// <returns>Awaiter which awaiting passed instruction.</returns>
        public static TaskAwaiter GetAwaiterForInstuction(object instruction) => ((Task)GetTaskForInstuctionAsResult(instruction)).GetAwaiter();

        /// <summary>
        /// Create awaiter (for any object) which return passed instruction as result.
        /// </summary>
        /// <typeparam name="T">Any type for yield.</typeparam>
        /// <param name="instruction">Instruction for yielding.</param>
        /// <returns>Awaiter which awaiting passed instruction and return it back.</returns>
        public static TaskAwaiter<T> GetAwaiterForInstuctionAsResult<T>(T instruction) => GetTaskForInstuctionAsResult(instruction).GetAwaiter();

        /// <summary>
        /// Create awaiter for enumerable object.
        /// </summary>
        /// <param name="enumerator">Object which can enumerate.</param>
        /// <returns>Awaiter which awaiting passed enumerator.</returns>
        public static TaskAwaiter GetAwaiterForEnumerator(IEnumerator enumerator) => GetTaskForEnumerator(enumerator).GetAwaiter();

        private static Task<T> GetTaskForInstuctionAsResult<T>(T instruction)
        {
            TaskCompletionSource<T> taskSource = new TaskCompletionSource<T>();
            RoutineHelper.Instance.StartCoroutine(WaitForInstructionRoutine(instruction, taskSource));

            return taskSource.Task;
        }

        private static IEnumerator WaitForInstructionRoutine<T>(T instruction, TaskCompletionSource<T> taskSource)
        {
            yield return instruction;
            taskSource.SetResult(instruction);
        }

        private static Task GetTaskForEnumerator(IEnumerator enumerator)
        {
            TaskCompletionSource<object> taskSource = new TaskCompletionSource<object>();
            RoutineHelper.Instance.StartCoroutine(WaitForEnumeratorRoutine(enumerator, taskSource));

            return taskSource.Task;
        }

        private static IEnumerator WaitForEnumeratorRoutine(IEnumerator enumerator, TaskCompletionSource<object> taskSource)
        {
            while (enumerator.MoveNext()) yield return enumerator.Current;
            taskSource.SetResult(null);
        }
    }
}