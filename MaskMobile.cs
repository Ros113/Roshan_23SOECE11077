using System;

namespace Tutorial_1
{
    class MaskMobile
    {
        static void Main(string[] args)
        {
            Console.Write("Enter mobile number: ");
            string mobile = Console.ReadLine();

            if (mobile.Length >= 5)
            {
                string masked = mobile.Substring(0, mobile.Length - 5) + "XXXXX";
                Console.WriteLine(masked);
            }
            else
            {
                Console.WriteLine("Invalid mobile number");
            }
        }
    }
}