using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignExam
{
    class SuvStockCar : StockCar
    {
        public SuvStockCar()
        {
            Brand = "Tiger";
            Type = "SUV";
            Model = "A-Pace";
            Price = 850_000;
            IsAutomatic = true ;
        }
    }
}
