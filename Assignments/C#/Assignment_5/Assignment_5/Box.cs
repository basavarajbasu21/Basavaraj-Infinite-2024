using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{ 
    class Box
    {
        public double Length { get; set; }
        public double Breadth { get; set; }

        public Box(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }

        public static Box Add(Box box1, Box box2)
        {
            double newLength = box1.Length + box2.Length;
            double newBreadth = box1.Breadth + box2.Breadth;
            return new Box(newLength, newBreadth);
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Dimensions for Box 1:");
            double length1 = Convert.ToDouble(Console.ReadLine());
            double breadth1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Dimensions for Box 2:");
            double length2 = Convert.ToDouble(Console.ReadLine());
            double breadth2 = Convert.ToDouble(Console.ReadLine());

            Box box1 = new Box(length1, breadth1);
            Box box2 = new Box(length2, breadth2);

            Box resultBox = Box.Add(box1, box2);

            Console.WriteLine("Dimensions of the resulting box:");
            Console.WriteLine($"Length: {resultBox.Length}");
            Console.WriteLine($"Breadth: {resultBox.Breadth}");
            Console.ReadLine();
        }
    }
}
