﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareDesignExam
{
    class Seller : User
    {
        public override string GetInfo()
        {
            return Name;
        }
    }
}