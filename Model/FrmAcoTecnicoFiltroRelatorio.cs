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
    public partial class FrmAcoTecnicoFiltroRelatorio : Form
    {
        string _carteira;
        public FrmAcoTecnicoFiltroRelatorio(string carteira)
        {
            InitializeComponent();
            _carteira = carteira;
        }

        private void cmbTecnico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void dateTimeInicial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void dateTimeFinal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void btnGerar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void btnCancelar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            GerarRelatorio();
        }

        public void GerarRelatorio()
        {
            TecnicoChamadoNegocios tecnicoChamadoNegocios = new TecnicoChamadoNegocios();
            TecnicoChamadoRelatorioColecao tecnicoChamadoRelatorios = new TecnicoChamadoRelatorioColecao();

            tecnicoChamadoRelatorios = tecnicoChamadoNegocios.ChamadoRelatorio(dateTimeInicial.Value, dateTimeFinal.Value, _carteira);

            FrmTecnicoRelatorio frmTecnicoRelatorio = new FrmTecnicoRelatorio(tecnicoChamadoRelatorios);
            frmTecnicoRelatorio.Show();
        }
    }
}
