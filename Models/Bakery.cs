using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int Loaf { get; set; }
    public int Cost { get; set; }

    public Bread(int loaf)
    {
      Loaf = loaf;
      Cost = 5;
    }
    public void BreadCost()
    {
      if (Loaf == 1)
      {
        Console.WriteLine("Your total cost for " + Loaf + "loaf of bread is: " + "$" + Cost);
      }
      else if (Loaf == 2)
      {
        Loaf++;
        Console.WriteLine("Your total cost for " + Loaf + " loafs of bread is: " + "$" + Cost + "\n");
      }
      else if (Loaf % 3 == 0)
      {
        int free = (Loaf / 3);
        Cost = ((Loaf - free) * 5);
        Console.WriteLine("Your total cost for " + Loaf + " loafs of bread is: " + "$" + Cost + "\n");
      }
      else
      {
        int free = (Loaf / 3);
        Cost = ((Loaf - free) * 5);
        Console.WriteLine("Your total cost for " + Loaf + " loafs of bread is: " + "$" + Cost + "\n");
      }
      Program.BuyMore();
    }
  }
  public class Pastries
  {
    public int Pastry { get; set; }
    public int Cost { get; set; }

    public Pastries(int pastry)
    {
      Pastry = pastry;
      Cost = 0;
    }
    public void PastryCost()
    {
      if (Pastry == 1)
      {
        Cost += 2;
        Console.WriteLine("Your total cost for 1 pastry: " + "$" + Cost);
      }
      else if (Pastry == 2)
      {
        Cost += 4;
        Console.WriteLine("total cost for " + Pastry + " pastries: " + "$" + Cost + "\n");
      }
      else if (Pastry % 3 == 0)
      {
        int free = (Pastry / 3);
        Cost = ((Pastry * 2) - free);
        Console.WriteLine("total cost for " + Pastry + " pastries: " + "$" + Cost + "\n");
      }
      else
      {
        int free = (Pastry / 3);
        Cost = ((Pastry * 2) - free);
        Console.WriteLine("total cost for " + Pastry + " pastries: " + "$" + Cost + "\n");
      }
      Program.BuyMore();
    }
  }
}