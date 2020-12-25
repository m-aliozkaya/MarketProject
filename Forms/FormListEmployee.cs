using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketProject.Forms
{ 
    public partial class FormListEmployee : Form
    {
        private List<Employee> employeeList;

        public FormListEmployee()
        {
            InitializeComponent();
        }

        private void FormListEmployee_Load(object sender, EventArgs e)
        {
            employeeList = EmployeeManager.selectEmployees();

            dataGridViewEmployee.DataSource = employeeList;
        }

    

    
    }
}
