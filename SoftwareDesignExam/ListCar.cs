using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignExam
{
    class ListCar : Car
    {
        override
        public void DisplayCar()
        {
            Console.WriteLine($" Brand: {Brand}\n Model: {Model}\n Type: {Type}\n Color: {Color}\n Year: {Year}\n Mileage: {Mileage} Price: {Price}\n Automatic: {IsAutomatic}");
        }
        public ListCar(string brand, string model, string type, string color, int year, long mileage, double price, bool isAutomatic)
        {
            Brand = brand;
            Model = model;
            Type = type;
            Color = color;
            Year = year;
            Mileage = mileage;
            Price = price;
            IsAutomatic = isAutomatic;
        }
    }
}
