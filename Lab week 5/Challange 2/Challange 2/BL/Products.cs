using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_2.BL
{
    class Products
    {
       
        public Products(string productName , string productType , int ProductPrice, int stockQuantity , int thresholdQuantity)
        {
            this.productName = productName;
            this.productType = productType;
            this.ProductPrice = ProductPrice;
            this.stockQuantity = stockQuantity;
            this.thresholdQuantity = thresholdQuantity;
        }
        public string productName;
        public string productType;
        public int ProductPrice;
        public int stockQuantity;
        public int thresholdQuantity;
        public double SalesTax;
    }
}
