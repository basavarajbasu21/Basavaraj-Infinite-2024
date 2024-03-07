using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letterToCount
{
    class letterToCount
    {
        static void Main()
        {
            Console.WriteLine("Enter a string:");
            string inputString = Console.ReadLine();

            Console.WriteLine("Enter the letter to count:");
            char letterToCount = Console.ReadKey().KeyChar;
            Console.WriteLine(); 

            int count = CountOccurrences(inputString, letterToCount);
            Console.WriteLine($"The letter '{letterToCount}' appears {count} times in the given string.");

            Console.ReadLine(); 
        }

        static int CountOccurrences(string inputString, char letterToCount)
        {
            int count = 0;
            foreach (char c in inputString)
            {
                if (char.ToUpper(c) == char.ToUpper(letterToCount))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
