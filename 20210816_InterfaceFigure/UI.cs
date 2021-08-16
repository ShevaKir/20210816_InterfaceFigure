using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210816_InterfaceFigure
{
    class UI
    {
        public static void ShowFigure(Figure figure)
        {
            Point[] points = figure.GetPoints();

            for (int i = 0; i < points.Length - 1; i++)
            {
                ConnectTwoPoints(points[i], points[i + 1]);
            }
            ConnectTwoPoints(points[points.Length - 1], points[0]);
        }

        public static void ShowPerimetr(double parametr)
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Perimetr = {0}", parametr);
        }

        public static void ShowArea(double parametr)
        {
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("Area = {0}", parametr);
        }


        public static void ConnectTwoPoints(Point first, Point second)
        {
            int coordX = first.X;
            int coordY = first.Y;
            int coordX2 = second.X;
            int coordY2 = second.Y;

            int w = coordX2 - coordX;
            int h = coordY2 - coordY;

            int dx1 = 0;
            int dy1 = 0;
            int dx2 = 0;
            int dy2 = 0;

            if (w < 0)
            {
                dx1 = -1;
            }
            else if (w > 0)
            {
                dx1 = 1;
            }

            if (h < 0)
            {
                dy1 = -1;
            }
            else if (h > 0)
            {
                dy1 = 1;
            }

            if (w < 0)
            {
                dx2 = -1;
            }
            else if (w > 0)
            {
                dx2 = 1;
            }

            int longest = Math.Abs(w);
            int shortest = Math.Abs(h);

            if (!(longest > shortest))
            {
                longest = Math.Abs(h);
                shortest = Math.Abs(w);

                if (h < 0)
                {
                    dy2 = -1;
                }
                else if (h > 0)
                {
                    dy2 = 1;
                }

                dx2 = 0;
            }

            int numerator = longest >> 1;

            for (int i = 0; i <= longest; i++)
            {
                ShowPoint(coordX, coordY);

                numerator += shortest;

                if (!(numerator < longest))
                {
                    numerator -= longest;
                    coordX += dx1;
                    coordY += dy1;
                }
                else
                {
                    coordX += dx2;
                    coordY += dy2;
                }
            }
        }

        public static void ShowPoint(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("*");
        }
    }
}
