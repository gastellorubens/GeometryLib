
namespace Geometry.Lib.Elements
{
    internal struct TriangleSides
    {
        public readonly LineSegment A;
        public readonly LineSegment B;
        public readonly LineSegment C;
        public TriangleSides(double length_A,double length_B,double length_C)
        {
            A = new LineSegment(length_A);
            B = new LineSegment(length_B);
            C = new LineSegment(length_C);
        }
        public bool IsRectangular()
        {
            if (A.Length > B.Length && A.Length> C.Length)
            {
                return Calculation.PythagoreanTheorem(A.Length, B.Length, C.Length);
            }
            else if (B.Length > A.Length && B.Length > C.Length)
            {
                return Calculation.PythagoreanTheorem(B.Length, A.Length, C.Length);
            }
            else
            {
                return Calculation.PythagoreanTheorem(C.Length, A.Length, B.Length);
            }
        }

    }
}
