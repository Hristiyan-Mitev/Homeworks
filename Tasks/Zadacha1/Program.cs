using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 2076;
            string binNum = Convert.ToString(num, 2);
            Console.WriteLine("Преобразуване десетична бройна система в двоична: " + binNum);
            string octalNum = Convert.ToString(num, 8);
            Console.WriteLine("Преобразуване десетична бройна система в осмична: " + octalNum);
            string hexNum = Convert.ToString(num, 16);
            Console.WriteLine("Преобразуване десетична бройна система в шестнайсетична: " + hexNum); 
        }
    }
}
