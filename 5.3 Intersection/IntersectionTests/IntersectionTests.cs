using _5._3_Intersection;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _5._3_Intersection.Tests
{
    [TestClass()]
    public class IntersectionTests
    {
        [TestMethod()]
        public void GenerateCoordinatesTest()
        {
            Point[] routeCoordinates=new Point[1];
            Point startingPoint = new Point(0, 0);
            Point[] testCoordinates = { new Point(0,0), new Point(0, 1), new Point(0, 2), new Point(1, 2), new Point(1, 1), new Point(0, 1), new Point(0, 0), };
            Directions[] route = { Directions.Up, Directions.Up, Directions.Right,Directions.Down,Directions.Left,Directions.Down };
            Intersection.GenerateCoordinates(ref routeCoordinates, route, startingPoint);
            CollectionAssert.AreEqual(routeCoordinates,testCoordinates);

        }
    }
}

