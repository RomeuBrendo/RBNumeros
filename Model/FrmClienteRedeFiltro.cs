using System;
using System.Windows.Forms;
using Servicos;

namespace Model
{
    public partial class FrmClienteRedeFiltro : Form
    {
        string _carteira;
        ClienteNegocios clienteNegocios = new ClienteNegocios();
        public FrmClienteRedeFiltro(string carteira)
        {

            InitializeComponent();

            _carteira = carteira;

            
            cmbRede.DisplayMember = "Nome";
            this.cmbRede.DataSource = clienteNegocios.ConsultarRede(_carteira);
            cmbRede.ValueMember = "Id";
            cmbRede.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cmbRede.SelectedValue);
            FrmClienteRedeRelatorio frmClienteRedeRelatorio = new FrmClienteRedeRelatorio(_carteira,id );
            frmClienteRedeRelatorio.Show();
        }
    }
}
