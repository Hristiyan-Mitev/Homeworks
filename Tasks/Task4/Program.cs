using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се отпечатат следните фигури: *
                                            //**
                                           //***
                                          //****
                                         //*****
                                        //******
                                       //******* 
            int val = 1;
            int i, j, k;
            for (i = 7; i >= val; i--)
            {
                for (j = 1; j <= val - i; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            
        }
    }
}
