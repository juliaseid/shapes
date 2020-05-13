using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class PyramidTests
  {

    [TestMethod]
    public void Pyramid_GetSideLength_SideLengthOfPyramid()
    {
      // Arrange
      Rectangle newRectangle = new Rectangle(6, 8);
      Pyramid newPyramid = new Pyramid(newRectangle, 4);
      // Act
      double result = newPyramid.GetSideLength();
      // Assert
      Assert.AreEqual(result, 6.4);
    }

    [TestMethod]
    public void Pyramid_GetSideTriangles_SidesOfPyramid()
    {
      Rectangle newRectangle = new Rectangle(6, 8);
      Pyramid newPyramid = new Pyramid(newRectangle, 4);
      Triangle side1and3 = new Triangle(6, 6.4, 6.4);
      Triangle side2and4 = new Triangle(8, 6.4, 6.4);
      List<Triangle> testSides = new List<Triangle> {side1and3, side2and4};
      List<Triangle> result = newPyramid.GetSideTriangles();
      
      CollectionAssert.AreEqual(testSides, result);
    }

    // [TestMethod]
    // public void Pyramid_GetSurfaceArea_SurfaceAreaOfPyramid()
    // {
    //   Rectangle newRectangle = new Rectangle(6, 8);
    //   Pyramid newPyramid = new Pyramid(newRectangle, 4);
    //   double result = newPyramid.GetSurfaceArea();
    //   Assert.AreEqual(result, 69.29);
    // }

  }
}