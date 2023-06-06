using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Circle
    {
        protected double radius;
        protected string color;

        public Circle()
        {
            radius = 1.0;
            color = "Red";
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle(double radius , string color)
        {
            this.radius = radius;
            this.color = color;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public string getColor()
        {
            return color;
        }

        public void setRadius(double radius)
        {
            this.radius = radius;
        }

        public double getRadius()
        {
            return radius;
        }

        public double getArea()
        {
            double area = 3.14 * radius * radius;
            return area;
        }

        public string toString()
        {
            string circle = color + radius.ToString();
            return circle;
        }

    }
}
