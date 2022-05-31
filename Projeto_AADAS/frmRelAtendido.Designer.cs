
namespace Projeto_AADAS
{
    partial class FrmRelAtendido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelAtendido));
            this.atendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scdasDataSet = new Projeto_AADAS.scdasDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.atendidosTableAdapter = new Projeto_AADAS.scdasDataSetTableAdapters.atendidosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.atendidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scdasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // atendidosBindingSource
            // 
            this.atendidosBindingSource.DataMember = "atendidos";
            this.atendidosBindingSource.DataSource = this.scdasDataSet;
            // 
            // scdasDataSet
            // 
            this.scdasDataSet.DataSetName = "scdasDataSet";
            this.scdasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetAtendido";
            reportDataSource1.Value = this.atendidosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projeto_AADAS.Relatorios.RelAtendidos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(819, 574);
            this.reportViewer1.TabIndex = 0;
            // 
            // atendidosTableAdapter
            // 
            this.atendidosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelAtendido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(819, 574);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmRelAtendido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RELATÓRIO ATENDIDO";
            this.Load += new System.EventHandler(this.FrmRelAtendido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.atendidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scdasDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource atendidosBindingSource;
        private scdasDataSet scdasDataSet;
        private scdasDataSetTableAdapters.atendidosTableAdapter atendidosTableAdapter;
    }
}