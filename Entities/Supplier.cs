using System.Collections.Generic;
using System.ComponentModel;

namespace MarketProject
{
    public class Supplier
    {
        public int supplierID { get; set; }
        public string supplierName{ get; set; }
        public string supplierAdress { get; set; }
        public BindingList<Product> productList { get;}

        public Supplier(string supplierName)
        {
            this.supplierName = supplierName;
        }
        public Supplier (int supplierID, string supplierName, string supplierAdress)
        {
            this.supplierID = supplierID;
            this.supplierName = supplierName;
            this.supplierAdress = supplierAdress;
        }  
        public Supplier (string supplierName, string supplierAdress)
        {
            this.supplierName = supplierName;
            this.supplierAdress = supplierAdress;
        }

        public override string ToString()
        {
            return supplierName;
        }
    }
}