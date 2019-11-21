namespace SoftwareDesignExam
{
    public class AppleCarPlayDecorator : CarDecorator
    {
        public AppleCarPlayDecorator(ICar originalCar)
            : base(originalCar)
        {
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 5_000;
        }
        public override string GetType()
        {
            return base.GetType() + ", with AppleCarPlay entertainment system";
        }

        public override bool GetAutomatic()
        {
            return base.GetAutomatic() == false;
        }
    }
}
