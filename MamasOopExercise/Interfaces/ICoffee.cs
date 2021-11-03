using MamasOopExercise.Enums;

namespace MamasOopExercise.Interfaces
{
    public interface ICoffee : IHour
    {
        CoffeeBreakType Type { get; }
    }
}