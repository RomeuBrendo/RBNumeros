namespace Model
{
    partial class FrmClienteRedeRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClienteRedeRelatorio));
            this.reportClienteRede = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportClienteRede
            // 
            this.reportClienteRede.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportClienteRede.LocalReport.ReportEmbeddedResource = "Model.ReportClienteRede.rdlc";
            this.reportClienteRede.Location = new System.Drawing.Point(0, 0);
            this.reportClienteRede.Name = "reportClienteRede";
            this.reportClienteRede.ServerReport.BearerToken = null;
            this.reportClienteRede.Size = new System.Drawing.Size(800, 450);
            this.reportClienteRede.TabIndex = 0;
            // 
            // FrmClienteRedeRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportClienteRede);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmClienteRedeRelatorio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmClienteRedeRelatorio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportClienteRede;
    }
}