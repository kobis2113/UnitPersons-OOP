using MamasOopExercise.Classes;
using MamasOopExercise.Enums;
using MamasOopExercise.Interfaces;

namespace MamasOopExercise.UnitPersons
{
    public class Officer : UnitPerson
    {
        public Officer() : base(new Work(WorkType.OfficerStuff, 10), new Launch(LaunchTypes.OfficersDiningRoom, 0.5),
            new Coffee(CoffeeBreakType.RegularCoffee, 0.25),SpecialActions.PersonalMeetings , UnitPersonsType.Officer )
        {
        }
    }
}