using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftwareDesignExam;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignExam.Tests
{
    [TestClass()]
    public class StockCarFactoryTests
    {

        // Two tests as requested


        // testing if we can make a car
        [TestMethod()]
        public void MakeCarTest()
        {
            StockCarFactory factory = new StockCarFactory();
            Car car = factory.MakeCar(1);
            Assert.AreEqual("Sedan", car.GetType());
        }

        // testing if we can make a car with decorator
        [TestMethod()]
        public void MakeCarWithDecorator()
        {
            StockCarFactory factory = new StockCarFactory();
            ICar car = factory.MakeCar(2);
            car = new CruiseControlDecorator(car);
            Assert.AreEqual("Pickup Truck, with cruise control", car.GetType());
            Assert.AreEqual(710000, car.GetPrice());
        }
    }
}