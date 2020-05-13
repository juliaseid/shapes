using System;
namespace Shapes.Models
{
  public class Sphere
  {
    public Circle CrossSection { get; set; }

    public Sphere (Circle radius)
    {
      CrossSection = radius;
    }

    public double GetVolume()
    {
      return Math.Round((Math.Pow(CrossSection.Radius, 3) * Math.PI * 4/3), 2, MidpointRounding.AwayFromZero);
    }

    public double GetSurfaceArea()
    {
      return Math.Round((Math.Pow(CrossSection.Radius, 2) * Math.PI * 4), 2, MidpointRounding.AwayFromZero);
    }
  }
}