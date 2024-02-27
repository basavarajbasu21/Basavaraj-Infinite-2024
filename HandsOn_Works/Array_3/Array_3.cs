using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Array_3
{
    class Array_3
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5];
            int[] arr2 = new int[5];
            Console.WriteLine("Enter 5 Numbers of array : ");
            for (int i = 0; i < arr1.Length; i++)
            {
                int m = Convert.ToInt32(Console.ReadLine());
                arr1[i] = m;
            }
            Console.Write("The elements of First array are : ");
            Console.ReadLine();
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
                //copy the elements of first array into second array
                arr2[i] = arr1[i];
            }
            Console.WriteLine();
            // Printing the second array
            Console.Write("Second array");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr2[i] + " ");
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
