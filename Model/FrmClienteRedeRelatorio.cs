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
    public partial class FrmClienteRedeRelatorio : Form
    {
        int _id;
        string _carteira;
        public FrmClienteRedeRelatorio(string carteira,int id)
        {
            InitializeComponent();
            _id = id;
            _carteira = carteira;
        }

        private void FrmClienteRedeRelatorio_Load(object sender, EventArgs e)
        {
            CarregarRelatorio();
            this.reportClienteRede.RefreshReport();
        }

        public void CarregarRelatorio()
        {
            string nome ="";

            ClienteColecao clienteColecao = new ClienteColecao();
            ClienteNegocios clienteNegocios = new ClienteNegocios();

            clienteColecao = clienteNegocios.ConsultarClienteRede(_carteira, _id);

            clienteColecao.ForEach(a => { nome = a.tblRedeCliente.Nome; return; });

            var dataSoucer = new Microsoft.Reporting.WinForms.ReportDataSource("DataSetClienteRede", clienteColecao);

            this.reportClienteRede.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Rede", nome));
            this.reportClienteRede.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Total", clienteColecao.Count().ToString()));

            this.reportClienteRede.Clear();

            this.reportClienteRede.LocalReport.DataSources.Add(dataSoucer);

           
        }
    }
}
