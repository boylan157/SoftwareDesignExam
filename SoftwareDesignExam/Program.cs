using System;
using System.Collections.Generic;
using System.Threading;

namespace SoftwareDesignExam
{
    class Program
    {

        public static void Main(String[] args)
        {
            // Calls factory
            /* StockCarFactory carFactory = new StockCarFactory();
             ICar newCar = carFactory.MakeCar("pickup");
             ICar myCar = carFactory.MakeCar("sedan");

             newCar = new CruiseControlDecorator(newCar);
             myCar = new AppleCarPlayDecorator(myCar);
             */

            StockCarFactory fac = new StockCarFactory();

            

            ICar car = fac.CreateRandomCar();
            car = new CruiseControlDecorator(car);
            Console.WriteLine(car.GetDescription());


            /*

             // Creating first Buyers
             Buyer firstBuyer = new Buyer("Daniel", "Boylan", "danboy@email.com", "veien 19", "doylan", 12345678);
             Buyer secondBuyer = new Buyer("Mats", "Meek", "meek@email.com", "gata 116", "mmk", 87654321);


             // Restering and listing users
             List<Buyer> Buyers = new List<Buyer>();
             Buyers.Add(firstBuyer);
             Buyers.Add(secondBuyer);

             foreach (Buyer buyer in Buyers)
             {
                 buyer.DisplayUser();
                 Console.WriteLine();
             }

             //Registering and listing cars
             List<ICar> RegisteredCars = new List<ICar>();
             RegisteredCars.Add(newCar);
             RegisteredCars.Add(myCar);


             foreach (ICar car in RegisteredCars)
             {

                 Console.WriteLine(car.GetDescription() + ", Price: " + car.GetPrice());
             } 



            Console.ReadLine();
        {

        }

    */


        }

     
    }
}
