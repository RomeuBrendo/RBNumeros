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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbRede
            // 
            this.cmbRede.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbRede.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
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
            this.btnCancelar.Location = new System.Drawing.Point(194, 170);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(93, 170);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 19;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Prioridade";
            // 
            // FrmClienteRedeFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 232);
            this.Controls.Add(this.cmbRede);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}