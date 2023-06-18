using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank.Exception_Library
{
    public class ParaSecilmediException : Exception
    {
        public ParaSecilmediException() : base("Please Select The Money To Put In The Piggy Bank!")
        {

        }
    }
}
