using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha361
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "A*AASFSAFSAA*A";
            string z = s.Replace("A*A", "sqr(A)");
            Console.WriteLine(s + " " + z);
        }
    }
}
