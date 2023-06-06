using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.BL
{
    class Square : Shape
    {
        protected double length;
        

        public Square(double length)
        {
            this.length = length;
        }

        public void setLength(double length)
        {
            this.length = length;
        }

        public double getLength()
        {
            return length;
        }

        public override double calculateArea()
        {
            double area = length * length;
            return area;
        }

        public override string toString()
        {
            return base.toString() + " square and area is " + calculateArea().ToString();
        }
    }
}
