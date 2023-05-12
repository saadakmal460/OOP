using Challange_2.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_2.BL
{
    class Customers
    {
        public static void CalculatePrice()
        {
            
        }
        public Customers(string name , int quantity , string type , int totalPrice)
        {
            this.name = name;
            this.quantity = quantity;
            this.type = type;
            this.totalPrice = totalPrice;
        }
        public string name;
        public int quantity;
        public string type;
        public double tax;
        public double totalPrice;
        public double finalPrice;
    }
}
