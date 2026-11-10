using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace CupkekGames.Animations
{
    /// <summary>
    /// Single kind-driven entry point for state-based character animation (idle, walk, hit, death, etc.).
    /// Kinds are designer-defined string keys; new kinds are added by registering a (kind, clip) entry
    /// on the adapter, not by editing this interface.
    /// </summary>
    public interface IAnimationStateController
    {
        /// <summary>
        /// Play a kind from this controller's catalog. The adapter resolves any
        /// authored <c>ReturnToKind</c> / <c>OnlyFromKind</c> rules per entry.
        /// Unknown kinds are silently ignored.
        /// </summary>
        void Play(string kind);

        /// <summary>
        /// Play a raw clip and return to the <see cref="AnimationKinds.Idle"/> kind on completion.
        /// Useful for one-shot animations not authored in the controller's catalog (e.g. emotes, gathering).
        /// </summary>
        void PlayClipWithReturnToIdle(AnimationClip clip, float fadeDuration = 0.25f, CancellationToken? cancellationToken = null);

        /// <summary>The kinds this controller can play (its catalog, shared and its own).</summary>
        IReadOnlyCollection<string> Kinds { get; }

        /// <summary>
        /// The clip <paramref name="kind"/> plays on this controller (to time
        /// something by it, or to tell which variant a character uses); false
        /// when it has no such kind.
        /// </summary>
        bool TryGetClip(string kind, out AnimationClip clip);

        /// <summary>Transform of the controlled character — for SFX/VFX positioning, hit effects, etc.</summary>
        Transform Transform { get; }

        /// <summary>Fired whenever a clip is played through this controller.</summary>
        event Action<AnimationClip> OnAnimationPlayed;
    }
}
