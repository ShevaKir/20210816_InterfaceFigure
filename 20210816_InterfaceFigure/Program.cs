using System;

namespace _20210816_InterfaceFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(3, 3, 4);
            Rectangle rectangle = new Rectangle(10, 10, 6, 8);

            Picture picture = new Picture(5);

            picture.AddFigure(square);
            picture.AddFigure(rectangle);
            picture.ShowPicture();

            UI.ShowPerimetr(picture.GetPerimetr());
            UI.ShowArea(picture.GetArea());
        }
    }
}
