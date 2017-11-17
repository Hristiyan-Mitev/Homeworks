using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {


            static double Addition(double first, double second)
            {
                double sum = first + second;
                double result = sum + (sum * 0.1);
                return result;
            }

            static double Subtraction(double first, double second)
            {
                double result = 0;

                if (first >= second)
                {
                    result = (first * first) - second;
                }
                else
                {
                    result = (second * second) - first;
                }

                return result;
            }

            static double Multiplication(double first, double second)
            {
                double result = first * Math.Sqrt(second);
                return result;
            }

            static double Division(double first, double second)
            {
                if (second == 0)
                {
                    throw new ArgumentException("Error !!! You can't divide to zero !!!");
                }

                double result = first / second;
                return result;
            }

            static void Main(string[] args)
            {
                try
                {
                    string input = string.Empty;
                    while (true)
                    {
                        double first = 0;
                        double second = 0;
                        string operation = string.Empty;
                        double result = 0;
                        bool operand = true;

                        Console.WriteLine("Do you want to calculate some numbers? (yes or no)");
                        input = Console.ReadLine();
                        if (input == "no")
                        {
                            break;
                        }
                        else if (input == "yes")
                        {
                            Console.WriteLine("Enter first number:");
                            first = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter second number:");
                            second = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter operation:");
                            operation = Console.ReadLine();

                            switch (operation)
                            {
                                case "+":
                                    result = Addition(first, second);
                                    break;
                                case "-":
                                    result = Subtraction(first, second);
                                    break;
                                case "*":
                                    result = Multiplication(first, second);
                                    break;
                                case "/":
                                    try
                                    {
                                        result = Division(first, second);
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                        operand = false;
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Wrong input!");
                                    operand = false;
                                    continue;
                            }

                            if (operand)
                            {
                                Console.WriteLine("Result is " + Math.Round(result, 2).ToString("0.00"));
                                Console.WriteLine();
                                Console.WriteLine("***************************************************");
                                Console.WriteLine("***************************************************");
                                Console.WriteLine("***************************************************");
                                Console.WriteLine();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }


        }
    
}
