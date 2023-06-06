using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.BL
{
    class Rectangle : Shape
    {
        protected double length;
        protected double width;
        
        public Rectangle(double length , double width)
        {
            this.length = length;
            this.width = width;
        }

        public void setLength(double length)
        {
            this.length = length;
        }

        public double getLength()
        {
            return length;
        }

        public void setWidth(double width)
        {
            this.width = width;
        }

        public double getWidth()
        {
            return width;
        }
        
        public override double calculateArea()
        {
            double area = length * width;
            return area;
        }

        public override string toString()
        {
            return base.toString() + " rectangle and area is " + calculateArea().ToString();
        }
    }
}
