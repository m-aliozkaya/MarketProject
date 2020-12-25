
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
            this.btnAddProduct = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // txtproductName
            // 
            this.txtproductName.Location = new System.Drawing.Point(91, 48);
            this.txtproductName.Name = "txtproductName";
            this.txtproductName.Size = new System.Drawing.Size(152, 22);
            this.txtproductName.TabIndex = 1;
            // 
            // txtproductPrice
            // 
            this.txtproductPrice.Location = new System.Drawing.Point(91, 115);
            this.txtproductPrice.Name = "txtproductPrice";
            this.txtproductPrice.Size = new System.Drawing.Size(152, 22);
            this.txtproductPrice.TabIndex = 2;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddProduct.BorderColor = System.Drawing.Color.Black;
            this.btnAddProduct.ButtonColor = System.Drawing.Color.Black;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddProduct.Location = new System.Drawing.Point(91, 248);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddProduct.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(255)))), ((int)(((byte)(226)))));
            this.btnAddProduct.Size = new System.Drawing.Size(147, 54);
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtproductPrice);
            this.Controls.Add(this.txtproductName);
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
    }
}