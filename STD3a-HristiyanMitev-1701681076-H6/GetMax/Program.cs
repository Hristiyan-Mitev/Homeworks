using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMax
{
    class Program
    {
        static void getMax(int number1, int number2, int number3)
        {
            if (number1 > number2 && number1 > number3)
            {
                Console.WriteLine("The biggest number is " + number1);
            }
            else if (number2 > number1 && number2 > number3)
            {
                Console.WriteLine("The biggest number is " + number2);
            }
            else
            {
                Console.WriteLine("The biggest number is " + number3);
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Enter first number: ");
            int first = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int second = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter third number: ");
            int third = int.Parse(Console.ReadLine());

            getMax(first, second, third);


        }
    }
}
