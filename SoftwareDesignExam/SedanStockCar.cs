using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignExam
{
    //Class with information about stock SedanCar
    class SedanStockCar : Car
    {
        public SedanStockCar()
        {
            Brand = "Gaudi";
            Type = "Sedan";
            Model = "A6";
            Color = "Yellow";
            Year = 2018;
            Price = 645_000;
            IsAutomatic = false;
        }
    }
}
