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

namespace Numba
{
    public class Test : MonoBehaviour
    {
        [SerializeField]
        private Transform _cube;

        [SerializeField]
        [Range(0f, 1f)]
        private float _time;

        private Tweening.Tweaks.Tweak tweak;

        private async void Awake()
        {
            // bool byte, sbyte, short, ushort, int, uint, long, ulong, decimal, float, double string, DateTime
            
            await new Tween(new TweakDateTime(new DateTime(), DateTime.Now, (dt) => Log(dt)), 1f).PlayAsync();

            //tweak = new TweakFloat(0f, 1f, (x) => _cube.position = new Vector3(x, 0, 0));

            //await new Tween(new TweakByte(0, 240, (x) => _cube.eulerAngles = new Vector3(0, x, 0)), 1f).SetEase(Ease.InExpo).SetLoops(1, LoopType.Forward).PlayAsync();
            //await new Tween(new TweakInt(0, 360, (x) => _cube.eulerAngles = new Vector3(0, x, 0)), 1f).SetEase(Ease.InExpo).SetLoops(1, LoopType.Reversed).PlayAsync();

            //var moveTask = _cube.DoMoveX(2f, 1f, Ease.Linear, 1, LoopType.Yoyo).PlayAsync();
            //var rotateTask = _cube.DoRotate(0, 90, 0, 1, RotationQuality.Best, Ease.Linear, 1, LoopType.ReversedYoyo).PlayAsync();
            //var scaleTask = _cube.DoLocalScale(2, 3, 4, 1, Ease.Linear, 3, LoopType.Yoyo).PlayAsync();

            //await Task.WhenAll(moveTask, rotateTask, scaleTask);

            //await _cube.DoRotateY(36000, 2f, Ease.InExpo, 1, LoopType.Reversed).PlayAsync();

            Log("Completed");
        }

        private void Update()
        {
            //Log("Update");
            //tweak.SetTime(_time, Ease.InExpo);
        }
    }
}