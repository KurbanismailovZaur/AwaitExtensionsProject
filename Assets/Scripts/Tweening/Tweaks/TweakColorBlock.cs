using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

namespace Numba.Tweening.Tweaks
{
    public sealed class TweakColorBlock : Tweak<ColorBlock>
    {
        private TweakColorBlock() { }

        public TweakColorBlock(ColorBlock from, ColorBlock to, Action<ColorBlock> setter) : base(from, to, setter) { }

        protected override ColorBlock Evaluate(float normalizedPassedTime, Ease ease)
        {
            return new ColorBlock()
            {
                colorMultiplier = Easing.Ease(From.colorMultiplier, To.colorMultiplier, normalizedPassedTime, ease),
                disabledColor = Easing.Ease(From.disabledColor, To.disabledColor, normalizedPassedTime, ease),
                fadeDuration = Easing.Ease(From.fadeDuration, To.fadeDuration, normalizedPassedTime, ease),
                highlightedColor = Easing.Ease(From.highlightedColor, To.highlightedColor, normalizedPassedTime, ease),
                normalColor = Easing.Ease(From.normalColor, To.normalColor, normalizedPassedTime, ease),
                pressedColor = Easing.Ease(From.pressedColor, To.pressedColor, normalizedPassedTime, ease)
            };
        }

        protected override ColorBlock EvaluateBackward(float normalizedPassedTime, Ease ease)
        {
            return new ColorBlock()
            {
                colorMultiplier = Easing.Ease(To.colorMultiplier, From.colorMultiplier, normalizedPassedTime, ease),
                disabledColor = Easing.Ease(To.disabledColor, From.disabledColor, normalizedPassedTime, ease),
                fadeDuration = Easing.Ease(To.fadeDuration, From.fadeDuration, normalizedPassedTime, ease),
                highlightedColor = Easing.Ease(To.highlightedColor, From.highlightedColor, normalizedPassedTime, ease),
                normalColor = Easing.Ease(To.normalColor, From.normalColor, normalizedPassedTime, ease),
                pressedColor = Easing.Ease(To.pressedColor, From.pressedColor, normalizedPassedTime, ease)
            };
        }

        protected override ColorBlock Evaluate(float normalizedTime, AnimationCurve curve)
        {
            return new ColorBlock()
            {
                colorMultiplier = Easing.Ease(From.colorMultiplier, To.colorMultiplier, normalizedTime, curve),
                disabledColor = Easing.Ease(From.disabledColor, To.disabledColor, normalizedTime, curve),
                fadeDuration = Easing.Ease(From.fadeDuration, To.fadeDuration, normalizedTime, curve),
                highlightedColor = Easing.Ease(From.highlightedColor, To.highlightedColor, normalizedTime, curve),
                normalColor = Easing.Ease(From.normalColor, To.normalColor, normalizedTime, curve),
                pressedColor = Easing.Ease(From.pressedColor, To.pressedColor, normalizedTime, curve)
            };
        }

        protected override ColorBlock EvaluateBackward(float normalizedTime, AnimationCurve curve)
        {
            return new ColorBlock()
            {
                colorMultiplier = Easing.Ease(To.colorMultiplier, From.colorMultiplier, normalizedTime, curve),
                disabledColor = Easing.Ease(To.disabledColor, From.disabledColor, normalizedTime, curve),
                fadeDuration = Easing.Ease(To.fadeDuration, From.fadeDuration, normalizedTime, curve),
                highlightedColor = Easing.Ease(To.highlightedColor, From.highlightedColor, normalizedTime, curve),
                normalColor = Easing.Ease(To.normalColor, From.normalColor, normalizedTime, curve),
                pressedColor = Easing.Ease(To.pressedColor, From.pressedColor, normalizedTime, curve)
            };
        }
    }
}