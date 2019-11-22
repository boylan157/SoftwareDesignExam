

namespace SoftwareDesignExam
{
    //Class with information/properties about stock Pickupcar
    public class PickupStockCar : Car
    {
        public PickupStockCar()
        {
            Brand = "Doge";
            Type = "Pickup Truck";
            Model = "Ram";
            Color = "Black";
            Year = 2015;
            Price = 690_000;
            IsAutomatic = true;
        }
    }
}
