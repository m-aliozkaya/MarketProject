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
        public int productName { get; set; }
        public int productPrice { get; set; }
        public Supplier supplier { get; set; }
        public Market market { get; set; }
    }
}
