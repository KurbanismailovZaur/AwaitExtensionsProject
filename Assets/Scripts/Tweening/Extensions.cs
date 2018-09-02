using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static UnityEngine.Debug;
using System;

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

        public static Sequence DoMove(this Transform transform, float x, float y, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMove(transform, new Vector3(x, y, z), duration, ease, loopsCount, loopType);

        public static Sequence DoMove(this Transform transform, Vector3 position, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMove(transform, Space.World, position, duration, ease, loopsCount, loopType);
        #endregion

        #region Local
        public static Tween DoLocalMoveX(this Transform transform, float position, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMoveAxis(() => transform.localPosition.x, (x) => ChangeTransformPosition(transform, Space.Self, 0, x), position, duration, ease, loopsCount, loopType);

        public static Tween DoLocalMoveY(this Transform transform, float position, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMoveAxis(() => transform.localPosition.y, (y) => ChangeTransformPosition(transform, Space.Self, 1, y), position, duration, ease, loopsCount, loopType);

        public static Tween DoLocalMoveZ(this Transform transform, float position, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMoveAxis(() => transform.localPosition.z, (z) => ChangeTransformPosition(transform, Space.Self, 2, z), position, duration, ease, loopsCount, loopType);

        public static Sequence DoLocalMove(this Transform transform, float x, float y, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoLocalMove(transform, new Vector3(x, y, z), duration, ease, loopsCount, loopType);

        public static Sequence DoLocalMove(this Transform transform, Vector3 position, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMove(transform, Space.Self, position, duration, ease, loopsCount, loopType);
        #endregion

        private static Sequence DoMove(Transform transform, Space space, Vector3 position, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            Func<Transform, float, float, Ease, int, LoopType, Tween> doX;
            Func<Transform, float, float, Ease, int, LoopType, Tween> doY;
            Func<Transform, float, float, Ease, int, LoopType, Tween> doZ;

            if (space == Space.World)
            {
                doX = DoMoveX;
                doY = DoMoveY;
                doZ = DoMoveZ;
            }
            else
            {
                doX = DoLocalMoveX;
                doY = DoLocalMoveY;
                doZ = DoLocalMoveZ;
            }

            Sequence sequence = new Sequence();
            sequence.Insert(0f, doX(transform, position.x, duration, ease, 1, loopType));
            sequence.Insert(0f, doY(transform, position.y, duration, ease, 1, loopType));
            sequence.Insert(0f, doZ(transform, position.z, duration, ease, 1, loopType));
            sequence.LoopsCount = loopsCount;

            return sequence;
        }

        private static Tween DoMoveAxis(Func<float> axisValueGetter, Action<float> axisValueSetter, float position, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => new Tween(axisValueGetter(), position, axisValueSetter, duration).SetEase(ease).SetLoops(loopsCount, loopType);

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

        public static Sequence DoRotate(this Transform transform, Quaternion rotation, float duration, RotationQuality rotationQuality = RotationQuality.Best, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotate(transform, rotation.eulerAngles, duration, rotationQuality, ease, loopsCount, loopType);

        public static Sequence DoRotate(this Transform transform, Vector3 euler, float duration, RotationQuality rotationQuality = RotationQuality.Best, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotate(transform, euler.x, euler.y, euler.z, duration, rotationQuality, ease, loopsCount, loopType);

        public static Sequence DoRotate(this Transform transform, float x, float y, float z, float duration, RotationQuality rotationQuality = RotationQuality.Best, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotate(transform, Space.World, x, y, z, duration, rotationQuality, ease, loopsCount, loopType);
        #endregion

        #region Local
        public static Tween DoLocalRotateX(this Transform transform, float angle, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotateAxis(() => transform.localEulerAngles.x, angle, (x) => transform.localEulerAngles = SetVectorValue(transform.localEulerAngles, 0, x), duration, ease, loopsCount, loopType);

        public static Tween DoLocalRotateY(this Transform transform, float angle, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotateAxis(() => transform.localEulerAngles.y, angle, (y) => transform.localEulerAngles = SetVectorValue(transform.localEulerAngles, 1, y), duration, ease, loopsCount, loopType);

        public static Tween DoLocalRotateZ(this Transform transform, float angle, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotateAxis(() => transform.localEulerAngles.z, angle, (z) => transform.localEulerAngles = SetVectorValue(transform.localEulerAngles, 2, z), duration, ease, loopsCount, loopType);

        public static Sequence DoLocalRotate(this Transform transform, Quaternion rotation, float duration, RotationQuality rotationQuality = RotationQuality.Best, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotate(transform, rotation.eulerAngles, duration, rotationQuality, ease, loopsCount, loopType);

        public static Sequence DoLocalRotate(this Transform transform, Vector3 euler, float duration, RotationQuality rotationQuality = RotationQuality.Best, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotate(transform, euler.x, euler.y, euler.z, duration, rotationQuality, ease, loopsCount, loopType);

        public static Sequence DoLocalRotate(this Transform transform, float x, float y, float z, float duration, RotationQuality rotationQuality = RotationQuality.Best, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotate(transform, Space.Self, x, y, z, duration, rotationQuality, ease, loopsCount, loopType);
        #endregion

        private static Tween DoRotateAxis(Func<float> angleGetter, float angle, Action<float> angleSetter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => new Tween(angleGetter(), angle, angleSetter, duration).SetEase(ease).SetLoops(loopsCount, loopType);

        private static Sequence DoRotate(Transform transform, Space space, float x, float y, float z, float duration, RotationQuality rotationQuality = RotationQuality.Best, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            if (rotationQuality == RotationQuality.Fast)
            {
                Func<Transform, float, float, Ease, int, LoopType, Tween> doX;
                Func<Transform, float, float, Ease, int, LoopType, Tween> doY;
                Func<Transform, float, float, Ease, int, LoopType, Tween> doZ;

                if (space == Space.World)
                {
                    doX = DoRotateX;
                    doY = DoRotateY;
                    doZ = DoRotateZ;
                }
                else
                {
                    doX = DoLocalRotateX;
                    doY = DoLocalRotateY;
                    doZ = DoLocalRotateZ;
                }

                Sequence sequence = new Sequence();
                sequence.Insert(0f, doX(transform, x, duration, ease, 1, loopType));
                sequence.Insert(0f, doY(transform, y, duration, ease, 1, loopType));
                sequence.Insert(0f, doZ(transform, z, duration, ease, 1, loopType));
                sequence.LoopsCount = loopsCount;

                return sequence;
            }
            else
            {
                Quaternion startRotation = space == Space.World ? transform.rotation : transform.localRotation;
                Quaternion endRotation = Quaternion.Euler(x, y, z);

                Action<float> setter;
                if (space == Space.World) setter = (t) => { transform.rotation = Quaternion.Lerp(startRotation, endRotation, t); };
                else setter = (t) => { transform.localRotation = Quaternion.Lerp(startRotation, endRotation, t); };

                Sequence sequence = new Sequence();
                sequence.Append(new Tween(0f, 1f, setter, duration).SetEase(ease).SetLoopType(loopType));
                sequence.LoopsCount = loopsCount;

                return sequence;
            }
        }
        #endregion

        #region Scale
        public static Tween DoLocalScaleX(this Transform transform, float x, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalScaleAxis(() => transform.localScale.x, x, (tweenedX) => transform.localScale = SetVectorValue(transform.localScale, 0, tweenedX), duration, ease, loopsCount, loopType);
        }

        public static Tween DoLocalScaleY(this Transform transform, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalScaleAxis(() => transform.localScale.y, y, (tweenedY) => transform.localScale = SetVectorValue(transform.localScale, 1, tweenedY), duration, ease, loopsCount, loopType);
        }

        public static Tween DoLocalScaleZ(this Transform transform, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoLocalScaleAxis(() => transform.localScale.z, z, (tweenedZ) => transform.localScale = SetVectorValue(transform.localScale, 2, tweenedZ), duration, ease, loopsCount, loopType);
        }

        private static Tween DoLocalScaleAxis(Func<float> axisScaleGetter, float value, Action<float> axisScaleSetter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return new Tween(axisScaleGetter(), value, axisScaleSetter, duration).SetEase(ease).SetLoops(loopsCount, loopType);
        }

        public static Sequence DoLocalScale(this Transform transform, float uniformScale, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoLocalScale(transform, uniformScale, uniformScale, uniformScale, duration, ease, loopsCount, loopType);

        public static Sequence DoLocalScale(this Transform transform, Vector3 scale, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoLocalScale(transform, scale.x, scale.y, scale.z, duration, ease, loopsCount, loopType);

        public static Sequence DoLocalScale(this Transform transform, float x, float y, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            Sequence sequence = new Sequence();
            sequence.Insert(0f, DoLocalScaleX(transform, x, duration, ease, 1, loopType));
            sequence.Insert(0f, DoLocalScaleY(transform, y, duration, ease, 1, loopType));
            sequence.Insert(0f, DoLocalScaleZ(transform, z, duration, ease, 1, loopType));
            sequence.LoopsCount = loopsCount;

            return sequence;
        }
        #endregion
        #endregion

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