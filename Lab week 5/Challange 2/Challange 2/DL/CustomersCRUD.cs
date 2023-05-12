using Challange_2.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_2.DL
{
    class CustomersCRUD
    {

        public static List<Customers> c = new List<Customers>();
        public static void AddInList(Customers cust)
        {
            c.Add(cust);
        }
        public static void CalculateTax()
        {
            foreach(Customers i in c)
            {
                foreach(Products j in ProductsCRUD.pro)
                {
                    if(i.type.ToLower() == "grocery")
                    {
                        i.totalPrice = (j.ProductPrice * i.quantity);
                        i.tax = i.tax + i.totalPrice * 0.1;
                        i.finalPrice = i.totalPrice + i.tax;
                    }
                    else if(i.type.ToLower() == "fruit")
                    {
                        i.totalPrice = (j.ProductPrice * i.quantity);
                        i.tax = i.tax + i.totalPrice * 0.05;
                        i.finalPrice = i.totalPrice + i.tax;
                    }
                    else
                    {
                        i.totalPrice = i.totalPrice + (j.ProductPrice * i.quantity);
                        i.tax = i.tax + i.totalPrice * 0.15;
                        i.finalPrice = i.finalPrice + i.totalPrice + i.tax;
                    }
                }
                
            }
        }

        public static void Calculate()
        {
            foreach (Customers i in c)
            {
                foreach (Products j in ProductsCRUD.pro)
                {
                    if (i.name == j.productName && i.type == "grocery")
                    {
                        i.totalPrice = (j.ProductPrice * i.quantity);
                        i.tax = i.totalPrice * 0.1;
                        i.finalPrice = i.totalPrice + i.tax;
                    }
                    else if(i.name == j.productName && i.type == "fruit")
                    {
                        i.totalPrice = (j.ProductPrice * i.quantity);
                        i.tax = i.totalPrice * 0.05;
                        i.finalPrice = i.totalPrice + i.tax;
                    }
                    else if(i.name == j.productName && i.type == "other")
                    {
                        i.totalPrice = (j.ProductPrice * i.quantity);
                        i.tax = i.totalPrice * 0.15;
                        i.finalPrice = i.totalPrice + i.tax;
                    }

                }
                
            }
            
        }
            
    }
}
