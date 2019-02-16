namespace Model
{
    partial class FrmTecnicoRelatorio
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTecnicoRelatorio));
            this.TecnicoChamadoRelatorioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClienteColecaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerTecnicoRelatorio = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.TecnicoChamadoRelatorioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteColecaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TecnicoChamadoRelatorioBindingSource
            // 
            this.TecnicoChamadoRelatorioBindingSource.DataSource = typeof(Servicos.Entidades.TecnicoChamadoRelatorio);
            // 
            // ClienteColecaoBindingSource
            // 
            this.ClienteColecaoBindingSource.DataMember = "tblChamado";
            this.ClienteColecaoBindingSource.DataSource = typeof(Servicos.ClienteColecao);
            // 
            // reportViewerTecnicoRelatorio
            // 
            this.reportViewerTecnicoRelatorio.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetTecnicoRelatorio";
            reportDataSource1.Value = this.TecnicoChamadoRelatorioBindingSource;
            reportDataSource2.Name = "DataSetChamado";
            reportDataSource2.Value = this.ClienteColecaoBindingSource;
            this.reportViewerTecnicoRelatorio.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerTecnicoRelatorio.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerTecnicoRelatorio.LocalReport.ReportEmbeddedResource = "Model.ReportTecnicoRelatorio.rdlc";
            this.reportViewerTecnicoRelatorio.Location = new System.Drawing.Point(0, 0);
            this.reportViewerTecnicoRelatorio.Name = "reportViewerTecnicoRelatorio";
            this.reportViewerTecnicoRelatorio.ServerReport.BearerToken = null;
            this.reportViewerTecnicoRelatorio.Size = new System.Drawing.Size(800, 450);
            this.reportViewerTecnicoRelatorio.TabIndex = 0;
            // 
            // FrmTecnicoRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerTecnicoRelatorio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmTecnicoRelatorio";
            this.Text = "Técnico Relatorio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmTecnicoRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TecnicoChamadoRelatorioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteColecaoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerTecnicoRelatorio;
        private System.Windows.Forms.BindingSource TecnicoChamadoRelatorioBindingSource;
        private System.Windows.Forms.BindingSource ClienteColecaoBindingSource;
    }
}