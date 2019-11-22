using System;

namespace SoftwareDesignExam
{
    //Makes a factory for Cars
    public class StockCarFactory
    {
        //creates random car
        public static ICar CreateRandomCar()
        {
            //creates random generator
            Random random = new Random();
            StockCarFactory carFactory = new StockCarFactory();
            //initalises carfactory to make random car with numbers 0-3
            ICar car = carFactory.MakeCar(random.Next(0, 4));

            /* Makes a randomiser to choose between extra equipment for the cars */
            Random randomize = new Random();

            //Chooses inbetween three equipment based on randomiser
            if (randomize.Next(2) == 1)
            {
                car = new CruiseControlDecorator(car);

            }
            else if (randomize.Next(2) == 1)
            {
                car = new ThreeHundredSixtyDegreeCameraDecorator(car);

            }
            else if (randomize.Next(2) == 1)
            {
                car = new AppleCarPlayDecorator(car);

            }

            return car;

        }


        // Has to be public for test to work
        /* Makes car checking for input from randomiser choosing
         from 1-3 making cars based on the number given*/
        public Car MakeCar(int newStockCar)
        { 
               if (newStockCar.Equals(1))
               {
                   return new SedanStockCar();
               }
               if (newStockCar.Equals(2))
               { 
                   return new PickupStockCar();
               } 
               
               return new SuvStockCar();
               

        }
    }
}
