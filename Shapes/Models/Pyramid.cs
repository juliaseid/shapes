using System;
using System.Collections.Generic;

namespace Shapes.Models
{
  public class Pyramid
  {
    public Rectangle Base { get; set; }
    public double Height { get; set; }

    public Pyramid (Rectangle bottom, double height)
    {
      Base = bottom;
      Height = height;
    }

    public double GetSideLength()
    {
      double length = Base.Length;
      double width = Base.Width;
      double diagonal = Math.Sqrt(Math.Pow((length/2), 2) + Math.Pow((width/2), 2));
      return Math.Round(Math.Sqrt(Math.Pow(diagonal, 2) + Math.Pow(Height, 2)), 2, MidpointRounding.AwayFromZero);
    }

    public List<Triangle> GetSideTriangles()
    {
      List<Triangle> pyramidSides = new List<Triangle> { };
      Triangle sides1And3 = new Triangle(Base.Width, GetSideLength(), GetSideLength());
      Triangle sides2And4 = new Triangle(Base.Length, GetSideLength(), GetSideLength());
      pyramidSides.Add(sides1And3);
      pyramidSides.Add(sides2And4);
      return pyramidSides;
    }

    public double GetSurfaceArea()
    {
      return 0;
    }



  }
}