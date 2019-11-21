using NUnit.Framework;


namespace NUnitTestProject1
{

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            StockCarFactory testFactory = new StockCarFactory();
            Car testCar = testFactory.MakeCar(1);
            Assert.AreSame("Sedan", testCar.Brand);
        }

        [Test]
        public void MakeSedan()
        {
            StockCarFactory testFactory = new StockCarFactory();
            Car testCar = testFactory.MakeCar(1);
            Assert.AreSame("Sedan", testCar.Brand);
        }
    }
}