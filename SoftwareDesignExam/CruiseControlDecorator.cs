using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignExam
{
    public class CruiseControlDecorator : CarDecorator
    {
        public CruiseControlDecorator(ICar originalCar)
            : base(originalCar){
        }

        public override double GetPrice()
        {
            return  base.GetPrice() + 20_000;
        }
        public override string GetType()
        {
            return base.GetType() + ", with cruise control";
        }

        public override int GetYear()
        {
            return 2021;
        }
    }
}
