using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignExam
{
    class StockCarFactory
    {

        public ICar CreateRandomCar()
        {
            Random random = new Random();
            StockCarFactory carFactory = new StockCarFactory();
            ICar car = carFactory.MakeCar(random.Next(0, 4));
            return car;

            
        }
            
        
           public  Car MakeCar(int newStockCar)
           {        
               if (newStockCar.Equals(1))
               {
                   return new SedanStockCar();
               } 
                else if (newStockCar.Equals(2))
               {
                   return new PickupStockCar();
               }
                else if (newStockCar.Equals(3))
                {
                   return new SuvStockCar();
               }
                else
               {
                   return null;
               }
           }         
         
    }
}
