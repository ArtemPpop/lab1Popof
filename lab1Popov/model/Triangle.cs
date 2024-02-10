using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1Popov.model
{
    public abstract class Triangle
    {
        public double Firstside { get; set; }
        public double Secondside { get; set; }
        public double AngleBetween { get; set; }

        public abstract double Square();
        public abstract double Perimetr();
    }
}
