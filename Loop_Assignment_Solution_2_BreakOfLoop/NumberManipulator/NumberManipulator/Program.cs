using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Sum(number));
        }

        private static int Sum(int num)
        {
            int sum = 0;
            for (int i = 0; i < num; i++)
            {
                sum += i+1;
            }
            return sum;
        }
    }
}
