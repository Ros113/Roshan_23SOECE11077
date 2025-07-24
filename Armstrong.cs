using System;

namespace Tutorial_1
{
    class Armstrong
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            int temp = num, sum = 0, rem;
            int digits = num.ToString().Length;

            while (temp > 0)
            {
                rem = temp % 10;
                sum += (int)Math.Pow(rem, digits);
                temp /= 10;
            }

            if (num == sum)
                Console.WriteLine("Armstrong number");
            else
                Console.WriteLine("Not an Armstrong number");
        }
    }
}