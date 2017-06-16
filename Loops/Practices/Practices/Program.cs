using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            Console.WriteLine("1 2 3 4 5 6 7 8 9 10");

            //2.
            int sum = 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10;
            Console.WriteLine("The Sum is "+sum);

            //3.
            /* for loop execution */
            //Ask for a number
            string userInputNumber = Console.ReadLine();
            //Convert userInputNumber to Int
            int count =  Convert.ToInt32(userInputNumber);
            int sum2 = 0;
            //Print out "count" number of times
            //for (int i = 0; i < count; i+=2)
            //{
            //    Console.Write(i);
            //    Console.Write(" ");
            //    sum2 += (i);
            //}
            //int i = 0;
            //while (i<count)
            //{
            //    Console.Write(i+1);
            //    Console.Write(" ");
            //    sum2 += (i+1);

            //    i++;
            //}

            int i = 0;
            do
            {
                Console.Write(i + 1);
                Console.Write(" ");
                sum2 += (i + 1);

                i++;
            } while (i<count);

            Console.WriteLine();
            Console.WriteLine("The Sum is " + sum2);
            Console.ReadLine();
        }
    }
}
