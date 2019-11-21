namespace SoftwareDesignExam
{
    public abstract class CarDecorator : ICar
    {
        private readonly ICar _originalCar;

        protected CarDecorator(ICar originalCar)
        {
            _originalCar = originalCar;
        }

  

        public virtual string GetDescription()
        {
            return _originalCar.GetDescription();
        }

        public virtual double GetPrice()
        {
            return _originalCar.GetPrice();
        }
    }
}