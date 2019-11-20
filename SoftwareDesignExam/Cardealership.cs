using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SoftwareDesignExam
{
    class Cardealership : ThreadProxy
    {
        List<ICar> _cars;
        Random rn;

        private readonly object _lock = new object();

        private bool HasCars { get => _cars.Count > 0; }

        public Cardealership()
        {
            _cars = new List<ICar>();
            rn = new Random();
        }

        protected override void Task()
        {
            Thread.Sleep(rn.Next(50, 400));
         //   MakeCar();
        }
        
        public ICar BuyCar()
        {
            lock (_lock)
            {
                if(_cars.Count > 0)
                {
                    ICar carsToSell = _cars[0];
                    _cars.RemoveAt(0);
                    return carsToSell;
                } else
                {
                    return null;
                }
            }
        } 
        /*
        void MakeCar()
        {
            lock (_lock)
            {
                _
            }
        }*/
    }
}

