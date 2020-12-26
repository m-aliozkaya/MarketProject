namespace MarketProject
{
    public class Employee
    {
        public int employeeID { get; set; }
        public string employeeName { get; set; }

        public string employeeAdress { get; set; }
        public double employeeSalary { get; set; }
        public string dailyHoliday { get; set; }
        public int yearlyHoliday { get; set; }
        public int hiringDate { get; set; }

        public Market market { get; set; }
        public Employee(string employeeName, string employeeAdress, double employeeSalary, int yearlyHoliday)
        {
            this.employeeName = employeeName;
            this.employeeAdress = employeeAdress;
            this.employeeSalary = employeeSalary;
            this.yearlyHoliday = yearlyHoliday;
        }

        public Employee(string employeeName, string employeeAdress, double employeeSalary, Market market)
        {
            this.employeeName = employeeName;
            this.employeeAdress = employeeAdress;
            this.employeeSalary = employeeSalary;
            this.market = market;
        }


        public Employee()
        {

        }

    }
}