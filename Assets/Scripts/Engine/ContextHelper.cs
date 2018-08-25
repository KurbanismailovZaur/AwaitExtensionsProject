using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static UnityEngine.Debug;
using System.Threading;

namespace Numba.Await.Engine
{
    /// <summary>
    /// This class capture UnitySynchronizationContext before scene loads and allows you access to it.
    /// </summary>
	public static class ContextHelper 
	{
        /// <summary>
        /// Synchronization context which created by Unity for main thread.
        /// </summary>
        public static SynchronizationContext UnitySynchronizationContext { get; private set; }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void SaveContext()
		{
            UnitySynchronizationContext = SynchronizationContext.Current;
		}
	}
}