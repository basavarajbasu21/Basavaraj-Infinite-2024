using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication_table
{
    class multiplication_table
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Data: ");
            Console.Write("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Expected Output: ");

            for (int i = 0; i <= 10; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");

            }
            Console.ReadLine();


        }
    }
}
