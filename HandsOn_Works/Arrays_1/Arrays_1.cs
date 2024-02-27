using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_1
{
    class Arrays_1
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
            Console.WriteLine("Average value of Array elements : " + (total / 10));
            Console.WriteLine("Min value of the array : " + arr.Min());
            Console.WriteLine("Max value of the array : " + arr.Max());
            Console.ReadLine();
        }
    }
}
