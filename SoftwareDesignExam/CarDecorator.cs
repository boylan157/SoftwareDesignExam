namespace SoftwareDesignExam
{

    //Makes a car decorator
    public abstract class CarDecorator : ICar
    {
        private readonly ICar _originalCar;

        //Initialises cardecorator
        protected CarDecorator(ICar originalCar)
        {
            _originalCar = originalCar;
        }

  
        //makes getters for car decorator and returns originalcar
        public virtual string GetType()
        {
            return _originalCar.GetType();
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