using MamasOopExercise.Enums;

namespace MamasOopExercise.Interfaces
{
    public interface IWork : IHour
    {
        WorkType Type { get; }
    }
}