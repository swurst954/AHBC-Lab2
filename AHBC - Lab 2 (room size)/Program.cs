using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHBC___Lab_2__room_size_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");


            // James - nice use of while true!
            while (true)
            {
                // James - I like how you are organizing your code!, its clear what 
                // part of the code is doing what
                Console.Write("Enter Length: ");
                double length = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Width: ");
                double width = Convert.ToDouble(Console.ReadLine());

                double area = length * width;
                double perimeter = (length + width) * 2;

                Console.Write("Area: " + area);
                Console.ReadLine();
                Console.Write("Perimeter: " + perimeter);
                Console.ReadLine();

                Console.WriteLine("Continue? (y/n)");
                string continuing = Console.ReadLine();

                // for comparing strings we typically want to use 
                // string.Equals(), so in your cause you could 
                // coninuing.Equals("y",  StringComparison.OrdinalIgnoreCase)
                if (continuing != "y")
                {
                    Console.WriteLine("Goodbye!");
                    Console.ReadKey();
                    break;
                }

            }
        }
    }
}
