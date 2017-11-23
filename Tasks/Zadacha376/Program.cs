using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha376
{
    class Program
    {
        static double Sred(int k)
        {
            Console.WriteLine("3.");
            int sum3 = 0;
            int br3 = 0;

            Random rnd = new Random();
            k = rnd.Next(10, 100);
            for (int i = 0; i < k; i++)
            {
                sum3 += i;
                br3++;

            }

            return (sum3 * 1.0) / br3;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("1.");
            int br = 0;
            double sum = 0;

            Console.WriteLine("Въведете число:");
            int number = int.Parse(Console.ReadLine());

            while (number != 0)
            {
                Console.WriteLine("Въведете число:");
                number = int.Parse(Console.ReadLine());
                if (number > 0)
                {
                    sum += number;
                    br++;
                }

            }

            Console.WriteLine("Средноаритметично: " + sum / br);
            Console.WriteLine("");
            Console.WriteLine("2.");
            int sum2 = 0;
            int number2;
            Console.WriteLine("Да се въведат от клавиатурата 7 числа: ");

            for (int i = 1; i <= 7; i++)
            {
                number2 = int.Parse(Console.ReadLine());
                if (number2 > 300 || number2 < 0)
                {
                    sum2 += number2;
                }
            }

            Console.WriteLine("Сумата: " + sum2);
            Console.Write("a= ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c= ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine($"По формулата е равно на: {Math.Abs(a - b) - (c + a)}");
        }
    }
}
