using System;

namespace Tutorial_1
{
    class GenderPrefix
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter gender (M/F): ");
            char gender = Console.ReadLine()[0];

            string prefix = (gender == 'M' || gender == 'm') ? "Mr. " : "Ms. ";
            Console.WriteLine(prefix + name);
        }
    }
}