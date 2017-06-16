using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number:");
            int aNum = Convert.ToInt32(Console.ReadLine());

            #region Practice 1, cube
            /* practice 1
               for (int i = 0; i < aNum; i++)
               {
                   int a = i + 1;
                   Console.WriteLine("The num is {0}, The cube of number {0} is {1}", a, a * a * a);
               }
               */
            #endregion

            #region Practice 2, pyramid of stars\
            //string starString = "*";
            //for (int i = 0; i < 2*aNum; i++)
            //{
            //    int temp = i > aNum ? i - 2 * (i - aNum) : i;

            //    for (int j = 0; j < temp; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region Practice 3 pyramid of number
            //for (int i = 0; i < aNum; i++)
            //{
            //    for (int j = 0; j < i+1; j++)
            //    {
            //        Console.Write(j+1);
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region pyramid of 0101
            //for (int i = 0; i < aNum; i++)
            //{
            //    int temp = (i+1)%2;
            //    for (int j = 0; j < i+1; j++)
            //    {
            //        Console.Write((temp+j) % 2);
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < aNum; i++)
            //{
            //    for (int j = 0; j < i + 1; j++)
            //    {
            //        Console.Write(( i + 1 + j) % 2);
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region 1+11+111
            int sum = 0;
            int temp = 0;
            string tempString = "";
            for (int i = 0; i < aNum; i++)
            {
                int timer = Convert.ToInt32(Math.Pow(10, i));
                temp = timer + temp;
                //Console.Write(temp+"+");
                tempString += (temp + "+");
                sum += temp;
            }
            Console.WriteLine(tempString.TrimEnd('+'));
            Console.WriteLine(sum);

             sum = 0;
             temp = 0;           
            for (int i = 0; i < aNum; i++)
            {
                int timer = 1;
                for (int j = 0; j < i; j++)
                {
                    timer *= 10;
                }
                temp = timer + temp;
                Console.WriteLine(temp);
                sum += temp;
            }
            Console.WriteLine(sum);
            #endregion
        }
    }
}
