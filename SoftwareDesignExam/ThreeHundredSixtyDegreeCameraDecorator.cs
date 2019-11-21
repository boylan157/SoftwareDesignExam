namespace SoftwareDesignExam
{
    public class ThreeHundredSixtyDegreeCameraDecorator : CarDecorator
    {
        public ThreeHundredSixtyDegreeCameraDecorator(ICar originalCar)
            : base(originalCar)
        {
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 5_000;
        }
        public override string GetType()
        {
            return base.GetType() + ", with 360 Degree camera and auto parking";
        }

        public override string GetColor()
        {
            return "Blue";
        }
    }
}