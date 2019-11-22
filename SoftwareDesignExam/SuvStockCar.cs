using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignExam
{
    //Class with information about stock SuvCar
    class SuvStockCar : Car
    {
        public SuvStockCar()
        {
            Brand = "Tiger";
            Type = "SUV";
            Model = "A-Pace";
            Color = "Red";
            Year = 2020;
            Price = 850_000;
            IsAutomatic = true;
        }
    }
}
