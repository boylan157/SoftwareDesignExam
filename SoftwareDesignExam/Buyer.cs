using System;
using System.Threading;

namespace SoftwareDesignExam
{
    class Buyer : ThreadCarDealership
    {
        Cardealership _carDealership;
        private string _firstName;
        private string _lastName;


        // Constructor
        public Buyer(string firstname, string lastname, Cardealership carDealership)
        {
            _firstName = firstname;
            _lastName = lastname;
            _carDealership = carDealership;
        }


        //initialising counter for cars
        int _counter = 1;

        //protected task for printing cars for console
        protected override void Task()
        {
            //Runs untill cardealership is out of cars
            while (!_carDealership.HasCars && running) ;
            ICar bought = _carDealership.BuyCar();
            if (bought != null)
            {
                //writes output to console
                Console.WriteLine(
                    $"AUTOXO put up car #{_counter} for sale , {bought.GetType()} for {bought.GetPrice()} NOK\n");
                Console.WriteLine(
                    $"\t\t\t\t{_firstName} {_lastName} bought car #{_counter} Brand {bought.GetBrand()} | Model {bought.GetModel()} " +
                    $"| Has automatic = {bought.GetAutomatic()} | Color {bought.GetColor()} | Registered {bought.GetYear()} | {bought.GetType()} for {bought.GetPrice()} NOK\n\n");
            }

            //counts 1 up each turn
            Interlocked.Increment(ref this._counter);
        }
    }
}
