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
        public static Tween DoPositionX(this Transform transform, float x, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMoveAlongAxis(() => transform.position.x, (px) => ChangeTransformPosition(transform, Space.World, 0, px), x, duration, ease, loopsCount, loopType);

        public static Tween DoPositionY(this Transform transform, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMoveAlongAxis(() => transform.position.y, (py) => ChangeTransformPosition(transform, Space.World, 1, py), y, duration, ease, loopsCount, loopType);

        public static Tween DoPositionZ(this Transform transform, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMoveAlongAxis(() => transform.position.z, (pz) => ChangeTransformPosition(transform, Space.World, 2, pz), z, duration, ease, loopsCount, loopType);

        public static Tween DoPosition(this Transform transform, float x, float y, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoPosition(transform, Space.World, new Vector3(x, y, z), duration, ease, loopsCount, loopType);

        public static Tween DoPosition(this Transform transform, Vector3 position, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoPosition(transform, Space.World, position, duration, ease, loopsCount, loopType);
        #endregion

        #region Local
        public static Tween DoLocalPositionX(this Transform transform, float x, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMoveAlongAxis(() => transform.localPosition.x, (lpx) => ChangeTransformPosition(transform, Space.Self, 0, lpx), x, duration, ease, loopsCount, loopType);

        public static Tween DoLocalPositionY(this Transform transform, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMoveAlongAxis(() => transform.localPosition.y, (lpy) => ChangeTransformPosition(transform, Space.Self, 1, lpy), y, duration, ease, loopsCount, loopType);

        public static Tween DoLocalPositionZ(this Transform transform, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoMoveAlongAxis(() => transform.localPosition.z, (lpz) => ChangeTransformPosition(transform, Space.Self, 2, lpz), z, duration, ease, loopsCount, loopType);

        public static Tween DoLocalPosition(this Transform transform, float x, float y, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoPosition(transform, Space.Self, new Vector3(x, y, z), duration, ease, loopsCount, loopType);

        public static Tween DoLocalPosition(this Transform transform, Vector3 localPosition, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoPosition(transform, Space.Self, localPosition, duration, ease, loopsCount, loopType);
        #endregion

        private static Tween DoPosition(Transform transform, Space space, Vector3 position, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            if (space == Space.World)
                return Tween.Create(transform.position, position, (p) => transform.position = p, duration, ease, loopsCount, loopType);
            else
                return Tween.Create(transform.localPosition, position, (p) => transform.localPosition = p, duration, ease, loopsCount, loopType);
        }

        private static Tween DoMoveAlongAxis(Func<float> axisValueGetter, Action<float> axisValueSetter, float axisValue, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(axisValueGetter(), axisValue, axisValueSetter, duration, ease, loopsCount, loopType);

        private static void ChangeTransformPosition(Transform transform, Space space, int axis, float value)
        {
            if (space == Space.World) transform.position = SetVectorValue(transform.position, axis, value);
            else transform.localPosition = SetVectorValue(transform.localPosition, axis, value);
        }
        #endregion

        #region Rotation
        #region Global
        public static Tween DoEulerAnglesX(this Transform transform, float x, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotateAroundAxis(() => transform.eulerAngles.x, x, (eax) => transform.eulerAngles = SetVectorValue(transform.eulerAngles, 0, eax), duration, ease, loopsCount, loopType);

        public static Tween DoEulerAnglesY(this Transform transform, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotateAroundAxis(() => transform.eulerAngles.y, y, (eay) => transform.eulerAngles = SetVectorValue(transform.eulerAngles, 1, eay), duration, ease, loopsCount, loopType);

        public static Tween DoEulerAnglesZ(this Transform transform, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotateAroundAxis(() => transform.eulerAngles.z, z, (eaz) => transform.eulerAngles = SetVectorValue(transform.eulerAngles, 2, eaz), duration, ease, loopsCount, loopType);

        public static Tween DoEulerAngles(this Transform transform, float x, float y, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotation(transform, Space.World, Quaternion.Euler(x, y, z), duration, ease, loopsCount, loopType);

        public static Tween DoEulerAngles(this Transform transform, Vector3 eulerAngles, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotation(transform, Space.World, Quaternion.Euler(eulerAngles), duration, ease, loopsCount, loopType);

        public static Tween DoRotation(this Transform transform, Quaternion rotation, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotation(transform, Space.World, rotation, duration, ease, loopsCount, loopType);
        #endregion

        #region Local
        public static Tween DoLocalEulerAnglesX(this Transform transform, float x, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotateAroundAxis(() => transform.localEulerAngles.x, x, (leax) => transform.localEulerAngles = SetVectorValue(transform.localEulerAngles, 0, leax), duration, ease, loopsCount, loopType);

        public static Tween DoLocalEulerAnglesY(this Transform transform, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotateAroundAxis(() => transform.localEulerAngles.y, y, (leay) => transform.localEulerAngles = SetVectorValue(transform.localEulerAngles, 1, leay), duration, ease, loopsCount, loopType);

        public static Tween DoLocalEulerAnglesZ(this Transform transform, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotateAroundAxis(() => transform.localEulerAngles.z, z, (leaz) => transform.localEulerAngles = SetVectorValue(transform.localEulerAngles, 2, leaz), duration, ease, loopsCount, loopType);

        public static Tween DoLocalEulerAngles(this Transform transform, float x, float y, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotation(transform, Space.Self, Quaternion.Euler(x, y, z), duration, ease, loopsCount, loopType);

        public static Tween DoLocalEulerAngles(this Transform transform, Vector3 localEulerAngles, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotation(transform, Space.Self, Quaternion.Euler(localEulerAngles), duration, ease, loopsCount, loopType);

        public static Tween DoLocalRotation(this Transform transform, Quaternion localRotation, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoRotation(transform, Space.Self, localRotation, duration, ease, loopsCount, loopType);
        #endregion

        private static Tween DoRotateAroundAxis(Func<float> angleGetter, float axisValue, Action<float> angleSetter, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(angleGetter(), axisValue, angleSetter, duration, ease, loopsCount, loopType);

        private static Tween DoRotation(Transform transform, Space space, Quaternion rotation, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward)
        {
            if (space == Space.World)
                return Tween.Create(transform.rotation, rotation, (q) => transform.rotation = q, duration, ease, loopsCount, loopType);
            else
                return Tween.Create(transform.localRotation, rotation, (q) => transform.localRotation = q, duration, ease, loopsCount, loopType);
        }
        #endregion

        #region Scale
        public static Tween DoLocalScaleX(this Transform transform, float x, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(transform.localScale.x, x, (lsx) => transform.localScale = SetVectorValue(transform.localScale, 0, lsx), duration, ease, loopsCount, loopType);

        public static Tween DoLocalScaleY(this Transform transform, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(transform.localScale.y, y, (lsy) => transform.localScale = SetVectorValue(transform.localScale, 1, lsy), duration, ease, loopsCount, loopType);

        public static Tween DoLocalScaleZ(this Transform transform, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(transform.localScale.z, z, (lsz) => transform.localScale = SetVectorValue(transform.localScale, 2, lsz), duration, ease, loopsCount, loopType);

        public static Tween DoLocalScale(this Transform transform, float uniformScale, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoLocalScale(transform, new Vector3(uniformScale, uniformScale, uniformScale), duration, ease, loopsCount, loopType);

        public static Tween DoLocalScale(this Transform transform, float x, float y, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => DoLocalScale(transform, new Vector3(x, y, z), duration, ease, loopsCount, loopType);

        public static Tween DoLocalScale(this Transform transform, Vector3 localScale, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(transform.localScale, localScale, (ls) => transform.localScale = ls, duration, ease, loopsCount, loopType);
        #endregion
        #endregion

        #region RectTransform
        #region Anchored position
        public static Tween DoAnchoredPositionX(this RectTransform rectTransform, float x, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(rectTransform.anchoredPosition.x, x, (apx) => rectTransform.anchoredPosition = SetVectorValue(rectTransform.anchoredPosition, 0, apx), duration, ease, loopsCount, loopType);

        public static Tween DoAnchoredPositionY(this RectTransform rectTransform, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(rectTransform.anchoredPosition.y, y, (apy) => rectTransform.anchoredPosition = SetVectorValue(rectTransform.anchoredPosition, 1, apy), duration, ease, loopsCount, loopType);

        public static Tween DoAnchoredPosition(this RectTransform rectTransform, float x, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(rectTransform.anchoredPosition, new Vector2(x, y), (ap) => rectTransform.anchoredPosition = ap, duration, ease, loopsCount, loopType);

        public static Tween DoAnchoredPosition(this RectTransform rectTransform, Vector2 anchoredPosition, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(rectTransform.anchoredPosition, anchoredPosition, (ap) => rectTransform.anchoredPosition = ap, duration, ease, loopsCount, loopType);
        #endregion

        #region Anchored position 3D
        public static Tween DoAnchoredPosition3DX(this RectTransform rectTransform, float x, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(rectTransform.anchoredPosition3D.x, x, (ap3dx) => rectTransform.anchoredPosition3D = SetVectorValue(rectTransform.anchoredPosition3D, 0, ap3dx), duration, ease, loopsCount, loopType);

        public static Tween DoAnchoredPosition3DY(this RectTransform rectTransform, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(rectTransform.anchoredPosition3D.y, y, (ap3dy) => rectTransform.anchoredPosition3D = SetVectorValue(rectTransform.anchoredPosition3D, 1, ap3dy), duration, ease, loopsCount, loopType);

        public static Tween DoAnchoredPosition3DZ(this RectTransform rectTransform, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(rectTransform.anchoredPosition3D.z, z, (ap3dz) => rectTransform.anchoredPosition3D = SetVectorValue(rectTransform.anchoredPosition3D, 2, ap3dz), duration, ease, loopsCount, loopType);

        public static Tween DoAnchoredPosition3D(this RectTransform rectTransform, float x, float y, float z, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(rectTransform.anchoredPosition3D, new Vector3(x, y, z), (ap3d) => rectTransform.anchoredPosition3D = ap3d, duration, ease, loopsCount, loopType);

        public static Tween DoAnchoredPosition3D(this RectTransform rectTransform, Vector3 anchoredPosition3D, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(rectTransform.anchoredPosition3D, anchoredPosition3D, (ap3d) => rectTransform.anchoredPosition3D = ap3d, duration, ease, loopsCount, loopType);
        #endregion

        #region AnchorMax
        public static Tween DoAnchorMaxX(this RectTransform rectTransform, float x, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(rectTransform.anchorMax.x, x, (amx) => rectTransform.anchorMax = SetVectorValue(rectTransform.anchorMax, 0, amx), duration, ease, loopsCount, loopType);

        public static Tween DoAnchorMaxY(this RectTransform rectTransform, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(rectTransform.anchorMax.y, y, (amy) => rectTransform.anchorMax = SetVectorValue(rectTransform.anchorMax, 1, amy), duration, ease, loopsCount, loopType);

        public static Tween DoAnchorMax(this RectTransform rectTransform, float x, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(rectTransform.anchorMax, new Vector2(x, y), (am) => rectTransform.anchorMax = am, duration, ease, loopsCount, loopType);

        public static Tween DoAnchorMax(this RectTransform rectTransform, Vector2 anchorMax, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(rectTransform.anchorMax, anchorMax, (am) => rectTransform.anchorMax = am, duration, ease, loopsCount, loopType);
        #endregion

        #region AnchorMin
        public static Tween DoAnchorMinX(this RectTransform rectTransform, float x, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(rectTransform.anchorMin.x, x, (amx) => rectTransform.anchorMin = SetVectorValue(rectTransform.anchorMin, 0, amx), duration, ease, loopsCount, loopType);

        public static Tween DoAnchorMinY(this RectTransform rectTransform, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(rectTransform.anchorMin.y, y, (amy) => rectTransform.anchorMin = SetVectorValue(rectTransform.anchorMin, 1, amy), duration, ease, loopsCount, loopType);

        public static Tween DoAnchorMin(this RectTransform rectTransform, float x, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(rectTransform.anchorMin, new Vector2(x, y), (am) => rectTransform.anchorMin = am, duration, ease, loopsCount, loopType);

        public static Tween DoAnchorMin(this RectTransform rectTransform, Vector2 anchorMin, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(rectTransform.anchorMin, anchorMin, (am) => rectTransform.anchorMin = am, duration, ease, loopsCount, loopType);
        #endregion

        #region OffsetMax
        public static Tween DoOffsetMaxX(this RectTransform rectTransform, float x, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(rectTransform.offsetMax.x, x, (omx) => rectTransform.offsetMax = SetVectorValue(rectTransform.offsetMax, 0, omx), duration, ease, loopsCount, loopType);

        public static Tween DoOffsetMaxY(this RectTransform rectTransform, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(rectTransform.offsetMax.y, y, (omy) => rectTransform.offsetMax = SetVectorValue(rectTransform.offsetMax, 1, omy), duration, ease, loopsCount, loopType);

        public static Tween DoOffsetMax(this RectTransform rectTransform, float x, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(rectTransform.offsetMax, new Vector2(x, y), (om) => rectTransform.offsetMax = om, duration, ease, loopsCount, loopType);

        public static Tween DoOffsetMax(this RectTransform rectTransform, Vector2 offsetMax, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(rectTransform.offsetMax, offsetMax, (om) => rectTransform.offsetMax = om, duration, ease, loopsCount, loopType);
        #endregion

        #region OffsetMin
        public static Tween DoOffsetMinX(this RectTransform rectTransform, float x, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(rectTransform.offsetMin.x, x, (omx) => rectTransform.offsetMin = SetVectorValue(rectTransform.offsetMin, 0, omx), duration, ease, loopsCount, loopType);

        public static Tween DoOffsetMinY(this RectTransform rectTransform, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(rectTransform.offsetMin.y, y, (omy) => rectTransform.offsetMin = SetVectorValue(rectTransform.offsetMin, 1, omy), duration, ease, loopsCount, loopType);

        public static Tween DoOffsetMin(this RectTransform rectTransform, float x, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(rectTransform.offsetMin, new Vector2(x, y), (om) => rectTransform.offsetMin = om, duration, ease, loopsCount, loopType);

        public static Tween DoOffsetMin(this RectTransform rectTransform, Vector2 offsetMin, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(rectTransform.offsetMin, offsetMin, (om) => rectTransform.offsetMin = om, duration, ease, loopsCount, loopType);
        #endregion

        #region Pivot
        public static Tween DoPivotX(this RectTransform rectTransform, float x, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(rectTransform.pivot.x, x, (px) => rectTransform.pivot = SetVectorValue(rectTransform.pivot, 0, px), duration, ease, loopsCount, loopType);

        public static Tween DoPivotY(this RectTransform rectTransform, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(rectTransform.pivot.y, y, (py) => rectTransform.pivot = SetVectorValue(rectTransform.pivot, 1, py), duration, ease, loopsCount, loopType);

        public static Tween DoPivot(this RectTransform rectTransform, float x, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(rectTransform.pivot, new Vector2(x, y), (p) => rectTransform.pivot = p, duration, ease, loopsCount, loopType);

        public static Tween DoPivot(this RectTransform rectTransform, Vector2 pivot, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(rectTransform.pivot, pivot, (p) => rectTransform.pivot = p, duration, ease, loopsCount, loopType);
        #endregion

        #region SizeDelta
        public static Tween DoSizeDeltaX(this RectTransform rectTransform, float x, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(rectTransform.sizeDelta.x, x, (sdx) => rectTransform.sizeDelta = SetVectorValue(rectTransform.sizeDelta, 0, sdx), duration, ease, loopsCount, loopType);

        public static Tween DoSizeDeltaY(this RectTransform rectTransform, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(rectTransform.sizeDelta.y, y, (sdy) => rectTransform.sizeDelta = SetVectorValue(rectTransform.sizeDelta, 1, sdy), duration, ease, loopsCount, loopType);

        public static Tween DoSizeDelta(this RectTransform rectTransform, float x, float y, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(rectTransform.sizeDelta, new Vector2(x, y), (sd) => rectTransform.sizeDelta = sd, duration, ease, loopsCount, loopType);

        public static Tween DoSizeDelta(this RectTransform rectTransform, Vector2 sizeDelta, float duration, Ease ease = Ease.Linear, int loopsCount = 1, LoopType loopType = LoopType.Forward) => Tween.Create(rectTransform.sizeDelta, sizeDelta, (sd) => rectTransform.sizeDelta = sd, duration, ease, loopsCount, loopType);
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