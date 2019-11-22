using System;
using System.Collections.Generic;
using System.Threading;

namespace SoftwareDesignExam
{
    class Cardealership : ThreadCarDealership
    {
        List<ICar> cars;
        Random rn;

        //makes a lock
        private readonly object _lock = new object();

        //gets cars count from list cars
        public bool HasCars { get => cars.Count > 0; }

        //making carslist and a random generator
        public Cardealership()
        {
            cars = new List<ICar>();
            rn = new Random();
        }


        //Chooses how long inbetween threads protected
        protected override void Task()
        {
            Thread.Sleep(rn.Next(800));
            MakeCar();
        }
        
        //BuyCar to make Buyer buy cars from list
        public ICar BuyCar()
        {
            lock (_lock)
            {
                if(cars.Count > 0)
                {
                    ICar carsToSell = cars[0];
                    cars.RemoveAt(0);
                    return carsToSell;
                } else
                {
                    return null;
                }
            }
        } 
        
        //MakeCar to make random car with random features from factory
        void MakeCar()
        {
            lock (_lock)
            {
                cars.Add(StockCarFactory.CreateRandomCar());
            }
        }
    }
}

