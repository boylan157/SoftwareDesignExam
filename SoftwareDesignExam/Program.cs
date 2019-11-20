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
            Car newCar = carFactory.MakeStockCar("pickup");


            // Creating first Buyers
            User firstBuyer = new Buyer("Daniel", "Boylan", "danboy@email.com", "veien 19", "doylan", 12345678);
            User secondBuyer = new Buyer("Mats", "Meek", "meek@email.com", "gata 116", "mmk", 87654321);


            // Restering and listing users
            List<User> RegisteredUsers = new List<User>();
            RegisteredUsers.Add(firstBuyer);
            RegisteredUsers.Add(secondBuyer);

            foreach (User user in RegisteredUsers)
            {
                user.DisplayUser();
                Console.WriteLine();
            }

            //Registering and listing cars
            List<Car> RegisteredCars = new List<Car>();
            RegisteredCars.Add(newCar);
            

            foreach (Car car in RegisteredCars)
            {
                car.DisplayCar();
                Console.WriteLine();
            }



        }
    }
}
