

namespace SoftwareDesignExam
{
    //makes car abstract class
    public abstract class Car : ICar
    {
        private string _brand;
        private string _model;
        private string _color;
        private string _type;
        private int _year;
        private double _price;
        private bool _isAutomatic;
        

     //makes getters for Car virtual so it can be overrided
        public virtual double GetPrice()
        {
            return _price;
        }

        public virtual string GetType()
        {
            return _type;
        }

        public virtual string GetBrand()
        {
            return _brand;
        }

        public virtual string GetModel()
        {
            return _model;
        }

        public virtual string GetColor()
        {
            return _color;
        }

        public virtual int GetYear()
        {
            return _year;
        }

        public virtual bool GetAutomatic()
        {
            return _isAutomatic;
        }

        /* Properties, decided to have properties to show we know how to do it
         Check SedanStockCar*/
        public string Brand 
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public bool IsAutomatic
        {
            get { return _isAutomatic; }
            set { _isAutomatic = value; }
        }
    }
}
