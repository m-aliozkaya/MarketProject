using System.Collections.Generic;

namespace MarketProject
{
    public class Supplier
    {
        public int supplierID { get; set; }
        public int supplierName{ get; set; }
        public int supplierAdress { get; set; }
        public List<Product> productList { get;}
    }
}