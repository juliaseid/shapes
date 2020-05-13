using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;


namespace Shapes.Tests
{
  [TestClass]
  public class SphereTests
  {

    [TestMethod]
    public void Sphere_GetVolume_VolumeOfSphere()
    {
      Circle newCircle = new Circle(4);
      Sphere newSphere = new Sphere(newCircle);
      double result = newSphere.GetVolume();
      Assert.AreEqual(result, (Math.Pow(4, 3) * Math.PI * 4/3));
    }

    [TestMethod]
    public void Sphere_GetSurfaceArea_SurfaceAreaOfSphere()
    {
      Circle newCircle = new Circle(4);
      Sphere newSphere = new Sphere(newCircle);
      double result = newSphere.GetSurfaceArea();
      Assert.AreEqual(result, (Math.Pow(4, 2) * Math.PI * 4));
    }


  }
}
