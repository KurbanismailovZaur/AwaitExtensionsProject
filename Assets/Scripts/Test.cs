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
            var moveTask = _cube.DoMoveX(2f, 1f, Ease.Linear, 1, LoopType.Yoyo).PlayAsync();
            var rotateTask = _cube.DoRotate(0, 90, 0, 1, RotationQuality.Best, Ease.Linear, 1, LoopType.Yoyo).PlayAsync();
            var scaleTask = _cube.DoLocalScale(2, 3, 4, 1, Ease.Linear, 3, LoopType.Yoyo).PlayAsync();

            await Task.WhenAll(moveTask, rotateTask, scaleTask);

            await _cube.DoRotateY(3600, 2f, Ease.InExpo, 1, LoopType.ReversedYoyo).PlayAsync();

            Log("Completed");
        }
    }
}