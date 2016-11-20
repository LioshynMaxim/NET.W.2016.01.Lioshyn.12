using System;

namespace Task1
{
    public class CircleClassGeometricShape : GeometricShapeClass
    {
        public double Radius { get; }

        /// <summary>
        /// .ctor
        /// </summary>
        /// <param name="radius">Radius circle</param>

        public CircleClassGeometricShape(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Circumference
        /// </summary>
        /// <returns>Circumference</returns>

        public override double Perimeter() => 2 * Math.PI * Radius;

        /// <summary>
        /// Circle area
        /// </summary>
        /// <returns>Circle area</returns>

        public override double Square() => Radius * Radius * Math.PI;

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