using System.Collections.Generic;
using System.ComponentModel;

namespace MarketProject
{
    public class Market
    {
        public int marketID { get; set; }
        public string marketName { get; set; }
        public string marketAdress { get; set; }
        public BindingList<Employee> employeeList { get; set; }
        public BindingList<Product> productList { get; set; }

        public Market(int marketID, string marketName, string marketAdress)
        {
            this.marketID = marketID;
            this.marketName = marketName;
            this.marketAdress = marketAdress;
        }

        public Market(string marketName, string marketAdress)
        {
            this.marketName = marketName;
            this.marketAdress = marketAdress;
        }

        public Market(string marketName)
        {
            this.marketName = marketName;
        }

        public override string ToString()
        {
            return $"{this.marketName} || {this.marketAdress}";
        }
    }
}