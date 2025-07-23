using System;
namespace Tutorial_1
{
    class WhileLop
    {
        static void Main(string[] args)
        {
            int num1, res, i;

            Console.WriteLine("Enter a number");
            num1 = Convert.ToInt32(Console.ReadLine());
            i = 1; 

            while (i <= 10)
            {
                res = num1 * i;
                Console.WriteLine("{0} x {1} = {2}", num1, i, res);

                i++; 
            }
            Console.ReadLine();
        }
    }
}
