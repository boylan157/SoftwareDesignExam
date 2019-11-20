namespace SoftwareDesignExam
{
    public abstract class CarDecorator : ICar
    {

        private readonly ICar_iCar;

        protected CarDecorator(Icar iCar)
        {
            _iCar = iCar;
        }

        public virtual string Get

    }
}