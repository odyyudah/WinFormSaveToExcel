namespace WindowsFormsApplication1
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.NorthwindBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNorthwind = new WindowsFormsApplication1.dsNorthwind();
            this.NorthwindTableAdapter = new WindowsFormsApplication1.dsNorthwindTableAdapters.NorthwindTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NorthwindBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNorthwind)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.NorthwindBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Northwind.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 41);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(578, 306);
            this.reportViewer1.TabIndex = 0;
            // 
            // NorthwindBindingSource
            // 
            this.NorthwindBindingSource.DataMember = "Northwind";
            this.NorthwindBindingSource.DataSource = this.dsNorthwind;
            // 
            // dsNorthwind
            // 
            this.dsNorthwind.DataSetName = "dsNorthwind";
            this.dsNorthwind.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NorthwindTableAdapter
            // 
            this.NorthwindTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save to MSExcel format";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 359);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NorthwindBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNorthwind)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource NorthwindBindingSource;
        private dsNorthwind dsNorthwind;
        private dsNorthwindTableAdapters.NorthwindTableAdapter NorthwindTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}

