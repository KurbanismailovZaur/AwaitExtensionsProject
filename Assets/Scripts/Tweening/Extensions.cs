using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static UnityEngine.Debug;
using System;
using Numba.Tweening.Tweaks;

namespace Numba.Tweening
{
    public static class Extensions
    {
        #region Transform
        #region Move
        #region Global
        public static Tween DoMoveX(this Transform transform, float position, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMoveAxis(() => transform.position.x, (x) => ChangeTransformPosition(transform, Space.World, 0, x), position, duration, ease, loopsCount, loopType);

        public static Tween DoMoveY(this Transform transform, float position, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMoveAxis(() => transform.position.y, (y) => ChangeTransformPosition(transform, Space.World, 1, y), position, duration, ease, loopsCount, loopType);

        public static Tween DoMoveZ(this Transform transform, float position, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMoveAxis(() => transform.position.z, (z) => ChangeTransformPosition(transform, Space.World, 2, z), position, duration, ease, loopsCount, loopType);

        public static Tween DoMove(this Transform transform, float x, float y, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMove(transform, Space.World, new Vector3(x, y, z), duration, ease, loopsCount, loopType);

        public static Tween DoMove(this Transform transform, Vector3 position, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMove(transform, Space.World, position, duration, ease, loopsCount, loopType);
        #endregion

        #region Local
        public static Tween DoLocalMoveX(this Transform transform, float position, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMoveAxis(() => transform.localPosition.x, (x) => ChangeTransformPosition(transform, Space.Self, 0, x), position, duration, ease, loopsCount, loopType);

        public static Tween DoLocalMoveY(this Transform transform, float position, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMoveAxis(() => transform.localPosition.y, (y) => ChangeTransformPosition(transform, Space.Self, 1, y), position, duration, ease, loopsCount, loopType);

        public static Tween DoLocalMoveZ(this Transform transform, float position, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMoveAxis(() => transform.localPosition.z, (z) => ChangeTransformPosition(transform, Space.Self, 2, z), position, duration, ease, loopsCount, loopType);

        public static Tween DoLocalMove(this Transform transform, float x, float y, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMove(transform, Space.Self, new Vector3(x, y, z), duration, ease, loopsCount, loopType);

        public static Tween DoLocalMove(this Transform transform, Vector3 position, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMove(transform, Space.Self, position, duration, ease, loopsCount, loopType);
        #endregion

        private static Tween DoMove(Transform transform, Space space, Vector3 position, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            if (space == Space.World) return new Tween(new TweakVector3(transform.position, position, (p) => transform.position = p), duration).SetEase(ease).SetLoops(loopsCount, loopType);
            else return new Tween(new TweakVector3(transform.localPosition, position, (p) => transform.localPosition = p), duration).SetEase(ease).SetLoops(loopsCount, loopType);
        }

        private static Tween DoMoveAxis(Func<float> axisValueGetter, Action<float> axisValueSetter, float position, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => new Tween(new TweakFloat(axisValueGetter(), position, axisValueSetter), duration).SetEase(ease).SetLoops(loopsCount, loopType);

        private static void ChangeTransformPosition(Transform transform, Space space, int axis, float value)
        {
            if (space == Space.World) transform.position = SetVectorValue(transform.position, axis, value);
            else transform.localPosition = SetVectorValue(transform.localPosition, axis, value);
        }
        #endregion

        #region Rotation
        #region Global
        public static Tween DoRotateX(this Transform transform, float angle, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotateAxis(() => transform.eulerAngles.x, angle, (x) => transform.eulerAngles = SetVectorValue(transform.eulerAngles, 0, x), duration, ease, loopsCount, loopType);

        public static Tween DoRotateY(this Transform transform, float angle, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotateAxis(() => transform.eulerAngles.y, angle, (y) => transform.eulerAngles = SetVectorValue(transform.eulerAngles, 1, y), duration, ease, loopsCount, loopType);

        public static Tween DoRotateZ(this Transform transform, float angle, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotateAxis(() => transform.eulerAngles.z, angle, (z) => transform.eulerAngles = SetVectorValue(transform.eulerAngles, 2, z), duration, ease, loopsCount, loopType);

        public static Tween DoRotate(this Transform transform, float x, float y, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotate(transform, Space.World, Quaternion.Euler(x, y, z), duration, ease, loopsCount, loopType);

        public static Tween DoRotate(this Transform transform, Vector3 euler, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotate(transform, Space.World, Quaternion.Euler(euler), duration, ease, loopsCount, loopType);

        public static Tween DoRotate(this Transform transform, Quaternion rotation, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotate(transform, Space.World, rotation, duration, ease, loopsCount, loopType);
        #endregion

        #region Local
        public static Tween DoLocalRotateX(this Transform transform, float angle, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotateAxis(() => transform.localEulerAngles.x, angle, (x) => transform.localEulerAngles = SetVectorValue(transform.localEulerAngles, 0, x), duration, ease, loopsCount, loopType);

        public static Tween DoLocalRotateY(this Transform transform, float angle, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotateAxis(() => transform.localEulerAngles.y, angle, (y) => transform.localEulerAngles = SetVectorValue(transform.localEulerAngles, 1, y), duration, ease, loopsCount, loopType);

        public static Tween DoLocalRotateZ(this Transform transform, float angle, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotateAxis(() => transform.localEulerAngles.z, angle, (z) => transform.localEulerAngles = SetVectorValue(transform.localEulerAngles, 2, z), duration, ease, loopsCount, loopType);

        public static Tween DoLocalRotate(this Transform transform, float x, float y, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotate(transform, Space.Self, Quaternion.Euler(x, y, z), duration, ease, loopsCount, loopType);

        public static Tween DoLocalRotate(this Transform transform, Vector3 euler, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotate(transform, Space.Self, Quaternion.Euler(euler), duration, ease, loopsCount, loopType);

        public static Tween DoLocalRotate(this Transform transform, Quaternion rotation, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotate(transform, Space.Self, rotation, duration, ease, loopsCount, loopType);
        #endregion

        private static Tween DoRotateAxis(Func<float> angleGetter, float angle, Action<float> angleSetter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => new Tween(new TweakFloat(angleGetter(), angle, angleSetter), duration).SetEase(ease).SetLoops(loopsCount, loopType);

        private static Tween DoRotate(Transform transform, Space space, Quaternion rotation, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            if (space == Space.World) return new Tween(new TweakQuaternion(transform.rotation, rotation, (q) => transform.rotation = q), duration).SetEase(ease).SetLoops(loopsCount, loopType);
            else return new Tween(new TweakQuaternion(transform.localRotation, rotation, (q) => transform.localRotation = q), duration).SetEase(ease).SetLoops(loopsCount, loopType);
        }
        #endregion

        #region Scale
        public static Tween DoLocalScaleX(this Transform transform, float x, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return new Tween(new TweakFloat(transform.localScale.x, x, (tweenedX) => transform.localScale = SetVectorValue(transform.localScale, 0, tweenedX)), duration).SetEase(ease).SetLoops(loopsCount, loopType);
        }

        public static Tween DoLocalScaleY(this Transform transform, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return new Tween(new TweakFloat(transform.localScale.y, y, (tweenedY) => transform.localScale = SetVectorValue(transform.localScale, 1, tweenedY)), duration).SetEase(ease).SetLoops(loopsCount, loopType);
        }

        public static Tween DoLocalScaleZ(this Transform transform, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return new Tween(new TweakFloat(transform.localScale.z, z, (tweenedZ) => transform.localScale = SetVectorValue(transform.localScale, 2, tweenedZ)), duration).SetEase(ease).SetLoops(loopsCount, loopType);
        }

        public static Tween DoLocalScale(this Transform transform, float uniformScale, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoLocalScale(transform, new Vector3(uniformScale, uniformScale, uniformScale), duration, ease, loopsCount, loopType);

        public static Tween DoLocalScale(this Transform transform, float x, float y, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoLocalScale(transform, new Vector3(x, y, z), duration, ease, loopsCount, loopType);

        public static Tween DoLocalScale(this Transform transform, Vector3 scale, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return new Tween(new TweakVector3(transform.localScale, scale, (s) => transform.localScale = s), duration).SetEase(ease).SetLoops(loopsCount, loopType);
        }
        #endregion
        #endregion

        private static Vector2 SetVectorValue(Vector2 vector2, int axis, float value)
        {
            vector2[axis] = value;
            return vector2;
        }

        private static Vector3 SetVectorValue(Vector3 vector3, int axis, float value)
        {
            vector3[axis] = value;
            return vector3;
        }

        private static Vector4 SetVectorValue(Vector4 vector4, int axis, float value)
        {
            vector4[axis] = value;
            return vector4;
        }
    }
}