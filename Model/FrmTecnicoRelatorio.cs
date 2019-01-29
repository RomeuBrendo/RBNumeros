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
        TecnicoChamadoRelatorioColecao _tecnicoChamadoRelatorios = new TecnicoChamadoRelatorioColecao();
        ChamadoColecao _chamadoColecao = new ChamadoColecao();
        public FrmTecnicoRelatorio(TecnicoChamadoRelatorioColecao tecnicoChamadoRelatorios)
        {
            InitializeComponent();

            _tecnicoChamadoRelatorios = tecnicoChamadoRelatorios;

            GerarRelatorio();
        }

        public void GerarRelatorio()
        {
            foreach(var chamadoTecnico in _tecnicoChamadoRelatorios)
            {
                foreach(var chamado in chamadoTecnico.Chamados)
                {
                    _chamadoColecao.Add(chamado);
                }
            }

            var dataSourceChamado = new Microsoft.Reporting.WinForms.ReportDataSource("DataSetChamado", _chamadoColecao);
            var dataSourceTecnico = new Microsoft.Reporting.WinForms.ReportDataSource("DataSetTecnicoRelatorio", _tecnicoChamadoRelatorios);

            this.reportViewerTecnicoRelatorio.LocalReport.DataSources.Clear();

            this.reportViewerTecnicoRelatorio.LocalReport.DataSources.Add(dataSourceChamado);
            this.reportViewerTecnicoRelatorio.LocalReport.DataSources.Add(dataSourceTecnico);
            this.reportViewerTecnicoRelatorio.LocalReport.Refresh();


        }

        private void FrmTecnicoRelatorio_Load(object sender, EventArgs e)
        {

            this.reportViewerTecnicoRelatorio.RefreshReport();
        }
    }
}
