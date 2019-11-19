using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignExam
{
    class SedanStockCar : StockCar
    {
        public SedanStockCar()
        {
            Brand = "Gaudi";
            Type = "Sedan";
            Model = "A6";
            Price = 645_000;
            IsAutomatic = true;
        }
    }
}
