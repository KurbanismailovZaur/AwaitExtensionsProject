using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static UnityEngine.Debug;
using static UnityEngine.Mathf;

namespace Numba.Tweening
{
    public static class Easing
    {
        private const float _lerpThresold = 0.005f;

        private const float _calculationThresold = 0.0009765625f;

        private static float Remap(float value, float iMin, float iMax, float oMin, float oMax)
        {
            return oMin + (value - iMin) * (oMax - oMin) / (iMax - iMin);
        }

        public static float Ease(float from, float to, float normalizedPassedTime, Ease ease)
        {
            switch (ease)
            {
                case Tweening.Ease.Linear: return Linear(from, to, normalizedPassedTime);
                case Tweening.Ease.InQuad: return QuadraticInEase(from, to, normalizedPassedTime);
                case Tweening.Ease.OutQuad: return QuadraticOutEase(from, to, normalizedPassedTime);
                case Tweening.Ease.InOutQuad: return QuadraticInOutEase(from, to, normalizedPassedTime);
                case Tweening.Ease.InCubic: return CubicInEase(from, to, normalizedPassedTime);
                case Tweening.Ease.OutCubic: return CubicOutEase(from, to, normalizedPassedTime);
                case Tweening.Ease.InOutCubic: return CubicInOutEase(from, to, normalizedPassedTime);
                case Tweening.Ease.InQuart: return QuarticInEase(from, to, normalizedPassedTime);
                case Tweening.Ease.OutQuart: return QuarticOutEase(from, to, normalizedPassedTime);
                case Tweening.Ease.InOutQuart: return QuarticInOutEase(from, to, normalizedPassedTime);
                case Tweening.Ease.InQuint: return QuinticInEase(from, to, normalizedPassedTime);
                case Tweening.Ease.OutQuint: return QuinticOutEase(from, to, normalizedPassedTime);
                case Tweening.Ease.InOutQuint: return QuinticInOutEase(from, to, normalizedPassedTime);
                case Tweening.Ease.InSine: return SinusoidalInEase(from, to, normalizedPassedTime);
                case Tweening.Ease.OutSine: return SinusoidalOutEase(from, to, normalizedPassedTime);
                case Tweening.Ease.InOutSine: return SinusoidalInOutEase(from, to, normalizedPassedTime);
                case Tweening.Ease.InExpo: return ExponentialInEase(from, to, normalizedPassedTime);
                case Tweening.Ease.OutExpo: return ExponentialOutEase(from, to, normalizedPassedTime);
                case Tweening.Ease.InOutExpo: return ExponentialInOutEase(from, to, normalizedPassedTime);
                case Tweening.Ease.InCirc: return CircularInEase(from, to, normalizedPassedTime);
                case Tweening.Ease.OutCirc: return CircularOutEase(from, to, normalizedPassedTime);
                case Tweening.Ease.InOutCirc: return CircularInOutEase(from, to, normalizedPassedTime);
                default: return 0f;
            }
        }

        #region Ease formulas
        public static float Linear(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * t + from;
        }

        public static float QuadraticInEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * t * t + from;
        }

        public static float QuadraticOutEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return -(to - from) * t * (t - 2) + from;
        }

        public static float QuadraticInOutEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (to - from) / 2 * t * t + from;
            --t;
            return -(to - from) / 2 * (t * (t - 2) - 1) + from;
        }

        public static float CubicInEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * t * t * t + from;
        }

        public static float CubicOutEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (to - from) * (t * t * t + 1) + from;
        }

        public static float CubicInOutEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (to - from) / 2 * t * t * t + from;
            t -= 2;
            return (to - from) / 2 * (t * t * t + 2) + from;
        }

        public static float QuarticInEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * t * t * t * t + from;
        }

        public static float QuarticOutEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return -(to - from) * (t * t * t * t - 1) + from;
        }

        public static float QuarticInOutEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (to - from) / 2 * t * t * t * t + from;
            t -= 2;
            return -(to - from) / 2 * (t * t * t * t - 2) + from;
        }

        public static float QuinticInEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * t * t * t * t * t + from;
        }

        public static float QuinticOutEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (to - from) * (t * t * t * t * t + 1) + from;
        }

        public static float QuinticInOutEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (to - from) / 2 * t * t * t * t * t + from;
            t -= 2;
            return (to - from) / 2 * (t * t * t * t * t + 2) + from;
        }

        public static float SinusoidalInEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            float c = to - from;

            return -c * Cos(t * (PI / 2)) + c + from;
        }

        public static float SinusoidalOutEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * Sin(t * (PI / 2)) + from;
        }

        public static float SinusoidalInOutEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return -(to - from) / 2 * (Cos(PI * t) - 1) + from;
        }

        public static float ExponentialInEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            float result = (to - from) * Pow(2, 10 * (t - 1)) + from;

            return result;
            //if (normalizedPassedTime < _lerpThresold)
            //{
            //    return Remap(result, _calculationThresold, _lerpThresold, 0f, _lerpThresold);
            //}
            //else return result;
        }

        public static float ExponentialOutEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * (-Pow(2, -10 * t) + 1) + from;
        }

        public static float ExponentialInOutEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (to - from) / 2 * Pow(2, 10 * (t - 1)) + from;
            --t;
            return (to - from) / 2 * (-Pow(2, -10 * t) + 2) + from;
        }

        public static float CircularInEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return -(to - from) * (Sqrt(1 - t * t) - 1) + from;
        }

        public static float CircularOutEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (to - from) * Sqrt(1 - t * t) + from;
        }

        public static float CircularInOutEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return -(to - from) / 2 * (Sqrt(1 - t * t) - 1) + from;
            t -= 2;
            return (to - from) / 2 * (Sqrt(1 - t * t) + 1) + from;
        }
        #endregion
    }
}