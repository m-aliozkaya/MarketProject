
namespace MarketProject
{
    partial class FormAddMarket
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
            this.txtMarketName = new System.Windows.Forms.TextBox();
            this.txtMarketAdres = new System.Windows.Forms.TextBox();
            this.checkListProducts = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddMarket = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // txtMarketName
            // 
            this.txtMarketName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMarketName.Location = new System.Drawing.Point(437, 310);
            this.txtMarketName.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txtMarketName.Name = "txtMarketName";
            this.txtMarketName.Size = new System.Drawing.Size(142, 34);
            this.txtMarketName.TabIndex = 0;
            // 
            // txtMarketAdres
            // 
            this.txtMarketAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMarketAdres.Location = new System.Drawing.Point(437, 361);
            this.txtMarketAdres.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txtMarketAdres.Name = "txtMarketAdres";
            this.txtMarketAdres.Size = new System.Drawing.Size(142, 34);
            this.txtMarketAdres.TabIndex = 1;
            // 
            // checkListProducts
            // 
            this.checkListProducts.FormattingEnabled = true;
            this.checkListProducts.Location = new System.Drawing.Point(27, 73);
            this.checkListProducts.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.checkListProducts.Name = "checkListProducts";
            this.checkListProducts.Size = new System.Drawing.Size(227, 412);
            this.checkListProducts.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(298, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Market Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(343, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Adresi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(67, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "ÜRÜNLER";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(274, 107);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(319, 146);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(395, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Seçilmiş ürünlerin sırasına göre ürün stoklarını satır satır girin.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "(Stoğu olmayan ürününüzü 0 olarak giriniz!)";
            // 
            // btnAddMarket
            // 
            this.btnAddMarket.BorderColor = System.Drawing.Color.Black;
            this.btnAddMarket.ButtonColor = System.Drawing.Color.Black;
            this.btnAddMarket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMarket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddMarket.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddMarket.Location = new System.Drawing.Point(400, 415);
            this.btnAddMarket.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnAddMarket.Name = "btnAddMarket";
            this.btnAddMarket.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnAddMarket.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddMarket.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(255)))), ((int)(((byte)(226)))));
            this.btnAddMarket.Size = new System.Drawing.Size(143, 49);
            this.btnAddMarket.TabIndex = 5;
            this.btnAddMarket.Text = "Market Ekle";
            this.btnAddMarket.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(255)))), ((int)(((byte)(226)))));
            this.btnAddMarket.UseVisualStyleBackColor = true;
            this.btnAddMarket.Click += new System.EventHandler(this.btnAddMarket_Click);
            // 
            // FormAddMarket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 634);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddMarket);
            this.Controls.Add(this.checkListProducts);
            this.Controls.Add(this.txtMarketAdres);
            this.Controls.Add(this.txtMarketName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "FormAddMarket";
            this.Text = "FormAddList";
            this.Load += new System.EventHandler(this.FormAddList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMarketName;
        private System.Windows.Forms.TextBox txtMarketAdres;
        private System.Windows.Forms.CheckedListBox checkListProducts;
        private ePOSOne.btnProduct.Button_WOC btnAddMarket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}