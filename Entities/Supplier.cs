using System.Collections.Generic;

namespace MarketProject
{
    public class Supplier
    {
        public int supplierID { get; set; }
        public string supplierName{ get; set; }
        public string supplierAdress { get; set; }
        public List<Product> productList { get;}

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
    }
}