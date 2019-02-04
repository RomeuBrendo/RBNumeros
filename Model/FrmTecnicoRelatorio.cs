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
    public partial class FrmTecnicoRelatorio : Form
    {
        TecnicoChamadoRelatorio _tecnicoChamadoRelatorio = new TecnicoChamadoRelatorio();
        TecnicoChamadoRelatorioColecao _tecnicoChamadoRelatorios = new TecnicoChamadoRelatorioColecao();

        ChamadoColecao _chamadoColecao = new ChamadoColecao();
        public FrmTecnicoRelatorio(TecnicoChamadoRelatorio tecnicoChamadoRelatorio)
        {
            InitializeComponent();

            _tecnicoChamadoRelatorio = tecnicoChamadoRelatorio;
            _tecnicoChamadoRelatorios.Add(_tecnicoChamadoRelatorio);

            GerarRelatorio();
        }

        public void GerarRelatorio()
        {
            String nomeTecnico = "";
     
                foreach(var chamado in _tecnicoChamadoRelatorio.Chamados)
                {
                    _chamadoColecao.Add(chamado);
                   nomeTecnico = chamado.NomeTecnico;
                }

      

            var dataSourceChamado = new Microsoft.Reporting.WinForms.ReportDataSource("DataSetChamado", _chamadoColecao);

            var dataSourceTecnicoRelatorio = new Microsoft.Reporting.WinForms.ReportDataSource("DataSetTecnicoRelatorio", _tecnicoChamadoRelatorios);


            this.reportViewerTecnicoRelatorio.LocalReport.DataSources.Clear();

            this.reportViewerTecnicoRelatorio.LocalReport.DataSources.Add(dataSourceChamado);
            this.reportViewerTecnicoRelatorio.LocalReport.DataSources.Add(dataSourceTecnicoRelatorio);

            this.reportViewerTecnicoRelatorio.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("NomeTecnico", nomeTecnico));
            

            this.reportViewerTecnicoRelatorio.LocalReport.Refresh();

        }

        private void FrmTecnicoRelatorio_Load(object sender, EventArgs e)
        {

            this.reportViewerTecnicoRelatorio.RefreshReport();
        }
    }
}
