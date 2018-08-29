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
        public static float Ease(float from, float changeInValue, float passedTime, float duration, Ease ease)
        {
            switch (ease)
            {
                case Tweening.Ease.Linear: return LinearEase(from, changeInValue, passedTime, duration);
                case Tweening.Ease.QuadIn: return QuadraticInEase(from, changeInValue, passedTime, duration);
                case Tweening.Ease.QuadOut: return QuadraticOutEase(from, changeInValue, passedTime, duration);
                case Tweening.Ease.QuadInOut: return QuadraticInOutEase(from, changeInValue, passedTime, duration);
                case Tweening.Ease.CubicIn: return CubicInEase(from, changeInValue, passedTime, duration);
                case Tweening.Ease.CubicOut: return CubicOutEase(from, changeInValue, passedTime, duration);
                case Tweening.Ease.CubicInOut: return CubicInOutEase(from, changeInValue, passedTime, duration);
                case Tweening.Ease.QuartIn: return QuarticInEase(from, changeInValue, passedTime, duration);
                case Tweening.Ease.QuartOut: return QuarticOutEase(from, changeInValue, passedTime, duration);
                case Tweening.Ease.QuartInOut: return QuarticInOutEase(from, changeInValue, passedTime, duration);
                case Tweening.Ease.QuintIn: return QuinticInEase(from, changeInValue, passedTime, duration);
                case Tweening.Ease.QuintOut: return QuinticOutEase(from, changeInValue, passedTime, duration);
                case Tweening.Ease.QuintInOut: return QuinticInOutEase(from, changeInValue, passedTime, duration);
                case Tweening.Ease.SineIn: return SinusoidalInEase(from, changeInValue, passedTime, duration);
                case Tweening.Ease.SineOut: return SinusoidalOutEase(from, changeInValue, passedTime, duration);
                case Tweening.Ease.SineinOut: return SinusoidalInOutEase(from, changeInValue, passedTime, duration);
                case Tweening.Ease.ExpoIn: return ExponentialInEase(from, changeInValue, passedTime, duration);
                case Tweening.Ease.ExpoOut: return ExponentialOutEase(from, changeInValue, passedTime, duration);
                case Tweening.Ease.ExpoInOut: return ExponentialInOutEase(from, changeInValue, passedTime, duration);
                case Tweening.Ease.CircIn: return CircularInEase(from, changeInValue, passedTime, duration);
                case Tweening.Ease.CircOut: return CircularOutEase(from, changeInValue, passedTime, duration);
                case Tweening.Ease.CircInOut: return CircularInOutEase(from, changeInValue, passedTime, duration);
                default: return 0f;
            }
        }

        #region Ease formulas
        private static float LinearEase(float b, float c, float t, float d)
        {
            return c* t / d + b;
        }

        private static float QuadraticInEase(float b, float c, float t, float d)
        {
            float normalizedTime = t / d;
            return c * normalizedTime * normalizedTime + b;
        }

        private static float QuadraticOutEase(float b, float c, float t, float d)
        {
            t /= d;
            return -c * t * (t - 2) + b;
        }

        private static float QuadraticInOutEase(float b, float c, float t, float d)
        {
            t /= d / 2;
            if (t < 1) return c / 2 * t * t + b;
            t--;
            return -c / 2 * (t * (t - 2) - 1) + b;
        }

        private static float CubicInEase(float b, float c, float t, float d)
        {
            t /= d;
            return c * t * t * t + b;
        }

        private static float CubicOutEase(float b, float c, float t, float d)
        {
            t /= d;
            t--;
            return c * (t * t * t + 1) + b;
        }

        private static float CubicInOutEase(float b, float c, float t, float d)
        {
            t /= d / 2;
            if (t < 1) return c / 2 * t * t * t + b;
            t -= 2;
            return c / 2 * (t * t * t + 2) + b;
        }

        private static float QuarticInEase(float b, float c, float t, float d)
        {
            t /= d;
            return c * t * t * t * t + b;
        }

        private static float QuarticOutEase(float b, float c, float t, float d)
        {
            t /= d;
            t--;
            return -c * (t * t * t * t - 1) + b;
        }

        private static float QuarticInOutEase(float b, float c, float t, float d)
        {
            t /= d / 2;
            if (t < 1) return c / 2 * t * t * t * t + b;
            t -= 2;
            return -c / 2 * (t * t * t * t - 2) + b;
        }

        private static float QuinticInEase(float b, float c, float t, float d)
        {
            t /= d;
            return c * t * t * t * t * t + b;
        }

        private static float QuinticOutEase(float b, float c, float t, float d)
        {
            t /= d;
            t--;
            return c * (t * t * t * t * t + 1) + b;
        }

        private static float QuinticInOutEase(float b, float c, float t, float d)
        {
            t /= d / 2;
            if (t < 1) return c / 2 * t * t * t * t * t + b;
            t -= 2;
            return c / 2 * (t * t * t * t * t + 2) + b;
        }

        private static float SinusoidalInEase(float b, float c, float t, float d)
        {
            return -c * Cos(t / d * (PI / 2)) + c + b;
        }

        private static float SinusoidalOutEase(float b, float c, float t, float d)
        {
            return c * Sin(t / d * (PI / 2)) + b;
        }

        private static float SinusoidalInOutEase(float b, float c, float t, float d)
        {
            return -c / 2 * (Cos(PI * t / d) - 1) + b;
        }

        private static float ExponentialInEase(float b, float c, float t, float d)
        {
            return c * Pow(2, 10 * (t / d - 1)) + b;
        }

        private static float ExponentialOutEase(float b, float c, float t, float d)
        {
            return c * (-Pow(2, -10 * t / d) + 1) + b;
        }

        private static float ExponentialInOutEase(float b, float c, float t, float d)
        {
            t /= d / 2;
            if (t < 1) return c / 2 * Pow(2, 10 * (t - 1)) + b;
            t--;
            return c / 2 * (-Pow(2, -10 * t) + 2) + b;
        }

        private static float CircularInEase(float b, float c, float t, float d)
        {
            t /= d;
            return -c * (Sqrt(1 - t * t) - 1) + b;
        }

        private static float CircularOutEase(float b, float c, float t, float d)
        {
            t /= d;
            t--;
            return c * Sqrt(1 - t * t) + b;
        }

        private static float CircularInOutEase(float b, float c, float t, float d)
        {
            t /= d / 2;
            if (t < 1) return -c / 2 * (Sqrt(1 - t * t) - 1) + b;
            t -= 2;
            return c / 2 * (Sqrt(1 - t * t) + 1) + b;
        }
        #endregion
    }
}