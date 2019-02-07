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
    public partial class FrmClientePrioridade : Form
    {
        ChamadoColecao chamadoColecao = new ChamadoColecao();
        ClientePrioridadeNegocio ClientePrioridadeNegocio = new ClientePrioridadeNegocio();

        public FrmClientePrioridade(DateTime inicial, DateTime final, string prioridade, string carteira)
        {
            InitializeComponent();

            chamadoColecao = ClientePrioridadeNegocio.ChamadoPrioridade(prioridade,carteira,inicial, final);

            Carregar(chamadoColecao,prioridade);
        }

        public void Carregar(ChamadoColecao chamadoColecao, string prioridade)
        {
            var dataSourceChamado = new Microsoft.Reporting.WinForms.ReportDataSource("DataSetChamado", chamadoColecao);

            this.reportViewerClientePrioridade.Clear();

            this.reportViewerClientePrioridade.LocalReport.DataSources.Add(dataSourceChamado);

            this.reportViewerClientePrioridade.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Prioridade", prioridade));

            reportViewerClientePrioridade.LocalReport.Refresh();
        }

        private void FrmClientePrioridade_Load(object sender, EventArgs e)
        {

            this.reportViewerClientePrioridade.RefreshReport();
        }
    }
}
