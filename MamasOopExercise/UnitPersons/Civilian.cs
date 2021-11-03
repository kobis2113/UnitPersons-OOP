using MamasOopExercise.Classes;
using MamasOopExercise.Enums;
using MamasOopExercise.Interfaces;

namespace MamasOopExercise.UnitPersons
{
    public class Civilian : UnitPerson
    {
        public Civilian() :base(new Work(WorkType.Programming, 8), new Launch(LaunchTypes.Moses, 2), 
                new Coffee(CoffeeBreakType.CoffeeTime, 1), SpecialActions.HourReporting, UnitPersonsType.Civilian)
        {
        }
    }
}