using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank.Exception_Library
{
    public class DoluKumbaraException : Exception
    {
        public DoluKumbaraException() : base("The Piggy Bank Is Full, You Can't Throw The Money!!")
        {

        }
    }
}
