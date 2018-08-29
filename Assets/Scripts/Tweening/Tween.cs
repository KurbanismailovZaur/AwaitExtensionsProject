using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static UnityEngine.Debug;
using System;
using System.Runtime.CompilerServices;

namespace Numba.Tweening
{
    public class Tween
    {
        #region Fields
        private float _from;

        private float _to;

        private float _duration;

        private Ease _ease;

        private Action<float> _setter;

        private bool _isPlaying;

        private TaskCompletionSource<object> _taskSource;
        #endregion

        #region Constructors
        private Tween() { }

        public Tween(float from, float to, float duration, Action<float> setter)
        {
            _from = from;
            _to = to;
            _duration = duration;
            _setter = setter;
        }
        #endregion

        public float Duration { get { return _duration; } }

        public Tween SetEase(Ease ease)
        {
            _ease = ease;

            return this;
        }

        public Task PlayAsync() => PlayAsync(Time.time);

        public Task PlayAsync(float startTime)
        {
            if (_isPlaying)
            {
                LogWarning("Tween is already playing.");
                return _taskSource.Task;
            }

            CreateRoutineAsync(startTime).CatchErrors();

            return _taskSource.Task;
        }

        private async Task CreateRoutineAsync(float startTime)
        {
            _isPlaying = true;
            _taskSource = new TaskCompletionSource<object>();

            float endTime = startTime + _duration;

            while (Time.time < endTime)
            {
                _setter(Easing.Ease(_from, _to - _from, Time.time - startTime, _duration, _ease));
                await new WaitForUpdate();
            }

            _setter(Easing.Ease(_from, _to - _from, _duration, _duration, _ease));

            _isPlaying = false;
            _taskSource.SetResult(null);
        }
    }
}