using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
