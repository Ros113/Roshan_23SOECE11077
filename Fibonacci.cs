using System;

namespace Tutorial_1
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3;
            Console.Write(n1 + " " + n2 + " ");

            for (int i = 2; i < 11; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}