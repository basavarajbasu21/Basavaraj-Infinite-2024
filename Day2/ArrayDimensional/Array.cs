using System;

class Array
{
    static void Main()
    {
        // Creating a 2-dimensional array
        int[,] twoDArray = new int[3, 4];

        // Initializing the array
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 4; col++)
            {
                twoDArray[row, col] = row * 4 + col + 1;
            }
        }

        // Accessing and printing values
        Console.WriteLine("Values in the 2D array:");
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 4; col++)
            {
                Console.Write(twoDArray[row, col] + "\t");
            }
            Console.WriteLine(); // Move to the next row
            Console.ReadLine();
        }
    }
}