using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry.Lib.Figures.Flat
{
    public abstract class Polygon : FlatFigure
    { 
        public static double CalcArea(double [] sideLengths)
        {
            foreach(var length in sideLengths)
            {
                if (length <= 0)
                {
                    PolygonLengthException();
                }
            }
            var sidesCount = sideLengths.Length;
            if (sidesCount < 3)
            {
                throw new Exception("Фигура многоугольник не может иметь меньше трех сторон");
            }
            else if (sidesCount == 3)
            {
                return Calculation.HeronFormula(sideLengths[0], sideLengths[1], sideLengths[2]);
            }
            else
            {
                throw new Exception("Фигуры со количеством сторон больше 3 не поддерживаются в этой версии библиотеки.");
            }
        }

        internal static void PolygonLengthException()
        {
            throw new Exception("Длина стороны фигуры не может быть меньше или равна 0");
        }

    }
}
