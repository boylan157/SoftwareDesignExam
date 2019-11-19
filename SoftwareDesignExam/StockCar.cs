﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignExam
{
    abstract class StockCar
    {
       
        private string _brand;
        private string _model;
        private string _type;
        private double _price;
        private bool _isAutomatic;
        
       
        // Display method
        public void DisplayStockCar()
        {
            Console.WriteLine($" Brand: {Brand}\n Model: {Model}\n Type: {Type}\n Price: {Price}\n Automatic: {IsAutomatic}");
        }


       // Properties

            
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public bool IsAutomatic
        {
            get { return _isAutomatic; }
            set { _isAutomatic = value; }
        }
        

    }
}

