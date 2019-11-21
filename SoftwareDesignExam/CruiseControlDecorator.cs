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
        public override string GetDescription()
        {
            return base.GetDescription() + ", with cruisecontroll";
        }

        public override int GetYear()
        {
            return 2021;
        }
    }
}
