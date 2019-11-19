using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignExam
{
    abstract class StockCar : Car
    {   
        // Display method
        public void DisplayStockCar()
        {
            Console.WriteLine($" Brand: {Brand}\n Model: {Model}\n Type: {Type}\n Price: {Price}\n Automatic: {IsAutomatic}");
        }
    }
}


