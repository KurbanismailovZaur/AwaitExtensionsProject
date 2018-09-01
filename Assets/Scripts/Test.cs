using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static UnityEngine.Debug;
using System.Threading;
using UnityEngine.SceneManagement;
using System;
using Numba.Tweening;

namespace Numba
{
    public class Test : MonoBehaviour
    {
        [SerializeField]
        private Transform _cube;

        private async void Awake()
        {
            await _cube.DoMove(1, 2, 3, 1, Ease.InOutSine, -1, LoopType.ReversedYoyo).PlayAsync();

            Log("Completed");
        }
    }
}