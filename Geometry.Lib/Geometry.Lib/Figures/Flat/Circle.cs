using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry.Lib.Figures.Flat
{
    public class Circle : FlatFigure
    {
        public readonly double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double Area => Calculation.GetCircleArea(radius);
    }
}
