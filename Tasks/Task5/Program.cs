using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {//1.Да се въведат от клавитуарата произволно число k и произволен брой числа (за край на въвеждането служи числото 0). 
        // Да се отпечата средноаритметичното на тези от тях, който са положителни.
        //2. Да се въведат от клавиатурата 7 числа. Да се намери и отпечата на екрана сумата на тези от тях, който отговарят на следното условие: да са отрицателни или
        // по-големи от 300.
        //3. Да се създаде метод Sred(k), който генерира k на брой случайни цели числа и като резултат връща средноаритметичното от тях, който са в интервала [10,100].
        //В главния метод да се въведат 3 цели положителни числа a,b и c. Да се намери и отпечата: Sred(|a-b|) - Sred(c+a).
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
            Console.WriteLine($"По формулата е равно на: {Math.Abs(a - b)-(c+a)}");
        }
        }
}



