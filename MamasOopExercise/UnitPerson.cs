using MamasOopExercise.Classes;
using MamasOopExercise.Enums;
using MamasOopExercise.Interfaces;

namespace MamasOopExercise
{
    public class UnitPerson : IUnitPerson
    {
        public Work Work { get; }
        public Launch Launch { get; }
        public Coffee Coffee { get; }
        
        public UnitPersonsType UnitPersonsType { get; }
        public SpecialActions SpecialAction { get; }
        
        public UnitPerson(Work work, Launch launch, Coffee coffee, SpecialActions specialAction, UnitPersonsType unitPersonsType)
        {
            Work = work;
            Launch = launch;
            Coffee = coffee;
            SpecialAction = specialAction;
            UnitPersonsType = unitPersonsType;
        }
        
                
        public override string ToString()
        {
            return $"Data for {UnitPersonsType}: {Work}, {Launch}, {Coffee}. " +
                   $"Special Action- {SpecialAction}";
        }
    }
}