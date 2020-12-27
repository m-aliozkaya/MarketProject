using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProject
{
    public class Product
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public double productPrice { get; set; }
        public double indirimOrani { get; set; }

        public int stokDurumu { get; set; }

        public Supplier supplier { get; set; }

        public Product(string productName, double productPrice, Supplier supplier)
        {
            this.productName = productName;
            this.productPrice = productPrice;
            this.supplier = supplier;
        }

        public Product(int productID,int stokDurumu, string productName, double productPrice, double indirimOrani)
        {
            this.productID = productID;
            this.stokDurumu = stokDurumu;
            this.productName = productName;
            this.productPrice = productPrice; 
            this.indirimOrani = indirimOrani;

        }        
        
        public Product(int productID, string productName, double productPrice,Supplier supplier)
        {
            this.productID = productID;
            this.productName = productName;
            this.productPrice = productPrice; 
            this.supplier = supplier;

        }

        public Product(int productID, string productName, double productPrice)
        {
            this.productID = productID;
            this.productName = productName;
            this.productPrice = productPrice;

        }



        public override string ToString()
        {
            return $"{this.productName}";
        }
    }
}
