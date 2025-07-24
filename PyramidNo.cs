using System;

namespace Tutorial_1
{
    class PyramidNo
    {
        static void Main(string[] args)
        {
            int num = 1, rows = 4;
            for (int i = 1; i <= rows; i++)
            {
                for (int space = 1; space <= rows - i; space++)
                    Console.Write(" ");

                for (int j = 1; j <= i; j++)
                    Console.Write(num++ + " ");

                Console.WriteLine();
            }
        }
    }
}