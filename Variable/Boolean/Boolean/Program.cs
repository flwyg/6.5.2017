using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeek = "Saturday";
            bool isSaturday = dayOfWeek=="Saturday";
            double d = 3.22;
            int i;
            i = (int)d;
            Console.WriteLine(i);

            string aString = "2.22";
            double aDouble = Convert.ToDouble(aString);
            i = Convert.ToInt32(aDouble);
            Console.WriteLine(aDouble);
            Console.WriteLine(i);


        }
    }
}
