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
        private CanvasGroup _canvasGroup;

        private void Start()
        {
            _cube.DoPositionX(1f, 1f, Ease.InOutExpo, 1, LoopType.Yoyo).Play();
            _cube.DoEulerAnglesZ(-90f, 1f, Ease.InOutExpo, 1, LoopType.Yoyo).Play();
            _cube.DoLocalScaleX(2f, 1f, Ease.InOutExpo, 1, LoopType.Yoyo).Play();

            _cube.GetComponent<MeshRenderer>().material.DoColor(Color.yellow, 1f, Ease.InOutExpo, 1, LoopType.ReversedYoyo).Play();

            Camera.main.transform.DoPosition(-10f, 0f, 0f, 1f, Ease.InOutExpo, 1, LoopType.Yoyo).Play();
            Camera.main.transform.DoEulerAnglesY(90f, 1f, Ease.InOutExpo, 1, LoopType.Yoyo).Play();
            Camera.main.DoFieldOfView(30f, 1f, Ease.InOutExpo, 1, LoopType.Yoyo).Play();
            //Camera.main.DoRect(new Rect(0.25f, 0.25f, 0.75f, 0.75f), 1f, Ease.InOutExpo, 1, LoopType.Yoyo).Play();

            //_canvasGroup.DoAlpha(1f, 1f, Ease.InOutExpo, 1, LoopType.Yoyo).Play();

            //Tween.Time.DoTimeScale(0f, 1f, Ease.InOutExpo, 1, LoopType.Yoyo).Play(true);
        }
    }
}