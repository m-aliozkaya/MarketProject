
namespace MarketProject
{
    partial class FormHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.market = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.listSupplier = new System.Windows.Forms.Label();
            this.addSupplier = new System.Windows.Forms.Label();
            this.listEmployee = new System.Windows.Forms.Label();
            this.addEmployee = new System.Windows.Forms.Label();
            this.listProduct = new System.Windows.Forms.Label();
            this.addProduct = new System.Windows.Forms.Label();
            this.listMarket = new System.Windows.Forms.Label();
            this.addMarket = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // market
            // 
            this.market.BackColor = System.Drawing.Color.Transparent;
            this.market.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.market.Location = new System.Drawing.Point(18, 119);
            this.market.Name = "market";
            this.market.Size = new System.Drawing.Size(143, 36);
            this.market.TabIndex = 0;
            this.market.Text = "Market";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.listSupplier);
            this.panel1.Controls.Add(this.addSupplier);
            this.panel1.Controls.Add(this.listEmployee);
            this.panel1.Controls.Add(this.addEmployee);
            this.panel1.Controls.Add(this.listProduct);
            this.panel1.Controls.Add(this.addProduct);
            this.panel1.Controls.Add(this.listMarket);
            this.panel1.Controls.Add(this.addMarket);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.market);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.panel1.Location = new System.Drawing.Point(-1, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 591);
            this.panel1.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(13, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(318, 55);
            this.label12.TabIndex = 12;
            this.label12.Text = "Admin Paneli";
            // 
            // listSupplier
            // 
            this.listSupplier.AutoSize = true;
            this.listSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listSupplier.Location = new System.Drawing.Point(46, 537);
            this.listSupplier.Name = "listSupplier";
            this.listSupplier.Size = new System.Drawing.Size(178, 25);
            this.listSupplier.TabIndex = 11;
            this.listSupplier.Text = "Tedarikçileri Listele";
            this.listSupplier.MouseLeave += new System.EventHandler(this.labelLeave);
            this.listSupplier.MouseHover += new System.EventHandler(this.labelHover);
            // 
            // addSupplier
            // 
            this.addSupplier.AutoSize = true;
            this.addSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addSupplier.Location = new System.Drawing.Point(46, 512);
            this.addSupplier.Name = "addSupplier";
            this.addSupplier.Size = new System.Drawing.Size(135, 25);
            this.addSupplier.TabIndex = 10;
            this.addSupplier.Text = "Tedarikçi Ekle";
            this.addSupplier.MouseLeave += new System.EventHandler(this.labelLeave);
            this.addSupplier.MouseHover += new System.EventHandler(this.labelHover);
            // 
            // listEmployee
            // 
            this.listEmployee.AutoSize = true;
            this.listEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listEmployee.Location = new System.Drawing.Point(46, 408);
            this.listEmployee.Name = "listEmployee";
            this.listEmployee.Size = new System.Drawing.Size(139, 25);
            this.listEmployee.TabIndex = 9;
            this.listEmployee.Text = "Çalışan Listele";
            this.listEmployee.Click += new System.EventHandler(this.listEmployee_Click);
            this.listEmployee.MouseLeave += new System.EventHandler(this.labelLeave);
            this.listEmployee.MouseHover += new System.EventHandler(this.labelHover);
            // 
            // addEmployee
            // 
            this.addEmployee.AutoSize = true;
            this.addEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addEmployee.Location = new System.Drawing.Point(46, 383);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(121, 25);
            this.addEmployee.TabIndex = 8;
            this.addEmployee.Text = "Çalışan Ekle";
            this.addEmployee.Click += new System.EventHandler(this.addEmployee_Click);
            this.addEmployee.MouseLeave += new System.EventHandler(this.labelLeave);
            this.addEmployee.MouseHover += new System.EventHandler(this.labelHover);
            // 
            // listProduct
            // 
            this.listProduct.AutoSize = true;
            this.listProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listProduct.Location = new System.Drawing.Point(46, 292);
            this.listProduct.Name = "listProduct";
            this.listProduct.Size = new System.Drawing.Size(140, 25);
            this.listProduct.TabIndex = 7;
            this.listProduct.Text = "Ürünleri Listele";
            this.listProduct.Click += new System.EventHandler(this.listProduct_Click);
            this.listProduct.MouseLeave += new System.EventHandler(this.labelLeave);
            this.listProduct.MouseHover += new System.EventHandler(this.labelHover);
            // 
            // addProduct
            // 
            this.addProduct.AutoSize = true;
            this.addProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addProduct.Location = new System.Drawing.Point(46, 267);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(97, 25);
            this.addProduct.TabIndex = 6;
            this.addProduct.Text = "Ürün Ekle";
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            this.addProduct.MouseLeave += new System.EventHandler(this.labelLeave);
            this.addProduct.MouseHover += new System.EventHandler(this.labelHover);
            // 
            // listMarket
            // 
            this.listMarket.AutoSize = true;
            this.listMarket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listMarket.Location = new System.Drawing.Point(46, 180);
            this.listMarket.Name = "listMarket";
            this.listMarket.Size = new System.Drawing.Size(158, 25);
            this.listMarket.TabIndex = 5;
            this.listMarket.Text = "Marketleri Listele";
            this.listMarket.Click += new System.EventHandler(this.listMarket_Click);
            this.listMarket.MouseLeave += new System.EventHandler(this.labelLeave);
            this.listMarket.MouseHover += new System.EventHandler(this.labelHover);
            // 
            // addMarket
            // 
            this.addMarket.AutoSize = true;
            this.addMarket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addMarket.Location = new System.Drawing.Point(46, 155);
            this.addMarket.Name = "addMarket";
            this.addMarket.Size = new System.Drawing.Size(115, 25);
            this.addMarket.TabIndex = 4;
            this.addMarket.Text = "Market Ekle";
            this.addMarket.Click += new System.EventHandler(this.addMarket_Click);
            this.addMarket.MouseLeave += new System.EventHandler(this.labelLeave);
            this.addMarket.MouseHover += new System.EventHandler(this.labelHover);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(18, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 49);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tedarikçi";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 43);
            this.label2.TabIndex = 2;
            this.label2.Text = "Çalışan";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Location = new System.Drawing.Point(364, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 588);
            this.panel2.TabIndex = 1;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 587);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHome_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label market;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label listProduct;
        private System.Windows.Forms.Label addProduct;
        private System.Windows.Forms.Label listMarket;
        private System.Windows.Forms.Label addMarket;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label listSupplier;
        private System.Windows.Forms.Label addSupplier;
        private System.Windows.Forms.Label listEmployee;
        private System.Windows.Forms.Label addEmployee;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
    }
}