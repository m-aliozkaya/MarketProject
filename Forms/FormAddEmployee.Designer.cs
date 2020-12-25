
namespace MarketProject
{
    partial class FormAddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEmployee));
            this.cmbBoxMarket = new System.Windows.Forms.ComboBox();
            this.labelMarket = new System.Windows.Forms.Label();
            this.txtemployeeName = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtemployeeAdress = new System.Windows.Forms.TextBox();
            this.btnAddEmployee = new ePOSOne.btnProduct.Button_WOC();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAdress = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbBoxMarket
            // 
            this.cmbBoxMarket.FormattingEnabled = true;
            resources.ApplyResources(this.cmbBoxMarket, "cmbBoxMarket");
            this.cmbBoxMarket.Name = "cmbBoxMarket";
            // 
            // labelMarket
            // 
            resources.ApplyResources(this.labelMarket, "labelMarket");
            this.labelMarket.Name = "labelMarket";
            // 
            // txtemployeeName
            // 
            resources.ApplyResources(this.txtemployeeName, "txtemployeeName");
            this.txtemployeeName.Name = "txtemployeeName";
            this.txtemployeeName.TextChanged += new System.EventHandler(this.txtemployeName);
            // 
            // txtSalary
            // 
            resources.ApplyResources(this.txtSalary, "txtSalary");
            this.txtSalary.Name = "txtSalary";
            // 
            // txtemployeeAdress
            // 
            resources.ApplyResources(this.txtemployeeAdress, "txtemployeeAdress");
            this.txtemployeeAdress.Name = "txtemployeeAdress";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BorderColor = System.Drawing.Color.Silver;
            this.btnAddEmployee.ButtonColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.btnAddEmployee, "btnAddEmployee");
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnAddEmployee.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnAddEmployee.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnAddEmployee.TextColor = System.Drawing.Color.White;
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // labelName
            // 
            resources.ApplyResources(this.labelName, "labelName");
            this.labelName.Name = "labelName";
            // 
            // labelAdress
            // 
            resources.ApplyResources(this.labelAdress, "labelAdress");
            this.labelAdress.Name = "labelAdress";
            // 
            // labelSalary
            // 
            resources.ApplyResources(this.labelSalary, "labelSalary");
            this.labelSalary.Name = "labelSalary";
            // 
            // FormAddEmployee
            // 
            resources.ApplyResources(this, "$this");
            this.ControlBox = false;
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.txtemployeeAdress);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtemployeeName);
            this.Controls.Add(this.labelMarket);
            this.Controls.Add(this.cmbBoxMarket);
            this.Controls.Add(this.btnAddEmployee);
            this.Name = "FormAddEmployee";
            this.Load += new System.EventHandler(this.FormAddEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private ePOSOne.btnProduct.Button_WOC button_ekle;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private ePOSOne.btnProduct.Button_WOC btnAddEmployee;
        private System.Windows.Forms.ComboBox cmbBoxMarket;
        private System.Windows.Forms.Label labelMarket;
        private System.Windows.Forms.TextBox txtemployeeName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtemployeeAdress;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.Label labelSalary;
    }
}