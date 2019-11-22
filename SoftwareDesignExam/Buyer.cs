using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SoftwareDesignExam
{
    class Buyer  : ThreadCarDealership
    {
        Cardealership _carDealership;
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _address;
        private string _userName;
        private int _phoneNumber;

        // Constructor
        public Buyer(string firstname, string lastname,  Cardealership carDealership)
        {
            _firstName = firstname;
            _lastName = lastname;
            _carDealership = carDealership;
        }
        //Constructor
        public Buyer(string firstname,string lastname, string email, string address, string username, int phonenumber)
        {
            _firstName = firstname;
            _lastName = lastname;
            _email = email;
            _address = address;
            _userName = username;
            _phoneNumber = phonenumber;
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
                    Console.WriteLine($"AUTOXO put up car #{_counter} for sale , {bought.GetType()} for {bought.GetPrice()} NOK\n");
                    Console.WriteLine($"\t\t\t\t{_firstName} {_lastName} bought car #{_counter} Brand {bought.GetBrand()} | Model {bought.GetModel()} " +
                                      $"| Has automatic = {bought.GetAutomatic()} | Color {bought.GetColor()} | Registered {bought.GetYear()} | {bought.GetType()} for {bought.GetPrice()} NOK\n\n");                   
                }
                //counts 1 up each turn
                Interlocked.Increment(ref this._counter);
        }

        
        // Display buyer method
        public void DisplayBuyer()
        {
            
            Console.WriteLine($" Name: {FirstName} {LastName}\n Email: {Email}\n Address: {Address}\n Username: {UserName}\n PhoneNumber: {PhoneNumber}");
            
        }


        //properties
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        public int PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
    }
    }
