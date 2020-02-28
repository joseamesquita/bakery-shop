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
            Cost = 5;
        }
        public void BreadCost()
        {
            if (Loaf == 1)
            {   
                Console.WriteLine("Your total cost for 1 loaf of bread is: " + Cost);
            }
            else if (Loaf == 2 || Loaf == 3 || Loaf == 4)
            {
                Cost = Loaf * 5; 
                Console.WriteLine("total cost for " + Loaf + "loafs of bread: " + Cost);
            }
            else if (Loaf == 5 || Loaf == 6)
            {
                Cost = 20;
                Console.WriteLine("total cost for " + Loaf + " loafs of bread: " + Cost);
            }
            else 
            {
                Console.WriteLine("Sorry, we are only able to sell a quantity amount between 1-6 loafs of bread per guest.");
            }
           

        }
    }
    public  class Pastry
    {
    
    }
}