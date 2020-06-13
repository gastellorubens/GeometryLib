using System;

namespace Geometry.Lib
{
    public static class Calculation
    {
        public static bool PythagoreanTheorem(double hypotenuseLength, double cathetLength1, double cathetLength2)
        {
            return Math.Pow(hypotenuseLength, 2) == Math.Pow(cathetLength1, 2) + Math.Pow(cathetLength2, 2);
        }
        public static double HeronFormula(double lenght1,double length2,double length3)
        {
            var halfPerimeter = (lenght1 + length2 + length3) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - lenght1) * (halfPerimeter - length2) * (halfPerimeter - length3));
        }
        public static double GetCircleArea(double radius,int mathRound=5)
        {
            return Math.Round(Math.PI * Math.Pow(radius, 2),mathRound);
        }
    }
}
