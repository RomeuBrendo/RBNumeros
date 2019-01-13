namespace Model
{
    partial class FrmChamadoTecnico
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
            this.dateTimeInicial = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFinal = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // dateTimeInicial
            // 
            this.dateTimeInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeInicial.Location = new System.Drawing.Point(27, 12);
            this.dateTimeInicial.Name = "dateTimeInicial";
            this.dateTimeInicial.Size = new System.Drawing.Size(90, 20);
            this.dateTimeInicial.TabIndex = 1;
            // 
            // dateTimeFinal
            // 
            this.dateTimeFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFinal.Location = new System.Drawing.Point(176, 12);
            this.dateTimeFinal.Name = "dateTimeFinal";
            this.dateTimeFinal.Size = new System.Drawing.Size(86, 20);
            this.dateTimeFinal.TabIndex = 2;
            // 
            // FrmChamadoTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimeFinal);
            this.Controls.Add(this.dateTimeInicial);
            this.Name = "FrmChamadoTecnico";
            this.Text = "FrmChamadoTecnico";
            this.Load += new System.EventHandler(this.FrmChamadoTecnico_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimeInicial;
        private System.Windows.Forms.DateTimePicker dateTimeFinal;
    }
}