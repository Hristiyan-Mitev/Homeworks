using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 2076;
            string binNum = Convert.ToString(num, 2);
            Console.WriteLine("Преобразуване числото от двоична бройна система: "+binNum);
            string octalNum = Convert.ToString(num, 8);
            Console.WriteLine("Преобразуване числото от осмична бройна система: "+octalNum);
            string hexNum = Convert.ToString(num, 16);
            Console.WriteLine("Преобразуване числото от шестнайсетична бройна система: "+hexNum);
        }
    }
}
