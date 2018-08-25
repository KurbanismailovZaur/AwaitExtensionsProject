using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static UnityEngine.Debug;

namespace Numba.Await.Engine
{
    /// <summary>
    /// Help run coroutines. 
    /// Do not visible in hierarchy.
    /// </summary>
    public class RoutineHelper : MonoSingleton<RoutineHelper>
    {
        /// <summary>
        /// Make this gameobject undestroyable and hided in hierarchy.
        /// </summary>
        private void Awake()
        {
            gameObject.hideFlags = HideFlags.HideInHierarchy;
            DontDestroyOnLoad(this);
        }
    }
}