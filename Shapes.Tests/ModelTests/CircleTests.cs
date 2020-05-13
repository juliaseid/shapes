using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;


namespace Shapes.Tests
{
  [TestClass]
  public class CircleTests
  {

    [TestMethod]
    public void Circle_GetArea_AreaOfCirle()
    {
      // Arrange
      Circle newCircle = new Circle(4);
      // Act
      double result = newCircle.GetArea();
      // Assert
      Assert.AreEqual(result, 16 * Math.PI);
    }

    [TestMethod]
    public void Circle_GetCircumference_CircumferenceOfCircle()
    {
      Circle newCircle = new Circle(4);
      double result = newCircle.GetCircumference();
      Assert.AreEqual(result, 8 * Math.PI);
    }

  }

}