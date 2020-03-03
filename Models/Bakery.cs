using System;

namespace Model
{
  public class Bakery
  {
    public int Loaf { get; set; }
    public int Cost { get; set; }

    public Bakery(int loaf)
    {
      Loaf = loaf;
      Cost = 5;
    }
    public void BreadCost()
    {
      if (Loaf == 1)
      {
        Console.WriteLine("Your total cost for 1 loaf of bread is: " + "$" + Cost);
      }
      else if (Loaf == 2 || Loaf == 3 || Loaf == 4)
      {
        Cost = 10;
        Console.WriteLine("total cost for " + Loaf + " loafs of bread: " + "$" + Cost + "\n");
      }
      else if (Loaf == 5 || Loaf == 6)
      {
        Cost = 20;
        Console.WriteLine("total cost for " + Loaf + " loafs of bread: " + "$" + Cost + "\n");
      }
      else
      {
        Console.WriteLine("Sorry, we are only able to sell a quantity amount between 1-6 loafs of bread per guest. \n");
      }
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
      else if (Pastry == 3)
      {
        Cost += 5;
        Console.WriteLine("total cost for " + Pastry + " pastries: " + "$" + Cost + "\n");
      }
      else if (Pastry == 4)
      {
        Cost += 7;
        Console.WriteLine("total cost for " + Pastry + " pastries: " + "$" + Cost + "\n");
      }
      else if (Pastry == 5)
      {
        Cost += 9;
        Console.WriteLine("total cost for " + Pastry + " pastries: " + "$" + Cost + "\n");
      }
      else if (Pastry == 6)
      {
        Cost += 10;
        Console.WriteLine("total cost for " + Pastry + " pastries: " + "$" + Cost + "\n");
      }
      else
      {
        Console.WriteLine("Sorry, we are only able to sell a quantity amount between 1-6 pastries per guest. \n");
      }
    }
  }
}