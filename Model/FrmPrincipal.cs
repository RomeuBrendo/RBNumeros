using System;
using System.Windows.Forms;
using Servicos;
namespace Model
{
    public partial class FrmPrincipal : Form
    {
        string _carteira;
        public FrmPrincipal(String carteira)
        {
            InitializeComponent();
            FrmLogin frmLogin = new FrmLogin();
        
            _carteira = carteira;

           this.BackgroundImageLayout = ImageLayout.Stretch;
        }


        private void importarPlanilhaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResultValidacao = MessageBox.Show("Planilha se encontra no diretorio C:\\RBNUMEROS\\CHAMADOS ?", "Última data importada", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dialogResultValidacao == DialogResult.Yes)
            {
                ImportarPlanilha chamadoServico = new ImportarPlanilha();

                chamadoServico.InserirChamado();
                MessageBox.Show("Importação realizada com sucesso");
            }
        }

        private void clientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente(_carteira);

            frmCliente.MdiParent = this;

            frmCliente.Show();
        }

        private void nRNãoResolvidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNR frmNR = new FrmNR(_carteira);

            frmNR.MdiParent = this;

            frmNR.Show();
        }

        private void usúariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTecnico frmUsuario = new FrmTecnico(_carteira);
            frmUsuario.MdiParent = this;
            frmUsuario.Show();
        }

        private void chamadosAbertosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChamadoTecnico frmChamadoTecnico = new FrmChamadoTecnico(_carteira);
            frmChamadoTecnico.MdiParent = this;
            frmChamadoTecnico.Show();
        }
    }
}
