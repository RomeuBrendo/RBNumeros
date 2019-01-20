using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicos.Entidades;
using Servicos;
namespace Model
{
    public partial class FrmChamadoTecnico : Form
    {
        TecnicoChamadoColecao tecnicoChamadoColecao = new TecnicoChamadoColecao();
        TecnicoChamadoNegocios tecnicoChamadoNegocios = new TecnicoChamadoNegocios();
        String _carteira;

        public FrmChamadoTecnico(String carteira)
        {
            InitializeComponent();
            _carteira = carteira;
            
          
        }


        private void FrmChamadoTecnico_Load(object sender, EventArgs e)
        {
           
         //   this.reportViewerChamado.RefreshReport();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ConsultarChamados();
        }

        public void ConsultarChamados()
        {
            tecnicoChamadoColecao = tecnicoChamadoNegocios.ConsultarChamado(dateTimeInicial.Value, dateTimeFinal.Value, _carteira);
            var dataSourceTecnico = new Microsoft.Reporting.WinForms.ReportDataSource("DataSetTecnico",tecnicoChamadoColecao);
            this.reportViewerChamado.LocalReport.DataSources.Add(dataSourceTecnico);

            this.reportViewerChamado.RefreshReport();
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            ConsultarChamados();
        }

      

        private void FrmChamadoTecnico_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
                this.Close();

            if (e.KeyCode == Keys.F4)
                ConsultarChamados();

        }

        private void btnPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();

            if (e.KeyCode == Keys.F4)
                ConsultarChamados();
        }

        private void dateTimeInicial_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Escape)
                this.Close();

            if (e.KeyCode == Keys.F4)
                ConsultarChamados();
        }

        private void dateTimeFinal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();

            if (e.KeyCode == Keys.F4)
                ConsultarChamados();
        }

        private void reportViewerChamado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();

            if (e.KeyCode == Keys.F4)
                ConsultarChamados();
        }
    }
}
