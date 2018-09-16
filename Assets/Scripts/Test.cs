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
            _cube.DoPositionX(1f, 1f, Ease.InOutExpo, 1, LoopType.Yoyo).Play();
            _cube.DoEulerAnglesZ(-90f, 1f, Ease.InOutExpo, 1, LoopType.Yoyo).Play();
            _cube.DoLocalScaleX(2f, 1f, Ease.InOutExpo, 1, LoopType.Yoyo).Play();
        }
    }
}