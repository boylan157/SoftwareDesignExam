namespace SoftwareDesignExam
{
    public class ThreeHundredSixtyDegreeCamera : CarDecorator
    {
        public ThreeHundredSixtyDegreeCamera(ICar originalCar)
            : base(originalCar)
        {
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 5_000;
        }
        public override string GetDescription()
        {
            return base.GetDescription() + ", with 360 Degree camera and auto parking";
        }


    }
}