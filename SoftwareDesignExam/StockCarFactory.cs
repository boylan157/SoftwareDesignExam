using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignExam
{
    class StockCarFactory
    {
       public StockCar MakeStockCar(string newStockCar)
        {
           // newStockCar = newStockCar.ToLower(); 

            if (newStockCar.Equals("sedan"))
            {
                return new SedanStockCar();
            } else if (newStockCar.Equals("pickup"))
            {
                return new PickupStockCar();
            } else if (newStockCar.Equals("suv")){
                return new SuvStockCar();
            } else
            {
                return null;
            }
        }
    }
}
