using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Assesment_1.BL
{
    class MenuItem
    {
        public MenuItem(string item , string type, int price)
        {
            this.item = item;
            this.type = type;
            this.price = price;
        }
        public string item;
        public string type;
        public int price;
    }
}
