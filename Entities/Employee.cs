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
        public int totalWorkingTime { get; set; }
        public string position { get; set; }
        public Market market { get; set; }

        public Employee(string employeeName, string employeeAdress, double employeeSalary, Market market, string position, string dailyHoliday)
        {
            this.employeeName = employeeName;
            this.employeeAdress = employeeAdress;
            this.employeeSalary = employeeSalary;
            this.market = market;
            this.position = position;
            this.dailyHoliday = dailyHoliday;
        }        
        public Employee(int employeeID, string employeeName, string employeeAdress,string position ,double employeeSalary, int yearlyHoliday, string dailyHoliday, Market market,int totalWorkingTime )
        {
            this.employeeID = employeeID;
            this.employeeName = employeeName;
            this.position = position;
            this.employeeAdress = employeeAdress;
            this.employeeSalary = employeeSalary;
            this.yearlyHoliday = yearlyHoliday;
            this.dailyHoliday = dailyHoliday;
            this.market = market;
            this.totalWorkingTime = totalWorkingTime;
        }      
        
        public Employee(int employeeID, string employeeName, string employeeAdress,string position ,double employeeSalary, int yearlyHoliday, string dailyHoliday, int totalWorkingTime )
        {
            this.employeeID = employeeID;
            this.employeeName = employeeName;
            this.position = position;
            this.employeeAdress = employeeAdress;
            this.employeeSalary = employeeSalary;
            this.yearlyHoliday = yearlyHoliday;
            this.dailyHoliday = dailyHoliday;
            this.totalWorkingTime = totalWorkingTime;
        }
        public Employee()
        {

        }

    }
}