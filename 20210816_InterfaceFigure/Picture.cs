using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20210816_InterfaceFigure
{
    class Picture
    {
        private const int SIZE = 10;
        private Figure[] _figures;
        private int _countFigures;

        public Picture(int capacity = SIZE)
        {
            _figures = new Figure[capacity];
        }

        public void AddFigure(Figure newFigure)
        {
            if (_countFigures >= _figures.Length)
            {
                Array.Resize(ref _figures, _figures.Length * 2);
            }

            _figures[_countFigures] = newFigure;
            _countFigures++;
        }

        public void Move(int deltaX, int deltaY)
        {
            for (int i = 0; i < _countFigures; i++)
            {
                _figures[i].Move(deltaX, deltaY);
            }
        }

        public void ShowPicture()
        {
            for (int i = 0; i < _countFigures; i++)
            {
                UI.ShowFigure(_figures[i]);
            }
        }

        public double GetArea()
        {
            double result = 0.0;

            for (int i = 0; i < _countFigures; i++)
            {
                result += _figures[i].GetArea();
            }

            return result;
        }

        public double GetPerimetr()
        {
            double result = 0.0;

            for (int i = 0; i < _countFigures; i++)
            {
                result += _figures[i].GetPerimetr();
            }

            return result;
        }

    }
}