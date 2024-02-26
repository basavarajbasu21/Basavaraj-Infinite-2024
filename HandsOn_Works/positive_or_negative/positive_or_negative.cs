using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace positive_or_negative
{
    class positive_or_negative
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To check whether a given number is positive or negative.");
            Console.Write("Enter Test Data: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine($"{number} is a positive number");
                Console.ReadLine();
            }
            else if (number < 0)
            {
                Console.WriteLine($"{number} is a negative number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"{number} is neither positive nor negative (it's zero)");
                Console.ReadLine();
            }
        }
    }
}
