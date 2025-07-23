using System;

namespace Tutorial_1
{
    class Profile
    {
        static void Main(string[] args)
        {
            // Collect user information
            Console.WriteLine("Enter Your Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Your Date of Birth (DD/MM/YYYY): ");
            string dob = Console.ReadLine();

            Console.WriteLine("Enter Your Address: ");
            string address = Console.ReadLine();

            Console.WriteLine("Enter Your City: ");
            string city = Console.ReadLine();

            Console.WriteLine("Enter Your Pincode: ");
            string pincode = Console.ReadLine();

            Console.WriteLine("Enter Your State: ");
            string state = Console.ReadLine();

            Console.WriteLine("Enter Your Country: ");
            string country = Console.ReadLine();

            Console.WriteLine("Enter Your Email: ");
            string email = Console.ReadLine();

            
            Console.WriteLine("\n\n----- User Profile -----");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Date of Birth: {dob}");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"City: {city}");
            Console.WriteLine($"Pincode: {pincode}");
            Console.WriteLine($"State: {state}");
            Console.WriteLine($"Country: {country}");
            Console.WriteLine($"Email: {email}");
            
        }
    }
}