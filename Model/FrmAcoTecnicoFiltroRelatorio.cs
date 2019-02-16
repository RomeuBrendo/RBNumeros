using System;
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
            TecnicoColecao tecnicoColecao = new TecnicoColecao();
            TecnicoNegocios tecnicoNegocios = new TecnicoNegocios();

             tecnicoColecao = tecnicoNegocios.Consultar(carteira);
            

            tecnicoColecao.RemoveAll(a => a.CarteiraSN == false);


            InitializeComponent();
            
            cmbTecnico.DisplayMember = "Nome";
            this.cmbTecnico.DataSource = tecnicoColecao;
            cmbTecnico.ValueMember = "Id";
            cmbTecnico.SelectedIndex = -1;
          

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
            TecnicoChamadoRelatorio tecnicoChamadoRelatorio = new TecnicoChamadoRelatorio();

            int idTecnico = Convert.ToInt32(cmbTecnico.SelectedValue);

            
            tecnicoChamadoRelatorio = tecnicoChamadoNegocios.ChamadoRelatorio(dateTimeInicial.Value, dateTimeFinal.Value, _carteira,idTecnico);

            FrmTecnicoRelatorio frmTecnicoRelatorio = new FrmTecnicoRelatorio(tecnicoChamadoRelatorio);
            frmTecnicoRelatorio.Show();
        }
    }
}
