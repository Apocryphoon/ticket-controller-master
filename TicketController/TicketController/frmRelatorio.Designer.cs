
namespace TicketController
{
    partial class frmRelatorio
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorio));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.hostgatordbDataSet = new TicketController.hostgatordbDataSet();
            this.hostgatordbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bravogrcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bravogrcTableAdapter = new TicketController.hostgatordbDataSetTableAdapters.bravogrcTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hostgatordbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostgatordbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bravogrcBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "bravogrc_dataset";
            reportDataSource1.Value = this.bravogrcBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TicketController.Relatorios.RelatorioChamados.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(697, 803);
            this.reportViewer1.TabIndex = 0;
            // 
            // hostgatordbDataSet
            // 
            this.hostgatordbDataSet.DataSetName = "hostgatordbDataSet";
            this.hostgatordbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hostgatordbDataSetBindingSource
            // 
            this.hostgatordbDataSetBindingSource.DataSource = this.hostgatordbDataSet;
            this.hostgatordbDataSetBindingSource.Position = 0;
            // 
            // bravogrcBindingSource
            // 
            this.bravogrcBindingSource.DataMember = "bravogrc";
            this.bravogrcBindingSource.DataSource = this.hostgatordbDataSet;
            // 
            // bravogrcTableAdapter
            // 
            this.bravogrcTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 803);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRelatorio";
            this.Load += new System.EventHandler(this.frmRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hostgatordbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostgatordbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bravogrcBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource hostgatordbDataSetBindingSource;
        private hostgatordbDataSet hostgatordbDataSet;
        private System.Windows.Forms.BindingSource bravogrcBindingSource;
        private hostgatordbDataSetTableAdapters.bravogrcTableAdapter bravogrcTableAdapter;
    }
}