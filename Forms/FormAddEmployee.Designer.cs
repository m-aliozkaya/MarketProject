
namespace MarketProject.Forms
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMarket = new System.Windows.Forms.ComboBox();
            this.cmbPozisyon = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.addButton = new ePOSOne.btnProduct.Button_WOC();
            this.tatilGünü = new System.Windows.Forms.Label();
            this.cmbBoxHoliday = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(172, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marketi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(172, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pozisyonu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(172, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adı";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(172, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adresi";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(172, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "Maaşı";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbMarket
            // 
            this.cmbMarket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMarket.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbMarket.FormattingEnabled = true;
            this.cmbMarket.Location = new System.Drawing.Point(397, 105);
            this.cmbMarket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMarket.Name = "cmbMarket";
            this.cmbMarket.Size = new System.Drawing.Size(306, 45);
            this.cmbMarket.TabIndex = 6;
            // 
            // cmbPozisyon
            // 
            this.cmbPozisyon.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cmbPozisyon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPozisyon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbPozisyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbPozisyon.FormattingEnabled = true;
            this.cmbPozisyon.Items.AddRange(new object[] {
            "Müdür",
            "Müdür Yardımcısı",
            "Kasiyer"});
            this.cmbPozisyon.Location = new System.Drawing.Point(397, 171);
            this.cmbPozisyon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPozisyon.Name = "cmbPozisyon";
            this.cmbPozisyon.Size = new System.Drawing.Size(306, 45);
            this.cmbPozisyon.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.Location = new System.Drawing.Point(397, 246);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(306, 44);
            this.txtName.TabIndex = 8;
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdres.Location = new System.Drawing.Point(397, 321);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(306, 44);
            this.txtAdres.TabIndex = 9;
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSalary.Location = new System.Drawing.Point(396, 396);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(306, 44);
            this.txtSalary.TabIndex = 10;
            this.txtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalary_KeyPress);
            // 
            // addButton
            // 
            this.addButton.BorderColor = System.Drawing.Color.Silver;
            this.addButton.ButtonColor = System.Drawing.Color.Red;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addButton.Location = new System.Drawing.Point(503, 569);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.addButton.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.addButton.OnHoverTextColor = System.Drawing.Color.Gray;
            this.addButton.Size = new System.Drawing.Size(200, 65);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Ekle";
            this.addButton.TextColor = System.Drawing.Color.White;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // tatilGünü
            // 
            this.tatilGünü.AutoSize = true;
            this.tatilGünü.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tatilGünü.Location = new System.Drawing.Point(172, 478);
            this.tatilGünü.Name = "tatilGünü";
            this.tatilGünü.Size = new System.Drawing.Size(166, 37);
            this.tatilGünü.TabIndex = 13;
            this.tatilGünü.Text = "Tatil Günü";
            this.tatilGünü.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbBoxHoliday
            // 
            this.cmbBoxHoliday.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cmbBoxHoliday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxHoliday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBoxHoliday.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBoxHoliday.FormattingEnabled = true;
            this.cmbBoxHoliday.Items.AddRange(new object[] {
            "Pazar",
            "Pazartesi",
            "Salı",
            "Çarşamba",
            "Perşembe",
            "Cuma",
            "Cumartesi"});
            this.cmbBoxHoliday.Location = new System.Drawing.Point(396, 470);
            this.cmbBoxHoliday.Name = "cmbBoxHoliday";
            this.cmbBoxHoliday.Size = new System.Drawing.Size(307, 45);
            this.cmbBoxHoliday.TabIndex = 14;
            // 
            // FormAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 735);
            this.Controls.Add(this.cmbBoxHoliday);
            this.Controls.Add(this.tatilGünü);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cmbPozisyon);
            this.Controls.Add(this.cmbMarket);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAddEmployee";
            this.Text = "FormAddEmployee";
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
        private System.Windows.Forms.ComboBox cmbMarket;
        private System.Windows.Forms.ComboBox cmbPozisyon;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtSalary;
        private ePOSOne.btnProduct.Button_WOC addButton;
        private System.Windows.Forms.Label tatilGünü;
        private System.Windows.Forms.ComboBox cmbBoxHoliday;
    }
}