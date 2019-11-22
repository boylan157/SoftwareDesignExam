
namespace SoftwareDesignExam
{
    public class CruiseControlDecorator : CarDecorator
    {
        public CruiseControlDecorator(ICar originalCar)
            : base(originalCar){
        }

        //gets price of original car and ovverides it adding more
        public override double GetPrice()
        {
            return  base.GetPrice() + 20_000;
        }

        //gets base type of car and adds new feature
        public override string GetType()
        {
            return base.GetType() + ", with cruise control";
        }

        //gets year base car is made and changes it to 2021
        public override int GetYear()
        {
            return 2021;
        }
    }
}
