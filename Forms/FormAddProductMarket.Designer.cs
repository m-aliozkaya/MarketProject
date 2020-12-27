
namespace MarketProject.Forms
{
    partial class FormAddProductMarket
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkListProducts = new System.Windows.Forms.CheckedListBox();
            this.btnAddMarket = new ePOSOne.btnProduct.Button_WOC();
            this.cmbBoxMarkets = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(453, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(313, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "(Stoğu olmayan ürününüzü 0 olarak giriniz!)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(433, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Seçilmiş ürünlerin sırasına göre ürün stoklarını satır satır girin.";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(405, 132);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(423, 318);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(45, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 32);
            this.label3.TabIndex = 19;
            this.label3.Text = "ÜRÜNLER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(399, 528);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "Market";
            // 
            // checkListProducts
            // 
            this.checkListProducts.FormattingEnabled = true;
            this.checkListProducts.Location = new System.Drawing.Point(12, 76);
            this.checkListProducts.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.checkListProducts.Name = "checkListProducts";
            this.checkListProducts.Size = new System.Drawing.Size(337, 602);
            this.checkListProducts.TabIndex = 15;
            // 
            // btnAddMarket
            // 
            this.btnAddMarket.BorderColor = System.Drawing.Color.Black;
            this.btnAddMarket.ButtonColor = System.Drawing.Color.Black;
            this.btnAddMarket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddMarket.Location = new System.Drawing.Point(653, 617);
            this.btnAddMarket.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnAddMarket.Name = "btnAddMarket";
            this.btnAddMarket.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnAddMarket.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddMarket.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(255)))), ((int)(((byte)(226)))));
            this.btnAddMarket.Size = new System.Drawing.Size(181, 61);
            this.btnAddMarket.TabIndex = 16;
            this.btnAddMarket.Text = "Kaydet";
            this.btnAddMarket.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(255)))), ((int)(((byte)(226)))));
            this.btnAddMarket.UseVisualStyleBackColor = true;
            this.btnAddMarket.Click += new System.EventHandler(this.btnAddMarket_Click);
            // 
            // cmbBoxMarkets
            // 
            this.cmbBoxMarkets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBoxMarkets.FormattingEnabled = true;
            this.cmbBoxMarkets.Location = new System.Drawing.Point(547, 528);
            this.cmbBoxMarkets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBoxMarkets.Name = "cmbBoxMarkets";
            this.cmbBoxMarkets.Size = new System.Drawing.Size(287, 37);
            this.cmbBoxMarkets.TabIndex = 23;
            // 
            // FormAddProductMarket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 736);
            this.Controls.Add(this.cmbBoxMarkets);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddMarket);
            this.Controls.Add(this.checkListProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddProductMarket";
            this.Text = "Form Add Product MARKET";
            this.Load += new System.EventHandler(this.FormEditMarket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private ePOSOne.btnProduct.Button_WOC btnAddMarket;
        private System.Windows.Forms.CheckedListBox checkListProducts;
        private System.Windows.Forms.ComboBox cmbBoxMarkets;
    }
}