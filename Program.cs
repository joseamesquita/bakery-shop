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
            Console.WriteLine("Hello, would you like to purchase any bread or pastries? [YES] or [NO] \n");
            string response = Console.ReadLine().ToUpper();
            
            if( response == "YES")
            {
                Program.Order();
                
            }
            else
            {
                Console.WriteLine("Have a great day. We look forward in seeing you soon.");
            }

        }
        public static void Order()
        {
            Console.WriteLine("\n ----- Today's specials include ----- ");
            Console.WriteLine("Bread: Buy 2, get 1 free. A single loaf costs $5.");
            Console.WriteLine("Pastry: Buy 1 for $2 or 3 for $5.");
            Console.WriteLine("------------------------------------- \n");
            Console.WriteLine("How many loaf(s) of bread would you like to purchase?");

            int order = int.Parse(Console.ReadLine());

            Console.WriteLine("------------------------------------- \n");
            Bakery bread = new Bakery(order);
            bread.BreadCost();
        }
    }
}