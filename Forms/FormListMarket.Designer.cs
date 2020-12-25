
namespace MarketProject
{
    partial class FormListMarket
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
            this.dataProduct = new System.Windows.Forms.DataGridView();
            this.dataEmployee = new System.Windows.Forms.DataGridView();
            this.cmbBoxMarkets = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dataProduct
            // 
            this.dataProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProduct.Location = new System.Drawing.Point(71, 83);
            this.dataProduct.Name = "dataProduct";
            this.dataProduct.RowHeadersWidth = 62;
            this.dataProduct.RowTemplate.Height = 28;
            this.dataProduct.Size = new System.Drawing.Size(705, 258);
            this.dataProduct.TabIndex = 0;
            // 
            // dataEmployee
            // 
            this.dataEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEmployee.Location = new System.Drawing.Point(71, 384);
            this.dataEmployee.Name = "dataEmployee";
            this.dataEmployee.RowHeadersWidth = 62;
            this.dataEmployee.RowTemplate.Height = 28;
            this.dataEmployee.Size = new System.Drawing.Size(705, 258);
            this.dataEmployee.TabIndex = 1;
            // 
            // cmbBoxMarkets
            // 
            this.cmbBoxMarkets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBoxMarkets.FormattingEnabled = true;
            this.cmbBoxMarkets.Location = new System.Drawing.Point(143, 12);
            this.cmbBoxMarkets.Name = "cmbBoxMarkets";
            this.cmbBoxMarkets.Size = new System.Drawing.Size(580, 37);
            this.cmbBoxMarkets.TabIndex = 2;
            this.cmbBoxMarkets.SelectedIndexChanged += new System.EventHandler(this.cmbBoxMarkets_SelectedIndexChanged);
            // 
            // FormListMarket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 679);
            this.Controls.Add(this.cmbBoxMarkets);
            this.Controls.Add(this.dataEmployee);
            this.Controls.Add(this.dataProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormListMarket";
            this.Text = "FormListMarket";
            this.Load += new System.EventHandler(this.FormListMarket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataProduct;
        private System.Windows.Forms.DataGridView dataEmployee;
        private System.Windows.Forms.ComboBox cmbBoxMarkets;
    }
}