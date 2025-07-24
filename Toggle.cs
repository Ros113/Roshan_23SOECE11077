using System;

namespace Tutorial_1
{
    class Toggle
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            char[] chars = name.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsUpper(chars[i]))
                    chars[i] = char.ToLower(chars[i]);
                else if (char.IsLower(chars[i]))
                    chars[i] = char.ToUpper(chars[i]);
            }

            Console.WriteLine(new string(chars));
        }
    }
}