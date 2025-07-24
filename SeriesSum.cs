using System;

namespace Tutorial_1
{
    class SeriesSum
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of terms: ");
            int terms = int.Parse(Console.ReadLine());

            Console.Write("Input number: ");
            int num = int.Parse(Console.ReadLine());

            long sum = 0, current = 0;
            string series = "";

            for (int i = 1; i <= terms; i++)
            {
                current = current * 10 + num;
                sum += current;
                series += current + (i < terms ? " + " : "");
            }

            Console.WriteLine(series);
            Console.WriteLine("The Sum is: " + sum);
        }
    }
}