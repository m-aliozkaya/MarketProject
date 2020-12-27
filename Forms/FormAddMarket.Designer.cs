
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
            this.btnAddMarket = new ePOSOne.btnProduct.Button_WOC();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMarketName
            // 
            this.txtMarketName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMarketName.Location = new System.Drawing.Point(611, 437);
            this.txtMarketName.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txtMarketName.Name = "txtMarketName";
            this.txtMarketName.Size = new System.Drawing.Size(241, 39);
            this.txtMarketName.TabIndex = 0;
            // 
            // txtMarketAdres
            // 
            this.txtMarketAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMarketAdres.Location = new System.Drawing.Point(611, 515);
            this.txtMarketAdres.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txtMarketAdres.Name = "txtMarketAdres";
            this.txtMarketAdres.Size = new System.Drawing.Size(241, 39);
            this.txtMarketAdres.TabIndex = 1;
            // 
            // checkListProducts
            // 
            this.checkListProducts.FormattingEnabled = true;
            this.checkListProducts.Location = new System.Drawing.Point(35, 68);
            this.checkListProducts.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.checkListProducts.Name = "checkListProducts";
            this.checkListProducts.Size = new System.Drawing.Size(337, 602);
            this.checkListProducts.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(394, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Market Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(405, 515);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Adresi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(68, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "ÜRÜNLER";
            // 
            // btnAddMarket
            // 
            this.btnAddMarket.BorderColor = System.Drawing.Color.Black;
            this.btnAddMarket.ButtonColor = System.Drawing.Color.Black;
            this.btnAddMarket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddMarket.Location = new System.Drawing.Point(671, 648);
            this.btnAddMarket.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnAddMarket.Name = "btnAddMarket";
            this.btnAddMarket.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnAddMarket.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddMarket.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(255)))), ((int)(((byte)(226)))));
            this.btnAddMarket.Size = new System.Drawing.Size(181, 61);
            this.btnAddMarket.TabIndex = 5;
            this.btnAddMarket.Text = "Market Ekle";
            this.btnAddMarket.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(255)))), ((int)(((byte)(226)))));
            this.btnAddMarket.UseVisualStyleBackColor = true;
            this.btnAddMarket.Click += new System.EventHandler(this.btnAddMarket_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(454, 124);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(423, 227);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(433, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Seçilmiş ürünlerin sırasına göre ürün stoklarını satır satır girin.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(502, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(313, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "(Stoğu olmayan ürününüzü 0 olarak giriniz!)";
            // 
            // FormAddMarket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 789);
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