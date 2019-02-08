namespace Model
{
    partial class FrmNR
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNR));
            this.dataGridNR = new System.Windows.Forms.DataGridView();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chamados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDataInicial = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.checkBoxRecorrente = new System.Windows.Forms.CheckBox();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.checkBoxPerdido = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.toolTipRecorrentes = new System.Windows.Forms.ToolTip(this.components);
            this.panelNRDetalhado = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridNRDetalhado = new System.Windows.Forms.DataGridView();
            this.Chamado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataAbertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Assunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dateTimeInicial = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFinal = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNR)).BeginInit();
            this.panelNRDetalhado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNRDetalhado)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridNR
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dataGridNR.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridNR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cliente,
            this.Chamados});
            this.dataGridNR.Location = new System.Drawing.Point(12, 70);
            this.dataGridNR.MultiSelect = false;
            this.dataGridNR.Name = "dataGridNR";
            this.dataGridNR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridNR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridNR.Size = new System.Drawing.Size(745, 448);
            this.dataGridNR.TabIndex = 1;
            this.dataGridNR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridNR_KeyDown);
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "NomeCliente";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.Cliente.DefaultCellStyle = dataGridViewCellStyle2;
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 600;
            // 
            // Chamados
            // 
            this.Chamados.DataPropertyName = "Quantidade";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Chamados.DefaultCellStyle = dataGridViewCellStyle3;
            this.Chamados.HeaderText = "Chamados";
            this.Chamados.Name = "Chamados";
            // 
            // lblDataInicial
            // 
            this.lblDataInicial.AutoSize = true;
            this.lblDataInicial.Location = new System.Drawing.Point(12, 29);
            this.lblDataInicial.Name = "lblDataInicial";
            this.lblDataInicial.Size = new System.Drawing.Size(62, 13);
            this.lblDataInicial.TabIndex = 3;
            this.lblDataInicial.Text = "Data inicial:";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(177, 29);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(55, 13);
            this.lblFinal.TabIndex = 5;
            this.lblFinal.Text = "Data final:";
            // 
            // checkBoxRecorrente
            // 
            this.checkBoxRecorrente.AutoSize = true;
            this.checkBoxRecorrente.Checked = true;
            this.checkBoxRecorrente.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRecorrente.Location = new System.Drawing.Point(345, 26);
            this.checkBoxRecorrente.Name = "checkBoxRecorrente";
            this.checkBoxRecorrente.Size = new System.Drawing.Size(137, 17);
            this.checkBoxRecorrente.TabIndex = 2;
            this.checkBoxRecorrente.Text = "Chamados Recorrentes";
            this.checkBoxRecorrente.UseVisualStyleBackColor = true;
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(682, 24);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 23);
            this.btnCarregar.TabIndex = 4;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // checkBoxPerdido
            // 
            this.checkBoxPerdido.AutoSize = true;
            this.checkBoxPerdido.Checked = true;
            this.checkBoxPerdido.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPerdido.Location = new System.Drawing.Point(488, 28);
            this.checkBoxPerdido.Name = "checkBoxPerdido";
            this.checkBoxPerdido.Size = new System.Drawing.Size(181, 17);
            this.checkBoxPerdido.TabIndex = 3;
            this.checkBoxPerdido.Text = "Chamado Perdido / Sem contato";
            this.checkBoxPerdido.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Total chamados:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(104, 54);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 10;
            // 
            // toolTipRecorrentes
            // 
            this.toolTipRecorrentes.Tag = "teste";
            this.toolTipRecorrentes.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // panelNRDetalhado
            // 
            this.panelNRDetalhado.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelNRDetalhado.Controls.Add(this.label2);
            this.panelNRDetalhado.Controls.Add(this.dataGridNRDetalhado);
            this.panelNRDetalhado.Location = new System.Drawing.Point(12, 70);
            this.panelNRDetalhado.Name = "panelNRDetalhado";
            this.panelNRDetalhado.Size = new System.Drawing.Size(745, 448);
            this.panelNRDetalhado.TabIndex = 11;
            this.panelNRDetalhado.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(222, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Detalhamento do Cliente";
            // 
            // dataGridNRDetalhado
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            this.dataGridNRDetalhado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridNRDetalhado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNRDetalhado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chamado,
            this.DataAbertura,
            this.Nome,
            this.Assunto});
            this.dataGridNRDetalhado.Location = new System.Drawing.Point(0, 32);
            this.dataGridNRDetalhado.MultiSelect = false;
            this.dataGridNRDetalhado.Name = "dataGridNRDetalhado";
            this.dataGridNRDetalhado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridNRDetalhado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridNRDetalhado.Size = new System.Drawing.Size(745, 413);
            this.dataGridNRDetalhado.TabIndex = 0;
            this.dataGridNRDetalhado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridNRDetalhado_KeyDown);
            // 
            // Chamado
            // 
            this.Chamado.DataPropertyName = "Id";
            this.Chamado.HeaderText = "Chamado";
            this.Chamado.Name = "Chamado";
            this.Chamado.ReadOnly = true;
            this.Chamado.Width = 70;
            // 
            // DataAbertura
            // 
            this.DataAbertura.DataPropertyName = "DataAbertura";
            this.DataAbertura.HeaderText = "Data Abertura";
            this.DataAbertura.Name = "DataAbertura";
            this.DataAbertura.ReadOnly = true;
            this.DataAbertura.Width = 110;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Aberto Por";
            this.Nome.Name = "Nome";
            this.Nome.Width = 120;
            // 
            // Assunto
            // 
            this.Assunto.DataPropertyName = "Assunto";
            this.Assunto.HeaderText = "Assunto";
            this.Assunto.Name = "Assunto";
            this.Assunto.ReadOnly = true;
            this.Assunto.Width = 400;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 513);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(771, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(399, 17);
            this.toolStripStatusLabel1.Text = "Selecione o cliente e aperte ENTER ou a tecla D para ver seu detalhamento.";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(243, 17);
            this.toolStripStatusLabel2.Text = "Aperte ESC para sair da tela de detalhamento";
            // 
            // dateTimeInicial
            // 
            this.dateTimeInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeInicial.Location = new System.Drawing.Point(80, 24);
            this.dateTimeInicial.Name = "dateTimeInicial";
            this.dateTimeInicial.Size = new System.Drawing.Size(90, 20);
            this.dateTimeInicial.TabIndex = 0;
            // 
            // dateTimeFinal
            // 
            this.dateTimeFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFinal.Location = new System.Drawing.Point(238, 25);
            this.dateTimeFinal.Name = "dateTimeFinal";
            this.dateTimeFinal.Size = new System.Drawing.Size(90, 20);
            this.dateTimeFinal.TabIndex = 1;
            // 
            // FrmNR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 535);
            this.Controls.Add(this.dateTimeFinal);
            this.Controls.Add(this.dateTimeInicial);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelNRDetalhado);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxPerdido);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.checkBoxRecorrente);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.lblDataInicial);
            this.Controls.Add(this.dataGridNR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmNR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chamados não Resolvidos NR";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmNR_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNR)).EndInit();
            this.panelNRDetalhado.ResumeLayout(false);
            this.panelNRDetalhado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNRDetalhado)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridNR;
        private System.Windows.Forms.Label lblDataInicial;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.CheckBox checkBoxRecorrente;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.CheckBox checkBoxPerdido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chamados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ToolTip toolTipRecorrentes;
        private System.Windows.Forms.Panel panelNRDetalhado;
        private System.Windows.Forms.DataGridView dataGridNRDetalhado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chamado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataAbertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assunto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.DateTimePicker dateTimeInicial;
        private System.Windows.Forms.DateTimePicker dateTimeFinal;
    }
}