using System;

namespace Shapes.Models
{
  public class Cube
  {
    public Rectangle Face { get; set; }

    public Cube (Rectangle side)
    {
      Face = side;
    }

    public double GetVolume()
    {
      double length = Face.Length;
      return Math.Round(length * length * length, 2, MidpointRounding.AwayFromZero);
    }

    public double GetSurfaceArea()
    {
      double length = Face.Length;
      return Math.Round((length * length) * 6, 2, MidpointRounding.AwayFromZero);
    }

  }
}