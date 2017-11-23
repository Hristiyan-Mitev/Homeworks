using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
     //Съставете програма, която при всяко срещане на низа "A*A" в низа S се заменя с низа "sqr(A)". Забележете, че низът "А*А" може да се среща няколко пъти.
        static void Main(string[] args)
        {
           string s = "A*AASFSAFSAA*A";
            string z = s.Replace("A*A", "sqr(A)");
            Console.WriteLine(s+" "+ z);
        }
    }
}
