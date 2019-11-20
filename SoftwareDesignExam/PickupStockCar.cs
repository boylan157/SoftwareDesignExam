using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignExam
{
    class PickupStockCar : Car
    {
        public PickupStockCar()
        {
            Brand = "Doge";
            Type = "Pickup Truck";
            Model = "Ram";
            Color = "Black";
            Year = 2015;
            Mileage = 0;
            Price = 690_000;
            IsAutomatic = true;
            Description = "a Pickup truck";
        }
    }
}
