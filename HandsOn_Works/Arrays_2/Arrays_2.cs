using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_2
{
    class Arrays_2
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int total = 0;
            Console.WriteLine(" Enter 10 Elements of the Array");
            for (int i = 0; i < arr.Length; i++)
            {
                int m = Convert.ToInt32(Console.ReadLine());
                arr[i] = m;
                total += arr[i];
            }
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Total : " + total);
            Console.WriteLine("Average value of Array elements : " + (total / 10));
            Console.WriteLine("Minimum marks : " + arr.Min());
            Console.WriteLine("Maximum marks : " + arr.Max());
            Console.WriteLine("______________________________________");
            Console.WriteLine("Array in ascending order");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ",");

            }
            // Display marks in Descending order
            Console.WriteLine("");
            Console.WriteLine("Array in Descending order");
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + ",");
            }
            Console.ReadLine();
        }
    }
}
