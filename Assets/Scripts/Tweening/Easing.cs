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
        public static float Ease(float from, float to, float normalizedPassedTime, Ease ease)
        {
            switch (ease)
            {
                case Tweening.Ease.Linear: return Linear(from, to, normalizedPassedTime);
                case Tweening.Ease.QuadIn: return QuadraticInEase(from, to, normalizedPassedTime);
                case Tweening.Ease.QuadOut: return QuadraticOutEase(from, to, normalizedPassedTime);
                case Tweening.Ease.QuadInOut: return QuadraticInOutEase(from, to, normalizedPassedTime);
                case Tweening.Ease.CubicIn: return CubicInEase(from, to, normalizedPassedTime);
                case Tweening.Ease.CubicOut: return CubicOutEase(from, to, normalizedPassedTime);
                case Tweening.Ease.CubicInOut: return CubicInOutEase(from, to, normalizedPassedTime);
                case Tweening.Ease.QuartIn: return QuarticInEase(from, to, normalizedPassedTime);
                case Tweening.Ease.QuartOut: return QuarticOutEase(from, to, normalizedPassedTime);
                case Tweening.Ease.QuartInOut: return QuarticInOutEase(from, to, normalizedPassedTime);
                case Tweening.Ease.QuintIn: return QuinticInEase(from, to, normalizedPassedTime);
                case Tweening.Ease.QuintOut: return QuinticOutEase(from, to, normalizedPassedTime);
                case Tweening.Ease.QuintInOut: return QuinticInOutEase(from, to, normalizedPassedTime);
                case Tweening.Ease.SineIn: return SinusoidalInEase(from, to, normalizedPassedTime);
                case Tweening.Ease.SineOut: return SinusoidalOutEase(from, to, normalizedPassedTime);
                case Tweening.Ease.SineInOut: return SinusoidalInOutEase(from, to, normalizedPassedTime);
                case Tweening.Ease.ExpoIn: return ExponentialInEase(from, to, normalizedPassedTime);
                case Tweening.Ease.ExpoOut: return ExponentialOutEase(from, to, normalizedPassedTime);
                case Tweening.Ease.ExpoInOut: return ExponentialInOutEase(from, to, normalizedPassedTime);
                case Tweening.Ease.CircIn: return CircularInEase(from, to, normalizedPassedTime);
                case Tweening.Ease.CircOut: return CircularOutEase(from, to, normalizedPassedTime);
                case Tweening.Ease.CircInOut: return CircularInOutEase(from, to, normalizedPassedTime);
                default: return 0f;
            }
        }

        #region Ease formulas
        public static float Linear(float from, float to, float normalizedPassedTime)
        {
            return (to - from) * normalizedPassedTime + from;
        }

        public static float QuadraticInEase(float from, float to, float normalizedPassedTime)
        {
            return (to - from) * normalizedPassedTime * normalizedPassedTime + from;
        }

        public static float QuadraticOutEase(float from, float to, float normalizedPassedTime)
        {
            return -(to - from) * normalizedPassedTime * (normalizedPassedTime - 2) + from;
        }

        public static float QuadraticInOutEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            t /= .5f;
            if (t < 1) return (to - from) / 2 * t * t + from;
            --t;
            return -(to - from) / 2 * (t * (t - 2) - 1) + from;
        }

        public static float CubicInEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;
            
            return (to - from) * t * t * t + from;
        }

        public static float CubicOutEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;
            
            --t;
            return (to - from) * (t * t * t + 1) + from;
        }

        public static float CubicInOutEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            t /= .5f;
            if (t < 1) return (to - from) / 2 * t * t * t + from;
            t -= 2;
            return (to - from) / 2 * (t * t * t + 2) + from;
        }

        public static float QuarticInEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;
            
            return (to - from) * t * t * t * t + from;
        }

        public static float QuarticOutEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;
            
            --t;
            return -(to - from) * (t * t * t * t - 1) + from;
        }

        public static float QuarticInOutEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;
            
            t /= .5f;
            if (t < 1) return (to - from) / 2 * t * t * t * t + from;
            t -= 2;
            return -(to - from) / 2 * (t * t * t * t - 2) + from;
        }

        public static float QuinticInEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;
            
            return (to - from) * t * t * t * t * t + from;
        }

        public static float QuinticOutEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;
            
            --t;
            return (to - from) * (t * t * t * t * t + 1) + from;
        }

        public static float QuinticInOutEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            t /= .5f;
            if (t < 1) return (to - from) / 2 * t * t * t * t * t + from;
            t -= 2;
            return (to - from) / 2 * (t * t * t * t * t + 2) + from;
        }

        public static float SinusoidalInEase(float from, float to, float normalizedPassedTime)
        {
            float c = to - from;

            return -c * Cos(normalizedPassedTime * (PI / 2)) + c + from;
        }

        public static float SinusoidalOutEase(float from, float to, float normalizedPassedTime)
        {
            return (to - from) * Sin(normalizedPassedTime * (PI / 2)) + from;
        }

        public static float SinusoidalInOutEase(float from, float to, float normalizedPassedTime)
        {
            return -(to - from) / 2 * (Cos(PI * normalizedPassedTime) - 1) + from;
        }

        public static float ExponentialInEase(float from, float to, float normalizedPassedTime)
        {
            return (to - from) * Pow(2, 10 * (normalizedPassedTime - 1)) + from;
        }

        public static float ExponentialOutEase(float from, float to, float normalizedPassedTime)
        {
            return (to - from) * (-Pow(2, -10 * normalizedPassedTime) + 1) + from;
        }

        public static float ExponentialInOutEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            t /= .5f;
            if (t < 1) return (to - from) / 2 * Pow(2, 10 * (t - 1)) + from;
            --t;
            return (to - from) / 2 * (-Pow(2, -10 * t) + 2) + from;
        }

        public static float CircularInEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;
            
            return -(to - from) * (Sqrt(1 - t * t) - 1) + from;
        }

        public static float CircularOutEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;
            
            --t;
            return (to - from) * Sqrt(1 - t * t) + from;
        }

        public static float CircularInOutEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            t /= .5f;
            if (t < 1) return -(to - from) / 2 * (Sqrt(1 - t * t) - 1) + from;
            t -= 2;
            return (to - from) / 2 * (Sqrt(1 - t * t) + 1) + from;
        }
        #endregion
    }
}