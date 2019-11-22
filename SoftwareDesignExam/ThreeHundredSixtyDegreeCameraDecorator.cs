namespace SoftwareDesignExam
{
    public class ThreeHundredSixtyDegreeCameraDecorator : CarDecorator
    {
        public ThreeHundredSixtyDegreeCameraDecorator(ICar originalCar)
            : base(originalCar)
        {
        }

        //gets price of original car and ovverides it adding more
        public override double GetPrice()
        {
            return base.GetPrice() + 8_500;
        }

        //gets base type of car and adds new feature
        public override string GetType()
        {
            return base.GetType() + ", with 360 Degree camera and auto parking";
        }
        //gets base color and overrides it with new color
        public override string GetColor()
        {
            return "Blue";
        }
    }
}