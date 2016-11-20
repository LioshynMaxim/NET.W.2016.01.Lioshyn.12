using System;

namespace Task1
{
    public class TriangleClassGeometricShape : GeometricShapeClass
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        /// <summary>
        /// .ctor
        /// </summary>
        /// <param name="a">First side</param>
        /// <param name="b">Second Side</param>
        /// <param name="c">Fird side</param>

        public TriangleClassGeometricShape(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0 || (a > (b + c)) || (b > (a + c)) || (c > (a + b)))
                throw new ArgumentException();

            C = c;
            B = b;
            A = a;
        }

        /// <summary>
        /// Perimeter
        /// </summary>
        /// <returns>Perimeter</returns>

        public override double Perimeter() => A + B + C;

        /// <summary>
        /// Triangle area
        /// </summary>
        /// <returns>Triangle area</returns>

        public override double Square()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public override double Length()
        {
            throw new NotImplementedException();
        }

        public override double Width()
        {
            throw new NotImplementedException();
        }
    }
}