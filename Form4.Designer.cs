namespace RDLC_Train
{
    partial class Form4
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dW_Istanbul_MallDataSet = new RDLC_Train.DW_Istanbul_MallDataSet();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new RDLC_Train.DW_Istanbul_MallDataSetTableAdapters.DataTable1TableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.mallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mallTableAdapter = new RDLC_Train.DW_Istanbul_MallDataSetTableAdapters.MallTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.mallBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dW_Istanbul_MallDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mallBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mallBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.dataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RDLC_Train.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(22, 118);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1098, 463);
            this.reportViewer1.TabIndex = 0;
            // 
            // dW_Istanbul_MallDataSet
            // 
            this.dW_Istanbul_MallDataSet.DataSetName = "DW_Istanbul_MallDataSet";
            this.dW_Istanbul_MallDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dW_Istanbul_MallDataSet;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(62, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 100);
            this.panel1.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(785, 51);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(191, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Generate PDF";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(785, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Load";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // mallBindingSource
            // 
            this.mallBindingSource.DataMember = "Mall";
            this.mallBindingSource.DataSource = this.dW_Istanbul_MallDataSet;
            // 
            // mallTableAdapter
            // 
            this.mallTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.mallBindingSource1;
            this.comboBox1.DisplayMember = "shopping_mall";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(89, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(305, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "shopping_mall";
            // 
            // mallBindingSource1
            // 
            this.mallBindingSource1.DataMember = "Mall";
            this.mallBindingSource1.DataSource = this.dW_Istanbul_MallDataSet;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 614);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dW_Istanbul_MallDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mallBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mallBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DW_Istanbul_MallDataSet dW_Istanbul_MallDataSet;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DW_Istanbul_MallDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource mallBindingSource;
        private DW_Istanbul_MallDataSetTableAdapters.MallTableAdapter mallTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource mallBindingSource1;
    }
}