using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    class FireTruck
    {
        public void SetPipe(Pipe pipe)
        {
            this.pipe = pipe;
        }
        public FireTruck(Laddar laddar , List<FireFighter> f , List<FireChief> fc)
        {
            this.laddar = laddar;
            this.f = f;
            this.fc = fc;
        }
        public Laddar laddar;
        public Pipe pipe;
        public List<FireFighter> f = new List<FireFighter>();
        public List<FireChief> fc = new List<FireChief>();   
    }
}
