using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Threading;

namespace SoftwareDesignExam
{
    public class Program
    {
        public static void Main(String[] args)
        {
            //initalises cardealership and makes a list with 3 buyers
            Cardealership carDealership = new Cardealership();
            List<Buyer> buyers = new List<Buyer>() { new Buyer("Jeremy", "Clarkson", carDealership), new Buyer("James", "May", carDealership),new Buyer("Richard", "Hammond", carDealership), new Buyer("Tomas", "Sandnes", carDealership) };

            //starts cardealership thread
            carDealership.Start();

            //For each buyer in list buyers start thread
            foreach (var buyer in buyers)
            {
                buyer.Start();
            }
            
            Thread.Sleep(3000);

            //For each buyer in list buyers stop thread
            foreach (var buyer in buyers)
            {
                buyer.Stop();             
            }

            //stop cardealership thread
            carDealership.Stop();


            //Makes console window stay open when running .exe
            Console.WriteLine("\n\t\t Press any key to exit program :)");
            Console.ReadLine();
            
        }         
    }    
}
