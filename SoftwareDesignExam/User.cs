using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignExam
{
    abstract class User
    {
        public string Name { get; set; }

        public abstract void GetInfo();


    }
}
