using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakOfLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            char answer = 'z';

            //Do While Loop
            //do
            //{
            //Console.WriteLine("What's 3+5?\na. 5\nb. 6\nc. 7\nd. 8");
            //    answer = Console.ReadKey().KeyChar; //Convert.ToChar(Console.ReadKey().Key);
            //    Console.WriteLine();
            //    switch (answer)
            //    {
            //        case 'A':
            //        case 'B':
            //        case 'C':
            //        case 'a':
            //        case 'b':
            //        case 'c':
            //            Console.WriteLine("Incorrect");
            //            break;
            //        case 'D':
            //        case 'd':
            //            Console.WriteLine("Correct");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid Answer");
            //            break;
            //    } 
            //} while (!(answer == 'D'||answer =='d'));//while(answer!='D'&& answer!='d');


            // While Loop
            //while (answer != 'D' && answer != 'd')
            //{
            //    Console.WriteLine("What's 3+5?\na. 5\nb. 6\nc. 7\nd. 8");
            //    answer = Console.ReadKey().KeyChar; //Convert.ToChar(Console.ReadKey().Key);
            //    Console.WriteLine();
            //    switch (answer)
            //    {
            //        case 'A':
            //        case 'B':
            //        case 'C':
            //        case 'a':
            //        case 'b':
            //        case 'c':
            //            Console.WriteLine("Incorrect");
            //            break;
            //        case 'D':
            //        case 'd':
            //            Console.WriteLine("Correct");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid Answer");
            //            break;
            //    }
            //}

            //For
            for (;;)
            {
                Console.WriteLine("What's 3+5?\na. 5\nb. 6\nc. 7\nd. 8");
                answer = Console.ReadKey().KeyChar; //Convert.ToChar(Console.ReadKey().Key);
                Console.WriteLine();
                switch (answer)
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
                        goto Exit;
                        break;
                    default:
                        Console.WriteLine("Invalid Answer");
                        break;
                }
            }
            Exit:
            Console.ReadKey();
        }
    }
}
