using Figures.ViewModel.Figures.Interfaces;

namespace Figures.ViewModel.Figures;

public class Circle : IShape
{
    public double X { get; init; }
    public double Y { get; init; }
    public required string Fill { get; init; }
}