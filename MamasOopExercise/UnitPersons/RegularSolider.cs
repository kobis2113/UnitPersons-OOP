using MamasOopExercise.Classes;
using MamasOopExercise.Enums;
using MamasOopExercise.Interfaces;

namespace MamasOopExercise.UnitPersons
{
    public class RegularSolider : UnitPerson
    { 
        public RegularSolider() : base(new Work(WorkType.Programming, 8),new Launch(LaunchTypes.RegularDiningRoom, 2),
            new Coffee(CoffeeBreakType.RegularCoffee, 2), SpecialActions.Shekem, UnitPersonsType.RegularSolider)
        {
        }
    }
}