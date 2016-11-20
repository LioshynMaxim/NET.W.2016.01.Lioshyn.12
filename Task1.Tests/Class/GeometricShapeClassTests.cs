using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Task1.Tests.Class
{
    [TestFixture()]
    public class GeometricShapeClassTests
    {
        public IEnumerable<TestCaseData> PerimetrTests
        {
            get
            {
                yield return new TestCaseData(3).Returns(3 * 2 * Math.PI);
                yield return new TestCaseData(5).Returns(5 * 2 * Math.PI);
                yield return new TestCaseData(6).Returns(6 * 2 * Math.PI);
                yield return new TestCaseData(9).Returns(9 * 2 * Math.PI);
            }
        }

        [Test(), TestCaseSource(nameof(PerimetrTests))]
        public double PerimeterTest(double d)
        {
            return new CircleClassGeometricShape(d).Perimeter();
        }

        public IEnumerable<TestCaseData> SquareTests
        {
            get
            {
                yield return new TestCaseData(3).Returns(3 * 3 * Math.PI);
                yield return new TestCaseData(5).Returns(5 * 5 * Math.PI);
                yield return new TestCaseData(6).Returns(6 * 6 * Math.PI);
                yield return new TestCaseData(9).Returns(9 * 9 * Math.PI);
            }
        }

        [Test(), TestCaseSource(nameof(SquareTests))]
        public double SquareTest(double d)
        {
            return new CircleClassGeometricShape(d).Square();
        }
    }
}