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
            await new Tween(new TweakColor(Color.black, Color.white, (c) => _cube.GetComponent<MeshRenderer>().material.color = c), 1f).SetEase(_curve).SetLoops(1, LoopType.ReversedYoyo).PlayAsync();
        }

        private void Update()
        {
            //_tweak.SetTime(_time, _curve);
        }
    }
}