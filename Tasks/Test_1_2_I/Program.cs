using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_1_2_I
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("x= ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y= ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("z= ");
            double z = double.Parse(Console.ReadLine());
            Console.WriteLine("Изразът е: " + (Math.Pow(x, 7) * y * z - 3.3 * Math.Abs(x + Math.Pow(Math.Sqrt(y), 4))) / (Math.Pow(10, 7) + (Math.Pow(Math.Log(4), 1))));
        }

    }
}
