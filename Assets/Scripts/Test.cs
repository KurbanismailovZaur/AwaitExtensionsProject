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
        public Transform _cube;

        public float xPos;

        public float duration;

        public Ease ease;

        private async void Awake()
        {
            await new WWW("google.ru");

            Log($"Thread: {Thread.CurrentThread.ManagedThreadId}");

            await Routine();

            Log($"Thread: {Thread.CurrentThread.ManagedThreadId}");

            await new WaitForBackgroundThread();

            Log($"Thread: {Thread.CurrentThread.ManagedThreadId}");

            await new WaitForUpdate();

            Log($"Thread: {Thread.CurrentThread.ManagedThreadId}");

            #region Tweens
            //Tween xPosTween = new Tween(0f, xPos, duration, (x) => { _cube.position = new Vector3(x, 0f, 0f); }).SetEase(ease);
            //Tween yPosTween = new Tween(0f, xPos, duration, (y) => { _cube.position = new Vector3(0f, y, 0f); }).SetEase(ease);
            //Tween zPosTween = new Tween(0f, xPos, duration, (z) => { _cube.position = new Vector3(0f, 0f, z); }).SetEase(ease);

            //Sequence sequence = new Sequence(xPosTween, yPosTween, zPosTween);
            //await sequence.PlayAsync();
            #endregion
        }

        private void Update()
        {
            Log("Update");
        }

        private async Task GT()
        {
            await Task.Delay(1000).ConfigureAwait(false);
            Log($"Thread: {Thread.CurrentThread.ManagedThreadId}");
            await new WaitForEndOfFrame();
            Log($"Thread: {Thread.CurrentThread.ManagedThreadId}");
        }

        private IEnumerator Routine()
        {
            yield return new WaitForSeconds(1f);
        }
    }
}