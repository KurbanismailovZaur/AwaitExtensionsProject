using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static UnityEngine.Debug;

namespace Numba.Await.Engine
{
    /// <summary>
    /// Makes any class MonoBehaviour singleton.
    /// </summary>
    /// <typeparam name="T">Any class.</typeparam>
    public class MonoSingleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static T _instance;

        /// <summary>
        /// Get instance of passed generic class (create if not exist).
        /// </summary>
        public static T Instance
        {
            get
            {
                if (_instance != null) return _instance;

                return _instance = new GameObject(typeof(T).Name).AddComponent<T>();
            }
        }
    }
}