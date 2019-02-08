using System;
using System.Windows.Forms;
using Servicos;

namespace Model
{
    public partial class FrmClientePrioridadeFiltro : Form
    {
        string _carteira;
        ClienteNegocios clienteNegocios = new ClienteNegocios();

        public FrmClientePrioridadeFiltro(String carteira)
        {
            InitializeComponent();
            _carteira = carteira;
            cmbPrioridade.SelectedIndex = 0;
        
        }

        private void FrmClientePrioridadeFiltro_Load(object sender, EventArgs e)
        {

        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            FrmClientePrioridade frmClientePrioridade = new FrmClientePrioridade(dateTimeInicial.Value, dateTimeFinal.Value,cmbPrioridade.Text,_carteira);
           // frmClientePrioridade.MdiParent = this;
            frmClientePrioridade.Show();
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
