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
        private AnimationCurve _curve;

        [SerializeField]
        [Range(0f, 1f)]
        private float _time;

        private Tweak _tweak;

        private async void Awake()
        {
            await _cube.DoMove(1f, 0f, 0f, 1).SetEase(_curve).SetLoops(1, LoopType.Reversed).PlayAsync();
            //await new Tween(new TweakVec(Color.black, Color.white, (c) => _cube.GetComponent<MeshRenderer>().material.color = c), 1f).SetEase(_curve).SetLoops(1, LoopType.ReversedYoyo).PlayAsync();
            Log("Awaked");
        }

        private void Update()
        {
            //_tweak.SetTime(_time, _curve);
        }
    }
}