using MamasOopExercise.Enums;

namespace MamasOopExercise.Interfaces
{
    public interface ILaunch : IHour
    {
        LaunchTypes Type { get; }
    }
}