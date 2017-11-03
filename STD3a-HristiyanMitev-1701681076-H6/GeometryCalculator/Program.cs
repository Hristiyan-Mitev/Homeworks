using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class Program
    {
        static void triangle(double side, double height)
        {
            double area;
            area = side * height / 2;
            Console.WriteLine("The area of the triangle is = {0:0.00}", area);
        }

        static void square(double side)
        {
            double area;
            area = side * side;
            Console.WriteLine("The area of the square is = {0:0.00}", area);
        }

        static void degreeToRadians(int degree)
        {
            double radians;
            const double pi = Math.PI;
            radians = (pi / 180) * degree;
            Console.WriteLine("Your degrees in radians are = " + radians);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Choose option (triangle, square or radians)");
            string Figure = Console.ReadLine();
            if (Figure == "triangle")
            {

                Console.WriteLine("Enter side: ");
                double TriangleSide = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter height: ");
                double TriangleHeight = double.Parse(Console.ReadLine());
                triangle(TriangleSide, TriangleHeight);
            }


            if (Figure == "square")
            {

                Console.WriteLine("Enter side: ");
                double SquareSide = double.Parse(Console.ReadLine());
                square(SquareSide);
            }

            if (Figure == "radians")
            {
                Console.WriteLine("Enter the degrees you want to transform in radians: ");
                int degree = int.Parse(Console.ReadLine());
                degreeToRadians(degree);
            }

        }
    }
}
