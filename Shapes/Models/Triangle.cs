using System;

namespace Shapes.Models
{
  public class Triangle
  {
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC {get; set; }
    public double Base {get; set; }

    public Triangle(double sideA, double sideB, double sideC)
    {
      SideA = sideA;
      SideB = sideB;
      SideC = sideC;
    }

    public double GetHeight(double myBase)
    {
      Base = myBase;
      return 0.5 * Math.Sqrt((SideA + SideB + SideC) * (SideB + SideC - SideA) * (SideA - SideB + SideC) * (SideA + SideB - SideC)) / myBase;
    } 

    public double GetArea()
    {
      return 0.25 * Math.Sqrt((SideA + SideB + SideC) * (SideB + SideC - SideA) * (SideA - SideB + SideC) * (SideA + SideB - SideC));
    }

    public double GetAngle(double sideOne, double sideTwo, double sideThree)
    {
      return 0;
    }

  }
}
