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

        public static Vector2 Ease(Vector2 from, Vector2 to, float normalizedPassedTime, Ease ease)
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
                default: return Vector2.zero;
            }
        }

        public static Vector3 Ease(Vector3 from, Vector3 to, float normalizedPassedTime, Ease ease)
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
                default: return Vector3.zero;
            }
        }

        public static Vector4 Ease(Vector4 from, Vector4 to, float normalizedPassedTime, Ease ease)
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
                default: return Vector4.zero;
            }
        }

        public static Quaternion Ease(Quaternion from, Quaternion to, float normalizedPassedTime, Ease ease)
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
                default: return Quaternion.identity;
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

        public static Vector2 Linear(Vector2 from, Vector2 to, float normalizedPassedTime)
        {
            return new Vector2(Linear(from.x, to.x, normalizedPassedTime), Linear(from.y, to.y, normalizedPassedTime));
        }

        public static Vector3 Linear(Vector3 from, Vector3 to, float normalizedPassedTime)
        {
            return new Vector3(Linear(from.x, to.x, normalizedPassedTime), Linear(from.y, to.y, normalizedPassedTime), Linear(from.z, to.z, normalizedPassedTime));
        }

        public static Vector4 Linear(Vector4 from, Vector4 to, float normalizedPassedTime)
        {
            return new Vector4(Linear(from.x, to.x, normalizedPassedTime), Linear(from.y, to.y, normalizedPassedTime), Linear(from.z, to.z, normalizedPassedTime), Linear(from.w, to.w, normalizedPassedTime));
        }

        public static Quaternion Linear(Quaternion from, Quaternion to, float normalizedPassedTime)
        {
            return Quaternion.Lerp(from, to, normalizedPassedTime);
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

        public static Vector2 QuadraticInEase(Vector2 from, Vector2 to, float normalizedPassedTime)
        {
            return new Vector2(QuadraticInEase(from.x, to.x, normalizedPassedTime), QuadraticInEase(from.y, to.y, normalizedPassedTime));
        }

        public static Vector3 QuadraticInEase(Vector3 from, Vector3 to, float normalizedPassedTime)
        {
            return new Vector3(QuadraticInEase(from.x, to.x, normalizedPassedTime), QuadraticInEase(from.y, to.y, normalizedPassedTime), QuadraticInEase(from.z, to.z, normalizedPassedTime));
        }

        public static Vector4 QuadraticInEase(Vector4 from, Vector4 to, float normalizedPassedTime)
        {
            return new Vector4(QuadraticInEase(from.x, to.x, normalizedPassedTime), QuadraticInEase(from.y, to.y, normalizedPassedTime), QuadraticInEase(from.z, to.z, normalizedPassedTime), QuadraticInEase(from.w, to.w, normalizedPassedTime));
        }

        public static Quaternion QuadraticInEase(Quaternion from, Quaternion to, float normalizedPassedTime)
        {
            return Quaternion.Lerp(from, to, QuadraticInEase(0f, 1f, normalizedPassedTime));
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

        public static Vector2 QuadraticOutEase(Vector2 from, Vector2 to, float normalizedPassedTime)
        {
            return new Vector2(QuadraticOutEase(from.x, to.x, normalizedPassedTime), QuadraticOutEase(from.y, to.y, normalizedPassedTime));
        }

        public static Vector3 QuadraticOutEase(Vector3 from, Vector3 to, float normalizedPassedTime)
        {
            return new Vector3(QuadraticOutEase(from.x, to.x, normalizedPassedTime), QuadraticOutEase(from.y, to.y, normalizedPassedTime), QuadraticOutEase(from.z, to.z, normalizedPassedTime));
        }

        public static Vector4 QuadraticOutEase(Vector4 from, Vector4 to, float normalizedPassedTime)
        {
            return new Vector4(QuadraticOutEase(from.x, to.x, normalizedPassedTime), QuadraticOutEase(from.y, to.y, normalizedPassedTime), QuadraticOutEase(from.z, to.z, normalizedPassedTime), QuadraticOutEase(from.w, to.w, normalizedPassedTime));
        }

        public static Quaternion QuadraticOutEase(Quaternion from, Quaternion to, float normalizedPassedTime)
        {
            return Quaternion.Lerp(from, to, QuadraticOutEase(0f, 1f, normalizedPassedTime));
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

        public static Vector2 QuadraticInOutEase(Vector2 from, Vector2 to, float normalizedPassedTime)
        {
            return new Vector2(QuadraticInOutEase(from.x, to.x, normalizedPassedTime), QuadraticInOutEase(from.y, to.y, normalizedPassedTime));
        }

        public static Vector3 QuadraticInOutEase(Vector3 from, Vector3 to, float normalizedPassedTime)
        {
            return new Vector3(QuadraticInOutEase(from.x, to.x, normalizedPassedTime), QuadraticInOutEase(from.y, to.y, normalizedPassedTime), QuadraticInOutEase(from.z, to.z, normalizedPassedTime));
        }

        public static Vector4 QuadraticInOutEase(Vector4 from, Vector4 to, float normalizedPassedTime)
        {
            return new Vector4(QuadraticInOutEase(from.x, to.x, normalizedPassedTime), QuadraticInOutEase(from.y, to.y, normalizedPassedTime), QuadraticInOutEase(from.z, to.z, normalizedPassedTime), QuadraticInOutEase(from.w, to.w, normalizedPassedTime));
        }

        public static Quaternion QuadraticInOutEase(Quaternion from, Quaternion to, float normalizedPassedTime)
        {
            return Quaternion.Lerp(from, to, QuadraticInOutEase(0f, 1f, normalizedPassedTime));
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

        public static Vector2 CubicInEase(Vector2 from, Vector2 to, float normalizedPassedTime)
        {
            return new Vector2(CubicInEase(from.x, to.x, normalizedPassedTime), CubicInEase(from.y, to.y, normalizedPassedTime));
        }

        public static Vector3 CubicInEase(Vector3 from, Vector3 to, float normalizedPassedTime)
        {
            return new Vector3(CubicInEase(from.x, to.x, normalizedPassedTime), CubicInEase(from.y, to.y, normalizedPassedTime), CubicInEase(from.z, to.z, normalizedPassedTime));
        }

        public static Vector4 CubicInEase(Vector4 from, Vector4 to, float normalizedPassedTime)
        {
            return new Vector4(CubicInEase(from.x, to.x, normalizedPassedTime), CubicInEase(from.y, to.y, normalizedPassedTime), CubicInEase(from.z, to.z, normalizedPassedTime), CubicInEase(from.w, to.w, normalizedPassedTime));
        }

        public static Quaternion CubicInEase(Quaternion from, Quaternion to, float normalizedPassedTime)
        {
            return Quaternion.Lerp(from, to, CubicInEase(0f, 1f, normalizedPassedTime));
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

        public static Vector2 CubicOutEase(Vector2 from, Vector2 to, float normalizedPassedTime)
        {
            return new Vector2(CubicOutEase(from.x, to.x, normalizedPassedTime), CubicOutEase(from.y, to.y, normalizedPassedTime));
        }

        public static Vector3 CubicOutEase(Vector3 from, Vector3 to, float normalizedPassedTime)
        {
            return new Vector3(CubicOutEase(from.x, to.x, normalizedPassedTime), CubicOutEase(from.y, to.y, normalizedPassedTime), CubicOutEase(from.z, to.z, normalizedPassedTime));
        }

        public static Vector4 CubicOutEase(Vector4 from, Vector4 to, float normalizedPassedTime)
        {
            return new Vector4(CubicOutEase(from.x, to.x, normalizedPassedTime), CubicOutEase(from.y, to.y, normalizedPassedTime), CubicOutEase(from.z, to.z, normalizedPassedTime), CubicOutEase(from.w, to.w, normalizedPassedTime));
        }

        public static Quaternion CubicOutEase(Quaternion from, Quaternion to, float normalizedPassedTime)
        {
            return Quaternion.Lerp(from, to, CubicOutEase(0f, 1f, normalizedPassedTime));
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

        public static Vector2 CubicInOutEase(Vector2 from, Vector2 to, float normalizedPassedTime)
        {
            return new Vector2(CubicInOutEase(from.x, to.x, normalizedPassedTime), CubicInOutEase(from.y, to.y, normalizedPassedTime));
        }

        public static Vector3 CubicInOutEase(Vector3 from, Vector3 to, float normalizedPassedTime)
        {
            return new Vector3(CubicInOutEase(from.x, to.x, normalizedPassedTime), CubicInOutEase(from.y, to.y, normalizedPassedTime), CubicInOutEase(from.z, to.z, normalizedPassedTime));
        }

        public static Vector4 CubicInOutEase(Vector4 from, Vector4 to, float normalizedPassedTime)
        {
            return new Vector4(CubicInOutEase(from.x, to.x, normalizedPassedTime), CubicInOutEase(from.y, to.y, normalizedPassedTime), CubicInOutEase(from.z, to.z, normalizedPassedTime), CubicInOutEase(from.w, to.w, normalizedPassedTime));
        }

        public static Quaternion CubicInOutEase(Quaternion from, Quaternion to, float normalizedPassedTime)
        {
            return Quaternion.Lerp(from, to, CubicInOutEase(0f, 1f, normalizedPassedTime));
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

        public static Vector2 QuarticInEase(Vector2 from, Vector2 to, float normalizedPassedTime)
        {
            return new Vector2(QuarticInEase(from.x, to.x, normalizedPassedTime), QuarticInEase(from.y, to.y, normalizedPassedTime));
        }

        public static Vector3 QuarticInEase(Vector3 from, Vector3 to, float normalizedPassedTime)
        {
            return new Vector3(QuarticInEase(from.x, to.x, normalizedPassedTime), QuarticInEase(from.y, to.y, normalizedPassedTime), QuarticInEase(from.z, to.z, normalizedPassedTime));
        }

        public static Vector4 QuarticInEase(Vector4 from, Vector4 to, float normalizedPassedTime)
        {
            return new Vector4(QuarticInEase(from.x, to.x, normalizedPassedTime), QuarticInEase(from.y, to.y, normalizedPassedTime), QuarticInEase(from.z, to.z, normalizedPassedTime), QuarticInEase(from.w, to.w, normalizedPassedTime));
        }

        public static Quaternion QuarticInEase(Quaternion from, Quaternion to, float normalizedPassedTime)
        {
            return Quaternion.Lerp(from, to, QuarticInEase(0f, 1f, normalizedPassedTime));
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

        public static Vector2 QuarticOutEase(Vector2 from, Vector2 to, float normalizedPassedTime)
        {
            return new Vector2(QuarticOutEase(from.x, to.x, normalizedPassedTime), QuarticOutEase(from.y, to.y, normalizedPassedTime));
        }

        public static Vector3 QuarticOutEase(Vector3 from, Vector3 to, float normalizedPassedTime)
        {
            return new Vector3(QuarticOutEase(from.x, to.x, normalizedPassedTime), QuarticOutEase(from.y, to.y, normalizedPassedTime), QuarticOutEase(from.z, to.z, normalizedPassedTime));
        }

        public static Vector4 QuarticOutEase(Vector4 from, Vector4 to, float normalizedPassedTime)
        {
            return new Vector4(QuarticOutEase(from.x, to.x, normalizedPassedTime), QuarticOutEase(from.y, to.y, normalizedPassedTime), QuarticOutEase(from.z, to.z, normalizedPassedTime), QuarticOutEase(from.w, to.w, normalizedPassedTime));
        }

        public static Quaternion QuarticOutEase(Quaternion from, Quaternion to, float normalizedPassedTime)
        {
            return Quaternion.Lerp(from, to, QuarticOutEase(0f, 1f, normalizedPassedTime));
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

        public static Vector2 QuarticInOutEase(Vector2 from, Vector2 to, float normalizedPassedTime)
        {
            return new Vector2(QuarticInOutEase(from.x, to.x, normalizedPassedTime), QuarticInOutEase(from.y, to.y, normalizedPassedTime));
        }

        public static Vector3 QuarticInOutEase(Vector3 from, Vector3 to, float normalizedPassedTime)
        {
            return new Vector3(QuarticInOutEase(from.x, to.x, normalizedPassedTime), QuarticInOutEase(from.y, to.y, normalizedPassedTime), QuarticInOutEase(from.z, to.z, normalizedPassedTime));
        }

        public static Vector4 QuarticInOutEase(Vector4 from, Vector4 to, float normalizedPassedTime)
        {
            return new Vector4(QuarticInOutEase(from.x, to.x, normalizedPassedTime), QuarticInOutEase(from.y, to.y, normalizedPassedTime), QuarticInOutEase(from.z, to.z, normalizedPassedTime), QuarticInOutEase(from.w, to.w, normalizedPassedTime));
        }

        public static Quaternion QuarticInOutEase(Quaternion from, Quaternion to, float normalizedPassedTime)
        {
            return Quaternion.Lerp(from, to, QuarticInOutEase(0f, 1f, normalizedPassedTime));
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

        public static Vector2 QuinticInEase(Vector2 from, Vector2 to, float normalizedPassedTime)
        {
            return new Vector2(QuinticInEase(from.x, to.x, normalizedPassedTime), QuinticInEase(from.y, to.y, normalizedPassedTime));
        }

        public static Vector3 QuinticInEase(Vector3 from, Vector3 to, float normalizedPassedTime)
        {
            return new Vector3(QuinticInEase(from.x, to.x, normalizedPassedTime), QuinticInEase(from.y, to.y, normalizedPassedTime), QuinticInEase(from.z, to.z, normalizedPassedTime));
        }

        public static Vector4 QuinticInEase(Vector4 from, Vector4 to, float normalizedPassedTime)
        {
            return new Vector4(QuinticInEase(from.x, to.x, normalizedPassedTime), QuinticInEase(from.y, to.y, normalizedPassedTime), QuinticInEase(from.z, to.z, normalizedPassedTime), QuinticInEase(from.w, to.w, normalizedPassedTime));
        }

        public static Quaternion QuinticInEase(Quaternion from, Quaternion to, float normalizedPassedTime)
        {
            return Quaternion.Lerp(from, to, QuinticInEase(0f, 1f, normalizedPassedTime));
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

        public static Vector2 QuinticOutEase(Vector2 from, Vector2 to, float normalizedPassedTime)
        {
            return new Vector2(QuinticOutEase(from.x, to.x, normalizedPassedTime), QuinticOutEase(from.y, to.y, normalizedPassedTime));
        }

        public static Vector3 QuinticOutEase(Vector3 from, Vector3 to, float normalizedPassedTime)
        {
            return new Vector3(QuinticOutEase(from.x, to.x, normalizedPassedTime), QuinticOutEase(from.y, to.y, normalizedPassedTime), QuinticOutEase(from.z, to.z, normalizedPassedTime));
        }

        public static Vector4 QuinticOutEase(Vector4 from, Vector4 to, float normalizedPassedTime)
        {
            return new Vector4(QuinticOutEase(from.x, to.x, normalizedPassedTime), QuinticOutEase(from.y, to.y, normalizedPassedTime), QuinticOutEase(from.z, to.z, normalizedPassedTime), QuinticOutEase(from.w, to.w, normalizedPassedTime));
        }

        public static Quaternion QuinticOutEase(Quaternion from, Quaternion to, float normalizedPassedTime)
        {
            return Quaternion.Lerp(from, to, QuinticOutEase(0f, 1f, normalizedPassedTime));
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

        public static Vector2 QuinticInOutEase(Vector2 from, Vector2 to, float normalizedPassedTime)
        {
            return new Vector2(QuinticInOutEase(from.x, to.x, normalizedPassedTime), QuinticInOutEase(from.y, to.y, normalizedPassedTime));
        }

        public static Vector3 QuinticInOutEase(Vector3 from, Vector3 to, float normalizedPassedTime)
        {
            return new Vector3(QuinticInOutEase(from.x, to.x, normalizedPassedTime), QuinticInOutEase(from.y, to.y, normalizedPassedTime), QuinticInOutEase(from.z, to.z, normalizedPassedTime));
        }

        public static Vector4 QuinticInOutEase(Vector4 from, Vector4 to, float normalizedPassedTime)
        {
            return new Vector4(QuinticInOutEase(from.x, to.x, normalizedPassedTime), QuinticInOutEase(from.y, to.y, normalizedPassedTime), QuinticInOutEase(from.z, to.z, normalizedPassedTime), QuinticInOutEase(from.w, to.w, normalizedPassedTime));
        }

        public static Quaternion QuinticInOutEase(Quaternion from, Quaternion to, float normalizedPassedTime)
        {
            return Quaternion.Lerp(from, to, QuinticInOutEase(0f, 1f, normalizedPassedTime));
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

        public static Vector2 SinusoidalInEase(Vector2 from, Vector2 to, float normalizedPassedTime)
        {
            return new Vector2(SinusoidalInEase(from.x, to.x, normalizedPassedTime), SinusoidalInEase(from.y, to.y, normalizedPassedTime));
        }

        public static Vector3 SinusoidalInEase(Vector3 from, Vector3 to, float normalizedPassedTime)
        {
            return new Vector3(SinusoidalInEase(from.x, to.x, normalizedPassedTime), SinusoidalInEase(from.y, to.y, normalizedPassedTime), SinusoidalInEase(from.z, to.z, normalizedPassedTime));
        }

        public static Vector4 SinusoidalInEase(Vector4 from, Vector4 to, float normalizedPassedTime)
        {
            return new Vector4(SinusoidalInEase(from.x, to.x, normalizedPassedTime), SinusoidalInEase(from.y, to.y, normalizedPassedTime), SinusoidalInEase(from.z, to.z, normalizedPassedTime), SinusoidalInEase(from.w, to.w, normalizedPassedTime));
        }

        public static Quaternion SinusoidalInEase(Quaternion from, Quaternion to, float normalizedPassedTime)
        {
            return Quaternion.Lerp(from, to, SinusoidalInEase(0f, 1f, normalizedPassedTime));
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

        public static Vector2 SinusoidalOutEase(Vector2 from, Vector2 to, float normalizedPassedTime)
        {
            return new Vector2(SinusoidalOutEase(from.x, to.x, normalizedPassedTime), SinusoidalOutEase(from.y, to.y, normalizedPassedTime));
        }

        public static Vector3 SinusoidalOutEase(Vector3 from, Vector3 to, float normalizedPassedTime)
        {
            return new Vector3(SinusoidalOutEase(from.x, to.x, normalizedPassedTime), SinusoidalOutEase(from.y, to.y, normalizedPassedTime), SinusoidalOutEase(from.z, to.z, normalizedPassedTime));
        }

        public static Vector4 SinusoidalOutEase(Vector4 from, Vector4 to, float normalizedPassedTime)
        {
            return new Vector4(SinusoidalOutEase(from.x, to.x, normalizedPassedTime), SinusoidalOutEase(from.y, to.y, normalizedPassedTime), SinusoidalOutEase(from.z, to.z, normalizedPassedTime), SinusoidalOutEase(from.w, to.w, normalizedPassedTime));
        }

        public static Quaternion SinusoidalOutEase(Quaternion from, Quaternion to, float normalizedPassedTime)
        {
            return Quaternion.Lerp(from, to, SinusoidalOutEase(0f, 1f, normalizedPassedTime));
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

        public static Vector2 SinusoidalInOutEase(Vector2 from, Vector2 to, float normalizedPassedTime)
        {
            return new Vector2(SinusoidalInOutEase(from.x, to.x, normalizedPassedTime), SinusoidalInOutEase(from.y, to.y, normalizedPassedTime));
        }

        public static Vector3 SinusoidalInOutEase(Vector3 from, Vector3 to, float normalizedPassedTime)
        {
            return new Vector3(SinusoidalInOutEase(from.x, to.x, normalizedPassedTime), SinusoidalInOutEase(from.y, to.y, normalizedPassedTime), SinusoidalInOutEase(from.z, to.z, normalizedPassedTime));
        }

        public static Vector4 SinusoidalInOutEase(Vector4 from, Vector4 to, float normalizedPassedTime)
        {
            return new Vector4(SinusoidalInOutEase(from.x, to.x, normalizedPassedTime), SinusoidalInOutEase(from.y, to.y, normalizedPassedTime), SinusoidalInOutEase(from.z, to.z, normalizedPassedTime), SinusoidalInOutEase(from.w, to.w, normalizedPassedTime));
        }

        public static Quaternion SinusoidalInOutEase(Quaternion from, Quaternion to, float normalizedPassedTime)
        {
            return Quaternion.Lerp(from, to, SinusoidalInOutEase(0f, 1f, normalizedPassedTime));
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

        public static Vector2 ExponentialInEase(Vector2 from, Vector2 to, float normalizedPassedTime)
        {
            return new Vector2(ExponentialInEase(from.x, to.x, normalizedPassedTime), ExponentialInEase(from.y, to.y, normalizedPassedTime));
        }

        public static Vector3 ExponentialInEase(Vector3 from, Vector3 to, float normalizedPassedTime)
        {
            return new Vector3(ExponentialInEase(from.x, to.x, normalizedPassedTime), ExponentialInEase(from.y, to.y, normalizedPassedTime), ExponentialInEase(from.z, to.z, normalizedPassedTime));
        }

        public static Vector4 ExponentialInEase(Vector4 from, Vector4 to, float normalizedPassedTime)
        {
            return new Vector4(ExponentialInEase(from.x, to.x, normalizedPassedTime), ExponentialInEase(from.y, to.y, normalizedPassedTime), ExponentialInEase(from.z, to.z, normalizedPassedTime), ExponentialInEase(from.w, to.w, normalizedPassedTime));
        }

        public static Quaternion ExponentialInEase(Quaternion from, Quaternion to, float normalizedPassedTime)
        {
            return Quaternion.Lerp(from, to, ExponentialInEase(0f, 1f, normalizedPassedTime));
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

        public static Vector2 ExponentialOutEase(Vector2 from, Vector2 to, float normalizedPassedTime)
        {
            return new Vector2(ExponentialOutEase(from.x, to.x, normalizedPassedTime), ExponentialOutEase(from.y, to.y, normalizedPassedTime));
        }

        public static Vector3 ExponentialOutEase(Vector3 from, Vector3 to, float normalizedPassedTime)
        {
            return new Vector3(ExponentialOutEase(from.x, to.x, normalizedPassedTime), ExponentialOutEase(from.y, to.y, normalizedPassedTime), ExponentialOutEase(from.z, to.z, normalizedPassedTime));
        }

        public static Vector4 ExponentialOutEase(Vector4 from, Vector4 to, float normalizedPassedTime)
        {
            return new Vector4(ExponentialOutEase(from.x, to.x, normalizedPassedTime), ExponentialOutEase(from.y, to.y, normalizedPassedTime), ExponentialOutEase(from.z, to.z, normalizedPassedTime), ExponentialOutEase(from.w, to.w, normalizedPassedTime));
        }

        public static Quaternion ExponentialOutEase(Quaternion from, Quaternion to, float normalizedPassedTime)
        {
            return Quaternion.Lerp(from, to, ExponentialOutEase(0f, 1f, normalizedPassedTime));
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

        public static Vector2 ExponentialInOutEase(Vector2 from, Vector2 to, float normalizedPassedTime)
        {
            return new Vector2(ExponentialInOutEase(from.x, to.x, normalizedPassedTime), ExponentialInOutEase(from.y, to.y, normalizedPassedTime));
        }

        public static Vector3 ExponentialInOutEase(Vector3 from, Vector3 to, float normalizedPassedTime)
        {
            return new Vector3(ExponentialInOutEase(from.x, to.x, normalizedPassedTime), ExponentialInOutEase(from.y, to.y, normalizedPassedTime), ExponentialInOutEase(from.z, to.z, normalizedPassedTime));
        }

        public static Vector4 ExponentialInOutEase(Vector4 from, Vector4 to, float normalizedPassedTime)
        {
            return new Vector4(ExponentialInOutEase(from.x, to.x, normalizedPassedTime), ExponentialInOutEase(from.y, to.y, normalizedPassedTime), ExponentialInOutEase(from.z, to.z, normalizedPassedTime), ExponentialInOutEase(from.w, to.w, normalizedPassedTime));
        }

        public static Quaternion ExponentialInOutEase(Quaternion from, Quaternion to, float normalizedPassedTime)
        {
            return Quaternion.Lerp(from, to, ExponentialInOutEase(0f, 1f, normalizedPassedTime));
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

        public static Vector2 CircularInEase(Vector2 from, Vector2 to, float normalizedPassedTime)
        {
            return new Vector2(CircularInEase(from.x, to.x, normalizedPassedTime), CircularInEase(from.y, to.y, normalizedPassedTime));
        }

        public static Vector3 CircularInEase(Vector3 from, Vector3 to, float normalizedPassedTime)
        {
            return new Vector3(CircularInEase(from.x, to.x, normalizedPassedTime), CircularInEase(from.y, to.y, normalizedPassedTime), CircularInEase(from.z, to.z, normalizedPassedTime));
        }

        public static Vector4 CircularInEase(Vector4 from, Vector4 to, float normalizedPassedTime)
        {
            return new Vector4(CircularInEase(from.x, to.x, normalizedPassedTime), CircularInEase(from.y, to.y, normalizedPassedTime), CircularInEase(from.z, to.z, normalizedPassedTime), CircularInEase(from.w, to.w, normalizedPassedTime));
        }

        public static Quaternion CircularInEase(Quaternion from, Quaternion to, float normalizedPassedTime)
        {
            return Quaternion.Lerp(from, to, CircularInEase(0f, 1f, normalizedPassedTime));
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

        public static Vector2 CircularOutEase(Vector2 from, Vector2 to, float normalizedPassedTime)
        {
            return new Vector2(CircularOutEase(from.x, to.x, normalizedPassedTime), CircularOutEase(from.y, to.y, normalizedPassedTime));
        }

        public static Vector3 CircularOutEase(Vector3 from, Vector3 to, float normalizedPassedTime)
        {
            return new Vector3(CircularOutEase(from.x, to.x, normalizedPassedTime), CircularOutEase(from.y, to.y, normalizedPassedTime), CircularOutEase(from.z, to.z, normalizedPassedTime));
        }

        public static Vector4 CircularOutEase(Vector4 from, Vector4 to, float normalizedPassedTime)
        {
            return new Vector4(CircularOutEase(from.x, to.x, normalizedPassedTime), CircularOutEase(from.y, to.y, normalizedPassedTime), CircularOutEase(from.z, to.z, normalizedPassedTime), CircularOutEase(from.w, to.w, normalizedPassedTime));
        }

        public static Quaternion CircularOutEase(Quaternion from, Quaternion to, float normalizedPassedTime)
        {
            return Quaternion.Lerp(from, to, CircularOutEase(0f, 1f, normalizedPassedTime));
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

        public static Vector2 CircularInOutEase(Vector2 from, Vector2 to, float normalizedPassedTime)
        {
            return new Vector2(CircularInOutEase(from.x, to.x, normalizedPassedTime), CircularInOutEase(from.y, to.y, normalizedPassedTime));
        }

        public static Vector3 CircularInOutEase(Vector3 from, Vector3 to, float normalizedPassedTime)
        {
            return new Vector3(CircularInOutEase(from.x, to.x, normalizedPassedTime), CircularInOutEase(from.y, to.y, normalizedPassedTime), CircularInOutEase(from.z, to.z, normalizedPassedTime));
        }

        public static Vector4 CircularInOutEase(Vector4 from, Vector4 to, float normalizedPassedTime)
        {
            return new Vector4(CircularInOutEase(from.x, to.x, normalizedPassedTime), CircularInOutEase(from.y, to.y, normalizedPassedTime), CircularInOutEase(from.z, to.z, normalizedPassedTime), CircularInOutEase(from.w, to.w, normalizedPassedTime));
        }

        public static Quaternion CircularInOutEase(Quaternion from, Quaternion to, float normalizedPassedTime)
        {
            return Quaternion.Lerp(from, to, CircularInOutEase(0f, 1f, normalizedPassedTime));
        }
        #endregion
        #endregion
        #endregion
    }
}