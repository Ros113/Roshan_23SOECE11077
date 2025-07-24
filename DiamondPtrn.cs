using System;

namespace Tutorial_1
{
    class DiamondPtrn
    {
        static void Main(string[] args)
        {
            int rows = 5;

            for (int i = 1; i <= rows; i++)
            {
                for (int space = 1; space <= rows - i; space++)
                    Console.Write(" ");

                for (int star = 1; star <= 2 * i - 1; star++)
                    Console.Write("*");

                Console.WriteLine();
            }
            
            for (int i = rows - 1; i >= 1; i--)
            {
                for (int space = 1; space <= rows - i; space++)
                    Console.Write(" ");

                for (int star = 1; star <= 2 * i - 1; star++)
                    Console.Write("*");

                Console.WriteLine();
            }
        }
    }
}