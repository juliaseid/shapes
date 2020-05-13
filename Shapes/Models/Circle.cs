using System;

namespace Shapes.Models
{
  public class Circle
  {
    public int Radius { get; set; }

    public Circle(int radius)
    {
      Radius = radius;
    }

    public double GetArea()
    {
      return Math.Pow(Radius, 2) * Math.PI ;
    }

    public double GetCircumference()
    {
      return Radius * 2 * Math.PI;
    }
    

  }
}