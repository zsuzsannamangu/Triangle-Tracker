using System;

namespace TriangleTracker
{

  class Triangle
  {
    private int A;
    private int B;
    private int C;

    public Triangle(int a, int b, int c)
    {
      A = a;
      B = b;
      C = c;
    }

  public string Type()
    {
      // if((A < B + C) && (B < A + C) && (C < B + A))
      // {
      //   if(A == B && A == C && B == C)
      //   {
      //     return "an Equilateral Triangle";
      //   }
      //   else if(A == B || A == C || B == C)
      //   {
      //     return "an Isosceles Triangle";
      //   }
      //     return "a scalene Triangle";
      // }
      // else
      // {
      //   return "not a triangle";
      if ((A > B + C) || (B > A + C) || (C > A + B))
      {
        Console.WriteLine("Not a triangle");
        return "Not a triangle";
      }
      else if (A == B && B == C)
      {
        Console.WriteLine("Equilateral triangle");
        return "Equilateral triangle";
      }
      else if ((A == B) || (B == C) || (A == C))
      {
        Console.WriteLine("Isosceles triangle");
        return "Isosceles triangle";
      }
      else
      {
        Console.WriteLine("Scalene triangle");
        return "Scalene triangle";
      }
    }
  }
}
//
// using System;
//
// namespace Triangles
// {
//
// class Triangle
// {
//   private int A;
//   private int B;
//   private int C;
//
// //access modifyer: public
//   public Triangle(int a, int b, int c) //constructor that takes multiple parameters
//   {
//   //object's properties = constructor method's parameters
//     A = a;
//     B = b;
//     C = c;
//   }
//
//   public string Type()
//     {
//       if((A < B + C) && (B < A + C) && (C < B + A)){
//         if(A == B && A == C && B == C)
//         {
//           return "an Equilateral Triangle";
//         }else if(A == B || A == C || B == C){
//           return "an Isosceles Triangle";
//         }
//         return "a scalene Triangle";
//       }else{
//         return "not a triangle";
//       }
//     }
//   }
// }
