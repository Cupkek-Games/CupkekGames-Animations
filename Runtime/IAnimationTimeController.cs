namespace CupkekGames.Animations
{
    public interface IAnimationTimeController
    {
        void Pause();
        void Resume();
        void SetPlaySpeed(float speed);
        void RegisterTimeContext(object timeContext);
        void UnRegisterTimeContext();
    }
}
