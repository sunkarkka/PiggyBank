﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank.Exception_Library
{
    public class ParaKatlanmadiException : Exception
    {
        public ParaKatlanmadiException() : base("You Can't Throw Money Without Folding!")
        {

        }
    }
}
