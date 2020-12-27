
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataProduct = new System.Windows.Forms.DataGridView();
            this.cmbBoxMarkets = new System.Windows.Forms.ComboBox();
            this.btnSave = new ePOSOne.btnProduct.Button_WOC();
            this.btnEdit = new ePOSOne.btnProduct.Button_WOC();
            this.btnDel = new ePOSOne.btnProduct.Button_WOC();
            this.dataEmployee = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dataProduct
            // 
            this.dataProduct.AllowUserToAddRows = false;
            this.dataProduct.AllowUserToDeleteRows = false;
            this.dataProduct.AllowUserToResizeColumns = false;
            this.dataProduct.AllowUserToResizeRows = false;
            this.dataProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataProduct.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataProduct.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataProduct.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataProduct.Location = new System.Drawing.Point(79, 129);
            this.dataProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataProduct.Name = "dataProduct";
            this.dataProduct.RowHeadersWidth = 30;
            this.dataProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataProduct.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataProduct.RowTemplate.Height = 28;
            this.dataProduct.Size = new System.Drawing.Size(704, 210);
            this.dataProduct.TabIndex = 0;
            // 
            // cmbBoxMarkets
            // 
            this.cmbBoxMarkets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBoxMarkets.FormattingEnabled = true;
            this.cmbBoxMarkets.Location = new System.Drawing.Point(67, 54);
            this.cmbBoxMarkets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBoxMarkets.Name = "cmbBoxMarkets";
            this.cmbBoxMarkets.Size = new System.Drawing.Size(560, 37);
            this.cmbBoxMarkets.TabIndex = 2;
            this.cmbBoxMarkets.SelectedIndexChanged += new System.EventHandler(this.cmbBoxMarkets_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.BorderColor = System.Drawing.Color.Silver;
            this.btnSave.ButtonColor = System.Drawing.Color.Red;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Location = new System.Drawing.Point(680, 98);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnSave.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnSave.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnSave.Size = new System.Drawing.Size(240, 50);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Değişiklikleri Kaydet";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BorderColor = System.Drawing.Color.Silver;
            this.btnEdit.ButtonColor = System.Drawing.Color.Red;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEdit.Location = new System.Drawing.Point(794, 24);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnEdit.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnEdit.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnEdit.Size = new System.Drawing.Size(126, 50);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Ürün Ekle";
            this.btnEdit.TextColor = System.Drawing.Color.White;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.BorderColor = System.Drawing.Color.Silver;
            this.btnDel.ButtonColor = System.Drawing.Color.Red;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDel.Location = new System.Drawing.Point(680, 24);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDel.Name = "btnDel";
            this.btnDel.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnDel.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnDel.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnDel.Size = new System.Drawing.Size(84, 48);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "Sil";
            this.btnDel.TextColor = System.Drawing.Color.White;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // dataEmployee
            // 
            this.dataEmployee.AllowUserToAddRows = false;
            this.dataEmployee.AllowUserToDeleteRows = false;
            this.dataEmployee.AllowUserToResizeColumns = false;
            this.dataEmployee.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataEmployee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataEmployee.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataEmployee.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataEmployee.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataEmployee.Location = new System.Drawing.Point(113, 321);
            this.dataEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataEmployee.Name = "dataEmployee";
            this.dataEmployee.RowHeadersWidth = 30;
            this.dataEmployee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataEmployee.RowTemplate.Height = 24;
            this.dataEmployee.Size = new System.Drawing.Size(719, 439);
            this.dataEmployee.TabIndex = 8;
            // 
            // FormListMarket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 789);
            this.Controls.Add(this.dataEmployee);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.cmbBoxMarkets);
            this.Controls.Add(this.dataProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormListMarket";
            this.Text = "FormListMarket";
            this.Load += new System.EventHandler(this.FormListMarket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataProduct;
        private System.Windows.Forms.ComboBox cmbBoxMarkets;
        private ePOSOne.btnProduct.Button_WOC btnDel;
        private ePOSOne.btnProduct.Button_WOC btnEdit;
        private ePOSOne.btnProduct.Button_WOC btnSave;
        private System.Windows.Forms.DataGridView dataEmployee;
    }
}