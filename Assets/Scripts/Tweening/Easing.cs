using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static UnityEngine.Debug;
using static UnityEngine.Mathf;
using System;

namespace Numba.Tweening
{
    public static class Easing
    {
        public static int Ease(int from, int to, float normalizedPassedTime, Ease ease)
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
                default: return 0;
            }
        }

        public static long Ease(long from, long to, float normalizedPassedTime, Ease ease)
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
                default: return 0L;
            }
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

        public static double Ease(double from, double to, float normalizedPassedTime, Ease ease)
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

        public static DateTime Ease(DateTime from, DateTime to, float normalizedPassedTime, Ease ease)
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
                default: return DateTime.MinValue;
            }
        }

        #region Ease formulas
        #region Linear
        public static int Linear(int from, int to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (int)((to - from) * t + from);
        }

        public static long Linear(long from, long to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (long)((to - from) * t + from);
        }

        public static float Linear(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * t + from;
        }

        public static double Linear(double from, double to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * t + from;
        }

        public static DateTime Linear(DateTime from, DateTime to, float normalizedPassedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(Linear(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedPassedTime)));
        }
        #endregion

        #region Quadratic
        #region In
        public static int QuadraticInEase(int from, int to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (int)((to - from) * t * t + from);
        }

        public static long QuadraticInEase(long from, long to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (long)((to - from) * t * t + from);
        }

        public static float QuadraticInEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * t * t + from;
        }

        public static double QuadraticInEase(double from, double to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * t * t + from;
        }

        public static DateTime QuadraticInEase(DateTime from, DateTime to, float normalizedPassedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(QuadraticInEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedPassedTime)));
        }
        #endregion

        #region Out
        public static int QuadraticOutEase(int from, int to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (int)(-(to - from) * t * (t - 2) + from);
        }

        public static long QuadraticOutEase(long from, long to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (long)(-(to - from) * t * (t - 2) + from);
        }

        public static float QuadraticOutEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return -(to - from) * t * (t - 2) + from;
        }

        public static double QuadraticOutEase(double from, double to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return -(to - from) * t * (t - 2) + from;
        }

        public static DateTime QuadraticOutEase(DateTime from, DateTime to, float normalizedPassedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(QuadraticOutEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedPassedTime)));
        }
        #endregion

        #region InOut
        public static int QuadraticInOutEase(int from, int to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (int)((to - from) / 2 * t * t + from);
            --t;
            return (int)(-(to - from) / 2 * (t * (t - 2) - 1) + from);
        }

        public static long QuadraticInOutEase(long from, long to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (long)((to - from) / 2 * t * t + from);
            --t;
            return (long)(-(to - from) / 2 * (t * (t - 2) - 1) + from);
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

        public static double QuadraticInOutEase(double from, double to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (to - from) / 2 * t * t + from;
            --t;
            return -(to - from) / 2 * (t * (t - 2) - 1) + from;
        }

        public static DateTime QuadraticInOutEase(DateTime from, DateTime to, float normalizedPassedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(QuadraticInOutEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedPassedTime)));
        }
        #endregion
        #endregion

        #region Cubic
        #region In
        public static int CubicInEase(int from, int to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (int)((to - from) * t * t * t + from);
        }

        public static long CubicInEase(long from, long to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (long)((to - from) * t * t * t + from);
        }

        public static float CubicInEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * t * t * t + from;
        }

        public static double CubicInEase(double from, double to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * t * t * t + from;
        }

        public static DateTime CubicInEase(DateTime from, DateTime to, float normalizedPassedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(CubicInEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedPassedTime)));
        }
        #endregion

        #region Out
        public static int CubicOutEase(int from, int to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (int)((to - from) * (t * t * t + 1) + from);
        }

        public static long CubicOutEase(long from, long to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (long)((to - from) * (t * t * t + 1) + from);
        }

        public static float CubicOutEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (to - from) * (t * t * t + 1) + from;
        }

        public static double CubicOutEase(double from, double to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (to - from) * (t * t * t + 1) + from;
        }

        public static DateTime CubicOutEase(DateTime from, DateTime to, float normalizedPassedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(CubicOutEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedPassedTime)));
        }
        #endregion

        #region InOut
        public static int CubicInOutEase(int from, int to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (int)((to - from) / 2 * t * t * t + from);
            t -= 2;
            return (int)((to - from) / 2 * (t * t * t + 2) + from);
        }

        public static long CubicInOutEase(long from, long to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (long)((to - from) / 2 * t * t * t + from);
            t -= 2;
            return (long)((to - from) / 2 * (t * t * t + 2) + from);
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

        public static double CubicInOutEase(double from, double to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (to - from) / 2 * t * t * t + from;
            t -= 2;
            return (to - from) / 2 * (t * t * t + 2) + from;
        }

        public static DateTime CubicInOutEase(DateTime from, DateTime to, float normalizedPassedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(CubicInOutEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedPassedTime)));
        }
        #endregion
        #endregion

        #region Quartic
        #region In
        public static int QuarticInEase(int from, int to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (int)((to - from) * t * t * t * t + from);
        }

        public static long QuarticInEase(long from, long to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (long)((to - from) * t * t * t * t + from);
        }

        public static float QuarticInEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * t * t * t * t + from;
        }

        public static double QuarticInEase(double from, double to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * t * t * t * t + from;
        }

        public static DateTime QuarticInEase(DateTime from, DateTime to, float normalizedPassedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(QuarticInEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedPassedTime)));
        }
        #endregion

        #region Out
        public static int QuarticOutEase(int from, int to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (int)(-(to - from) * (t * t * t * t - 1) + from);
        }

        public static long QuarticOutEase(long from, long to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (long)(-(to - from) * (t * t * t * t - 1) + from);
        }

        public static float QuarticOutEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return -(to - from) * (t * t * t * t - 1) + from;
        }

        public static double QuarticOutEase(double from, double to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return -(to - from) * (t * t * t * t - 1) + from;
        }

        public static DateTime QuarticOutEase(DateTime from, DateTime to, float normalizedPassedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(QuarticOutEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedPassedTime)));
        }
        #endregion

        #region InOut
        public static int QuarticInOutEase(int from, int to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (int)((to - from) / 2 * t * t * t * t + from);
            t -= 2;
            return (int)(-(to - from) / 2 * (t * t * t * t - 2) + from);
        }

        public static long QuarticInOutEase(long from, long to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (long)((to - from) / 2 * t * t * t * t + from);
            t -= 2;
            return (long)(-(to - from) / 2 * (t * t * t * t - 2) + from);
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

        public static double QuarticInOutEase(double from, double to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (to - from) / 2 * t * t * t * t + from;
            t -= 2;
            return -(to - from) / 2 * (t * t * t * t - 2) + from;
        }

        public static DateTime QuarticInOutEase(DateTime from, DateTime to, float normalizedPassedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(QuarticInOutEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedPassedTime)));
        }
        #endregion
        #endregion

        #region Quintic
        #region In
        public static int QuinticInEase(int from, int to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (int)((to - from) * t * t * t * t * t + from);
        }

        public static long QuinticInEase(long from, long to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (long)((to - from) * t * t * t * t * t + from);
        }

        public static float QuinticInEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * t * t * t * t * t + from;
        }

        public static double QuinticInEase(double from, double to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * t * t * t * t * t + from;
        }

        public static DateTime QuinticInEase(DateTime from, DateTime to, float normalizedPassedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(QuinticInEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedPassedTime)));
        }
        #endregion

        #region Out
        public static int QuinticOutEase(int from, int to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (int)((to - from) * (t * t * t * t * t + 1) + from);
        }

        public static long QuinticOutEase(long from, long to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (long)((to - from) * (t * t * t * t * t + 1) + from);
        }

        public static float QuinticOutEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (to - from) * (t * t * t * t * t + 1) + from;
        }

        public static double QuinticOutEase(double from, double to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (to - from) * (t * t * t * t * t + 1) + from;
        }

        public static DateTime QuinticOutEase(DateTime from, DateTime to, float normalizedPassedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(QuinticOutEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedPassedTime)));
        }
        #endregion

        #region InOut
        public static int QuinticInOutEase(int from, int to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (int)((to - from) / 2 * t * t * t * t * t + from);
            t -= 2;
            return (int)((to - from) / 2 * (t * t * t * t * t + 2) + from);
        }

        public static long QuinticInOutEase(long from, long to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (long)((to - from) / 2 * t * t * t * t * t + from);
            t -= 2;
            return (long)((to - from) / 2 * (t * t * t * t * t + 2) + from);
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

        public static double QuinticInOutEase(double from, double to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (to - from) / 2 * t * t * t * t * t + from;
            t -= 2;
            return (to - from) / 2 * (t * t * t * t * t + 2) + from;
        }

        public static DateTime QuinticInOutEase(DateTime from, DateTime to, float normalizedPassedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(QuinticInOutEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedPassedTime)));
        }
        #endregion
        #endregion

        #region Sinusoidal
        #region In
        public static int SinusoidalInEase(int from, int to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            float c = to - from;

            return (int)(-c * Cos(t * (PI / 2)) + c + from);
        }

        public static long SinusoidalInEase(long from, long to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            float c = to - from;

            return (long)(-c * Cos(t * (PI / 2)) + c + from);
        }

        public static float SinusoidalInEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            float c = to - from;

            return -c * Cos(t * (PI / 2)) + c + from;
        }

        public static double SinusoidalInEase(double from, double to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            double c = to - from;

            return -c * Cos(t * (PI / 2)) + c + from;
        }

        public static DateTime SinusoidalInEase(DateTime from, DateTime to, float normalizedPassedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(SinusoidalInEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedPassedTime)));
        }
        #endregion

        #region Out
        public static int SinusoidalOutEase(int from, int to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (int)((to - from) * Sin(t * (PI / 2)) + from);
        }

        public static long SinusoidalOutEase(long from, long to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (long)((to - from) * Sin(t * (PI / 2)) + from);
        }

        public static float SinusoidalOutEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * Sin(t * (PI / 2)) + from;
        }

        public static double SinusoidalOutEase(double from, double to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * Sin(t * (PI / 2)) + from;
        }

        public static DateTime SinusoidalOutEase(DateTime from, DateTime to, float normalizedPassedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(SinusoidalOutEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedPassedTime)));
        }
        #endregion

        #region InOut
        public static int SinusoidalInOutEase(int from, int to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (int)(-(to - from) / 2 * (Cos(PI * t) - 1) + from);
        }

        public static long SinusoidalInOutEase(long from, long to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (long)(-(to - from) / 2 * (Cos(PI * t) - 1) + from);
        }

        public static float SinusoidalInOutEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return -(to - from) / 2 * (Cos(PI * t) - 1) + from;
        }

        public static double SinusoidalInOutEase(double from, double to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return -(to - from) / 2 * (Cos(PI * t) - 1) + from;
        }

        public static DateTime SinusoidalInOutEase(DateTime from, DateTime to, float normalizedPassedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(SinusoidalInOutEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedPassedTime)));
        }
        #endregion
        #endregion

        #region Exponential
        #region In
        public static int ExponentialInEase(int from, int to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (int)((to - from) * Pow(2, 10 * (t - 1)) + from);
        }

        public static long ExponentialInEase(long from, long to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (long)((to - from) * Pow(2, 10 * (t - 1)) + from);
        }

        public static float ExponentialInEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * Pow(2, 10 * (t - 1)) + from;
        }

        public static double ExponentialInEase(double from, double to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * Pow(2, 10 * (t - 1)) + from;
        }

        public static DateTime ExponentialInEase(DateTime from, DateTime to, float normalizedPassedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(ExponentialInEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedPassedTime)));
        }
        #endregion

        #region Out
        public static int ExponentialOutEase(int from, int to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (int)((to - from) * (-Pow(2, -10 * t) + 1) + from);
        }

        public static long ExponentialOutEase(long from, long to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (long)((to - from) * (-Pow(2, -10 * t) + 1) + from);
        }

        public static float ExponentialOutEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * (-Pow(2, -10 * t) + 1) + from;
        }

        public static double ExponentialOutEase(double from, double to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * (-Pow(2, -10 * t) + 1) + from;
        }

        public static DateTime ExponentialOutEase(DateTime from, DateTime to, float normalizedPassedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(ExponentialOutEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedPassedTime)));
        }
        #endregion

        #region InOut
        public static int ExponentialInOutEase(int from, int to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (int)((to - from) / 2 * Pow(2, 10 * (t - 1)) + from);
            --t;
            return (int)((to - from) / 2 * (-Pow(2, -10 * t) + 2) + from);
        }

        public static long ExponentialInOutEase(long from, long to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (long)((to - from) / 2 * Pow(2, 10 * (t - 1)) + from);
            --t;
            return (long)((to - from) / 2 * (-Pow(2, -10 * t) + 2) + from);
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

        public static double ExponentialInOutEase(double from, double to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (to - from) / 2 * Pow(2, 10 * (t - 1)) + from;
            --t;
            return (to - from) / 2 * (-Pow(2, -10 * t) + 2) + from;
        }

        public static DateTime ExponentialInOutEase(DateTime from, DateTime to, float normalizedPassedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(ExponentialInOutEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedPassedTime)));
        }
        #endregion
        #endregion

        #region Circular
        #region In
        public static int CircularInEase(int from, int to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (int)(-(to - from) * (Sqrt(1 - t * t) - 1) + from);
        }

        public static long CircularInEase(long from, long to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (long)(-(to - from) * (Sqrt(1 - t * t) - 1) + from);
        }

        public static float CircularInEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return -(to - from) * (Sqrt(1 - t * t) - 1) + from;
        }

        public static double CircularInEase(double from, double to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return -(to - from) * (Sqrt(1 - t * t) - 1) + from;
        }

        public static DateTime CircularInEase(DateTime from, DateTime to, float normalizedPassedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(CircularInEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedPassedTime)));
        }
        #endregion

        #region Out
        public static int CircularOutEase(int from, int to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (int)((to - from) * Sqrt(1 - t * t) + from);
        }

        public static long CircularOutEase(long from, long to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (long)((to - from) * Sqrt(1 - t * t) + from);
        }

        public static float CircularOutEase(float from, float to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (to - from) * Sqrt(1 - t * t) + from;
        }

        public static double CircularOutEase(double from, double to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (to - from) * Sqrt(1 - t * t) + from;
        }

        public static DateTime CircularOutEase(DateTime from, DateTime to, float normalizedPassedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(CircularOutEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedPassedTime)));
        }
        #endregion

        #region InOut
        public static int CircularInOutEase(int from, int to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (int)(-(to - from) / 2 * (Sqrt(1 - t * t) - 1) + from);
            t -= 2;
            return (int)((to - from) / 2 * (Sqrt(1 - t * t) + 1) + from);
        }

        public static long CircularInOutEase(long from, long to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (long)(-(to - from) / 2 * (Sqrt(1 - t * t) - 1) + from);
            t -= 2;
            return (long)((to - from) / 2 * (Sqrt(1 - t * t) + 1) + from);
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

        public static double CircularInOutEase(double from, double to, float normalizedPassedTime)
        {
            float t = normalizedPassedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return -(to - from) / 2 * (Sqrt(1 - t * t) - 1) + from;
            t -= 2;
            return (to - from) / 2 * (Sqrt(1 - t * t) + 1) + from;
        }

        public static DateTime CircularInOutEase(DateTime from, DateTime to, float normalizedPassedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(CircularInOutEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedPassedTime)));
        }
        #endregion
        #endregion
        #endregion
    }
}