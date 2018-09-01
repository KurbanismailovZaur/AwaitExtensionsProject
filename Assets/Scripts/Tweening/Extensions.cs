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
        public static Sequence DoMove(this Transform transform, float x, float y, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMove(transform, new Vector3(x, y, z), duration, ease, loopsCount, loopType);

        public static Sequence DoMove(this Transform transform, Vector3 position, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMove((a) => transform.position[a], (a, v) => SetPositionAxisValue(transform, Space.World, a, v), position, duration, ease, loopsCount, loopType);

        public static Tween DoMoveX(this Transform transform, float value, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMoveAxis(() => transform.position.x, (x) => SetPositionAxisValue(transform, Space.World, 0, x), value, duration, ease, loopsCount, loopType);

        public static Tween DoMoveY(this Transform transform, float value, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMoveAxis(() => transform.position.y, (y) => SetPositionAxisValue(transform, Space.World, 1, y), value, duration, ease, loopsCount, loopType);

        public static Tween DoMoveZ(this Transform transform, float value, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMoveAxis(() => transform.position.z, (z) => SetPositionAxisValue(transform, Space.World, 2, z), value, duration, ease, loopsCount, loopType);
        #endregion

        #region Local
        public static Sequence DoLocalMove(this Transform transform, float x, float y, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoLocalMove(transform, new Vector3(x, y, z), duration, ease, loopsCount, loopType);

        public static Sequence DoLocalMove(this Transform transform, Vector3 position, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMove((a) => transform.localPosition[a], (a, v) => SetPositionAxisValue(transform, Space.Self, a, v), position, duration, ease, loopsCount, loopType);

        public static Tween DoLocalMoveX(this Transform transform, float value, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMoveAxis(() => transform.localPosition.x, (x) => SetPositionAxisValue(transform, Space.Self, 0, x), value, duration, ease, loopsCount, loopType);

        public static Tween DoLocalMoveY(this Transform transform, float value, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMoveAxis(() => transform.localPosition.y, (y) => SetPositionAxisValue(transform, Space.Self, 1, y), value, duration, ease, loopsCount, loopType);

        public static Tween DoLocalMoveZ(this Transform transform, float value, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMoveAxis(() => transform.localPosition.z, (z) => SetPositionAxisValue(transform, Space.Self, 2, z), value, duration, ease, loopsCount, loopType);
        #endregion

        private static Sequence DoMove(Func<int, float> axisValueGetter, Action<int, float> axisValueSetter, Vector3 position, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            Sequence sequence = new Sequence();
            sequence.Insert(0f, new Tween(axisValueGetter(0), position.x, (x) => axisValueSetter(0, x), duration).SetEase(ease).SetLoopType(loopType));
            sequence.Insert(0f, new Tween(axisValueGetter(1), position.x, (y) => axisValueSetter(1, y), duration).SetEase(ease).SetLoopType(loopType));
            sequence.Insert(0f, new Tween(axisValueGetter(2), position.x, (z) => axisValueSetter(2, z), duration).SetEase(ease).SetLoopType(loopType));
            sequence.LoopsCount = loopsCount;

            return sequence;
        }

        private static Tween DoMoveAxis(Func<float> axisValueGetter, Action<float> axisValueSetter, float value, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => new Tween(axisValueGetter(), value, axisValueSetter, duration).SetEase(ease).SetLoops(loopsCount, loopType);

        private static void SetPositionAxisValue(Transform transform, Space space, int axis, float value)
        {
            if (space == Space.World) transform.position = SetAxisValue(transform.position, axis, value);
            else transform.localPosition = SetAxisValue(transform.localPosition, axis, value);
        }
        #endregion

        #region Rotation
        #region Global
        public static Sequence DoRotate(this Transform transform, Quaternion rotation, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotate(transform, rotation.eulerAngles, duration, ease, loopsCount, loopType);

        public static Sequence DoRotate(this Transform transform, Vector3 euler, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotate(transform, euler.x, euler.y, euler.z, duration, ease, loopsCount, loopType);

        public static Sequence DoRotate(this Transform transform, float x, float y, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoRotate(transform, () => transform.rotation.eulerAngles, (a, v) => transform.rotation = Quaternion.Euler(SetAxisValue(transform.rotation.eulerAngles, a, v)), x, y, z, duration, ease, loopsCount, loopType);
        }
        #endregion

        #region Local
        public static Sequence DoLocalRotate(this Transform transform, Quaternion rotation, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotate(transform, rotation.eulerAngles, duration, ease, loopsCount, loopType);

        public static Sequence DoLocalRotate(this Transform transform, Vector3 euler, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotate(transform, euler.x, euler.y, euler.z, duration, ease, loopsCount, loopType);

        public static Sequence DoLocalRotate(this Transform transform, float x, float y, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            return DoRotate(transform, () => transform.localRotation.eulerAngles, (a, v) => transform.localRotation = Quaternion.Euler(SetAxisValue(transform.localRotation.eulerAngles, a, v)), x, y, z, duration, ease, loopsCount, loopType);
        }
        #endregion

        public static Sequence DoRotate(this Transform transform, Func<Vector3> eulerGetter, Action<int, float> eulerSetter, float x, float y, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            Vector3 euler = eulerGetter();

            Sequence sequence = new Sequence();
            sequence.Insert(0f, new Tween(euler.x, x, (tweenedX) => eulerSetter(0, tweenedX), duration).SetEase(ease).SetLoopType(loopType));
            sequence.Insert(0f, new Tween(euler.y, y, (tweenedY) => eulerSetter(1, tweenedY), duration).SetEase(ease).SetLoopType(loopType));
            sequence.Insert(0f, new Tween(euler.z, z, (tweenedZ) => eulerSetter(2, tweenedZ), duration).SetEase(ease).SetLoopType(loopType));
            sequence.SetLoopsCount(loopsCount);

            return sequence;
        }
        #endregion
        #endregion

        private static Vector3 SetAxisValue(Vector3 vector3, int axis, float value)
        {
            vector3[axis] = value;
            return vector3;
        }

        private static Vector4 SetAxisValue(Vector4 vector4, int axis, float value)
        {
            vector4[axis] = value;
            return vector4;
        }
    }
}