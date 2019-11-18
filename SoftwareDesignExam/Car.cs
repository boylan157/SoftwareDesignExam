using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignExam
{
    class Car
    {
        private string _brand;
        private string _model;
        private string _color;
        private int _year;
        private long _mileage;
        private double _price;
        private Boolean _automatic;

        // Constructors
        public Car(string brand, string model, int year, long mileage, double price)
        {
            _brand = brand;
            _model = model;
            _year = year;
            _mileage = mileage;
            _price = price; 
        }
        public Car(string brand, string model, string color, int year, long mileage, double price)
        {
            _brand = brand;
            _model = model;
            _color = color;
            _year = year;
            _mileage = mileage;
            _price = price;
        }

        // Properties
        public string Brand 
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public long Mileage
        {
            get { return _mileage; }
            set { _mileage = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

    }
}
