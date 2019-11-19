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

            // Creating first Buyer
            User firstBuyer = new Buyer("Daniel", "Boylan", "danboy@email.com", "veien 19", "doylan", 12345678);
            Seller.listcar


        }
       
    }
}
