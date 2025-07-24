using System;

namespace Tutorial_1
{
    class PyramidPtrn
    {
        static void Main(string[] args)
        {
            int rows = 4;
            for (int i = 1; i <= rows; i++)
            {
                for (int space = 1; space <= rows - i; space++)
                    Console.Write(" ");

                for (int star = 1; star <= i; star++)
                    Console.Write("* ");

                Console.WriteLine();
            }
        }
    }
}