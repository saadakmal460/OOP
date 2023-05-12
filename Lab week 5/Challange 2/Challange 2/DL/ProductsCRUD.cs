using Challange_2.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_2.DL
{
    class ProductsCRUD
    {
        public static void SalesTax()
        {
            for(int i=0; i <pro.Count; i++)
            {
                if(pro[i].productType.ToLower() == "grocery")
                {
                    pro[i].SalesTax = (pro[i].ProductPrice * pro[i].stockQuantity) * 0.1;
                }
                else if(pro[i].productType.ToLower() == "fruit")
                {
                    pro[i].SalesTax = (pro[i].ProductPrice * pro[i].stockQuantity) * 0.05;
                }
                else if (pro[i].productType.ToLower() == "other")
                {
                    pro[i].SalesTax = (pro[i].ProductPrice * pro[i].stockQuantity) * 0.15;
                }
            }
        }
        public static void AddProductsInList(Products p)
        {
            pro.Add(p);
        }
        public static List<Products> pro = new List<Products>();
    }
}
