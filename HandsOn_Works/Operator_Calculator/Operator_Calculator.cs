using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Calculator
{
    class Operator_Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Two numbers as input and performs all operations(+, -, *,/) on them and displays the result of that operation: ");
            Console.WriteLine("Test Data");


            while (true)
            {
                Console.WriteLine("\nChoose an operation:");
                Console.WriteLine("1. Addition (+)");
                Console.WriteLine("2. Subtraction (-)");
                Console.WriteLine("3. Multiplication (*)");
                Console.WriteLine("4. Division (/)");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice (1-5): ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 5)
                {
                    Console.WriteLine("Exiting the calculator. Goodbye!");
                    break;
                }

                double result = 0;

                switch (choice)
                {
                    case 1:
                        result = PerformAddition();
                        break;
                    case 2:
                        result = PerformSubtraction();
                        break;
                    case 3:
                        result = PerformMultiplication();
                        break;
                    case 4:
                        result = PerformDivision();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 7.");
                        continue; // Restart the loop
                }

                Console.WriteLine("Expected Output :" + result);
            }
        }

        static double PerformAddition()
        {
            Console.Write("Input first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            return num1 + num2;
        }

        static double PerformSubtraction()
        {
            Console.Write("Input first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            return num1 - num2;
        }

        static double PerformMultiplication()
        {
            Console.Write("Input first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            return num1 * num2;
        }

        static double PerformDivision()
        {
            Console.Write("Input first number: ");
            double dividend = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input second number: ");
            double divisor;
            do
            {
                divisor = Convert.ToDouble(Console.ReadLine());
                if (divisor == 0)
                    Console.WriteLine("Error: Division by zero. Please enter a non-zero divisor.");
            } while (divisor == 0);

            return dividend / divisor;
        }

    }
    
}
