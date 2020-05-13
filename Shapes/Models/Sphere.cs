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
      return (Math.Pow(CrossSection.Radius, 3) * Math.PI * 4/3);
    }

    public double GetSurfaceArea()
    {
      return (Math.Pow(CrossSection.Radius, 2) * Math.PI * 4);
    }
  }
}