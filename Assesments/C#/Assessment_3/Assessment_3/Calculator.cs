using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Operation
{
    delegate int CalculatorOperation(int a, int b);

    class Program
    {
        static void Main()
        {
            CalculatorOperation addition = Add;
            CalculatorOperation subtraction = Subtract;
            CalculatorOperation multiplication = Multiply;

            Console.WriteLine("-------- Calculator --------");

            Console.WriteLine("Enter two integers:");
            Console.Write("First integer: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Second integer: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Addition Result: {addition(num1, num2)}");

            Console.WriteLine($"Subtraction Result: {subtraction(num1, num2)}");

            Console.WriteLine($"Multiplication Result: {multiplication(num1, num2)}");

            Console.ReadLine();
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
