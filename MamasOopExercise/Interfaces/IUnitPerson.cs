using MamasOopExercise.Enums;

namespace MamasOopExercise.Interfaces
{
    public interface IUnitPerson : ISchedule
    {
        UnitPersonsType UnitPersonsType { get; }
        SpecialActions SpecialAction { get; }
    }
}