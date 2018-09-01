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

        public static Sequence DoMove(this Transform transform, Vector3 position, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMove((a) => transform.position[a], (a, v)=> SetAxisValue(transform, Space.World, a, v), position, duration, ease, loopsCount, loopType);

        public static Tween DoMoveX(this Transform transform, float value, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMoveAxis(() => transform.position.x, (x) => SetAxisValue(transform, Space.World, 0, x), value, duration, ease, loopsCount, loopType);

        public static Tween DoMoveY(this Transform transform, float value, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMoveAxis(() => transform.position.y, (y) => SetAxisValue(transform, Space.World, 1, y), value, duration, ease, loopsCount, loopType);

        public static Tween DoMoveZ(this Transform transform, float value, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMoveAxis(() => transform.position.z, (z) => SetAxisValue(transform, Space.World, 2, z), value, duration, ease, loopsCount, loopType);
        #endregion

        #region Local
        public static Sequence DoLocalMove(this Transform transform, float x, float y, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoLocalMove(transform, new Vector3(x, y, z), duration, ease, loopsCount, loopType);

        public static Sequence DoLocalMove(this Transform transform, Vector3 position, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMove((a) => transform.localPosition[a], (a, v) => SetAxisValue(transform, Space.Self, a, v), position, duration, ease, loopsCount, loopType);

        public static Tween DoLocalMoveX(this Transform transform, float value, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMoveAxis(() => transform.localPosition.x, (x) => SetAxisValue(transform, Space.Self, 0, x), value, duration, ease, loopsCount, loopType);

        public static Tween DoLocalMoveY(this Transform transform, float value, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMoveAxis(() => transform.localPosition.y, (y) => SetAxisValue(transform, Space.Self, 1, y), value, duration, ease, loopsCount, loopType);

        public static Tween DoLocalMoveZ(this Transform transform, float value, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMoveAxis(() => transform.localPosition.z, (z) => SetAxisValue(transform, Space.Self, 2, z), value, duration, ease, loopsCount, loopType);
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
        #endregion

        private static void SetAxisValue(Transform transform, Space space, int axis, float value)
        {
            if (space == Space.World) transform.position = SetAxisValue(transform.position, axis, value);
            else transform.localPosition = SetAxisValue(transform.localPosition, axis, value);
        }
        #endregion

        private static Vector3 SetAxisValue(Vector3 vector3, int axis, float value)
        {
            vector3[axis] = value;
            return vector3;
        }
    }
}