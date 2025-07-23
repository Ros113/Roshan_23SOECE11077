using System;

namespace Tutorial_1
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int n, fact = 1;          // Declare variables for number and factorial
            Console.WriteLine("Enter Number : ");  // Prompt user for input
            string str = Console.ReadLine();     // Read input as string
            n = Convert.ToInt32(str);             // Convert string to integer

            // Calculate factorial using loop
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;      // Multiply factorial by each number up to n
            }

            Console.WriteLine("Factorial : {0}", fact);  // Output result
            Console.Read();           // Wait for user input before closing
        }
    }
}