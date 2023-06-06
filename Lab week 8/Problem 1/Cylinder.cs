using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Cylinder : Circle
    {
        protected double height;

        public Cylinder()
        {
            height = 1.0;
        }
        public Cylinder (double radius) : base(radius)
        {
            this.radius = radius;
        }

        public Cylinder (double radius , double height) : base(radius)
        {
            this.height = height;
            this.radius = radius;
        }

        public Cylinder(double radius, double height , string color) : base (radius , color)
        {
            this.height = height;
            this.radius = radius;
            this.color = color;
        }

        public void setHeight(double height)
        {
            this.height = height;
        }

        public double getHeight()
        {
            return height;
        }

        public double getVloume()
        {
            double volume = (Math.PI * radius * radius * height);
            return volume;
        }
    }
}
