using System.Collections.Generic;

namespace MarketProject
{
    public class Market
    {
        public int marketID { get; set; }
        public int marketName { get; set; }
        public int marketAdress { get; set; }
        public List<Employee> employeeList { get; set; }
        public List<Product> productList { get; set; }
    }
}