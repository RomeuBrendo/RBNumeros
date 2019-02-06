namespace Model
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.statusStripPrincipal = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUltimoChamado = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarPlanilhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usúariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nRNãoResolvidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.performanceTécnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relátoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chamadosPorTécnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripPrincipal.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripPrincipal
            // 
            this.statusStripPrincipal.BackColor = System.Drawing.Color.White;
            this.statusStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1,
            this.lblUltimoChamado});
            this.statusStripPrincipal.Location = new System.Drawing.Point(0, 449);
            this.statusStripPrincipal.Name = "statusStripPrincipal";
            this.statusStripPrincipal.Size = new System.Drawing.Size(1004, 22);
            this.statusStripPrincipal.TabIndex = 3;
            this.statusStripPrincipal.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusLabel2.Text = "Versão 1.0";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(236, 17);
            this.toolStripStatusLabel1.Text = " / Data e Hora último chamado importado: ";
            // 
            // lblUltimoChamado
            // 
            this.lblUltimoChamado.Name = "lblUltimoChamado";
            this.lblUltimoChamado.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip
            // 
            this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.movimentaçõesToolStripMenuItem,
            this.relátoriosToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(1004, 24);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarPlanilhaToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.usúariosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // importarPlanilhaToolStripMenuItem
            // 
            this.importarPlanilhaToolStripMenuItem.Name = "importarPlanilhaToolStripMenuItem";
            this.importarPlanilhaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importarPlanilhaToolStripMenuItem.Text = "Importar Planilha";
            this.importarPlanilhaToolStripMenuItem.Click += new System.EventHandler(this.importarPlanilhaToolStripMenuItem_Click_1);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click_1);
            // 
            // usúariosToolStripMenuItem
            // 
            this.usúariosToolStripMenuItem.Name = "usúariosToolStripMenuItem";
            this.usúariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usúariosToolStripMenuItem.Text = "Técnicos";
            this.usúariosToolStripMenuItem.Click += new System.EventHandler(this.usúariosToolStripMenuItem_Click);
            // 
            // movimentaçõesToolStripMenuItem
            // 
            this.movimentaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nRNãoResolvidosToolStripMenuItem,
            this.performanceTécnicoToolStripMenuItem});
            this.movimentaçõesToolStripMenuItem.Name = "movimentaçõesToolStripMenuItem";
            this.movimentaçõesToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.movimentaçõesToolStripMenuItem.Text = "Movimentação";
            // 
            // nRNãoResolvidosToolStripMenuItem
            // 
            this.nRNãoResolvidosToolStripMenuItem.Name = "nRNãoResolvidosToolStripMenuItem";
            this.nRNãoResolvidosToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.nRNãoResolvidosToolStripMenuItem.Text = "NR Não Resolvidos";
            this.nRNãoResolvidosToolStripMenuItem.Click += new System.EventHandler(this.nRNãoResolvidosToolStripMenuItem_Click);
            // 
            // performanceTécnicoToolStripMenuItem
            // 
            this.performanceTécnicoToolStripMenuItem.Name = "performanceTécnicoToolStripMenuItem";
            this.performanceTécnicoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.performanceTécnicoToolStripMenuItem.Text = "Desempenho Equipe";
            this.performanceTécnicoToolStripMenuItem.Click += new System.EventHandler(this.performanceTécnicoToolStripMenuItem_Click);
            // 
            // relátoriosToolStripMenuItem
            // 
            this.relátoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chamadosPorTécnicoToolStripMenuItem});
            this.relátoriosToolStripMenuItem.Name = "relátoriosToolStripMenuItem";
            this.relátoriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relátoriosToolStripMenuItem.Text = "Relátorios";
            // 
            // chamadosPorTécnicoToolStripMenuItem
            // 
            this.chamadosPorTécnicoToolStripMenuItem.Name = "chamadosPorTécnicoToolStripMenuItem";
            this.chamadosPorTécnicoToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.chamadosPorTécnicoToolStripMenuItem.Text = "Chamados por Técnico";
            this.chamadosPorTécnicoToolStripMenuItem.Click += new System.EventHandler(this.chamadosPorTécnicoToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1004, 471);
            this.Controls.Add(this.statusStripPrincipal);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmPrincipal";
            this.Text = "RB Números";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStripPrincipal.ResumeLayout(false);
            this.statusStripPrincipal.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarPlanilhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nRNãoResolvidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usúariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem performanceTécnicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblUltimoChamado;
        private System.Windows.Forms.ToolStripMenuItem relátoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chamadosPorTécnicoToolStripMenuItem;
    }
}

