using MamasOopExercise.Enums;
using MamasOopExercise.Interfaces;

namespace MamasOopExercise.Classes
{
    public class Launch : ILaunch
    {
        public double Hours { get; }
        public LaunchTypes Type { get; }
        
        public Launch(LaunchTypes type, double hours)
        {
            Hours = hours;
            Type = type;
        }
        
        public override string ToString()
        {
            return $"Launch-{Type} for {Hours} hours";
        }
    }
}