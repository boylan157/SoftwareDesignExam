using System;
using System.Collections.Generic;
using System.Threading;

namespace SoftwareDesignExam
{
    class Program
    {
        public static void Main(String[] args)
        {
            Cardealership cardealership = new Cardealership();
            List<Buyer> buyers = new List<Buyer>() { new Buyer("Daniel", "Boylan", cardealership), new Buyer("Mats", "Meek", cardealership), new Buyer("Tomas", "Sandnes", cardealership) };

            cardealership.Start();

           
            foreach(var buyer in buyers)
            {
                
                buyer.Start();
                
                
            }
            
           
            Thread.Sleep(3000);

            foreach (var buyer in buyers)
            {
                buyer.Stop();             
            }
            
          
            
            

            cardealership.Stop();

        }         
    }    
}
