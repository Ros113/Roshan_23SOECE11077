using System;

namespace Tutorial_1
{
    class TraingleIncrement
    {
        static void Main(string[] args)
        {
            int num = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num++ + " ");
                }
                Console.WriteLine();
            }
        }
    }
}