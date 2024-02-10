using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1Popov.model
{
    internal class IsoscelesTriangle:Triangle
    {
        public IsoscelesTriangle(double length)
        {
            this.Firstside = this.Secondside = length;
            this.AngleBetween=AngleBetween;
        }

        public IsoscelesTriangle(double length, double side2, double angle) : this(length)
        {
        }

        public override double Perimetr()
        {
          return  2 * this.Firstside+this.Secondside;
        }

        public override double Square()
        {
         return this.Firstside*this.Secondside*Math.Sin(this.AngleBetween);
        }
    }
}
