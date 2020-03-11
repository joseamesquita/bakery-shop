using System;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Hello, would you like to purchase any bread or pastries? [YES] or [NO] \n");
      string response = Console.ReadLine().ToUpper();
      Program.Greeting(response);
    }

    public static void Greeting(string response)
    {

      if (response == "YES")
      {
        Console.WriteLine("\n ----- Today's specials include ----- ");
        Console.WriteLine("Bread: Buy 2, get 1 free. A single loaf costs $5.");
        Console.WriteLine("Pastry: Buy 1 for $2 or 3 for $5.");
        Console.WriteLine("------------------------------------- \n");
        Console.WriteLine("Would you like to order Bread or Pastries? [BREAD] or [PASTRIES] \n");
        string item = Console.ReadLine().ToUpper();
        Program.Order(item);

      }
      else if (response == "NO")
      {
        Console.WriteLine("\n" + "Thank you for stopping by, have a great day!");
      }
      else
      {
        Console.WriteLine("\n" + "Please type [yes] or type [no] to proceed with your order.");
        string respond = Console.ReadLine().ToUpper();
        Greeting(respond);
      }

    }
    public static void Order(string item)
    {
      item.ToUpper();
      string result = "";
      if (item == "BREAD")
      {
        Console.WriteLine("\n" + "How many loaf(s) of bread would you like to purchase?");

        int order = int.Parse(Console.ReadLine());

        Console.WriteLine("------------------------------------- \n");
        Bread bread = new Bread(order);
        bread.BreadCost();

      }

      else if (item == "PASTRIES")
      {
        Console.WriteLine("\n" + "How many pastries would you like to purchase?");

        int order = int.Parse(Console.ReadLine());

        Console.WriteLine("------------------------------------- \n");
        Pastries pastry = new Pastries(order);
        pastry.PastryCost();
      }

      else
      {

        Console.WriteLine("\n" + "Please type BREAD or PASTRIES \n");
        result = Console.ReadLine();
        Order(result.ToUpper());
      }
    }

    public static string BuyMore()
    {
      Console.WriteLine("Would you like to buy more? If yes, type [yes]. If no, type [no]");
      string result = Console.ReadLine().ToUpper();

      while (result == "YES")
      {
        Order(result);
      }
      if (result == "NO")
      {
        Console.WriteLine("\n" + "Thank you for stopping by, have a great day!" + "\n");
        return null;

      }
      else
      {
        Console.WriteLine("type [yes] or [no]");
        return Program.BuyMore();
      }
    }
  }
}