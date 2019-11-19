﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignExam
{
    abstract class User
    {
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _address;
        private string _userName;
        private int _phoneNumber;




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
