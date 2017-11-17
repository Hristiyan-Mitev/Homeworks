using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Random n = new Random();
            number = n.Next(1, 999);
            Console.WriteLine("The random number is " + number);

            if ((number >= 1) && (number <= 300))
            {
                Console.WriteLine("For a month they will save " + Math.Round((5.1 * Math.Sqrt(number)), 4) + " dollars.");
            }
            if ((number >= 301) && (number <= 600))
            {
                Console.WriteLine("For a month they will save " + Math.Round((10.098 * Math.Sqrt(number)), 4) + " dollars.");
            }
            if ((number >= 601) && (number <= 999))
            {
                Console.WriteLine("For a month they will save " + Math.Round((100.00001 * Math.Sqrt(number)), 4) + " dollars.");
            }


        }
    }
}
