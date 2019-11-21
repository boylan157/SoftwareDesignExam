using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignExam
{
    class StockCarFactory
    {

        public static ICar CreateRandomCar()
        {
            Random random = new Random();
            StockCarFactory carFactory = new StockCarFactory();
            ICar car = carFactory.MakeCar(random.Next(0, 4));

            Random randomize = new Random();
            if (randomize.Next(2) == 1)
            {
                car = new CruiseControlDecorator(car);

            }
            else if (randomize.Next(2) == 1)
            {
                car = new ThreeHundredSixtyDegreeCameraDecorator(car);

            }
            else if (randomize.Next(2) == 1)
            {
                car = new AppleCarPlayDecorator(car);

            }

            return car;

        }


        private Car MakeCar(int newStockCar)
           {        
               if (newStockCar.Equals(1))
               {
                   return new SedanStockCar();
               } 
                else if (newStockCar.Equals(2))
               {
                   return new PickupStockCar();
               }
                else
                {
                   return new SuvStockCar();
               }

           }         
         
    }
}
