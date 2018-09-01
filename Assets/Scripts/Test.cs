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
            var moveTask = _cube.DoLocalMoveY(1f, 1f, Ease.InOutCirc, 1, LoopType.Yoyo).PlayAsync();
            var rotateTask = _cube.DoLocalRotate(0, -90, 0, 1, Ease.InOutExpo, 2, LoopType.ReversedYoyo).PlayAsync();

            await Task.WhenAll(moveTask, rotateTask);

            Log("Completed");
        }
    }
}