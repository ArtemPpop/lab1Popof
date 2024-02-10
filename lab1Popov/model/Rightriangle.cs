using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1Popov.model
{
    internal class Rightriangle : Triangle
    {
        public Rightriangle(double length)
        {
            this.Firstside = this.Secondside = length;
            this.AngleBetween = 90;
        }

        public Rightriangle(double length, double side2, double angle) : this(length)
        {
        }

        public override double Perimetr()
        {
            return (this.Firstside * this.Secondside)/2;
        }

        public override double Square()
        {
            return this.Firstside+this.Secondside+Math.Sqrt(this.Firstside* this.Firstside+ this.Secondside* this.Secondside);
        }
    }
}
