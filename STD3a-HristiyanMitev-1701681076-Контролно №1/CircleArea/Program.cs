using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
          Random rnd = new Random();
          double height = rnd.Next(33, 187);
          Console.WriteLine("The triangle random heigh is = " + height);
          double s;
          double pi = Math.PI;
          s = pi * height * height;
          Console.WriteLine("The circle area is = " + Math.Round(s, 2));
        }
    }
}
