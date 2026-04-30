using System.Threading;
using UnityEngine;

namespace CupkekGames.Animations
{
    public interface ICombatAnimations
    {
        void PlayIdle();
        void PlayGetHit();
        void PlayDeath();
        void PlayWin();
        void PlayAnimationWithReturnToIdle(AnimationClip clip, float fadeDuration = 0.25f,
            CancellationToken? cancellationToken = null);
        Transform Transform { get; }
    }
}
