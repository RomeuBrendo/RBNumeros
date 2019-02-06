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

            int totalChamado = _tecnicoChamadoRelatorio.Chamados.Count;
            int quantidadeRecorrente = _tecnicoChamadoRelatorio.Chamados.Where(a => a.TipoChamado == "RECORRENTE" || a.Assunto == "CHAMADO RECORRENTE" || a.Assunto == "CHAMADO PERDIDO (SEM CONTATO)").Count();
            int quantidade = _tecnicoChamadoRelatorio.Chamados.Where(a => a.TipoChamado != "RECORRENTE" && a.Assunto != "CHAMADO RECORRENTE" && a.Assunto != "CHAMADO PERDIDO (SEM CONTATO)").Count();

            var dataSourceChamado = new Microsoft.Reporting.WinForms.ReportDataSource("DataSetChamado", _chamadoColecao);

            var dataSourceTecnicoRelatorio = new Microsoft.Reporting.WinForms.ReportDataSource("DataSetTecnicoRelatorio", _tecnicoChamadoRelatorios);


            this.reportViewerTecnicoRelatorio.LocalReport.DataSources.Clear();

            this.reportViewerTecnicoRelatorio.LocalReport.DataSources.Add(dataSourceChamado);
            this.reportViewerTecnicoRelatorio.LocalReport.DataSources.Add(dataSourceTecnicoRelatorio);

             this.reportViewerTecnicoRelatorio.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("NomeTecnico", nomeTecnico));
              this.reportViewerTecnicoRelatorio.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("QuantidadeRecorrente", quantidadeRecorrente.ToString()));
              this.reportViewerTecnicoRelatorio.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Quantidade", quantidade.ToString()));
              this.reportViewerTecnicoRelatorio.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("TotalChamados", totalChamado.ToString()));


            this.reportViewerTecnicoRelatorio.LocalReport.Refresh();

        }

        private void FrmTecnicoRelatorio_Load(object sender, EventArgs e)
        {

            this.reportViewerTecnicoRelatorio.RefreshReport();
        }
    }
}
