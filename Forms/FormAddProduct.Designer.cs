
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
            this.cmbBoxSupplier = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddProduct = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // txtproductName
            // 
            this.txtproductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtproductName.Location = new System.Drawing.Point(367, 190);
            this.txtproductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtproductName.Multiline = true;
            this.txtproductName.Name = "txtproductName";
            this.txtproductName.Size = new System.Drawing.Size(296, 48);
            this.txtproductName.TabIndex = 1;
            // 
            // txtproductPrice
            // 
            this.txtproductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtproductPrice.Location = new System.Drawing.Point(367, 296);
            this.txtproductPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtproductPrice.Multiline = true;
            this.txtproductPrice.Name = "txtproductPrice";
            this.txtproductPrice.Size = new System.Drawing.Size(296, 48);
            this.txtproductPrice.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(188, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(158, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ürün Fiyatı:";
            // 
            // cmbBoxSupplier
            // 
            this.cmbBoxSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbBoxSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBoxSupplier.FormattingEnabled = true;
            this.cmbBoxSupplier.Location = new System.Drawing.Point(367, 411);
            this.cmbBoxSupplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbBoxSupplier.Name = "cmbBoxSupplier";
            this.cmbBoxSupplier.Size = new System.Drawing.Size(296, 45);
            this.cmbBoxSupplier.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(181, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 37);
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
            this.btnAddProduct.Location = new System.Drawing.Point(407, 525);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddProduct.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddProduct.Size = new System.Drawing.Size(212, 90);
            this.btnAddProduct.TabIndex = 3;
            this.btnAddProduct.Text = "Ürün Ekle";
            this.btnAddProduct.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(255)))), ((int)(((byte)(226)))));
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // FormAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 789);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbBoxSupplier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtproductPrice);
            this.Controls.Add(this.txtproductName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.ComboBox cmbBoxSupplier;
        private System.Windows.Forms.Label label3;
    }
}