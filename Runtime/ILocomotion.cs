using System;
using UnityEngine;

namespace CupkekGames.Animations
{
    public interface ILocomotion
    {
        void PlayIdle();
        void PlayWalk();
        void PlayClipWithReturnToIdle(AnimationClip clip, float fadeDuration = 0.25f);
        event Action<AnimationClip> OnAnimationPlayed;
        Transform transform { get; }
    }
}
