using MamasOopExercise.Classes;
using MamasOopExercise.Enums;

namespace MamasOopExercise.Interfaces
{
    public interface ISchedule
    {
        Work Work { get; }
        Launch Launch { get; }
        Coffee Coffee { get; }
    }
}