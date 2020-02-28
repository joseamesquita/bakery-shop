using System;

namespace Model
{
    public class Bakery
    {   
        public int Loaf {get; set;}
        public int Cost {get; set;}

        public Bakery(int loaf)
        {
            Loaf = loaf;
        }
        public void BreadCost()
        {
            if (Loaf == 1)
            {   
                Cost = 5;
                Console.WriteLine("Your total cost for one loaf of bread is: " + Cost);
            }
            else if (Loaf % 2 == 0 || Loaf % 3 == 0)
            {
                Cost = Loaf * 5; 
                int free = Loaf / 2;
                Console.WriteLine("Your total cost for the loaf of bread is: " + Cost);
                Console.WriteLine("Your total loafs you order: " + Loaf);
                Console.WriteLine("Total loafs you receive for free: " + free);
                Console.WriteLine("Total loafs you purchased: " + (Loaf + free));
            }
           

        }
    }
    public  class Pastry
    {
    
    }
}