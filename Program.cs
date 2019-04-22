using System;
using System.Collections.Generic;

namespace TriangleTracker {

  public class Program
  {
    public static void Main()
    {
    Console.WriteLine("Enter length of side one: ");
    string stringTriangleSide1 = Console.ReadLine();
    int TriangleSide1 = int.Parse(stringTriangleSide1);

    Console.WriteLine("Enter length of side one: ");
    string stringTriangleSide2 = Console.ReadLine();
    int TriangleSide2 = int.Parse(stringTriangleSide2);

    Console.WriteLine("Enter length of side one: ");
    string stringTriangleSide3 = Console.ReadLine();
    int TriangleSide3 = int.Parse(stringTriangleSide3);

    if (TriangleSide1 > TriangleSide2 + TriangleSide3 || TriangleSide2 > TriangleSide1 + TriangleSide3 || TriangleSide3 > TriangleSide1 + TriangleSide2)
    {
      Console.WriteLine("Not a triangle");
    }
      else if (TriangleSide1 == TriangleSide2 == TriangleSide3)
    {
      Console.WriteLine("This is an Equilateral triangle.")
    }
      else if (TriangleSide1 == TriangleSide2 || TriangleSide2 == TriangleSide3 || TriangleSide1 == TriangleSide3)
      {
        Console.WriteLine("This is an Isosceles triangle.")
      }




    }
  }
}
