using Geometry.Lib.Elements;
using System;

namespace Geometry.Lib.Figures.Flat
{
    public class Triangle : Polygon
    {
        public bool IsRectangular
        {
            get
            {
                return sides.IsRectangular();
            }
        }
        private readonly TriangleSides sides;

        public Triangle((double,double,double) sideLengths)
        {
            if (sideLengths.Item1 <= 0 || sideLengths.Item2 <= 0 || sideLengths.Item3 <= 0)
            {
                PolygonLengthException();
            }
            sides = new TriangleSides(sideLengths.Item1, sideLengths.Item2, sideLengths.Item3);
        }
        public override double Area => CalcAreaByHeronFormula();

        private double CalcAreaByHeronFormula()
        {
            return Calculation.HeronFormula(sides.A.Length, sides.B.Length, sides.C.Length);
        }

    }
}
