using System;

namespace Shapes.Models
{
  public class Rectangle
  {
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(double sideLength, double sideWidth)
    {
      Length = sideLength;
      Width = sideWidth;
    }

    public double GetArea()
    {
      return Math.Round(Length * Width, 2, MidpointRounding.AwayFromZero);
    }

    public bool IsSquare()
    {
      if(Length == Width)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}