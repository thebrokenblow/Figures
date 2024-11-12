using Figures.ViewModel.Figures;
using Figures.ViewModel.Figures.Interfaces;

namespace Figures.ViewModel;

public class FiguresViewModel
{
    public List<IShape> Shapes { get; set; } =
    [
        new Circle
        {
            Fill = "Black",
            X = 0,
            Y = 0
        },

        new Circle
        {
            Fill = "Red",
            X = 130,
            Y = 310
        },

        new Square
        {
            Fill = "Green",
            X = 160,
            Y = 160
        },

        new Square
        {
            Fill = "Purple",
            X = 190,
            Y = 80
        }
    ];
}