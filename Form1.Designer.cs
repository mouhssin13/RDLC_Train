namespace RDLC_Train
{
    partial class Form1
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
            this.dWIstanbulMallDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new RDLC_Train.DW_Istanbul_MallDataSetTableAdapters.CustomerTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dW_Istanbul_MallDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dWIstanbulMallDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.customerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RDLC_Train.Simple1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-2, 159);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1085, 404);
            this.reportViewer1.TabIndex = 0;
            // 
            // dW_Istanbul_MallDataSet
            // 
            this.dW_Istanbul_MallDataSet.DataSetName = "DW_Istanbul_MallDataSet";
            this.dW_Istanbul_MallDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dWIstanbulMallDataSetBindingSource
            // 
            this.dWIstanbulMallDataSetBindingSource.DataSource = this.dW_Istanbul_MallDataSet;
            this.dWIstanbulMallDataSetBindingSource.Position = 0;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.dWIstanbulMallDataSetBindingSource;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(373, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate PDF";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 588);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dW_Istanbul_MallDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dWIstanbulMallDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DW_Istanbul_MallDataSet dW_Istanbul_MallDataSet;
        private System.Windows.Forms.BindingSource dWIstanbulMallDataSetBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private DW_Istanbul_MallDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}

