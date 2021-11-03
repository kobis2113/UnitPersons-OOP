using MamasOopExercise.Enums;
using MamasOopExercise.Interfaces;

namespace MamasOopExercise.Classes
{
    public class Coffee : ICoffee
    {
        public double Hours { get; }
        public CoffeeBreakType Type { get; }
        
        public Coffee(CoffeeBreakType type, double hours)
        {
            Hours = hours;
            Type = type;
        }
        
        public override string ToString()
        {
            return $"Coffee-{Type} for {Hours} hours";
        }
   
    }
}