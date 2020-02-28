using System;
using Model;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            Program.Greeting();
        }

        public static void Greeting()
        {
            Console.WriteLine("Hello, would you like to purchase any bread or pastries? [YES] or [NO]");
            string response = Console.ReadLine();
            Console.WriteLine(response.ToUpper());

        }
    }
}