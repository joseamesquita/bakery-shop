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
                int Cost = 5;
                Console.WriteLine("Your total cost for one loaf oof bread is: " + Cost);
            }
        }
    }
    public  class Pastry
    {
    
    }
}