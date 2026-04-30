using UnityEngine;

namespace CupkekGames.Animations
{
    [System.Serializable]
    public class AnimationClipData
    {
        public AnimationClip Clip;
        public float FadeDuration = 0.25f;
        public float Length => Clip != null ? Clip.length : 0f;
    }
}
