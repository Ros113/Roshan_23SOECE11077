using System;

namespace Tutorial_1
{
	class UpperCase
	{
		static void Main(string[] args)
		{
			Console.Write("Enter name: ");
			string name = Console.ReadLine();
			Console.WriteLine(name.ToUpper());
		}
	}
}