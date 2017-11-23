using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        //Да се състави програма, която да пресмята лицето на една от фигурите: кръг, триъгълник или правоъгълник.
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете радиус:");
            double r = double.Parse(Console.ReadLine());
            double s;
            double pi = Math.PI;
            s = pi * r * r;
            Console.WriteLine("Лицето на кръга е: "+s);
            Console.WriteLine();
            double a, b,c,p,s2;
            Console.WriteLine("Въведете страна a:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведете страна b:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведете страна c:");
            c = double.Parse(Console.ReadLine());
            p = (a + b + c) / 2;
            Console.WriteLine("Периметъра на триъгълника е: "+ p);
            s2 = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            Console.WriteLine("Лицето на триъгълника е: "+s2);
            int side1,side2,s3;
            Console.WriteLine("Въведете страна: ");
            side1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведете страна: ");
            side2 = int.Parse(Console.ReadLine());
            s3 = side1 * side2;
            Console.WriteLine("Лицето на правоъгълника е: "+s3);

        }

    }
}
