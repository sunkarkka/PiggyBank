﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    public abstract class Para
    {
        public string Type { get; set; }
        public double Value { get; set; }
        public abstract double Hacim();
        public double TotalHacim()
        {
            Random rnd = new Random();
            double fazlaRnd = rnd.Next(25, 76);
            double fazlaHacim = (fazlaRnd * Hacim()) / 100;
            return fazlaHacim;
        }
    }
}
