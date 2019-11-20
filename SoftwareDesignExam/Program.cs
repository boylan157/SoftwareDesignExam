using System;
using System.Collections.Generic;

namespace SoftwareDesignExam
{
    class Program
    {

        public static void Main(String[] args)
        {
            // Calls factory
            StockCarFactory carFactory = new StockCarFactory();
            Car newCar = carFactory.MakeCar("pIckup");
            Car myCar = carFactory.MakeCar("sedan");


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
            List<Car> RegisteredCars = new List<Car>();
            RegisteredCars.Add(newCar);
            RegisteredCars.Add(myCar);
            

            foreach (Car car in RegisteredCars)
            {
                car.DisplayCar();
                Console.WriteLine();
            }



        }
    }
}
