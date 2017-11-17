using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageNumber
{
    
    class Program
    {
        static void Main(string[] args)
        {   try
            { 
            int sum = 0;
            int br = 0;
            while (true)
            {
                Console.WriteLine("Enter a number:");
                int number = int.Parse(Console.ReadLine());

                if (number == 0)
                {
                    break;
                }
                else if (number >= 1 && number <= 255)

                    if (number % 2 == 0)
                    {
                        sum += number;
                        br++;
                    }
            }


            if (sum == 0)
            {
                Console.WriteLine("There aren't numbers in this diapason [1,255]!!!");
            }
            else
            {
                Console.WriteLine("Finished!!!");

                Console.WriteLine("****************");
            }
            Console.WriteLine();
            Console.WriteLine("Average " + sum / br);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
