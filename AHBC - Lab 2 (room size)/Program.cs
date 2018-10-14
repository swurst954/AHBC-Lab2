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

            while (true)
            {
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
