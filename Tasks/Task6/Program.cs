using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        //Да се въведат едномерен целочислен масив с дължина(брой елементи) в интервала [2,30]. Да се контролира въвежданети на дължината в този интервал.
        //а)Да се напише метод Sredno(k), който връща средноаритметичното на тези елементи на масива, който принадлежат на интервал [-k,k] и се делят на 5 без остатък.
        //Да се въведе от клавиатурата цяло положително число k. Да се извика метод за въведения масив и резултат от него да се отпечата на екрана.
        //б)Да се намери и отпечата на екрана последният минимален елемент на масива и неговият индекс.
        static void Main(string[] args)
        {
            int n;
            
            do
            {
                Console.Write("Въведи брой елементи на масива: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 2 || n > 30);
            int[] a = new int[n];
            Input(a);
            Console.Write("k= ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Средноаритметично: "+Sredno(a, k));
            minimum(a, n);


        }
        static void Input(int[] a)
        {

            for (int i = 0; i < a.Length; i++)
            {

                Console.Write("a[" + i + "]= ");
                a[i] = int.Parse(Console.ReadLine());

            }


        }
        static double Sredno(int[] a, int k)
        {


            double sum = 0;
            int br = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= -k && a[i] <= k && a[i] % 5 == 0)
                {
                    sum = sum + a[i];
                    br++;

                }

            }
            return sum / br;

        }
        static void minimum(int[] a, int n)
        {
            int nomer;
            int min;
            min = a[0];
            nomer = 0;
            for (int i = 1; i < n; i++)
                if (a[i] < min)
                {
                    min = a[i];

                }
            for (int i = 0; i < n; i++)
                if (min == a[i]) nomer = i;
            Console.WriteLine("Последният минимален елемент на масива: "+min);
            Console.WriteLine("Неговият индекс e: "+nomer);
            
        }

    }
}

