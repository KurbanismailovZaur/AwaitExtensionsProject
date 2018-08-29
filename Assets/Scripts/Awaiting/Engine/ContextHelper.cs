using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static UnityEngine.Debug;
using System.Threading;

namespace Numba.Awaiting.Engine
{
    /// <summary>
    /// This class capture UnitySynchronizationContext and main thread ID before scene loads and allows you access to it.
    /// </summary>
	public static class ContextHelper 
	{
        /// <summary>
        /// Main thread ID.
        /// </summary>
        public static int MainThreadID { get; private set; }

        /// <summary>
        /// Synchronization context which created by Unity for main thread.
        /// </summary>
        public static SynchronizationContext UnitySynchronizationContext { get; private set; }

        /// <summary>
        /// Do we on main thread?
        /// </summary>
        public static bool IsMainThread => Thread.CurrentThread.ManagedThreadId == MainThreadID;

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void SaveContext()
		{
            MainThreadID = Thread.CurrentThread.ManagedThreadId;
            UnitySynchronizationContext = SynchronizationContext.Current;
		}
	}
}