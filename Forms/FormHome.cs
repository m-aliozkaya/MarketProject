﻿using MarketProject.Forms;
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
            FormAddProduct formAddProduct = new FormAddProduct();
            formAddProduct.TopLevel = false;
            panel2.Controls.Add(formAddProduct);
            formAddProduct.Dock = DockStyle.Fill;
            formAddProduct.Show();

        }

        private void listProduct_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FormListProduct formListProduct = new FormListProduct();
            formListProduct.TopLevel = false;
            panel2.Controls.Add(formListProduct);
            formListProduct.Dock = DockStyle.Fill;
            formListProduct.Show();
        }

        private void addEmployee_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FormAddEmployee formAddEmployee = new FormAddEmployee();
            formAddEmployee.TopLevel = false;
            panel2.Controls.Add(formAddEmployee);
            formAddEmployee.Dock = DockStyle.Fill;
            formAddEmployee.Show();
        }
        private void listEmployee_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FormListEmployee formListEmployee = new FormListEmployee();
            formListEmployee.TopLevel = false;
            panel2.Controls.Add(formListEmployee);
            formListEmployee.Dock = DockStyle.Fill;
            formListEmployee.Show();
        }

        private void listSupplier_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FormListSupplier formListSupplier = new FormListSupplier();
            formListSupplier.TopLevel = false;
            panel2.Controls.Add(formListSupplier);
            formListSupplier.Dock = DockStyle.Fill;
            formListSupplier.Show();
        }

        private void addSupplier_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FormAddSupplier formAddSupplier = new FormAddSupplier();
            formAddSupplier.TopLevel = false;
            panel2.Controls.Add(formAddSupplier);
            formAddSupplier.Dock = DockStyle.Fill;
            formAddSupplier.Show();
        }
    }
}
