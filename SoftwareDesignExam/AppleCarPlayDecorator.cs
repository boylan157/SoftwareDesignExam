namespace SoftwareDesignExam
{
    public class AppleCarPlayDecorator : CarDecorator
    {
        public AppleCarPlayDecorator(ICar originalCar)
            : base(originalCar)
        {
        }
        //gets price of original car and ovverides it adding more
        public override double GetPrice()
        {
            return base.GetPrice() + 5_400;
        }

        //gets base type of car and adds new feature
        public override string GetType()
        {
            return base.GetType() + ", with AppleCarPlay entertainment system";
        }

        //gets if car is automatic and forces it to be manual
        public override bool GetAutomatic()
        {
            return base.GetAutomatic() == false;
        }
    }
}
