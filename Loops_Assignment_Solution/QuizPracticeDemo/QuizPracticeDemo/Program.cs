using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizPracticeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's 3+5?\na. 5\nb. 6\nc. 7\nd. 8");
            char answer = Console.ReadKey().KeyChar; //Convert.ToChar(Console.ReadKey().Key);
            Console.WriteLine();
            switch(answer)
            {
                case 'A':
                case 'B':
                case 'C':
                case 'a':
                case 'b':
                case 'c':
                    Console.WriteLine("Incorrect");
                    break;
                case 'D':
                case 'd':
                    Console.WriteLine("Correct");
                    break;
                default:
                    Console.WriteLine("Invalid Answer");
                    break;
            }
        }
    }
}
