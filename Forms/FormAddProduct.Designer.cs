
namespace MarketProject.Forms
{
    partial class FormAddProduct
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
            this.txtproductName = new System.Windows.Forms.TextBox();
            this.txtproductPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBoxMarket = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddProduct = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // txtproductName
            // 
            this.txtproductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtproductName.Location = new System.Drawing.Point(326, 152);
            this.txtproductName.Multiline = true;
            this.txtproductName.Name = "txtproductName";
            this.txtproductName.Size = new System.Drawing.Size(264, 39);
            this.txtproductName.TabIndex = 1;
            // 
            // txtproductPrice
            // 
            this.txtproductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtproductPrice.Location = new System.Drawing.Point(326, 237);
            this.txtproductPrice.Multiline = true;
            this.txtproductPrice.Name = "txtproductPrice";
            this.txtproductPrice.Size = new System.Drawing.Size(264, 39);
            this.txtproductPrice.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(167, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(140, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ürün Fiyatı:";
            // 
            // cmbBoxMarket
            // 
            this.cmbBoxMarket.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBoxMarket.FormattingEnabled = true;
            this.cmbBoxMarket.Location = new System.Drawing.Point(326, 327);
            this.cmbBoxMarket.Name = "cmbBoxMarket";
            this.cmbBoxMarket.Size = new System.Drawing.Size(264, 39);
            this.cmbBoxMarket.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(161, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tedarikçi:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddProduct.BorderColor = System.Drawing.Color.Black;
            this.btnAddProduct.ButtonColor = System.Drawing.Color.Black;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddProduct.Location = new System.Drawing.Point(362, 420);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddProduct.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddProduct.Size = new System.Drawing.Size(188, 72);
            this.btnAddProduct.TabIndex = 3;
            this.btnAddProduct.Text = "Ürün Ekle";
            this.btnAddProduct.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(255)))), ((int)(((byte)(226)))));
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // FormAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 631);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbBoxMarket);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtproductPrice);
            this.Controls.Add(this.txtproductName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddProduct";
            this.Text = "FormAddProduct";
            this.Load += new System.EventHandler(this.FormAddProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtproductName;
        private System.Windows.Forms.TextBox txtproductPrice;
        private ePOSOne.btnProduct.Button_WOC btnAddProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBoxMarket;
        private System.Windows.Forms.Label label3;
    }
}