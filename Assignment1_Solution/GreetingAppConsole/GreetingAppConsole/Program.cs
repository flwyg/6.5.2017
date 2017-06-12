using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Last Name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gender:");
            char gender = Convert.ToChar(Console.ReadLine());

            string title = "";//declar + init
            if (gender == 'M'||gender == 'm')
            {
                title = "Mr.";
            }
            if (gender == 'F'||gender =='f')
            {
                title = "Ms.";
            }

            string greetings = "";
            int hour = DateTime.Now.Hour;
            if (hour > 17 || hour < 8)
            {
                greetings = "Good Evening";
            }
            else
            {
                greetings = "Good Day";
            }

            string greetingMessage = greetings + "! " + title + " " + lastName + ", Age " + age;
            Console.WriteLine();
            Console.WriteLine(greetingMessage);
        }
    }
}
