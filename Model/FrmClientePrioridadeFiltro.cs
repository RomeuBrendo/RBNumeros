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
using Servicos.Entidades;

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
