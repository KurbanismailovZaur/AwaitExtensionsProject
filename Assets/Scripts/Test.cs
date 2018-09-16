using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static UnityEngine.Debug;
using System.Threading;
using UnityEngine.SceneManagement;
using System;
//using Numba.Tweening;
using Numba.Tweening.Tweaks;
using Numba.Tweening;
using UnityEngine.UI;

namespace Numba
{
    public class Test : MonoBehaviour
    {
        [SerializeField]
        private Transform _cube;

        private void Start()
        {
            // Tween.Create(Color.black, Color.white, (c) => _cube.GetComponent<MeshRenderer>().material.color = c, 1f, Ease.InOutExpo, 1, LoopType.Yoyo).Play();
            // new Tween(Color.black, Color.white, (c) => _cube.GetComponent<MeshRenderer>().material.color = c, 1f, Ease.InOutExpo, 1, LoopType.Yoyo).Play();
            
        }
    }
}