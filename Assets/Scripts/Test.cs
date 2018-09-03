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

        [SerializeField]
        [Range(0f, 1f)]
        private float _time;

        private Tweak tweak;
        
        private DateTime _from = new DateTime(2018, 8, 1);

        private DateTime _to = DateTime.Now;

        [SerializeField]
        private Text _text;

        private async void Awake()
        {


            await new Tween(new TweakVector2(Vector2.zero, Vector2.one, (v2) => _text.text = v2.ToString("0000.0000")), 4f).SetEase(Ease.Linear).SetLoops(2, LoopType.ReversedYoyo).PlayAsync();
            //await new Tween(new TweakFloat(0f, 1f, (v2) => _text.text = v2.ToString()), 4f).SetEase(Ease.OutExpo).SetLoops(3, LoopType.Backward).PlayAsync();

            //await new Tween(new TweakDateTime(new DateTime(), DateTime.Now, (dt) => Log(dt)), 1f).PlayAsync();

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
            //_text.text = Easing.Linear(_from, _to, _time).ToString();
            //tweak.SetTime(_time, Ease.InExpo);
        }
    }
}