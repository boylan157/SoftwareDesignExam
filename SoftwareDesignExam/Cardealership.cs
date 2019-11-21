using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SoftwareDesignExam
{
    class Cardealership : ThreadProxy
    {
        List<ICar> cars;
        Random rn;

        private readonly object _lock = new object();

        public bool HasCars { get => cars.Count > 0; }

        public Cardealership()
        {
            cars = new List<ICar>();
            rn = new Random();
        }

        protected override void Task()
        {
            Thread.Sleep(rn.Next(500));
            MakeCar();
        }
        
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
        
        void MakeCar()
        {
            lock (_lock)
            {
                cars.Add(StockCarFactory.CreateRandomCar());
            }
        }
    }
}

