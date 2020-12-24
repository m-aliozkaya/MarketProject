using System.Collections.Generic;

namespace MarketProject
{
    public class Market
    {
        public int marketID { get; set; }
        public string marketName { get; set; }
        public string marketAdress { get; set; }
        public List<Employee> employeeList { get; set; }
        public List<Product> productList { get; set; }

        public Market(int marketId, string marketName, string marketAdress)
        {
            this.marketID = marketId;
            this.marketName = marketName;
            this.marketAdress = marketAdress;
        }

        public Market(string marketName, string marketAdress)
        {
            this.marketName = marketName;
            this.marketAdress = marketAdress;
        }

        public override string ToString()
        {
            return $"{this.marketName, -20} {this.marketAdress, 20} :Adres";
        }
    }
}