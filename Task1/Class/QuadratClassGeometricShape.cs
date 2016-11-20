using System;

namespace Task1
{
    public class QuadratClassGeometricShape : GeometricShapeClass
    {
        public double A { get; }

        /// <summary>
        /// .ctor
        /// </summary>
        /// <param name="a">Side</param>

        public QuadratClassGeometricShape(double a)
        {
            if (a < 0)
                throw new ArgumentException();

            A = a;
        }

        /// <summary>
        /// Perimetr quadrat
        /// </summary>
        /// <returns>Perimetr quadrat</returns>

        public override double Perimeter() => 4 * A;

        /// <summary>
        /// Square quadrat
        /// </summary>
        /// <returns>Square quadrat</returns>

        public override double Square() => A * A;

        /// <summary>
        /// Length quadrat
        /// </summary>
        /// <returns>Length quadrat</returns>

        public override double Length() => A;

        /// <summary>
        /// Width quadrat
        /// </summary>
        /// <returns>Width quadrat</returns>

        public override double Width() => A;
    }
    
}