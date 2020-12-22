﻿
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.marketProjectDataSet = new MarketProject.MarketProjectDataSet();
            this.marketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marketTableAdapter = new MarketProject.MarketProjectDataSetTableAdapters.MarketTableAdapter();
            this.marketIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marketNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marketAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 34;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.marketIDDataGridViewTextBoxColumn,
            this.marketNameDataGridViewTextBoxColumn,
            this.marketAdresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.marketBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(846, 679);
            this.dataGridView1.TabIndex = 0;
            // 
            // marketProjectDataSet
            // 
            this.marketProjectDataSet.DataSetName = "MarketProjectDataSet";
            this.marketProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marketBindingSource
            // 
            this.marketBindingSource.DataMember = "Market";
            this.marketBindingSource.DataSource = this.marketProjectDataSet;
            // 
            // marketTableAdapter
            // 
            this.marketTableAdapter.ClearBeforeFill = true;
            // 
            // marketIDDataGridViewTextBoxColumn
            // 
            this.marketIDDataGridViewTextBoxColumn.DataPropertyName = "marketID";
            this.marketIDDataGridViewTextBoxColumn.HeaderText = "marketID";
            this.marketIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.marketIDDataGridViewTextBoxColumn.Name = "marketIDDataGridViewTextBoxColumn";
            // 
            // marketNameDataGridViewTextBoxColumn
            // 
            this.marketNameDataGridViewTextBoxColumn.DataPropertyName = "marketName";
            this.marketNameDataGridViewTextBoxColumn.HeaderText = "marketName";
            this.marketNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.marketNameDataGridViewTextBoxColumn.Name = "marketNameDataGridViewTextBoxColumn";
            // 
            // marketAdresDataGridViewTextBoxColumn
            // 
            this.marketAdresDataGridViewTextBoxColumn.DataPropertyName = "marketAdres";
            this.marketAdresDataGridViewTextBoxColumn.HeaderText = "marketAdres";
            this.marketAdresDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.marketAdresDataGridViewTextBoxColumn.Name = "marketAdresDataGridViewTextBoxColumn";
            // 
            // FormListMarket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 679);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormListMarket";
            this.Text = "FormListMarket";
            this.Load += new System.EventHandler(this.FormListMarket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MarketProjectDataSet marketProjectDataSet;
        private System.Windows.Forms.BindingSource marketBindingSource;
        private MarketProjectDataSetTableAdapters.MarketTableAdapter marketTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn marketIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marketNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marketAdresDataGridViewTextBoxColumn;
    }
}