using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Numba.Tweening.Engine
{
    /// <summary>
    /// Help run coroutines. 
    /// Auto created, not destroyable and not visible in hierarchy.
    /// </summary>
    public class RoutineHelper : MonoBehaviour
    {
        /// <summary>
        /// Return instance of this class (singleton pattern).
        /// Returned object will not be visualized in hierarchy and
        /// not be destroyed between scenes loading.
        /// </summary>
        public static RoutineHelper Instance { get; private set; }

        /// <summary>
        /// Create and save one instance of this class (singleton pattern).
        /// Created object will not be visible in hierarchy and do not destroyed between scenes.
        /// </summary>
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        private static void CreateInstance()
        {
            Instance = new GameObject("RoutineHelper(Tween)").AddComponent<RoutineHelper>();
            //Instance.gameObject.hideFlags = HideFlags.HideInHierarchy;

            DontDestroyOnLoad(Instance.gameObject);
        }
    }
}