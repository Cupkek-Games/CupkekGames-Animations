namespace CupkekGames.Animations
{
    /// <summary>
    /// Reserved animation-kind string constants.
    /// Call sites should use these constants instead of hand-written magic strings,
    /// but the catalog stays open — domain games add new kinds (Cast, Bow, Cheer, etc.)
    /// by populating their <c>CharacterAnimationStateAnimancer</c> entries, not by editing this class.
    /// </summary>
    public static class AnimationKinds
    {
        public const string Idle = "Idle";
        public const string Walk = "Walk";
        public const string GetHit = "GetHit";
        public const string Death = "Death";
        public const string Win = "Win";
    }
}
