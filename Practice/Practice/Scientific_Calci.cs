using System;

namespace ScientificCalculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Scientific Calculator!");

            while (true)
            {
                Console.WriteLine("\nChoose an operation:");
                Console.WriteLine("1. Addition (+)");
                Console.WriteLine("2. Subtraction (-)");
                Console.WriteLine("3. Multiplication (*)");
                Console.WriteLine("4. Division (/)");
                Console.WriteLine("5. Exponentiation (^)");
                Console.WriteLine("6. Square Root (√)");
                Console.WriteLine("7. Exit");

                Console.Write("Enter your choice (1-7): ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 7)
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
                    case 5:
                        result = PerformExponentiation();
                        break;
                    case 6:
                        result = PerformSquareRoot();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 7.");
                        continue; // Restart the loop
                }

                Console.WriteLine("Result: " + result);
            }
        }

        static double PerformAddition()
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            return num1 + num2;
        }

        static double PerformSubtraction()
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            return num1 - num2;
        }

        static double PerformMultiplication()
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            return num1 * num2;
        }

        static double PerformDivision()
        {
            Console.Write("Enter the dividend: ");
            double dividend = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the divisor (non-zero): ");
            double divisor;
            do
            {
                divisor = Convert.ToDouble(Console.ReadLine());
                if (divisor == 0)
                    Console.WriteLine("Error: Division by zero. Please enter a non-zero divisor.");
            } while (divisor == 0);

            return dividend / divisor;
        }

        static double PerformExponentiation()
        {
            Console.Write("Enter the base: ");
            double @base = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the exponent: ");
            double exponent = Convert.ToDouble(Console.ReadLine());

            return Math.Pow(@base, exponent);
        }

        static double PerformSquareRoot()
        {
            Console.Write("Enter the number: ");
            double number;
            do
            {
                number = Convert.ToDouble(Console.ReadLine());
                if (number < 0)
                    Console.WriteLine("Error: Cannot calculate the square root of a negative number. Please enter a non-negative number.");
            } while (number < 0);

            return Math.Sqrt(number);
        }
    }
}