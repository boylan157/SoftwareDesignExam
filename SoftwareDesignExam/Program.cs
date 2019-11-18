using System;

namespace SoftwareDesignExam
{
    class Program
    {

        public static void Main(String[] args)
        {
            // Calls factory
            StockCarFactory carFactory = new StockCarFactory();
            StockCar newCar = carFactory.MakeStockCar("pickup");
            newCar.DisplayStockCar();
           

        }
       
    }
}
