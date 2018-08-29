using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static UnityEngine.Debug;

namespace Numba.Awaiting.Engine
{
    /// <summary>
    /// Help run coroutines. 
    /// Auto created, not destroyable and not visible in hierarchy.
    /// </summary>
    public class RoutineHelper : MonoBehaviour
    {
        public static RoutineHelper Instance { get; private set; }

        /// <summary>
        /// Create and save one instance of this class (singleton pattern).
        /// Created object will not be visible in hierarchy and do not destroyed between scenes.
        /// </summary>
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        private static void CreateInstance()
        {
            Instance = new GameObject("RoutineHelper").AddComponent<RoutineHelper>();
            Instance.gameObject.hideFlags = HideFlags.HideInHierarchy;

            DontDestroyOnLoad(Instance.gameObject);
        }

        public new void StartCoroutine(IEnumerator enumerator)
        {
            if (ContextHelper.IsMainThread) base.StartCoroutine(enumerator);
            else ContextHelper.UnitySynchronizationContext.Post(s => base.StartCoroutine(enumerator), null);
        }
    }
}