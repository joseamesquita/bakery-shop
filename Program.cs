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
            string response = Console.ReadLine().ToUpper();
            Console.WriteLine("--------------------");

            if( response == "YES")
            {
                Console.WriteLine("Today's specials include, but 2 get 1 free for bread or a single loaf costs $5.");
                Console.WriteLine("For pastries, but 1 for $2 or 3 for $5.");
            }
            else
            {
                Console.WriteLine("Have a great day. We look forward in seeing you soon.");
            }

        }
    }
}