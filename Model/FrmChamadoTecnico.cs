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
        ChamadoColecao _chamadoColecao = new ChamadoColecao();

        public FrmChamadoTecnico(ChamadoColecao chamadoColecao)
        {
            InitializeComponent();

            _chamadoColecao = chamadoColecao;
        }


        private void FrmChamadoTecnico_Load(object sender, EventArgs e)
        {

          /*  this.reportViewerTecnicos.RefreshReport();

            var dataSource = new Microsoft.Reporting.WinForms.ReportDataSource("DataSetChamadosTecnico", _chamadoColecao);

            this.reportViewerTecnicos.LocalReport.DataSources.Clear();

            this.reportViewerTecnicos.LocalReport.DataSources.Add(dataSource);*/
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            
        }

        public void ConsultarChamados()
        {
            
        }
    }
}
