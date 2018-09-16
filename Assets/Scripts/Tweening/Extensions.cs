using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Numba.Tweening.Tweaks;

namespace Numba.Tweening
{
    public static class Extensions
    {
        #region Transform
        #region Move
        #region Global
        #region Absolute
        public static Tween DoMoveX(this Transform transform, float position, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMoveAxis(() => transform.position.x, (x) => ChangeTransformPosition(transform, Space.World, 0, x), position, duration, ease, loopsCount, loopType);

        public static Tween DoMoveY(this Transform transform, float position, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMoveAxis(() => transform.position.y, (y) => ChangeTransformPosition(transform, Space.World, 1, y), position, duration, ease, loopsCount, loopType);

        public static Tween DoMoveZ(this Transform transform, float position, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMoveAxis(() => transform.position.z, (z) => ChangeTransformPosition(transform, Space.World, 2, z), position, duration, ease, loopsCount, loopType);

        public static Tween DoMove(this Transform transform, float x, float y, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMove(transform, Space.World, new Vector3(x, y, z), duration, ease, loopsCount, loopType);

        public static Tween DoMove(this Transform transform, Vector3 position, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMove(transform, Space.World, position, duration, ease, loopsCount, loopType);
        #endregion

        #region Relative
        public static Tween DoMoveXBy(this Transform transform, float relativePosition, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMoveAxis(() => transform.position.x, (x) => ChangeTransformPosition(transform, Space.World, 0, x), transform.position.x + relativePosition, duration, ease, loopsCount, loopType);

        public static Tween DoMoveYBy(this Transform transform, float relativePosition, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMoveAxis(() => transform.position.y, (y) => ChangeTransformPosition(transform, Space.World, 1, y), transform.position.y + relativePosition, duration, ease, loopsCount, loopType);

        public static Tween DoMoveZBy(this Transform transform, float relativePosition, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMoveAxis(() => transform.position.z, (z) => ChangeTransformPosition(transform, Space.World, 2, z), transform.position.z + relativePosition, duration, ease, loopsCount, loopType);

        public static Tween DoMoveBy(this Transform transform, float relativeX, float relativeY, float relativeZ, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMove(transform, Space.World, transform.position + new Vector3(relativeX, relativeY, relativeZ), duration, ease, loopsCount, loopType);

        public static Tween DoMoveBy(this Transform transform, Vector3 relativePosition, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMove(transform, Space.World, transform.position + relativePosition, duration, ease, loopsCount, loopType);
        #endregion
        #endregion

        #region Local
        #region Absolute
        public static Tween DoLocalMoveX(this Transform transform, float position, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMoveAxis(() => transform.localPosition.x, (x) => ChangeTransformPosition(transform, Space.Self, 0, x), position, duration, ease, loopsCount, loopType);

        public static Tween DoLocalMoveY(this Transform transform, float position, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMoveAxis(() => transform.localPosition.y, (y) => ChangeTransformPosition(transform, Space.Self, 1, y), position, duration, ease, loopsCount, loopType);

        public static Tween DoLocalMoveZ(this Transform transform, float position, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMoveAxis(() => transform.localPosition.z, (z) => ChangeTransformPosition(transform, Space.Self, 2, z), position, duration, ease, loopsCount, loopType);

        public static Tween DoLocalMove(this Transform transform, float x, float y, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMove(transform, Space.Self, new Vector3(x, y, z), duration, ease, loopsCount, loopType);

        public static Tween DoLocalMove(this Transform transform, Vector3 position, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMove(transform, Space.Self, position, duration, ease, loopsCount, loopType);
        #endregion

        #region Relative
        public static Tween DoLocalMoveXBy(this Transform transform, float relativeLocalPosition, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMoveAxis(() => transform.localPosition.x, (x) => ChangeTransformPosition(transform, Space.Self, 0, x), transform.localPosition.x + relativeLocalPosition, duration, ease, loopsCount, loopType);

        public static Tween DoLocalMoveYBy(this Transform transform, float relativeLocalPosition, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMoveAxis(() => transform.localPosition.y, (y) => ChangeTransformPosition(transform, Space.Self, 1, y), transform.localPosition.y + relativeLocalPosition, duration, ease, loopsCount, loopType);

        public static Tween DoLocalMoveZBy(this Transform transform, float relativeLocalPosition, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMoveAxis(() => transform.localPosition.z, (z) => ChangeTransformPosition(transform, Space.Self, 2, z), transform.localPosition.z + relativeLocalPosition, duration, ease, loopsCount, loopType);

        public static Tween DoLocalMoveBy(this Transform transform, float relativeX, float relativeY, float relativeZ, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMove(transform, Space.Self, transform.localPosition + new Vector3(relativeX, relativeY, relativeZ), duration, ease, loopsCount, loopType);

        public static Tween DoLocalMoveBy(this Transform transform, Vector3 relativePosition, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMove(transform, Space.Self, transform.localPosition + relativePosition, duration, ease, loopsCount, loopType);
        #endregion
        #endregion

        private static Tween DoMove(Transform transform, Space space, Vector3 position, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            if (space == Space.World)
                return Tween.Create(transform.position, position, (p) => transform.position = p, duration, ease, loopsCount, loopType);
            else
                return Tween.Create(transform.localPosition, position, (p) => transform.localPosition = p, duration, ease, loopsCount, loopType);
        }

        private static Tween DoMoveAxis(Func<float> axisValueGetter, Action<float> axisValueSetter, float position, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(axisValueGetter(), position, axisValueSetter, duration, ease, loopsCount, loopType);

        private static void ChangeTransformPosition(Transform transform, Space space, int axis, float value)
        {
            if (space == Space.World) transform.position = SetVectorValue(transform.position, axis, value);
            else transform.localPosition = SetVectorValue(transform.localPosition, axis, value);
        }
        #endregion

        #region Rotation
        #region Global
        #region Absolute
        public static Tween DoRotateX(this Transform transform, float angle, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotateAxis(() => transform.eulerAngles.x, angle, (x) => transform.eulerAngles = SetVectorValue(transform.eulerAngles, 0, x), duration, ease, loopsCount, loopType);

        public static Tween DoRotateY(this Transform transform, float angle, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotateAxis(() => transform.eulerAngles.y, angle, (y) => transform.eulerAngles = SetVectorValue(transform.eulerAngles, 1, y), duration, ease, loopsCount, loopType);

        public static Tween DoRotateZ(this Transform transform, float angle, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotateAxis(() => transform.eulerAngles.z, angle, (z) => transform.eulerAngles = SetVectorValue(transform.eulerAngles, 2, z), duration, ease, loopsCount, loopType);

        public static Tween DoRotate(this Transform transform, float x, float y, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotate(transform, Space.World, Quaternion.Euler(x, y, z), duration, ease, loopsCount, loopType);

        public static Tween DoRotate(this Transform transform, Vector3 euler, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotate(transform, Space.World, Quaternion.Euler(euler), duration, ease, loopsCount, loopType);

        public static Tween DoRotate(this Transform transform, Quaternion rotation, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotate(transform, Space.World, rotation, duration, ease, loopsCount, loopType);
        #endregion
        
        #region Relative
        public static Tween DoRotateXBy(this Transform transform, float relativeAngle, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotateAxis(() => transform.eulerAngles.x, transform.eulerAngles.x + relativeAngle, (x) => transform.eulerAngles = SetVectorValue(transform.eulerAngles, 0, x), duration, ease, loopsCount, loopType);

        public static Tween DoRotateYBy(this Transform transform, float relativeAngle, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotateAxis(() => transform.eulerAngles.y, transform.eulerAngles.y + relativeAngle, (y) => transform.eulerAngles = SetVectorValue(transform.eulerAngles, 1, y), duration, ease, loopsCount, loopType);

        public static Tween DoRotateZBy(this Transform transform, float relativeAngle, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotateAxis(() => transform.eulerAngles.z, transform.eulerAngles.z + relativeAngle, (z) => transform.eulerAngles = SetVectorValue(transform.eulerAngles, 2, z), duration, ease, loopsCount, loopType);

        public static Tween DoRotateBy(this Transform transform, float relativeX, float relativeY, float relativeZ, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotate(transform, Space.World, transform.rotation * Quaternion.Euler(relativeX, relativeY, relativeZ), duration, ease, loopsCount, loopType);

        public static Tween DoRotateBy(this Transform transform, Vector3 relativeEuler, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotate(transform, Space.World, transform.rotation * Quaternion.Euler(relativeEuler), duration, ease, loopsCount, loopType);

        public static Tween DoRotateBy(this Transform transform, Quaternion relativeRotation, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotate(transform, Space.World, transform.rotation * relativeRotation, duration, ease, loopsCount, loopType);
        #endregion
        #endregion

        #region Local
        #region Absolute
        public static Tween DoLocalRotateX(this Transform transform, float angle, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotateAxis(() => transform.localEulerAngles.x, angle, (x) => transform.localEulerAngles = SetVectorValue(transform.localEulerAngles, 0, x), duration, ease, loopsCount, loopType);

        public static Tween DoLocalRotateY(this Transform transform, float angle, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotateAxis(() => transform.localEulerAngles.y, angle, (y) => transform.localEulerAngles = SetVectorValue(transform.localEulerAngles, 1, y), duration, ease, loopsCount, loopType);

        public static Tween DoLocalRotateZ(this Transform transform, float angle, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotateAxis(() => transform.localEulerAngles.z, angle, (z) => transform.localEulerAngles = SetVectorValue(transform.localEulerAngles, 2, z), duration, ease, loopsCount, loopType);

        public static Tween DoLocalRotate(this Transform transform, float x, float y, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotate(transform, Space.Self, Quaternion.Euler(x, y, z), duration, ease, loopsCount, loopType);

        public static Tween DoLocalRotate(this Transform transform, Vector3 euler, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotate(transform, Space.Self, Quaternion.Euler(euler), duration, ease, loopsCount, loopType);

        public static Tween DoLocalRotate(this Transform transform, Quaternion rotation, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotate(transform, Space.Self, rotation, duration, ease, loopsCount, loopType);
        #endregion

        #region Relative
        public static Tween DoLocalRotateXBy(this Transform transform, float relativeAngle, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotateAxis(() => transform.localEulerAngles.x, transform.localEulerAngles.x + relativeAngle, (x) => transform.localEulerAngles = SetVectorValue(transform.localEulerAngles, 0, x), duration, ease, loopsCount, loopType);

        public static Tween DoLocalRotateYBy(this Transform transform, float relativeAngle, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotateAxis(() => transform.localEulerAngles.y, transform.localEulerAngles.y + relativeAngle, (y) => transform.localEulerAngles = SetVectorValue(transform.localEulerAngles, 1, y), duration, ease, loopsCount, loopType);

        public static Tween DoLocalRotateZBy(this Transform transform, float relativeAngle, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotateAxis(() => transform.localEulerAngles.z, transform.localEulerAngles.z + relativeAngle, (z) => transform.localEulerAngles = SetVectorValue(transform.localEulerAngles, 2, z), duration, ease, loopsCount, loopType);

        public static Tween DoLocalRotateBy(this Transform transform, float relativeX, float relativeY, float relativeZ, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotate(transform, Space.Self, transform.localRotation * Quaternion.Euler(relativeX, relativeY, relativeZ), duration, ease, loopsCount, loopType);

        public static Tween DoLocalRotateBy(this Transform transform, Vector3 relativeEuler, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotate(transform, Space.Self, transform.localRotation * Quaternion.Euler(relativeEuler), duration, ease, loopsCount, loopType);

        public static Tween DoLocalRotateBy(this Transform transform, Quaternion relativeRotation, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotate(transform, Space.Self, transform.localRotation * relativeRotation, duration, ease, loopsCount, loopType);
        #endregion
        #endregion

        private static Tween DoRotateAxis(Func<float> angleGetter, float angle, Action<float> angleSetter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(angleGetter(), angle, angleSetter, duration, ease, loopsCount, loopType);

        private static Tween DoRotate(Transform transform, Space space, Quaternion rotation, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            if (space == Space.World)
                return Tween.Create(transform.rotation, rotation, (q) => transform.rotation = q, duration, ease, loopsCount, loopType);
            else
                return Tween.Create(transform.localRotation, rotation, (q) => transform.localRotation = q, duration, ease, loopsCount, loopType);
        }
        #endregion

        #region Scale
        #region Local
        #region Absolute
        public static Tween DoLocalScaleX(this Transform transform, float x, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(transform.localScale.x, x, (tweenedX) => transform.localScale = SetVectorValue(transform.localScale, 0, tweenedX), duration, ease, loopsCount, loopType);

        public static Tween DoLocalScaleY(this Transform transform, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(transform.localScale.y, y, (tweenedY) => transform.localScale = SetVectorValue(transform.localScale, 1, tweenedY), duration, ease, loopsCount, loopType);

        public static Tween DoLocalScaleZ(this Transform transform, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(transform.localScale.z, z, (tweenedZ) => transform.localScale = SetVectorValue(transform.localScale, 2, tweenedZ), duration, ease, loopsCount, loopType);

        public static Tween DoLocalScale(this Transform transform, float uniformScale, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoLocalScale(transform, new Vector3(uniformScale, uniformScale, uniformScale), duration, ease, loopsCount, loopType);

        public static Tween DoLocalScale(this Transform transform, float x, float y, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoLocalScale(transform, new Vector3(x, y, z), duration, ease, loopsCount, loopType);

        public static Tween DoLocalScale(this Transform transform, Vector3 scale, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoScale(transform, scale, duration, ease, loopsCount, loopType);
        #endregion

        #region Relative
        public static Tween DoLocalScaleXBy(this Transform transform, float relativeX, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(transform.localScale.x, transform.localScale.x + relativeX, (tweenedX) => transform.localScale = SetVectorValue(transform.localScale, 0, tweenedX), duration, ease, loopsCount, loopType);

        public static Tween DoLocalScaleYBy(this Transform transform, float relativeY, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(transform.localScale.y, transform.localScale.y + relativeY, (tweenedY) => transform.localScale = SetVectorValue(transform.localScale, 1, tweenedY), duration, ease, loopsCount, loopType);

        public static Tween DoLocalScaleZBy(this Transform transform, float relativeZ, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(transform.localScale.z, transform.localScale.z + relativeZ, (tweenedZ) => transform.localScale = SetVectorValue(transform.localScale, 2, tweenedZ), duration, ease, loopsCount, loopType);

        public static Tween DoLocalScaleBy(this Transform transform, float uniformScale, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoLocalScale(transform, transform.localScale + new Vector3(uniformScale, uniformScale, uniformScale), duration, ease, loopsCount, loopType);

        public static Tween DoLocalScaleBy(this Transform transform, float relativeX, float relativeY, float relativeZ, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoLocalScale(transform, transform.localScale + new Vector3(relativeX, relativeY, relativeZ), duration, ease, loopsCount, loopType);
        
        public static Tween DoLocalScaleBy(this Transform transform, Vector3 relativeScale, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoScale(transform, transform.localScale + relativeScale, duration, ease, loopsCount, loopType);
        #endregion

        public static Tween DoScale(Transform transform, Vector3 scale, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return Tween.Create(transform.localScale, scale, (s) => transform.localScale = s, duration, ease, loopsCount, loopType);
        }
        #endregion
        #endregion
        #endregion

        #region Material
        //public static Tween DoColor(this Material material, Color color, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        //{
        //    return new Tween
        //}
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