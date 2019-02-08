namespace Model
{
    partial class FrmClienteRedeFiltro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClienteRedeFiltro));
            this.cmbRede = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeFinal = new System.Windows.Forms.DateTimePicker();
            this.dateTimeInicial = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cmbRede
            // 
            this.cmbRede.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRede.FormattingEnabled = true;
            this.cmbRede.Items.AddRange(new object[] {
            "TODOS",
            "BAIXA",
            "MÉDIA",
            "ALTA"});
            this.cmbRede.Location = new System.Drawing.Point(130, 97);
            this.cmbRede.Name = "cmbRede";
            this.cmbRede.Size = new System.Drawing.Size(139, 21);
            this.cmbRede.TabIndex = 16;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(194, 272);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(93, 272);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 19;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Data Final:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Rede Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Data inicial:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Prioridade";
            // 
            // dateTimeFinal
            // 
            this.dateTimeFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFinal.Location = new System.Drawing.Point(130, 168);
            this.dateTimeFinal.Name = "dateTimeFinal";
            this.dateTimeFinal.Size = new System.Drawing.Size(97, 20);
            this.dateTimeFinal.TabIndex = 18;
            // 
            // dateTimeInicial
            // 
            this.dateTimeInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeInicial.Location = new System.Drawing.Point(130, 133);
            this.dateTimeInicial.Name = "dateTimeInicial";
            this.dateTimeInicial.Size = new System.Drawing.Size(97, 20);
            this.dateTimeInicial.TabIndex = 17;
            // 
            // FrmClienteRedeFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 327);
            this.Controls.Add(this.cmbRede);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeFinal);
            this.Controls.Add(this.dateTimeInicial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmClienteRedeFiltro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRede;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeFinal;
        private System.Windows.Forms.DateTimePicker dateTimeInicial;
    }
}