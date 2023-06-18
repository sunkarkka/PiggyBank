using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank.Exception_Library
{
    public class BosKumbaraException : Exception
    {
        public BosKumbaraException() : base("There Is No Money In The Piggy Bank!!")
        {

        }
    }
}
