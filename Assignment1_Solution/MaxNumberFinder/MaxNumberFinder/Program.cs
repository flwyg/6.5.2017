using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumberFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Frist Number:");
            decimal firstNumber = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("second Number:");
            decimal secondNumber = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Frist Number:");
            decimal thirdNumber = Convert.ToDecimal(Console.ReadLine());
            decimal max = 0;
            //first
            #region first method
            //if(firstNumber>secondNumber)
            //{               
            //    max = firstNumber;
            //}
            //else
            //{
            //    max = secondNumber;
            //}

            //if (max < thirdNumber)
            //{
            //    max = thirdNumber;
            //}
            #endregion
            #region second method
            //if (firstNumber >= secondNumber && firstNumber >= thirdNumber)
            //{
            //    max = firstNumber;
            //}
            //else if (secondNumber >= firstNumber && secondNumber >= thirdNumber)
            //{
            //    max = secondNumber;
            //}
            //else
            //{
            //    max = thirdNumber;
            //}
            #endregion
            #region third method
            if (firstNumber >= secondNumber)
            {
                if(firstNumber>thirdNumber)
                {
                    max = firstNumber;
                }
                else
                {
                    max = thirdNumber;
                }
            }
            //...
            #endregion
            Console.WriteLine("The Max is: "+max);
        }
    }
}
