using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Ninja!");

            Console.WriteLine("Enter Your Name:");
            string usersName = Console.ReadLine();
            Console.WriteLine("Hello, " + usersName + ". Welcome...");

            Console.WriteLine("Press any Key to continue.");
            Console.ReadLine();

            Console.Write("How many hours of sleep did you get last night? ");
            int hoursOfSleep = int.Parse(Console.ReadLine());

            if (hoursOfSleep >= 8)
            {
                Console.WriteLine("Good job, That's a lot of sleep.");
            }
            else if (hoursOfSleep >= 6)
            {
                Console.WriteLine("Not bad, but you need more.");
            }
            else if (hoursOfSleep < 6)
            {
                Console.WriteLine("Dude, you need more sleep");
            }
            else
            {
                Console.WriteLine("I don't know what you wrote.");
            }
            Console.ReadKey();
        }
    }
}
