using System;
using System.Collections.Generic;

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

    public List<double> GetAngles()
    {
      List<double> angleList = new List<double> {};
      double angleAB = (Math.Acos((Math.Pow(SideA, 2) + Math.Pow(SideB, 2) - Math.Pow(SideC, 2)) / (2 * SideA * SideB))) * 180 / Math.PI;
      angleList.Add(Math.Round(angleAB, 2, MidpointRounding.AwayFromZero));
      double angleBC = (Math.Acos((Math.Pow(SideB, 2) + Math.Pow(SideC, 2) - Math.Pow(SideA, 2)) / (2 * SideB * SideC))) * 180 / Math.PI;
      angleList.Add(Math.Round(angleBC, 2, MidpointRounding.AwayFromZero));
      double angleAC = (Math.Acos((Math.Pow(SideA, 2) + Math.Pow(SideC, 2) - Math.Pow(SideB, 2)) / (2 * SideA * SideC))) * 180 / Math.PI;
      angleList.Add(Math.Round(angleAC, 2, MidpointRounding.AwayFromZero));
      return angleList;
    }

  }
}
