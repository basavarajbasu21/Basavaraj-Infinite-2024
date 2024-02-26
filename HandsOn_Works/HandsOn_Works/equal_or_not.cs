using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn_Works
{
    class equal_or_not
    {
        static void Main()
        {
            Console.Write("Input 1st number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input 2nd number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine($"{num1} and {num2} are equal");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"{num1} and {num2} are not equal");
                Console.ReadLine();
            }
        }
    }
}
