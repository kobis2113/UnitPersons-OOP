using MamasOopExercise.Classes;
using MamasOopExercise.Enums;
using MamasOopExercise.Interfaces;

namespace MamasOopExercise.UnitPersons
{
    public class Nagad : UnitPerson
    {

        public Nagad() : base(new Work(WorkType.Driving, 5), new Launch(LaunchTypes.SteakHouse, 1),
            new Coffee(CoffeeBreakType.BlackCoffee, 0.5), SpecialActions.Reviewing, UnitPersonsType.Nagad)
        {

        }
    }
}