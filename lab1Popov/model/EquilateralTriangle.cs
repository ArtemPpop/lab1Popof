using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1Popov.model
{
    internal class EquilateralTriangle:Triangle
    {
        public EquilateralTriangle(double length)
        {
            this.Firstside = this.Secondside = length;
            this.AngleBetween = 60;
        }

        public override double Perimetr()
        {
           return 3*this.Firstside;
        }

        public override double Square()
        {
            return (Math.Sqrt(3) / 4) * Firstside * Secondside;
        }
    }
}
