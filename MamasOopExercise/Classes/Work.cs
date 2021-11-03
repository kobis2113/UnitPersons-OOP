using MamasOopExercise.Enums;
using MamasOopExercise.Interfaces;

namespace MamasOopExercise.Classes
{
    public class Work : IWork
    {
        public double Hours { get; }
        public WorkType Type { get; }

        public Work(WorkType type, double hours)
        {
            Type = type;
            Hours = hours;
        }

        public override string ToString()
        {
            return $"Work-{Type} for {Hours} hours";
        }
    }
}