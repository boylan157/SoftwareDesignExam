﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignExam
{
    public abstract class Car : ICar
    {
        private string _brand;
        private string _model;
        private string _color;
        private string _type;
        private int _year;
        private long _mileage;
        private double _price;
        private bool _isAutomatic;
        private string _description;
        

     
        public virtual double GetPrice()
        {
            return _price;
        }

        public virtual string GetDescription()
        {
            return _description;
        }

        public virtual string GetBrand()
        {
            return _brand;
        }

        public virtual string GetModel()
        {
            return _model;
        }

        public virtual string GetColor()
        {
            return _color;
        }

        public virtual int GetYear()
        {
            return _year;
        }

        public virtual bool GetAutomatic()
        {
            return _isAutomatic;
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
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public bool IsAutomatic
        {
            get { return _isAutomatic; }
            set { _isAutomatic = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
    }
}
