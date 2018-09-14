using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Numba.Tweening
{
    public static class Easing
    {
        private static AnimationCurve _cachedCurve = new AnimationCurve();

        #region Ease by curve
        private static void SetNormalizedCurveToCached(AnimationCurve curve)
        {
            Keyframe[] keys = curve.keys;

            #region Move and scale keys
            if (keys[0].time != 0f || keys[0].value != 0f)
            {
                float offsetTime = keys[0].time;
                float offsetValue = keys[0].value;

                for (int i = 0; i < keys.Length; i++)
                {
                    Keyframe key = keys[i];
                    key.time -= offsetTime;
                    key.value -= offsetValue;

                    keys[i] = key;
                }
            }

            if (keys[keys.Length - 1].time != 1f || keys[keys.Length - 1].value != 1f)
            {
                float lastTime = keys[keys.Length - 1].time;
                float lastValue = keys[keys.Length - 1].value;

                for (int i = 0; i < keys.Length; i++)
                {
                    Keyframe key = keys[i];
                    key.time /= lastTime;
                    key.value /= lastValue;

                    keys[i] = key;
                }
            }
            #endregion

            _cachedCurve.keys = keys;
        }

        public static int Ease(int from, int to, float normalizedTime, AnimationCurve curve)
        {
            if (curve.length < 2) return from;

            SetNormalizedCurveToCached(curve);

            return Linear(from, to, curve.Evaluate(normalizedTime));
        }

        public static long Ease(long from, long to, float normalizedTime, AnimationCurve curve)
        {
            if (curve.length < 2) return from;

            SetNormalizedCurveToCached(curve);

            return Linear(from, to, _cachedCurve.Evaluate(normalizedTime));
        }

        public static float Ease(float from, float to, float normalizedTime, AnimationCurve curve)
        {
            if (curve.length < 2) return from;

            SetNormalizedCurveToCached(curve);

            return Linear(from, to, curve.Evaluate(normalizedTime));
        }

        public static double Ease(double from, double to, float normalizedTime, AnimationCurve curve)
        {
            if (curve.length < 2) return from;

            SetNormalizedCurveToCached(curve);

            return Linear(from, to, curve.Evaluate(normalizedTime));
        }

        public static DateTime Ease(DateTime from, DateTime to, float normalizedTime, AnimationCurve curve)
        {
            if (curve.length < 2) return from;

            SetNormalizedCurveToCached(curve);

            return Linear(from, to, curve.Evaluate(normalizedTime));
        }

        public static Vector2 Ease(Vector2 from, Vector2 to, float normalizedTime, AnimationCurve curve)
        {
            if (curve.length < 2) return from;

            SetNormalizedCurveToCached(curve);

            return Linear(from, to, curve.Evaluate(normalizedTime));
        }

        public static Vector3 Ease(Vector3 from, Vector3 to, float normalizedTime, AnimationCurve curve)
        {
            if (curve.length < 2) return from;

            SetNormalizedCurveToCached(curve);

            return Linear(from, to, curve.Evaluate(normalizedTime));
        }

        public static Vector4 Ease(Vector4 from, Vector4 to, float normalizedTime, AnimationCurve curve)
        {
            if (curve.length < 2) return from;

            SetNormalizedCurveToCached(curve);

            return Linear(from, to, curve.Evaluate(normalizedTime));
        }

        public static Quaternion Ease(Quaternion from, Quaternion to, float normalizedTime, AnimationCurve curve)
        {
            if (curve.length < 2) return from;

            SetNormalizedCurveToCached(curve);

            return Linear(from, to, curve.Evaluate(normalizedTime));
        }

        public static Rect Ease(Rect from, Rect to, float normalizedTime, AnimationCurve curve)
        {
            if (curve.length < 2) return from;

            SetNormalizedCurveToCached(curve);

            return Linear(from, to, curve.Evaluate(normalizedTime));
        }

        public static Color Ease(Color from, Color to, float normalizedTime, AnimationCurve curve)
        {
            if (curve.length < 2) return from;

            SetNormalizedCurveToCached(curve);

            return Linear(from, to, curve.Evaluate(normalizedTime));
        }

        public static Color32 Ease(Color32 from, Color32 to, float normalizedTime, AnimationCurve curve)
        {
            if (curve.length < 2) return from;

            SetNormalizedCurveToCached(curve);

            return Linear(from, to, curve.Evaluate(normalizedTime));
        }
        #endregion

        #region Ease by formulas
        public static int Ease(int from, int to, float normalizedTime, Ease ease)
        {
            switch (ease)
            {
                case Tweening.Ease.Linear: return Linear(from, to, normalizedTime);
                case Tweening.Ease.InQuad: return QuadraticInEase(from, to, normalizedTime);
                case Tweening.Ease.OutQuad: return QuadraticOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutQuad: return QuadraticInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InCubic: return CubicInEase(from, to, normalizedTime);
                case Tweening.Ease.OutCubic: return CubicOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutCubic: return CubicInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InQuart: return QuarticInEase(from, to, normalizedTime);
                case Tweening.Ease.OutQuart: return QuarticOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutQuart: return QuarticInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InQuint: return QuinticInEase(from, to, normalizedTime);
                case Tweening.Ease.OutQuint: return QuinticOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutQuint: return QuinticInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InSine: return SinusoidalInEase(from, to, normalizedTime);
                case Tweening.Ease.OutSine: return SinusoidalOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutSine: return SinusoidalInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InExpo: return ExponentialInEase(from, to, normalizedTime);
                case Tweening.Ease.OutExpo: return ExponentialOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutExpo: return ExponentialInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InCirc: return CircularInEase(from, to, normalizedTime);
                case Tweening.Ease.OutCirc: return CircularOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutCirc: return CircularInOutEase(from, to, normalizedTime);
                default: return 0;
            }
        }

        public static long Ease(long from, long to, float normalizedTime, Ease ease)
        {
            switch (ease)
            {
                case Tweening.Ease.Linear: return Linear(from, to, normalizedTime);
                case Tweening.Ease.InQuad: return QuadraticInEase(from, to, normalizedTime);
                case Tweening.Ease.OutQuad: return QuadraticOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutQuad: return QuadraticInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InCubic: return CubicInEase(from, to, normalizedTime);
                case Tweening.Ease.OutCubic: return CubicOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutCubic: return CubicInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InQuart: return QuarticInEase(from, to, normalizedTime);
                case Tweening.Ease.OutQuart: return QuarticOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutQuart: return QuarticInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InQuint: return QuinticInEase(from, to, normalizedTime);
                case Tweening.Ease.OutQuint: return QuinticOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutQuint: return QuinticInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InSine: return SinusoidalInEase(from, to, normalizedTime);
                case Tweening.Ease.OutSine: return SinusoidalOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutSine: return SinusoidalInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InExpo: return ExponentialInEase(from, to, normalizedTime);
                case Tweening.Ease.OutExpo: return ExponentialOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutExpo: return ExponentialInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InCirc: return CircularInEase(from, to, normalizedTime);
                case Tweening.Ease.OutCirc: return CircularOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutCirc: return CircularInOutEase(from, to, normalizedTime);
                default: return 0L;
            }
        }

        public static float Ease(float from, float to, float normalizedTime, Ease ease)
        {
            switch (ease)
            {
                case Tweening.Ease.Linear: return Linear(from, to, normalizedTime);
                case Tweening.Ease.InQuad: return QuadraticInEase(from, to, normalizedTime);
                case Tweening.Ease.OutQuad: return QuadraticOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutQuad: return QuadraticInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InCubic: return CubicInEase(from, to, normalizedTime);
                case Tweening.Ease.OutCubic: return CubicOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutCubic: return CubicInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InQuart: return QuarticInEase(from, to, normalizedTime);
                case Tweening.Ease.OutQuart: return QuarticOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutQuart: return QuarticInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InQuint: return QuinticInEase(from, to, normalizedTime);
                case Tweening.Ease.OutQuint: return QuinticOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutQuint: return QuinticInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InSine: return SinusoidalInEase(from, to, normalizedTime);
                case Tweening.Ease.OutSine: return SinusoidalOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutSine: return SinusoidalInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InExpo: return ExponentialInEase(from, to, normalizedTime);
                case Tweening.Ease.OutExpo: return ExponentialOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutExpo: return ExponentialInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InCirc: return CircularInEase(from, to, normalizedTime);
                case Tweening.Ease.OutCirc: return CircularOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutCirc: return CircularInOutEase(from, to, normalizedTime);
                default: return 0f;
            }
        }

        public static double Ease(double from, double to, float normalizedTime, Ease ease)
        {
            switch (ease)
            {
                case Tweening.Ease.Linear: return Linear(from, to, normalizedTime);
                case Tweening.Ease.InQuad: return QuadraticInEase(from, to, normalizedTime);
                case Tweening.Ease.OutQuad: return QuadraticOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutQuad: return QuadraticInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InCubic: return CubicInEase(from, to, normalizedTime);
                case Tweening.Ease.OutCubic: return CubicOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutCubic: return CubicInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InQuart: return QuarticInEase(from, to, normalizedTime);
                case Tweening.Ease.OutQuart: return QuarticOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutQuart: return QuarticInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InQuint: return QuinticInEase(from, to, normalizedTime);
                case Tweening.Ease.OutQuint: return QuinticOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutQuint: return QuinticInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InSine: return SinusoidalInEase(from, to, normalizedTime);
                case Tweening.Ease.OutSine: return SinusoidalOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutSine: return SinusoidalInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InExpo: return ExponentialInEase(from, to, normalizedTime);
                case Tweening.Ease.OutExpo: return ExponentialOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutExpo: return ExponentialInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InCirc: return CircularInEase(from, to, normalizedTime);
                case Tweening.Ease.OutCirc: return CircularOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutCirc: return CircularInOutEase(from, to, normalizedTime);
                default: return 0f;
            }
        }

        public static DateTime Ease(DateTime from, DateTime to, float normalizedTime, Ease ease)
        {
            switch (ease)
            {
                case Tweening.Ease.Linear: return Linear(from, to, normalizedTime);
                case Tweening.Ease.InQuad: return QuadraticInEase(from, to, normalizedTime);
                case Tweening.Ease.OutQuad: return QuadraticOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutQuad: return QuadraticInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InCubic: return CubicInEase(from, to, normalizedTime);
                case Tweening.Ease.OutCubic: return CubicOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutCubic: return CubicInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InQuart: return QuarticInEase(from, to, normalizedTime);
                case Tweening.Ease.OutQuart: return QuarticOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutQuart: return QuarticInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InQuint: return QuinticInEase(from, to, normalizedTime);
                case Tweening.Ease.OutQuint: return QuinticOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutQuint: return QuinticInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InSine: return SinusoidalInEase(from, to, normalizedTime);
                case Tweening.Ease.OutSine: return SinusoidalOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutSine: return SinusoidalInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InExpo: return ExponentialInEase(from, to, normalizedTime);
                case Tweening.Ease.OutExpo: return ExponentialOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutExpo: return ExponentialInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InCirc: return CircularInEase(from, to, normalizedTime);
                case Tweening.Ease.OutCirc: return CircularOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutCirc: return CircularInOutEase(from, to, normalizedTime);
                default: return DateTime.MinValue;
            }
        }

        public static Vector2 Ease(Vector2 from, Vector2 to, float normalizedTime, Ease ease)
        {
            switch (ease)
            {
                case Tweening.Ease.Linear: return Linear(from, to, normalizedTime);
                case Tweening.Ease.InQuad: return QuadraticInEase(from, to, normalizedTime);
                case Tweening.Ease.OutQuad: return QuadraticOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutQuad: return QuadraticInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InCubic: return CubicInEase(from, to, normalizedTime);
                case Tweening.Ease.OutCubic: return CubicOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutCubic: return CubicInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InQuart: return QuarticInEase(from, to, normalizedTime);
                case Tweening.Ease.OutQuart: return QuarticOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutQuart: return QuarticInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InQuint: return QuinticInEase(from, to, normalizedTime);
                case Tweening.Ease.OutQuint: return QuinticOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutQuint: return QuinticInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InSine: return SinusoidalInEase(from, to, normalizedTime);
                case Tweening.Ease.OutSine: return SinusoidalOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutSine: return SinusoidalInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InExpo: return ExponentialInEase(from, to, normalizedTime);
                case Tweening.Ease.OutExpo: return ExponentialOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutExpo: return ExponentialInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InCirc: return CircularInEase(from, to, normalizedTime);
                case Tweening.Ease.OutCirc: return CircularOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutCirc: return CircularInOutEase(from, to, normalizedTime);
                default: return Vector2.zero;
            }
        }

        public static Vector3 Ease(Vector3 from, Vector3 to, float normalizedTime, Ease ease)
        {
            switch (ease)
            {
                case Tweening.Ease.Linear: return Linear(from, to, normalizedTime);
                case Tweening.Ease.InQuad: return QuadraticInEase(from, to, normalizedTime);
                case Tweening.Ease.OutQuad: return QuadraticOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutQuad: return QuadraticInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InCubic: return CubicInEase(from, to, normalizedTime);
                case Tweening.Ease.OutCubic: return CubicOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutCubic: return CubicInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InQuart: return QuarticInEase(from, to, normalizedTime);
                case Tweening.Ease.OutQuart: return QuarticOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutQuart: return QuarticInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InQuint: return QuinticInEase(from, to, normalizedTime);
                case Tweening.Ease.OutQuint: return QuinticOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutQuint: return QuinticInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InSine: return SinusoidalInEase(from, to, normalizedTime);
                case Tweening.Ease.OutSine: return SinusoidalOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutSine: return SinusoidalInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InExpo: return ExponentialInEase(from, to, normalizedTime);
                case Tweening.Ease.OutExpo: return ExponentialOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutExpo: return ExponentialInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InCirc: return CircularInEase(from, to, normalizedTime);
                case Tweening.Ease.OutCirc: return CircularOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutCirc: return CircularInOutEase(from, to, normalizedTime);
                default: return Vector3.zero;
            }
        }

        public static Vector4 Ease(Vector4 from, Vector4 to, float normalizedTime, Ease ease)
        {
            switch (ease)
            {
                case Tweening.Ease.Linear: return Linear(from, to, normalizedTime);
                case Tweening.Ease.InQuad: return QuadraticInEase(from, to, normalizedTime);
                case Tweening.Ease.OutQuad: return QuadraticOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutQuad: return QuadraticInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InCubic: return CubicInEase(from, to, normalizedTime);
                case Tweening.Ease.OutCubic: return CubicOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutCubic: return CubicInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InQuart: return QuarticInEase(from, to, normalizedTime);
                case Tweening.Ease.OutQuart: return QuarticOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutQuart: return QuarticInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InQuint: return QuinticInEase(from, to, normalizedTime);
                case Tweening.Ease.OutQuint: return QuinticOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutQuint: return QuinticInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InSine: return SinusoidalInEase(from, to, normalizedTime);
                case Tweening.Ease.OutSine: return SinusoidalOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutSine: return SinusoidalInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InExpo: return ExponentialInEase(from, to, normalizedTime);
                case Tweening.Ease.OutExpo: return ExponentialOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutExpo: return ExponentialInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InCirc: return CircularInEase(from, to, normalizedTime);
                case Tweening.Ease.OutCirc: return CircularOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutCirc: return CircularInOutEase(from, to, normalizedTime);
                default: return Vector4.zero;
            }
        }

        public static Quaternion Ease(Quaternion from, Quaternion to, float normalizedTime, Ease ease)
        {
            switch (ease)
            {
                case Tweening.Ease.Linear: return Linear(from, to, normalizedTime);
                case Tweening.Ease.InQuad: return QuadraticInEase(from, to, normalizedTime);
                case Tweening.Ease.OutQuad: return QuadraticOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutQuad: return QuadraticInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InCubic: return CubicInEase(from, to, normalizedTime);
                case Tweening.Ease.OutCubic: return CubicOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutCubic: return CubicInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InQuart: return QuarticInEase(from, to, normalizedTime);
                case Tweening.Ease.OutQuart: return QuarticOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutQuart: return QuarticInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InQuint: return QuinticInEase(from, to, normalizedTime);
                case Tweening.Ease.OutQuint: return QuinticOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutQuint: return QuinticInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InSine: return SinusoidalInEase(from, to, normalizedTime);
                case Tweening.Ease.OutSine: return SinusoidalOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutSine: return SinusoidalInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InExpo: return ExponentialInEase(from, to, normalizedTime);
                case Tweening.Ease.OutExpo: return ExponentialOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutExpo: return ExponentialInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InCirc: return CircularInEase(from, to, normalizedTime);
                case Tweening.Ease.OutCirc: return CircularOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutCirc: return CircularInOutEase(from, to, normalizedTime);
                default: return Quaternion.identity;
            }
        }

        public static Rect Ease(Rect from, Rect to, float normalizedTime, Ease ease)
        {
            switch (ease)
            {
                case Tweening.Ease.Linear: return Linear(from, to, normalizedTime);
                case Tweening.Ease.InQuad: return QuadraticInEase(from, to, normalizedTime);
                case Tweening.Ease.OutQuad: return QuadraticOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutQuad: return QuadraticInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InCubic: return CubicInEase(from, to, normalizedTime);
                case Tweening.Ease.OutCubic: return CubicOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutCubic: return CubicInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InQuart: return QuarticInEase(from, to, normalizedTime);
                case Tweening.Ease.OutQuart: return QuarticOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutQuart: return QuarticInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InQuint: return QuinticInEase(from, to, normalizedTime);
                case Tweening.Ease.OutQuint: return QuinticOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutQuint: return QuinticInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InSine: return SinusoidalInEase(from, to, normalizedTime);
                case Tweening.Ease.OutSine: return SinusoidalOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutSine: return SinusoidalInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InExpo: return ExponentialInEase(from, to, normalizedTime);
                case Tweening.Ease.OutExpo: return ExponentialOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutExpo: return ExponentialInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InCirc: return CircularInEase(from, to, normalizedTime);
                case Tweening.Ease.OutCirc: return CircularOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutCirc: return CircularInOutEase(from, to, normalizedTime);
                default: return Rect.zero;
            }
        }

        public static Color Ease(Color from, Color to, float normalizedTime, Ease ease)
        {
            switch (ease)
            {
                case Tweening.Ease.Linear: return Linear(from, to, normalizedTime);
                case Tweening.Ease.InQuad: return QuadraticInEase(from, to, normalizedTime);
                case Tweening.Ease.OutQuad: return QuadraticOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutQuad: return QuadraticInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InCubic: return CubicInEase(from, to, normalizedTime);
                case Tweening.Ease.OutCubic: return CubicOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutCubic: return CubicInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InQuart: return QuarticInEase(from, to, normalizedTime);
                case Tweening.Ease.OutQuart: return QuarticOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutQuart: return QuarticInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InQuint: return QuinticInEase(from, to, normalizedTime);
                case Tweening.Ease.OutQuint: return QuinticOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutQuint: return QuinticInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InSine: return SinusoidalInEase(from, to, normalizedTime);
                case Tweening.Ease.OutSine: return SinusoidalOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutSine: return SinusoidalInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InExpo: return ExponentialInEase(from, to, normalizedTime);
                case Tweening.Ease.OutExpo: return ExponentialOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutExpo: return ExponentialInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InCirc: return CircularInEase(from, to, normalizedTime);
                case Tweening.Ease.OutCirc: return CircularOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutCirc: return CircularInOutEase(from, to, normalizedTime);
                default: return Color.black;
            }
        }

        public static Color32 Ease(Color32 from, Color32 to, float normalizedTime, Ease ease)
        {
            switch (ease)
            {
                case Tweening.Ease.Linear: return Linear(from, to, normalizedTime);
                case Tweening.Ease.InQuad: return QuadraticInEase(from, to, normalizedTime);
                case Tweening.Ease.OutQuad: return QuadraticOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutQuad: return QuadraticInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InCubic: return CubicInEase(from, to, normalizedTime);
                case Tweening.Ease.OutCubic: return CubicOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutCubic: return CubicInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InQuart: return QuarticInEase(from, to, normalizedTime);
                case Tweening.Ease.OutQuart: return QuarticOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutQuart: return QuarticInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InQuint: return QuinticInEase(from, to, normalizedTime);
                case Tweening.Ease.OutQuint: return QuinticOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutQuint: return QuinticInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InSine: return SinusoidalInEase(from, to, normalizedTime);
                case Tweening.Ease.OutSine: return SinusoidalOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutSine: return SinusoidalInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InExpo: return ExponentialInEase(from, to, normalizedTime);
                case Tweening.Ease.OutExpo: return ExponentialOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutExpo: return ExponentialInOutEase(from, to, normalizedTime);
                case Tweening.Ease.InCirc: return CircularInEase(from, to, normalizedTime);
                case Tweening.Ease.OutCirc: return CircularOutEase(from, to, normalizedTime);
                case Tweening.Ease.InOutCirc: return CircularInOutEase(from, to, normalizedTime);
                default: return Color.black;
            }
        }

        #region Formulas
        #region Linear
        public static int Linear(int from, int to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (int)((to - from) * t + from);
        }

        public static long Linear(long from, long to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (long)((to - from) * t + from);
        }

        public static float Linear(float from, float to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * t + from;
        }

        public static double Linear(double from, double to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * t + from;
        }

        public static DateTime Linear(DateTime from, DateTime to, float normalizedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(Linear(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedTime)));
        }

        public static Vector2 Linear(Vector2 from, Vector2 to, float normalizedTime)
        {
            return new Vector2(Linear(from.x, to.x, normalizedTime), Linear(from.y, to.y, normalizedTime));
        }

        public static Vector3 Linear(Vector3 from, Vector3 to, float normalizedTime)
        {
            return new Vector3(Linear(from.x, to.x, normalizedTime), Linear(from.y, to.y, normalizedTime), Linear(from.z, to.z, normalizedTime));
        }

        public static Vector4 Linear(Vector4 from, Vector4 to, float normalizedTime)
        {
            return new Vector4(Linear(from.x, to.x, normalizedTime), Linear(from.y, to.y, normalizedTime), Linear(from.z, to.z, normalizedTime), Linear(from.w, to.w, normalizedTime));
        }

        public static Quaternion Linear(Quaternion from, Quaternion to, float normalizedTime)
        {
            return Quaternion.Lerp(from, to, normalizedTime);
        }

        public static Rect Linear(Rect from, Rect to, float normalizedTime)
        {
            return new Rect(Linear(from.position, to.position, normalizedTime), Linear(from.size, to.size, normalizedTime));
        }

        public static Color Linear(Color from, Color to, float normalizedTime)
        {
            return Linear((Vector4)from, (Vector4)to, normalizedTime);
        }

        public static Color32 Linear(Color32 from, Color32 to, float normalizedTime)
        {
            return Linear((Color)from, (Color)to, normalizedTime);
        }
        #endregion

        #region Quadratic
        #region In
        public static int QuadraticInEase(int from, int to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (int)((to - from) * t * t + from);
        }

        public static long QuadraticInEase(long from, long to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (long)((to - from) * t * t + from);
        }

        public static float QuadraticInEase(float from, float to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * t * t + from;
        }

        public static double QuadraticInEase(double from, double to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * t * t + from;
        }

        public static DateTime QuadraticInEase(DateTime from, DateTime to, float normalizedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(QuadraticInEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedTime)));
        }

        public static Vector2 QuadraticInEase(Vector2 from, Vector2 to, float normalizedTime)
        {
            return new Vector2(QuadraticInEase(from.x, to.x, normalizedTime), QuadraticInEase(from.y, to.y, normalizedTime));
        }

        public static Vector3 QuadraticInEase(Vector3 from, Vector3 to, float normalizedTime)
        {
            return new Vector3(QuadraticInEase(from.x, to.x, normalizedTime), QuadraticInEase(from.y, to.y, normalizedTime), QuadraticInEase(from.z, to.z, normalizedTime));
        }

        public static Vector4 QuadraticInEase(Vector4 from, Vector4 to, float normalizedTime)
        {
            return new Vector4(QuadraticInEase(from.x, to.x, normalizedTime), QuadraticInEase(from.y, to.y, normalizedTime), QuadraticInEase(from.z, to.z, normalizedTime), QuadraticInEase(from.w, to.w, normalizedTime));
        }

        public static Quaternion QuadraticInEase(Quaternion from, Quaternion to, float normalizedTime)
        {
            return Quaternion.Lerp(from, to, QuadraticInEase(0f, 1f, normalizedTime));
        }

        public static Rect QuadraticInEase(Rect from, Rect to, float normalizedTime)
        {
            return new Rect(QuadraticInEase(from.position, to.position, normalizedTime), QuadraticInEase(from.size, to.size, normalizedTime));
        }

        public static Color QuadraticInEase(Color from, Color to, float normalizedTime)
        {
            return QuadraticInEase((Vector4)from, (Vector4)to, normalizedTime);
        }

        public static Color32 QuadraticInEase(Color32 from, Color32 to, float normalizedTime)
        {
            return QuadraticInEase((Color)from, (Color)to, normalizedTime);
        }
        #endregion

        #region Out
        public static int QuadraticOutEase(int from, int to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (int)(-(to - from) * t * (t - 2) + from);
        }

        public static long QuadraticOutEase(long from, long to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (long)(-(to - from) * t * (t - 2) + from);
        }

        public static float QuadraticOutEase(float from, float to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return -(to - from) * t * (t - 2) + from;
        }

        public static double QuadraticOutEase(double from, double to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return -(to - from) * t * (t - 2) + from;
        }

        public static DateTime QuadraticOutEase(DateTime from, DateTime to, float normalizedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(QuadraticOutEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedTime)));
        }

        public static Vector2 QuadraticOutEase(Vector2 from, Vector2 to, float normalizedTime)
        {
            return new Vector2(QuadraticOutEase(from.x, to.x, normalizedTime), QuadraticOutEase(from.y, to.y, normalizedTime));
        }

        public static Vector3 QuadraticOutEase(Vector3 from, Vector3 to, float normalizedTime)
        {
            return new Vector3(QuadraticOutEase(from.x, to.x, normalizedTime), QuadraticOutEase(from.y, to.y, normalizedTime), QuadraticOutEase(from.z, to.z, normalizedTime));
        }

        public static Vector4 QuadraticOutEase(Vector4 from, Vector4 to, float normalizedTime)
        {
            return new Vector4(QuadraticOutEase(from.x, to.x, normalizedTime), QuadraticOutEase(from.y, to.y, normalizedTime), QuadraticOutEase(from.z, to.z, normalizedTime), QuadraticOutEase(from.w, to.w, normalizedTime));
        }

        public static Quaternion QuadraticOutEase(Quaternion from, Quaternion to, float normalizedTime)
        {
            return Quaternion.Lerp(from, to, QuadraticOutEase(0f, 1f, normalizedTime));
        }

        public static Rect QuadraticOutEase(Rect from, Rect to, float normalizedTime)
        {
            return new Rect(QuadraticOutEase(from.position, to.position, normalizedTime), QuadraticOutEase(from.size, to.size, normalizedTime));
        }

        public static Color QuadraticOutEase(Color from, Color to, float normalizedTime)
        {
            return QuadraticOutEase((Vector4)from, (Vector4)to, normalizedTime);
        }

        public static Color32 QuadraticOutEase(Color32 from, Color32 to, float normalizedTime)
        {
            return QuadraticOutEase((Color)from, (Color)to, normalizedTime);
        }
        #endregion

        #region InOut
        public static int QuadraticInOutEase(int from, int to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (int)((to - from) / 2 * t * t + from);
            --t;
            return (int)(-(to - from) / 2 * (t * (t - 2) - 1) + from);
        }

        public static long QuadraticInOutEase(long from, long to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (long)((to - from) / 2 * t * t + from);
            --t;
            return (long)(-(to - from) / 2 * (t * (t - 2) - 1) + from);
        }

        public static float QuadraticInOutEase(float from, float to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (to - from) / 2 * t * t + from;
            --t;
            return -(to - from) / 2 * (t * (t - 2) - 1) + from;
        }

        public static double QuadraticInOutEase(double from, double to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (to - from) / 2 * t * t + from;
            --t;
            return -(to - from) / 2 * (t * (t - 2) - 1) + from;
        }

        public static DateTime QuadraticInOutEase(DateTime from, DateTime to, float normalizedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(QuadraticInOutEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedTime)));
        }

        public static Vector2 QuadraticInOutEase(Vector2 from, Vector2 to, float normalizedTime)
        {
            return new Vector2(QuadraticInOutEase(from.x, to.x, normalizedTime), QuadraticInOutEase(from.y, to.y, normalizedTime));
        }

        public static Vector3 QuadraticInOutEase(Vector3 from, Vector3 to, float normalizedTime)
        {
            return new Vector3(QuadraticInOutEase(from.x, to.x, normalizedTime), QuadraticInOutEase(from.y, to.y, normalizedTime), QuadraticInOutEase(from.z, to.z, normalizedTime));
        }

        public static Vector4 QuadraticInOutEase(Vector4 from, Vector4 to, float normalizedTime)
        {
            return new Vector4(QuadraticInOutEase(from.x, to.x, normalizedTime), QuadraticInOutEase(from.y, to.y, normalizedTime), QuadraticInOutEase(from.z, to.z, normalizedTime), QuadraticInOutEase(from.w, to.w, normalizedTime));
        }

        public static Quaternion QuadraticInOutEase(Quaternion from, Quaternion to, float normalizedTime)
        {
            return Quaternion.Lerp(from, to, QuadraticInOutEase(0f, 1f, normalizedTime));
        }

        public static Rect QuadraticInOutEase(Rect from, Rect to, float normalizedTime)
        {
            return new Rect(QuadraticInOutEase(from.position, to.position, normalizedTime), QuadraticInOutEase(from.size, to.size, normalizedTime));
        }

        public static Color QuadraticInOutEase(Color from, Color to, float normalizedTime)
        {
            return QuadraticInOutEase((Vector4)from, (Vector4)to, normalizedTime);
        }

        public static Color32 QuadraticInOutEase(Color32 from, Color32 to, float normalizedTime)
        {
            return QuadraticInOutEase((Color)from, (Color)to, normalizedTime);
        }
        #endregion
        #endregion

        #region Cubic
        #region In
        public static int CubicInEase(int from, int to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (int)((to - from) * t * t * t + from);
        }

        public static long CubicInEase(long from, long to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (long)((to - from) * t * t * t + from);
        }

        public static float CubicInEase(float from, float to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * t * t * t + from;
        }

        public static double CubicInEase(double from, double to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * t * t * t + from;
        }

        public static DateTime CubicInEase(DateTime from, DateTime to, float normalizedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(CubicInEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedTime)));
        }

        public static Vector2 CubicInEase(Vector2 from, Vector2 to, float normalizedTime)
        {
            return new Vector2(CubicInEase(from.x, to.x, normalizedTime), CubicInEase(from.y, to.y, normalizedTime));
        }

        public static Vector3 CubicInEase(Vector3 from, Vector3 to, float normalizedTime)
        {
            return new Vector3(CubicInEase(from.x, to.x, normalizedTime), CubicInEase(from.y, to.y, normalizedTime), CubicInEase(from.z, to.z, normalizedTime));
        }

        public static Vector4 CubicInEase(Vector4 from, Vector4 to, float normalizedTime)
        {
            return new Vector4(CubicInEase(from.x, to.x, normalizedTime), CubicInEase(from.y, to.y, normalizedTime), CubicInEase(from.z, to.z, normalizedTime), CubicInEase(from.w, to.w, normalizedTime));
        }

        public static Quaternion CubicInEase(Quaternion from, Quaternion to, float normalizedTime)
        {
            return Quaternion.Lerp(from, to, CubicInEase(0f, 1f, normalizedTime));
        }

        public static Rect CubicInEase(Rect from, Rect to, float normalizedTime)
        {
            return new Rect(CubicInEase(from.position, to.position, normalizedTime), CubicInEase(from.size, to.size, normalizedTime));
        }

        public static Color CubicInEase(Color from, Color to, float normalizedTime)
        {
            return CubicInEase((Vector4)from, (Vector4)to, normalizedTime);
        }

        public static Color32 CubicInEase(Color32 from, Color32 to, float normalizedTime)
        {
            return CubicInEase((Color)from, (Color)to, normalizedTime);
        }
        #endregion

        #region Out
        public static int CubicOutEase(int from, int to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (int)((to - from) * (t * t * t + 1) + from);
        }

        public static long CubicOutEase(long from, long to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (long)((to - from) * (t * t * t + 1) + from);
        }

        public static float CubicOutEase(float from, float to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (to - from) * (t * t * t + 1) + from;
        }

        public static double CubicOutEase(double from, double to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (to - from) * (t * t * t + 1) + from;
        }

        public static DateTime CubicOutEase(DateTime from, DateTime to, float normalizedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(CubicOutEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedTime)));
        }

        public static Vector2 CubicOutEase(Vector2 from, Vector2 to, float normalizedTime)
        {
            return new Vector2(CubicOutEase(from.x, to.x, normalizedTime), CubicOutEase(from.y, to.y, normalizedTime));
        }

        public static Vector3 CubicOutEase(Vector3 from, Vector3 to, float normalizedTime)
        {
            return new Vector3(CubicOutEase(from.x, to.x, normalizedTime), CubicOutEase(from.y, to.y, normalizedTime), CubicOutEase(from.z, to.z, normalizedTime));
        }

        public static Vector4 CubicOutEase(Vector4 from, Vector4 to, float normalizedTime)
        {
            return new Vector4(CubicOutEase(from.x, to.x, normalizedTime), CubicOutEase(from.y, to.y, normalizedTime), CubicOutEase(from.z, to.z, normalizedTime), CubicOutEase(from.w, to.w, normalizedTime));
        }

        public static Quaternion CubicOutEase(Quaternion from, Quaternion to, float normalizedTime)
        {
            return Quaternion.Lerp(from, to, CubicOutEase(0f, 1f, normalizedTime));
        }

        public static Rect CubicOutEase(Rect from, Rect to, float normalizedTime)
        {
            return new Rect(CubicOutEase(from.position, to.position, normalizedTime), CubicOutEase(from.size, to.size, normalizedTime));
        }

        public static Color CubicOutEase(Color from, Color to, float normalizedTime)
        {
            return CubicOutEase((Vector4)from, (Vector4)to, normalizedTime);
        }

        public static Color32 CubicOutEase(Color32 from, Color32 to, float normalizedTime)
        {
            return CubicOutEase((Color)from, (Color)to, normalizedTime);
        }
        #endregion

        #region InOut
        public static int CubicInOutEase(int from, int to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (int)((to - from) / 2 * t * t * t + from);
            t -= 2;
            return (int)((to - from) / 2 * (t * t * t + 2) + from);
        }

        public static long CubicInOutEase(long from, long to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (long)((to - from) / 2 * t * t * t + from);
            t -= 2;
            return (long)((to - from) / 2 * (t * t * t + 2) + from);
        }

        public static float CubicInOutEase(float from, float to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (to - from) / 2 * t * t * t + from;
            t -= 2;
            return (to - from) / 2 * (t * t * t + 2) + from;
        }

        public static double CubicInOutEase(double from, double to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (to - from) / 2 * t * t * t + from;
            t -= 2;
            return (to - from) / 2 * (t * t * t + 2) + from;
        }

        public static DateTime CubicInOutEase(DateTime from, DateTime to, float normalizedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(CubicInOutEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedTime)));
        }

        public static Vector2 CubicInOutEase(Vector2 from, Vector2 to, float normalizedTime)
        {
            return new Vector2(CubicInOutEase(from.x, to.x, normalizedTime), CubicInOutEase(from.y, to.y, normalizedTime));
        }

        public static Vector3 CubicInOutEase(Vector3 from, Vector3 to, float normalizedTime)
        {
            return new Vector3(CubicInOutEase(from.x, to.x, normalizedTime), CubicInOutEase(from.y, to.y, normalizedTime), CubicInOutEase(from.z, to.z, normalizedTime));
        }

        public static Vector4 CubicInOutEase(Vector4 from, Vector4 to, float normalizedTime)
        {
            return new Vector4(CubicInOutEase(from.x, to.x, normalizedTime), CubicInOutEase(from.y, to.y, normalizedTime), CubicInOutEase(from.z, to.z, normalizedTime), CubicInOutEase(from.w, to.w, normalizedTime));
        }

        public static Quaternion CubicInOutEase(Quaternion from, Quaternion to, float normalizedTime)
        {
            return Quaternion.Lerp(from, to, CubicInOutEase(0f, 1f, normalizedTime));
        }

        public static Rect CubicInOutEase(Rect from, Rect to, float normalizedTime)
        {
            return new Rect(CubicInOutEase(from.position, to.position, normalizedTime), CubicInOutEase(from.size, to.size, normalizedTime));
        }

        public static Color CubicInOutEase(Color from, Color to, float normalizedTime)
        {
            return CubicInOutEase((Vector4)from, (Vector4)to, normalizedTime);
        }

        public static Color32 CubicInOutEase(Color32 from, Color32 to, float normalizedTime)
        {
            return CubicInOutEase((Color)from, (Color)to, normalizedTime);
        }
        #endregion
        #endregion

        #region Quartic
        #region In
        public static int QuarticInEase(int from, int to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (int)((to - from) * t * t * t * t + from);
        }

        public static long QuarticInEase(long from, long to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (long)((to - from) * t * t * t * t + from);
        }

        public static float QuarticInEase(float from, float to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * t * t * t * t + from;
        }

        public static double QuarticInEase(double from, double to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * t * t * t * t + from;
        }

        public static DateTime QuarticInEase(DateTime from, DateTime to, float normalizedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(QuarticInEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedTime)));
        }

        public static Vector2 QuarticInEase(Vector2 from, Vector2 to, float normalizedTime)
        {
            return new Vector2(QuarticInEase(from.x, to.x, normalizedTime), QuarticInEase(from.y, to.y, normalizedTime));
        }

        public static Vector3 QuarticInEase(Vector3 from, Vector3 to, float normalizedTime)
        {
            return new Vector3(QuarticInEase(from.x, to.x, normalizedTime), QuarticInEase(from.y, to.y, normalizedTime), QuarticInEase(from.z, to.z, normalizedTime));
        }

        public static Vector4 QuarticInEase(Vector4 from, Vector4 to, float normalizedTime)
        {
            return new Vector4(QuarticInEase(from.x, to.x, normalizedTime), QuarticInEase(from.y, to.y, normalizedTime), QuarticInEase(from.z, to.z, normalizedTime), QuarticInEase(from.w, to.w, normalizedTime));
        }

        public static Quaternion QuarticInEase(Quaternion from, Quaternion to, float normalizedTime)
        {
            return Quaternion.Lerp(from, to, QuarticInEase(0f, 1f, normalizedTime));
        }

        public static Rect QuarticInEase(Rect from, Rect to, float normalizedTime)
        {
            return new Rect(QuarticInEase(from.position, to.position, normalizedTime), QuarticInEase(from.size, to.size, normalizedTime));
        }

        public static Color QuarticInEase(Color from, Color to, float normalizedTime)
        {
            return QuarticInEase((Vector4)from, (Vector4)to, normalizedTime);
        }

        public static Color32 QuarticInEase(Color32 from, Color32 to, float normalizedTime)
        {
            return QuarticInEase((Color)from, (Color)to, normalizedTime);
        }
        #endregion

        #region Out
        public static int QuarticOutEase(int from, int to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (int)(-(to - from) * (t * t * t * t - 1) + from);
        }

        public static long QuarticOutEase(long from, long to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (long)(-(to - from) * (t * t * t * t - 1) + from);
        }

        public static float QuarticOutEase(float from, float to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return -(to - from) * (t * t * t * t - 1) + from;
        }

        public static double QuarticOutEase(double from, double to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return -(to - from) * (t * t * t * t - 1) + from;
        }

        public static DateTime QuarticOutEase(DateTime from, DateTime to, float normalizedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(QuarticOutEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedTime)));
        }

        public static Vector2 QuarticOutEase(Vector2 from, Vector2 to, float normalizedTime)
        {
            return new Vector2(QuarticOutEase(from.x, to.x, normalizedTime), QuarticOutEase(from.y, to.y, normalizedTime));
        }

        public static Vector3 QuarticOutEase(Vector3 from, Vector3 to, float normalizedTime)
        {
            return new Vector3(QuarticOutEase(from.x, to.x, normalizedTime), QuarticOutEase(from.y, to.y, normalizedTime), QuarticOutEase(from.z, to.z, normalizedTime));
        }

        public static Vector4 QuarticOutEase(Vector4 from, Vector4 to, float normalizedTime)
        {
            return new Vector4(QuarticOutEase(from.x, to.x, normalizedTime), QuarticOutEase(from.y, to.y, normalizedTime), QuarticOutEase(from.z, to.z, normalizedTime), QuarticOutEase(from.w, to.w, normalizedTime));
        }

        public static Quaternion QuarticOutEase(Quaternion from, Quaternion to, float normalizedTime)
        {
            return Quaternion.Lerp(from, to, QuarticOutEase(0f, 1f, normalizedTime));
        }

        public static Rect QuarticOutEase(Rect from, Rect to, float normalizedTime)
        {
            return new Rect(QuarticOutEase(from.position, to.position, normalizedTime), QuarticOutEase(from.size, to.size, normalizedTime));
        }

        public static Color QuarticOutEase(Color from, Color to, float normalizedTime)
        {
            return QuarticOutEase((Vector4)from, (Vector4)to, normalizedTime);
        }

        public static Color32 QuarticOutEase(Color32 from, Color32 to, float normalizedTime)
        {
            return QuarticOutEase((Color)from, (Color)to, normalizedTime);
        }
        #endregion

        #region InOut

        public static int QuarticInOutEase(int from, int to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (int)((to - from) / 2 * t * t * t * t + from);
            t -= 2;
            return (int)(-(to - from) / 2 * (t * t * t * t - 2) + from);
        }

        public static long QuarticInOutEase(long from, long to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (long)((to - from) / 2 * t * t * t * t + from);
            t -= 2;
            return (long)(-(to - from) / 2 * (t * t * t * t - 2) + from);
        }

        public static float QuarticInOutEase(float from, float to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (to - from) / 2 * t * t * t * t + from;
            t -= 2;
            return -(to - from) / 2 * (t * t * t * t - 2) + from;
        }

        public static double QuarticInOutEase(double from, double to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (to - from) / 2 * t * t * t * t + from;
            t -= 2;
            return -(to - from) / 2 * (t * t * t * t - 2) + from;
        }

        public static DateTime QuarticInOutEase(DateTime from, DateTime to, float normalizedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(QuarticInOutEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedTime)));
        }

        public static Vector2 QuarticInOutEase(Vector2 from, Vector2 to, float normalizedTime)
        {
            return new Vector2(QuarticInOutEase(from.x, to.x, normalizedTime), QuarticInOutEase(from.y, to.y, normalizedTime));
        }

        public static Vector3 QuarticInOutEase(Vector3 from, Vector3 to, float normalizedTime)
        {
            return new Vector3(QuarticInOutEase(from.x, to.x, normalizedTime), QuarticInOutEase(from.y, to.y, normalizedTime), QuarticInOutEase(from.z, to.z, normalizedTime));
        }

        public static Vector4 QuarticInOutEase(Vector4 from, Vector4 to, float normalizedTime)
        {
            return new Vector4(QuarticInOutEase(from.x, to.x, normalizedTime), QuarticInOutEase(from.y, to.y, normalizedTime), QuarticInOutEase(from.z, to.z, normalizedTime), QuarticInOutEase(from.w, to.w, normalizedTime));
        }

        public static Quaternion QuarticInOutEase(Quaternion from, Quaternion to, float normalizedTime)
        {
            return Quaternion.Lerp(from, to, QuarticInOutEase(0f, 1f, normalizedTime));
        }

        public static Rect QuarticInOutEase(Rect from, Rect to, float normalizedTime)
        {
            return new Rect(QuarticInOutEase(from.position, to.position, normalizedTime), QuarticInOutEase(from.size, to.size, normalizedTime));
        }

        public static Color QuarticInOutEase(Color from, Color to, float normalizedTime)
        {
            return QuarticInOutEase((Vector4)from, (Vector4)to, normalizedTime);
        }

        public static Color32 QuarticInOutEase(Color32 from, Color32 to, float normalizedTime)
        {
            return QuarticInOutEase((Color)from, (Color)to, normalizedTime);
        }
        #endregion
        #endregion

        #region Quintic
        #region In
        public static int QuinticInEase(int from, int to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (int)((to - from) * t * t * t * t * t + from);
        }

        public static long QuinticInEase(long from, long to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (long)((to - from) * t * t * t * t * t + from);
        }

        public static float QuinticInEase(float from, float to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * t * t * t * t * t + from;
        }

        public static double QuinticInEase(double from, double to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * t * t * t * t * t + from;
        }

        public static DateTime QuinticInEase(DateTime from, DateTime to, float normalizedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(QuinticInEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedTime)));
        }

        public static Vector2 QuinticInEase(Vector2 from, Vector2 to, float normalizedTime)
        {
            return new Vector2(QuinticInEase(from.x, to.x, normalizedTime), QuinticInEase(from.y, to.y, normalizedTime));
        }

        public static Vector3 QuinticInEase(Vector3 from, Vector3 to, float normalizedTime)
        {
            return new Vector3(QuinticInEase(from.x, to.x, normalizedTime), QuinticInEase(from.y, to.y, normalizedTime), QuinticInEase(from.z, to.z, normalizedTime));
        }

        public static Vector4 QuinticInEase(Vector4 from, Vector4 to, float normalizedTime)
        {
            return new Vector4(QuinticInEase(from.x, to.x, normalizedTime), QuinticInEase(from.y, to.y, normalizedTime), QuinticInEase(from.z, to.z, normalizedTime), QuinticInEase(from.w, to.w, normalizedTime));
        }

        public static Quaternion QuinticInEase(Quaternion from, Quaternion to, float normalizedTime)
        {
            return Quaternion.Lerp(from, to, QuinticInEase(0f, 1f, normalizedTime));
        }

        public static Rect QuinticInEase(Rect from, Rect to, float normalizedTime)
        {
            return new Rect(QuinticInEase(from.position, to.position, normalizedTime), QuinticInEase(from.size, to.size, normalizedTime));
        }

        public static Color QuinticInEase(Color from, Color to, float normalizedTime)
        {
            return QuinticInEase((Vector4)from, (Vector4)to, normalizedTime);
        }

        public static Color32 QuinticInEase(Color32 from, Color32 to, float normalizedTime)
        {
            return QuinticInEase((Color)from, (Color)to, normalizedTime);
        }
        #endregion

        #region Out
        public static int QuinticOutEase(int from, int to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (int)((to - from) * (t * t * t * t * t + 1) + from);
        }

        public static long QuinticOutEase(long from, long to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (long)((to - from) * (t * t * t * t * t + 1) + from);
        }

        public static float QuinticOutEase(float from, float to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (to - from) * (t * t * t * t * t + 1) + from;
        }

        public static double QuinticOutEase(double from, double to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (to - from) * (t * t * t * t * t + 1) + from;
        }

        public static DateTime QuinticOutEase(DateTime from, DateTime to, float normalizedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(QuinticOutEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedTime)));
        }

        public static Vector2 QuinticOutEase(Vector2 from, Vector2 to, float normalizedTime)
        {
            return new Vector2(QuinticOutEase(from.x, to.x, normalizedTime), QuinticOutEase(from.y, to.y, normalizedTime));
        }

        public static Vector3 QuinticOutEase(Vector3 from, Vector3 to, float normalizedTime)
        {
            return new Vector3(QuinticOutEase(from.x, to.x, normalizedTime), QuinticOutEase(from.y, to.y, normalizedTime), QuinticOutEase(from.z, to.z, normalizedTime));
        }

        public static Vector4 QuinticOutEase(Vector4 from, Vector4 to, float normalizedTime)
        {
            return new Vector4(QuinticOutEase(from.x, to.x, normalizedTime), QuinticOutEase(from.y, to.y, normalizedTime), QuinticOutEase(from.z, to.z, normalizedTime), QuinticOutEase(from.w, to.w, normalizedTime));
        }

        public static Quaternion QuinticOutEase(Quaternion from, Quaternion to, float normalizedTime)
        {
            return Quaternion.Lerp(from, to, QuinticOutEase(0f, 1f, normalizedTime));
        }

        public static Rect QuinticOutEase(Rect from, Rect to, float normalizedTime)
        {
            return new Rect(QuinticOutEase(from.position, to.position, normalizedTime), QuinticOutEase(from.size, to.size, normalizedTime));
        }

        public static Color QuinticOutEase(Color from, Color to, float normalizedTime)
        {
            return QuinticOutEase((Vector4)from, (Vector4)to, normalizedTime);
        }

        public static Color32 QuinticOutEase(Color32 from, Color32 to, float normalizedTime)
        {
            return QuinticOutEase((Color)from, (Color)to, normalizedTime);
        }
        #endregion

        #region InOut
        public static int QuinticInOutEase(int from, int to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (int)((to - from) / 2 * t * t * t * t * t + from);
            t -= 2;
            return (int)((to - from) / 2 * (t * t * t * t * t + 2) + from);
        }

        public static long QuinticInOutEase(long from, long to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (long)((to - from) / 2 * t * t * t * t * t + from);
            t -= 2;
            return (long)((to - from) / 2 * (t * t * t * t * t + 2) + from);
        }

        public static float QuinticInOutEase(float from, float to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (to - from) / 2 * t * t * t * t * t + from;
            t -= 2;
            return (to - from) / 2 * (t * t * t * t * t + 2) + from;
        }

        public static double QuinticInOutEase(double from, double to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (to - from) / 2 * t * t * t * t * t + from;
            t -= 2;
            return (to - from) / 2 * (t * t * t * t * t + 2) + from;
        }

        public static DateTime QuinticInOutEase(DateTime from, DateTime to, float normalizedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(QuinticInOutEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedTime)));
        }

        public static Vector2 QuinticInOutEase(Vector2 from, Vector2 to, float normalizedTime)
        {
            return new Vector2(QuinticInOutEase(from.x, to.x, normalizedTime), QuinticInOutEase(from.y, to.y, normalizedTime));
        }

        public static Vector3 QuinticInOutEase(Vector3 from, Vector3 to, float normalizedTime)
        {
            return new Vector3(QuinticInOutEase(from.x, to.x, normalizedTime), QuinticInOutEase(from.y, to.y, normalizedTime), QuinticInOutEase(from.z, to.z, normalizedTime));
        }

        public static Vector4 QuinticInOutEase(Vector4 from, Vector4 to, float normalizedTime)
        {
            return new Vector4(QuinticInOutEase(from.x, to.x, normalizedTime), QuinticInOutEase(from.y, to.y, normalizedTime), QuinticInOutEase(from.z, to.z, normalizedTime), QuinticInOutEase(from.w, to.w, normalizedTime));
        }

        public static Quaternion QuinticInOutEase(Quaternion from, Quaternion to, float normalizedTime)
        {
            return Quaternion.Lerp(from, to, QuinticInOutEase(0f, 1f, normalizedTime));
        }

        public static Rect QuinticInOutEase(Rect from, Rect to, float normalizedTime)
        {
            return new Rect(QuinticInOutEase(from.position, to.position, normalizedTime), QuinticInOutEase(from.size, to.size, normalizedTime));
        }

        public static Color QuinticInOutEase(Color from, Color to, float normalizedTime)
        {
            return QuinticInOutEase((Vector4)from, (Vector4)to, normalizedTime);
        }

        public static Color32 QuinticInOutEase(Color32 from, Color32 to, float normalizedTime)
        {
            return QuinticInOutEase((Color)from, (Color)to, normalizedTime);
        }
        #endregion
        #endregion

        #region Sinusoidal
        #region In
        public static int SinusoidalInEase(int from, int to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            float c = to - from;

            return (int)(-c * Mathf.Cos(t * (Mathf.PI / 2)) + c + from);
        }

        public static long SinusoidalInEase(long from, long to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            float c = to - from;

            return (long)(-c * Mathf.Cos(t * (Mathf.PI / 2)) + c + from);
        }

        public static float SinusoidalInEase(float from, float to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            float c = to - from;

            return -c * Mathf.Cos(t * (Mathf.PI / 2)) + c + from;
        }

        public static double SinusoidalInEase(double from, double to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            double c = to - from;

            return -c * Mathf.Cos(t * (Mathf.PI / 2)) + c + from;
        }

        public static DateTime SinusoidalInEase(DateTime from, DateTime to, float normalizedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(SinusoidalInEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedTime)));
        }

        public static Vector2 SinusoidalInEase(Vector2 from, Vector2 to, float normalizedTime)
        {
            return new Vector2(SinusoidalInEase(from.x, to.x, normalizedTime), SinusoidalInEase(from.y, to.y, normalizedTime));
        }

        public static Vector3 SinusoidalInEase(Vector3 from, Vector3 to, float normalizedTime)
        {
            return new Vector3(SinusoidalInEase(from.x, to.x, normalizedTime), SinusoidalInEase(from.y, to.y, normalizedTime), SinusoidalInEase(from.z, to.z, normalizedTime));
        }

        public static Vector4 SinusoidalInEase(Vector4 from, Vector4 to, float normalizedTime)
        {
            return new Vector4(SinusoidalInEase(from.x, to.x, normalizedTime), SinusoidalInEase(from.y, to.y, normalizedTime), SinusoidalInEase(from.z, to.z, normalizedTime), SinusoidalInEase(from.w, to.w, normalizedTime));
        }

        public static Quaternion SinusoidalInEase(Quaternion from, Quaternion to, float normalizedTime)
        {
            return Quaternion.Lerp(from, to, SinusoidalInEase(0f, 1f, normalizedTime));
        }

        public static Rect SinusoidalInEase(Rect from, Rect to, float normalizedTime)
        {
            return new Rect(SinusoidalInEase(from.position, to.position, normalizedTime), SinusoidalInEase(from.size, to.size, normalizedTime));
        }

        public static Color SinusoidalInEase(Color from, Color to, float normalizedTime)
        {
            return SinusoidalInEase((Vector4)from, (Vector4)to, normalizedTime);
        }

        public static Color32 SinusoidalInEase(Color32 from, Color32 to, float normalizedTime)
        {
            return SinusoidalInEase((Color)from, (Color)to, normalizedTime);
        }
        #endregion

        #region Out
        public static int SinusoidalOutEase(int from, int to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (int)((to - from) * Mathf.Sin(t * (Mathf.PI / 2)) + from);
        }

        public static long SinusoidalOutEase(long from, long to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (long)((to - from) * Mathf.Sin(t * (Mathf.PI / 2)) + from);
        }

        public static float SinusoidalOutEase(float from, float to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * Mathf.Sin(t * (Mathf.PI / 2)) + from;
        }

        public static double SinusoidalOutEase(double from, double to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * Mathf.Sin(t * (Mathf.PI / 2)) + from;
        }

        public static DateTime SinusoidalOutEase(DateTime from, DateTime to, float normalizedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(SinusoidalOutEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedTime)));
        }

        public static Vector2 SinusoidalOutEase(Vector2 from, Vector2 to, float normalizedTime)
        {
            return new Vector2(SinusoidalOutEase(from.x, to.x, normalizedTime), SinusoidalOutEase(from.y, to.y, normalizedTime));
        }

        public static Vector3 SinusoidalOutEase(Vector3 from, Vector3 to, float normalizedTime)
        {
            return new Vector3(SinusoidalOutEase(from.x, to.x, normalizedTime), SinusoidalOutEase(from.y, to.y, normalizedTime), SinusoidalOutEase(from.z, to.z, normalizedTime));
        }

        public static Vector4 SinusoidalOutEase(Vector4 from, Vector4 to, float normalizedTime)
        {
            return new Vector4(SinusoidalOutEase(from.x, to.x, normalizedTime), SinusoidalOutEase(from.y, to.y, normalizedTime), SinusoidalOutEase(from.z, to.z, normalizedTime), SinusoidalOutEase(from.w, to.w, normalizedTime));
        }

        public static Quaternion SinusoidalOutEase(Quaternion from, Quaternion to, float normalizedTime)
        {
            return Quaternion.Lerp(from, to, SinusoidalOutEase(0f, 1f, normalizedTime));
        }

        public static Rect SinusoidalOutEase(Rect from, Rect to, float normalizedTime)
        {
            return new Rect(SinusoidalOutEase(from.position, to.position, normalizedTime), SinusoidalOutEase(from.size, to.size, normalizedTime));
        }

        public static Color SinusoidalOutEase(Color from, Color to, float normalizedTime)
        {
            return SinusoidalOutEase((Vector4)from, (Vector4)to, normalizedTime);
        }

        public static Color32 SinusoidalOutEase(Color32 from, Color32 to, float normalizedTime)
        {
            return SinusoidalOutEase((Color)from, (Color)to, normalizedTime);
        }
        #endregion

        #region InOut
        public static int SinusoidalInOutEase(int from, int to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (int)(-(to - from) / 2 * (Mathf.Cos(Mathf.PI * t) - 1) + from);
        }

        public static long SinusoidalInOutEase(long from, long to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (long)(-(to - from) / 2 * (Mathf.Cos(Mathf.PI * t) - 1) + from);
        }

        public static float SinusoidalInOutEase(float from, float to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return -(to - from) / 2 * (Mathf.Cos(Mathf.PI * t) - 1) + from;
        }

        public static double SinusoidalInOutEase(double from, double to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return -(to - from) / 2 * (Mathf.Cos(Mathf.PI * t) - 1) + from;
        }

        public static DateTime SinusoidalInOutEase(DateTime from, DateTime to, float normalizedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(SinusoidalInOutEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedTime)));
        }

        public static Vector2 SinusoidalInOutEase(Vector2 from, Vector2 to, float normalizedTime)
        {
            return new Vector2(SinusoidalInOutEase(from.x, to.x, normalizedTime), SinusoidalInOutEase(from.y, to.y, normalizedTime));
        }

        public static Vector3 SinusoidalInOutEase(Vector3 from, Vector3 to, float normalizedTime)
        {
            return new Vector3(SinusoidalInOutEase(from.x, to.x, normalizedTime), SinusoidalInOutEase(from.y, to.y, normalizedTime), SinusoidalInOutEase(from.z, to.z, normalizedTime));
        }

        public static Vector4 SinusoidalInOutEase(Vector4 from, Vector4 to, float normalizedTime)
        {
            return new Vector4(SinusoidalInOutEase(from.x, to.x, normalizedTime), SinusoidalInOutEase(from.y, to.y, normalizedTime), SinusoidalInOutEase(from.z, to.z, normalizedTime), SinusoidalInOutEase(from.w, to.w, normalizedTime));
        }

        public static Quaternion SinusoidalInOutEase(Quaternion from, Quaternion to, float normalizedTime)
        {
            return Quaternion.Lerp(from, to, SinusoidalInOutEase(0f, 1f, normalizedTime));
        }

        public static Rect SinusoidalInOutEase(Rect from, Rect to, float normalizedTime)
        {
            return new Rect(SinusoidalInOutEase(from.position, to.position, normalizedTime), SinusoidalOutEase(from.size, to.size, normalizedTime));
        }

        public static Color SinusoidalInOutEase(Color from, Color to, float normalizedTime)
        {
            return SinusoidalInOutEase((Vector4)from, (Vector4)to, normalizedTime);
        }

        public static Color32 SinusoidalInOutEase(Color32 from, Color32 to, float normalizedTime)
        {
            return SinusoidalInOutEase((Color)from, (Color)to, normalizedTime);
        }
        #endregion
        #endregion

        #region Exponential
        #region In
        public static int ExponentialInEase(int from, int to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (int)((to - from) * Mathf.Pow(2, 10 * (t - 1)) + from);
        }

        public static long ExponentialInEase(long from, long to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (long)((to - from) * Mathf.Pow(2, 10 * (t - 1)) + from);
        }

        public static float ExponentialInEase(float from, float to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * Mathf.Pow(2, 10 * (t - 1)) + from;
        }

        public static double ExponentialInEase(double from, double to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * Mathf.Pow(2, 10 * (t - 1)) + from;
        }

        public static DateTime ExponentialInEase(DateTime from, DateTime to, float normalizedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(ExponentialInEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedTime)));
        }

        public static Vector2 ExponentialInEase(Vector2 from, Vector2 to, float normalizedTime)
        {
            return new Vector2(ExponentialInEase(from.x, to.x, normalizedTime), ExponentialInEase(from.y, to.y, normalizedTime));
        }

        public static Vector3 ExponentialInEase(Vector3 from, Vector3 to, float normalizedTime)
        {
            return new Vector3(ExponentialInEase(from.x, to.x, normalizedTime), ExponentialInEase(from.y, to.y, normalizedTime), ExponentialInEase(from.z, to.z, normalizedTime));
        }

        public static Vector4 ExponentialInEase(Vector4 from, Vector4 to, float normalizedTime)
        {
            return new Vector4(ExponentialInEase(from.x, to.x, normalizedTime), ExponentialInEase(from.y, to.y, normalizedTime), ExponentialInEase(from.z, to.z, normalizedTime), ExponentialInEase(from.w, to.w, normalizedTime));
        }

        public static Quaternion ExponentialInEase(Quaternion from, Quaternion to, float normalizedTime)
        {
            return Quaternion.Lerp(from, to, ExponentialInEase(0f, 1f, normalizedTime));
        }

        public static Rect ExponentialInEase(Rect from, Rect to, float normalizedTime)
        {
            return new Rect(ExponentialInEase(from.position, to.position, normalizedTime), ExponentialInEase(from.size, to.size, normalizedTime));
        }

        public static Color ExponentialInEase(Color from, Color to, float normalizedTime)
        {
            return ExponentialInEase((Vector4)from, (Vector4)to, normalizedTime);
        }

        public static Color32 ExponentialInEase(Color32 from, Color32 to, float normalizedTime)
        {
            return ExponentialInEase((Color)from, (Color)to, normalizedTime);
        }
        #endregion

        #region Out
        public static int ExponentialOutEase(int from, int to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (int)((to - from) * (-Mathf.Pow(2, -10 * t) + 1) + from);
        }

        public static long ExponentialOutEase(long from, long to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (long)((to - from) * (-Mathf.Pow(2, -10 * t) + 1) + from);
        }

        public static float ExponentialOutEase(float from, float to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * (-Mathf.Pow(2, -10 * t) + 1) + from;
        }

        public static double ExponentialOutEase(double from, double to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (to - from) * (-Mathf.Pow(2, -10 * t) + 1) + from;
        }

        public static DateTime ExponentialOutEase(DateTime from, DateTime to, float normalizedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(ExponentialOutEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedTime)));
        }

        public static Vector2 ExponentialOutEase(Vector2 from, Vector2 to, float normalizedTime)
        {
            return new Vector2(ExponentialOutEase(from.x, to.x, normalizedTime), ExponentialOutEase(from.y, to.y, normalizedTime));
        }

        public static Vector3 ExponentialOutEase(Vector3 from, Vector3 to, float normalizedTime)
        {
            return new Vector3(ExponentialOutEase(from.x, to.x, normalizedTime), ExponentialOutEase(from.y, to.y, normalizedTime), ExponentialOutEase(from.z, to.z, normalizedTime));
        }

        public static Vector4 ExponentialOutEase(Vector4 from, Vector4 to, float normalizedTime)
        {
            return new Vector4(ExponentialOutEase(from.x, to.x, normalizedTime), ExponentialOutEase(from.y, to.y, normalizedTime), ExponentialOutEase(from.z, to.z, normalizedTime), ExponentialOutEase(from.w, to.w, normalizedTime));
        }

        public static Quaternion ExponentialOutEase(Quaternion from, Quaternion to, float normalizedTime)
        {
            return Quaternion.Lerp(from, to, ExponentialOutEase(0f, 1f, normalizedTime));
        }

        public static Rect ExponentialOutEase(Rect from, Rect to, float normalizedTime)
        {
            return new Rect(ExponentialOutEase(from.position, to.position, normalizedTime), ExponentialOutEase(from.size, to.size, normalizedTime));
        }

        public static Color ExponentialOutEase(Color from, Color to, float normalizedTime)
        {
            return ExponentialOutEase((Vector4)from, (Vector4)to, normalizedTime);
        }

        public static Color32 ExponentialOutEase(Color32 from, Color32 to, float normalizedTime)
        {
            return ExponentialOutEase((Color)from, (Color)to, normalizedTime);
        }
        #endregion

        #region InOut
        public static int ExponentialInOutEase(int from, int to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (int)((to - from) / 2 * Mathf.Pow(2, 10 * (t - 1)) + from);
            --t;
            return (int)((to - from) / 2 * (-Mathf.Pow(2, -10 * t) + 2) + from);
        }

        public static long ExponentialInOutEase(long from, long to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (long)((to - from) / 2 * Mathf.Pow(2, 10 * (t - 1)) + from);
            --t;
            return (long)((to - from) / 2 * (-Mathf.Pow(2, -10 * t) + 2) + from);
        }

        public static float ExponentialInOutEase(float from, float to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (to - from) / 2 * Mathf.Pow(2, 10 * (t - 1)) + from;
            --t;
            return (to - from) / 2 * (-Mathf.Pow(2, -10 * t) + 2) + from;
        }

        public static double ExponentialInOutEase(double from, double to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (to - from) / 2 * Mathf.Pow(2, 10 * (t - 1)) + from;
            --t;
            return (to - from) / 2 * (-Mathf.Pow(2, -10 * t) + 2) + from;
        }

        public static DateTime ExponentialInOutEase(DateTime from, DateTime to, float normalizedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(ExponentialInOutEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedTime)));
        }

        public static Vector2 ExponentialInOutEase(Vector2 from, Vector2 to, float normalizedTime)
        {
            return new Vector2(ExponentialInOutEase(from.x, to.x, normalizedTime), ExponentialInOutEase(from.y, to.y, normalizedTime));
        }

        public static Vector3 ExponentialInOutEase(Vector3 from, Vector3 to, float normalizedTime)
        {
            return new Vector3(ExponentialInOutEase(from.x, to.x, normalizedTime), ExponentialInOutEase(from.y, to.y, normalizedTime), ExponentialInOutEase(from.z, to.z, normalizedTime));
        }

        public static Vector4 ExponentialInOutEase(Vector4 from, Vector4 to, float normalizedTime)
        {
            return new Vector4(ExponentialInOutEase(from.x, to.x, normalizedTime), ExponentialInOutEase(from.y, to.y, normalizedTime), ExponentialInOutEase(from.z, to.z, normalizedTime), ExponentialInOutEase(from.w, to.w, normalizedTime));
        }

        public static Quaternion ExponentialInOutEase(Quaternion from, Quaternion to, float normalizedTime)
        {
            return Quaternion.Lerp(from, to, ExponentialInOutEase(0f, 1f, normalizedTime));
        }

        public static Rect ExponentialInOutEase(Rect from, Rect to, float normalizedTime)
        {
            return new Rect(ExponentialInOutEase(from.position, to.position, normalizedTime), ExponentialInOutEase(from.size, to.size, normalizedTime));
        }

        public static Color ExponentialInOutEase(Color from, Color to, float normalizedTime)
        {
            return ExponentialInOutEase((Vector4)from, (Vector4)to, normalizedTime);
        }

        public static Color32 ExponentialInOutEase(Color32 from, Color32 to, float normalizedTime)
        {
            return ExponentialInOutEase((Color)from, (Color)to, normalizedTime);
        }
        #endregion
        #endregion

        #region Circular
        #region In
        public static int CircularInEase(int from, int to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (int)(-(to - from) * (Mathf.Sqrt(1 - t * t) - 1) + from);
        }

        public static long CircularInEase(long from, long to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return (long)(-(to - from) * (Mathf.Sqrt(1 - t * t) - 1) + from);
        }

        public static float CircularInEase(float from, float to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return -(to - from) * (Mathf.Sqrt(1 - t * t) - 1) + from;
        }

        public static double CircularInEase(double from, double to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            return -(to - from) * (Mathf.Sqrt(1 - t * t) - 1) + from;
        }

        public static DateTime CircularInEase(DateTime from, DateTime to, float normalizedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(CircularInEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedTime)));
        }

        public static Vector2 CircularInEase(Vector2 from, Vector2 to, float normalizedTime)
        {
            return new Vector2(CircularInEase(from.x, to.x, normalizedTime), CircularInEase(from.y, to.y, normalizedTime));
        }

        public static Vector3 CircularInEase(Vector3 from, Vector3 to, float normalizedTime)
        {
            return new Vector3(CircularInEase(from.x, to.x, normalizedTime), CircularInEase(from.y, to.y, normalizedTime), CircularInEase(from.z, to.z, normalizedTime));
        }

        public static Vector4 CircularInEase(Vector4 from, Vector4 to, float normalizedTime)
        {
            return new Vector4(CircularInEase(from.x, to.x, normalizedTime), CircularInEase(from.y, to.y, normalizedTime), CircularInEase(from.z, to.z, normalizedTime), CircularInEase(from.w, to.w, normalizedTime));
        }

        public static Quaternion CircularInEase(Quaternion from, Quaternion to, float normalizedTime)
        {
            return Quaternion.Lerp(from, to, CircularInEase(0f, 1f, normalizedTime));
        }

        public static Rect CircularInEase(Rect from, Rect to, float normalizedTime)
        {
            return new Rect(CircularInEase(from.position, to.position, normalizedTime), CircularInEase(from.size, to.size, normalizedTime));
        }

        public static Color CircularInEase(Color from, Color to, float normalizedTime)
        {
            return CircularInEase((Vector4)from, (Vector4)to, normalizedTime);
        }

        public static Color32 CircularInEase(Color32 from, Color32 to, float normalizedTime)
        {
            return CircularInEase((Color)from, (Color)to, normalizedTime);
        }
        #endregion

        #region Out
        public static int CircularOutEase(int from, int to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (int)((to - from) * Mathf.Sqrt(1 - t * t) + from);
        }

        public static long CircularOutEase(long from, long to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (long)((to - from) * Mathf.Sqrt(1 - t * t) + from);
        }

        public static float CircularOutEase(float from, float to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (to - from) * Mathf.Sqrt(1 - t * t) + from;
        }

        public static double CircularOutEase(double from, double to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            --t;
            return (to - from) * Mathf.Sqrt(1 - t * t) + from;
        }

        public static DateTime CircularOutEase(DateTime from, DateTime to, float normalizedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(CircularOutEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedTime)));
        }

        public static Vector2 CircularOutEase(Vector2 from, Vector2 to, float normalizedTime)
        {
            return new Vector2(CircularOutEase(from.x, to.x, normalizedTime), CircularOutEase(from.y, to.y, normalizedTime));
        }

        public static Vector3 CircularOutEase(Vector3 from, Vector3 to, float normalizedTime)
        {
            return new Vector3(CircularOutEase(from.x, to.x, normalizedTime), CircularOutEase(from.y, to.y, normalizedTime), CircularOutEase(from.z, to.z, normalizedTime));
        }

        public static Vector4 CircularOutEase(Vector4 from, Vector4 to, float normalizedTime)
        {
            return new Vector4(CircularOutEase(from.x, to.x, normalizedTime), CircularOutEase(from.y, to.y, normalizedTime), CircularOutEase(from.z, to.z, normalizedTime), CircularOutEase(from.w, to.w, normalizedTime));
        }

        public static Quaternion CircularOutEase(Quaternion from, Quaternion to, float normalizedTime)
        {
            return Quaternion.Lerp(from, to, CircularOutEase(0f, 1f, normalizedTime));
        }

        public static Rect CircularOutEase(Rect from, Rect to, float normalizedTime)
        {
            return new Rect(CircularOutEase(from.position, to.position, normalizedTime), CircularOutEase(from.size, to.size, normalizedTime));
        }

        public static Color CircularOutEase(Color from, Color to, float normalizedTime)
        {
            return CircularOutEase((Vector4)from, (Vector4)to, normalizedTime);
        }

        public static Color32 CircularOutEase(Color32 from, Color32 to, float normalizedTime)
        {
            return CircularOutEase((Color)from, (Color)to, normalizedTime);
        }
        #endregion

        #region InOut
        public static int CircularInOutEase(int from, int to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (int)(-(to - from) / 2 * (Mathf.Sqrt(1 - t * t) - 1) + from);
            t -= 2;
            return (int)((to - from) / 2 * (Mathf.Sqrt(1 - t * t) + 1) + from);
        }

        public static long CircularInOutEase(long from, long to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return (long)(-(to - from) / 2 * (Mathf.Sqrt(1 - t * t) - 1) + from);
            t -= 2;
            return (long)((to - from) / 2 * (Mathf.Sqrt(1 - t * t) + 1) + from);
        }

        public static float CircularInOutEase(float from, float to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return -(to - from) / 2 * (Mathf.Sqrt(1 - t * t) - 1) + from;
            t -= 2;
            return (to - from) / 2 * (Mathf.Sqrt(1 - t * t) + 1) + from;
        }

        public static double CircularInOutEase(double from, double to, float normalizedTime)
        {
            float t = normalizedTime;

            if (t == 0f) return from;
            if (t == 1f) return to;

            t /= .5f;
            if (t < 1) return -(to - from) / 2 * (Mathf.Sqrt(1 - t * t) - 1) + from;
            t -= 2;
            return (to - from) / 2 * (Mathf.Sqrt(1 - t * t) + 1) + from;
        }

        public static DateTime CircularInOutEase(DateTime from, DateTime to, float normalizedTime)
        {
            return DateTime.MinValue.Add(TimeSpan.FromMinutes(CircularInOutEase(new TimeSpan(from.Ticks).TotalMinutes, new TimeSpan(to.Ticks).TotalMinutes, normalizedTime)));
        }

        public static Vector2 CircularInOutEase(Vector2 from, Vector2 to, float normalizedTime)
        {
            return new Vector2(CircularInOutEase(from.x, to.x, normalizedTime), CircularInOutEase(from.y, to.y, normalizedTime));
        }

        public static Vector3 CircularInOutEase(Vector3 from, Vector3 to, float normalizedTime)
        {
            return new Vector3(CircularInOutEase(from.x, to.x, normalizedTime), CircularInOutEase(from.y, to.y, normalizedTime), CircularInOutEase(from.z, to.z, normalizedTime));
        }

        public static Vector4 CircularInOutEase(Vector4 from, Vector4 to, float normalizedTime)
        {
            return new Vector4(CircularInOutEase(from.x, to.x, normalizedTime), CircularInOutEase(from.y, to.y, normalizedTime), CircularInOutEase(from.z, to.z, normalizedTime), CircularInOutEase(from.w, to.w, normalizedTime));
        }

        public static Quaternion CircularInOutEase(Quaternion from, Quaternion to, float normalizedTime)
        {
            return Quaternion.Lerp(from, to, CircularInOutEase(0f, 1f, normalizedTime));
        }

        public static Rect CircularInOutEase(Rect from, Rect to, float normalizedTime)
        {
            return new Rect(CircularInOutEase(from.position, to.position, normalizedTime), CircularInOutEase(from.size, to.size, normalizedTime));
        }

        public static Color CircularInOutEase(Color from, Color to, float normalizedTime)
        {
            return CircularInOutEase((Vector4)from, (Vector4)to, normalizedTime);
        }

        public static Color32 CircularInOutEase(Color32 from, Color32 to, float normalizedTime)
        {
            return CircularInOutEase((Color)from, (Color)to, normalizedTime);
        }
        #endregion
        #endregion
        #endregion
        #endregion
    }
}