namespace MDJ
{
    partial class ViewSales
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
            this.mDJDataSet = new MDJ.MDJDataSet();
            this.getSalesDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getSalesDetailsTableAdapter = new MDJ.MDJDataSetTableAdapters.GetSalesDetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDJDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSalesDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(633, 346);
            this.dataGridView1.TabIndex = 0;
            // 
            // mDJDataSet
            // 
            this.mDJDataSet.DataSetName = "MDJDataSet";
            this.mDJDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getSalesDetailsBindingSource
            // 
            this.getSalesDetailsBindingSource.DataMember = "GetSalesDetails";
            this.getSalesDetailsBindingSource.DataSource = this.mDJDataSet;
            // 
            // getSalesDetailsTableAdapter
            // 
            this.getSalesDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // ViewSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 346);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewSales";
            this.Text = "ViewSales";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDJDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSalesDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource getSalesDetailsBindingSource;
        private MDJDataSet mDJDataSet;
        private MDJDataSetTableAdapters.GetSalesDetailsTableAdapter getSalesDetailsTableAdapter;
    }
}