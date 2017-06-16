using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToStringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            double i = 9.90989;
            Console.WriteLine(AddStars(i.ToString()));
        }
        static string AddStars(string line)
        {
            return line + "*****";
        }
    }
}
