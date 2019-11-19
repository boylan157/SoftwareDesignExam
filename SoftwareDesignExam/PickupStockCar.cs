using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignExam
{
    class PickupStockCar : StockCar
    {
        public PickupStockCar()
        {
            Brand = "Doge";
            Type = "Pickup Truck";
            Model = "Ram";
            Price = 690_000;
            IsAutomatic = true;
        }
    }
}
