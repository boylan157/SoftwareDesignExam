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

        public virtual string GetBrand()
        {
            return _originalCar.GetBrand();
        }

        public virtual string GetModel()
        {
            return _originalCar.GetModel();
        }

        public virtual string GetColor()
        {
            return _originalCar.GetColor();
        }

        public virtual int GetYear()
        {
            return _originalCar.GetYear();
        }

        public virtual bool GetAutomatic()
        {
            return _originalCar.GetAutomatic();
        }
    }
}