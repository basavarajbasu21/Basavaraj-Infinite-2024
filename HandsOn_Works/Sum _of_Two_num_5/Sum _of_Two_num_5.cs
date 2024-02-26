using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Two_num_5
{
    class Sum_of_Two_num_5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To compute the sum of two given integers. If two values are the same, return the triple of their sum: ");
            
            Console.Write("Input 1st number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input 2nd number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());



            if (num1 == num2)
            {
                int result = 3 * (num1 + num2);
                Console.WriteLine($"{num1} and {num2} are equal: {result}");
                Console.ReadLine();


            }
            else
            {
                int result = num1 + num2;
                Console.WriteLine($"Sum of {num1} and {num2} is: {result}");
                Console.ReadLine();
            }
        }
    }
}
