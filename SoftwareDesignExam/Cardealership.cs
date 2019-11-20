using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignExam
{
    class Seller : User
    {
        public Seller(string firstName, string lastName, string email, string address, string username, int phoneNumber)
            {
                FirstName = firstName;
                LastName = lastName;
                Email = email;
                Address = address;
                UserName = username;
                PhoneNumber = phoneNumber;
            }
        }
    }

