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
        public Supplier supplier { get; set; }
        public Market market { get; set; }

        public Product(int productID, string productName, double productPrice)
        {
            this.productID = productID;
            this.productName = productName;
            this.productPrice = productPrice;
        }

        public Product(string productName, double productPrice, Market market)
        {
            this.productName = productName;
            this.productPrice = productPrice;
            this.market = market;
        }

        public override string ToString()
        {
            return $"{this.productName,-20} {this.productPrice,20} :Price";
        }
    }
}
