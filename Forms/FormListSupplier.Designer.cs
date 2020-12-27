
namespace MarketProject.Forms
{
    partial class FormListSupplier
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
            this.dataSupplier = new System.Windows.Forms.DataGridView();
            this.btnDel = new ePOSOne.btnProduct.Button_WOC();
            this.btnSave = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.dataSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSupplier
            // 
            this.dataSupplier.AllowUserToAddRows = false;
            this.dataSupplier.AllowUserToDeleteRows = false;
            this.dataSupplier.AllowUserToResizeColumns = false;
            this.dataSupplier.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataSupplier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSupplier.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataSupplier.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataSupplier.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataSupplier.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataSupplier.Location = new System.Drawing.Point(152, 55);
            this.dataSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataSupplier.Name = "dataSupplier";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataSupplier.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataSupplier.RowHeadersWidth = 30;
            this.dataSupplier.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataSupplier.RowTemplate.Height = 28;
            this.dataSupplier.Size = new System.Drawing.Size(690, 543);
            this.dataSupplier.TabIndex = 0;
            // 
            // btnDel
            // 
            this.btnDel.BorderColor = System.Drawing.Color.Silver;
            this.btnDel.ButtonColor = System.Drawing.Color.Red;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDel.Location = new System.Drawing.Point(240, 649);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDel.Name = "btnDel";
            this.btnDel.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnDel.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnDel.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnDel.Size = new System.Drawing.Size(168, 69);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Sil";
            this.btnDel.TextColor = System.Drawing.Color.White;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BorderColor = System.Drawing.Color.Silver;
            this.btnSave.ButtonColor = System.Drawing.Color.Red;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Location = new System.Drawing.Point(598, 649);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnSave.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnSave.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnSave.Size = new System.Drawing.Size(173, 70);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Kaydet";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormListSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 789);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataSupplier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormListSupplier";
            this.Text = "FormListSupplier";
            this.Load += new System.EventHandler(this.FormListSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSupplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataSupplier;
        private ePOSOne.btnProduct.Button_WOC btnSave;
        private ePOSOne.btnProduct.Button_WOC btnDel;
    }
}