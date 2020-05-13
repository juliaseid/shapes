using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests 
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void Triangle_GetHeight_HeightOfTriangle()
    {
      Triangle newTriangle = new Triangle (3, 4, 5);
      double result = newTriangle.GetHeight(3);
      double result2 = newTriangle.GetHeight(4);
      double result3 = newTriangle.GetHeight(5);
      Assert.AreEqual(result, 4);
      Assert.AreEqual(result2, 3);
      Assert.AreEqual(result3, Math.Sqrt((3+4+5)*(-3+4+5)*(3-4+5)*(3+4-5))*0.5 / 5);
    }

    [TestMethod]
    public void Triangle_GetArea_AreaOfTriangle()
    {
      Triangle newTriangle = new Triangle(3, 4, 5);
      double result = newTriangle.GetArea();
      Console.WriteLine(newTriangle.GetArea());
      Assert.AreEqual(result, (3*4*.5));
    }

    [TestMethod]
    public void Triangle_GetAngles_AnglesOfTriangle()
    {
      Triangle newTriangle = new Triangle(3, 4, 5);
      List<double> testList = newTriangle.GetAngles();
      foreach (double angle in testList)
      {
        Console.WriteLine(angle);  
      }
      List<double> result = new List<double> {90, 36.87, 53.13};
      CollectionAssert.AreEqual(testList, result);
    }

  }
}