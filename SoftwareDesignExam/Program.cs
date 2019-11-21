using System;
using System.Collections.Generic;
using System.Threading;

namespace SoftwareDesignExam
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Cardealership carDealership = new Cardealership();
            List<Buyer> buyers = new List<Buyer>() { new Buyer("Jeremy", "Clarkson", carDealership), new Buyer("James", "May", carDealership),new Buyer("Richard", "Hammond", carDealership), new Buyer("Tomas", "Sandnes", carDealership) };

            carDealership.Start();

           
            foreach(var buyer in buyers)
            {
                
                buyer.Start();
                
                
            }
            
           
            Thread.Sleep(3000);

            foreach (var buyer in buyers)
            {
                buyer.Stop();             
            }
            
          
            
            

            carDealership.Stop();

        }         
    }    
}
