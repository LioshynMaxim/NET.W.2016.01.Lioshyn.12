using System;

namespace Task1
{
    public class RectangleClassGeometricShape : GeometricShapeClass
    {
        public double A { get; }
        public double B { get; }

        /// <summary>
        /// .ctor
        /// </summary>
        /// <param name="a">Length</param>
        /// <param name="b">Width</param>

        public RectangleClassGeometricShape(double a, double b)
        {
            if (a < 0 || b < 0)
                throw new ArgumentException();

            A = a;
            B = b;
        }

        /// <summary>
        /// Perimetr rectangle
        /// </summary>
        /// <returns>Perimetr rectangle</returns>

        public override double Perimeter() => 2 * (A + B);

        /// <summary>
        /// Square rectangle
        /// </summary>
        /// <returns>Square rectangle</returns>

        public override double Square() => A * B;

        /// <summary>
        /// Length rectangle
        /// </summary>
        /// <returns>Length rectangle</returns>

        public override double Length() => A;

        /// <summary>
        /// Width rectangle
        /// </summary>
        /// <returns>Width rectangle</returns>

        public override double Width() => B;
    }

}