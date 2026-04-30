using System;
using UnityEngine;

namespace CupkekGames.Animations
{
    public interface IAnimationEngine
    {
        void PlayClip(AnimationClipData clipData, AnimationClipData returnClip = null,
            int layer = 0, bool fadeOutLayer = false);
        event Action<AnimationClip> OnAnimationPlayed;
        Transform transform { get; }
    }
}
