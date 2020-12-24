
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
            this.btnAddMarket = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // txtMarketName
            // 
            this.txtMarketName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMarketName.Location = new System.Drawing.Point(136, 252);
            this.txtMarketName.Name = "txtMarketName";
            this.txtMarketName.Size = new System.Drawing.Size(242, 39);
            this.txtMarketName.TabIndex = 0;
            // 
            // txtMarketAdres
            // 
            this.txtMarketAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMarketAdres.Location = new System.Drawing.Point(136, 377);
            this.txtMarketAdres.Name = "txtMarketAdres";
            this.txtMarketAdres.Size = new System.Drawing.Size(242, 39);
            this.txtMarketAdres.TabIndex = 1;
            // 
            // checkListProducts
            // 
            this.checkListProducts.FormattingEnabled = true;
            this.checkListProducts.Location = new System.Drawing.Point(464, 54);
            this.checkListProducts.Name = "checkListProducts";
            this.checkListProducts.Size = new System.Drawing.Size(313, 579);
            this.checkListProducts.TabIndex = 4;
            // 
            // btnAddMarket
            // 
            this.btnAddMarket.BorderColor = System.Drawing.Color.Silver;
            this.btnAddMarket.ButtonColor = System.Drawing.Color.Red;
            this.btnAddMarket.Location = new System.Drawing.Point(170, 536);
            this.btnAddMarket.Name = "btnAddMarket";
            this.btnAddMarket.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnAddMarket.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnAddMarket.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnAddMarket.Size = new System.Drawing.Size(181, 63);
            this.btnAddMarket.TabIndex = 5;
            this.btnAddMarket.Text = "Market Ekle";
            this.btnAddMarket.TextColor = System.Drawing.Color.White;
            this.btnAddMarket.UseVisualStyleBackColor = true;
            this.btnAddMarket.Click += new System.EventHandler(this.btnAddMarket_Click);
            // 
            // FormAddMarket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 735);
            this.ControlBox = false;
            this.Controls.Add(this.btnAddMarket);
            this.Controls.Add(this.checkListProducts);
            this.Controls.Add(this.txtMarketAdres);
            this.Controls.Add(this.txtMarketName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
    }
}