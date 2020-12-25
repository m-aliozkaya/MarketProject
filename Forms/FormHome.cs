using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketProject
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void labelHover(object sender, EventArgs e)
        {
                var label = (Label)sender;
                label.ForeColor = Color.White;    
        }

        private void labelLeave(object sender, EventArgs e)
        {
            var label = (Label)sender;
            label.ForeColor = Color.FromArgb(29, 53, 87);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void FormHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void addMarket_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FormAddMarket formAddMarket = new FormAddMarket();
            formAddMarket.TopLevel = false;
            panel2.Controls.Add(formAddMarket);
            formAddMarket.Dock = DockStyle.Fill;
            formAddMarket.Show();
        }

        private void listMarket_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FormListMarket formListMarket = new FormListMarket();
            formListMarket.TopLevel = false;
            panel2.Controls.Add(formListMarket);
            formListMarket.Dock = DockStyle.Fill;
            formListMarket.Show();

        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
             
            
        }
    }
}
