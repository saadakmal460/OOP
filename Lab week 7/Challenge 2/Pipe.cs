using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    class Pipe
    {
        public string material;
        public string shape;
        public double diameter;

        public Pipe(string material, string shape , double diameter)
        {
            this.material = material;
            this.shape = shape;
            this.diameter = diameter;
        }
    }
}
