using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.BL
{
    class Circle : Shape
    {
        protected double radius;


        public Circle(double radius)
        {
            this.radius = radius;
        }

        public void setRadius(double radius)
        {
            this.radius = radius;
        }

        public double getRadius()
        {
            return radius;
        }

        public override double calculateArea()
        {
            double area = 2 * Math.PI * radius * radius;
            return area;
        }

        public override string toString()
        {
            return base.toString() + " circle and area is " + calculateArea().ToString();
        }
    }
}
