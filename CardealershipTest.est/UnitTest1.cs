using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftwareDesignExam;

namespace CardealershipTest.est
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        void MakeSedan()
        {
            StockCarFactory factory = new SoftwareDesignExam.StockCarFactory();
            ICar car = factory.MakeCar(1);
            System.Console.WriteLine(car.GetType());
            Assert.AreEqual("sedan", car.GetType());
        }

    }
}
