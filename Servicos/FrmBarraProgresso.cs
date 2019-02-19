using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servicos
{
    public partial class FrmBarraProgresso : Form
    {
        RBNumerosEntities et = new RBNumerosEntities();

        ImportarPlanilha importarPlanilha = new ImportarPlanilha();
       
        int quantidadeChamados =0;
        int aux = 0;

        public FrmBarraProgresso()
        {
            InitializeComponent();

            quantidadeChamados = et.tblChamado.Count();      
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 5;
            backgroundWorker2.RunWorkerAsync();
            backgroundWorker.RunWorkerAsync();
                   
        }

        public void CarregarQuantidade()
        {
            lblChamadosImportados.BeginInvoke(new Action(() => { lblChamadosImportados.Text = (quantidadeChamados - et.tblChamado.Count()).ToString().Replace("-", "").ToString(); }));
            Thread.Sleep(300);
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (aux == 0)
            {
                CarregarQuantidade();
            }

        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
          
            if (aux > 0)
            {
                progressBar1.MarqueeAnimationSpeed = 0;
                progressBar1.Style = ProgressBarStyle.Blocks;
                progressBar1.Value = 100;
                CarregarQuantidade();
                btnCancelar.Text = "OK";
                this.Text = "Importação realizada com sucesso!";
            }
            
        }

        private void FrmBarraProgresso_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            this.Close();
                           
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
         
            importarPlanilha.InserirChamado();
            aux++;
        }
    }
}
