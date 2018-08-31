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

        [SerializeField]
        private Ease _ease;

        [SerializeField]
        [Range(0f, 1f)]
        private float _time;

        [SerializeField]
        private bool _reversed;

        private Tweak _tweak;

        private async void Awake()
        {
            //_tweak = new Tweak(0, 1, (x) => { _cube.position = new Vector3(x, 0f, 0f); });
            
            Tween tween = new Tween("MyTween", 0f, 1f, (x) => { _cube.position = new Vector3(x, 0f, 0f); }, 1f).SetEase(Ease.ExpoInOut).SetLoops(-1, LoopType.ReversedYoyo);
            await tween.PlayAsync();

            Log("Tweened!");
        }

        private void Update()
        {
            //_tweak.SetTime(_time, _ease, _reversed);
        }
    }
}