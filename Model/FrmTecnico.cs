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
    public partial class FrmTecnico : Form
    {
        string _carteira;

        TecnicoColecao tecnicoColecao = new TecnicoColecao();
        tblTecnico tecnico = new tblTecnico();
        TecnicoNegocios tecnicoNegocio = new TecnicoNegocios();

        public FrmTecnico(string carteira)
        {
            InitializeComponent();

            _carteira = carteira;

            dataGridTecnico.AutoGenerateColumns = false;

            AtualizaGrid();
        }

        public void AtualizaGrid()
        {
            dataGridTecnico.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            tecnicoColecao = null;
            tecnicoColecao = tecnicoNegocio.Consultar(_carteira);

            
            dataGridTecnico.DataSource = null;

            dataGridTecnico.DataSource = tecnicoColecao.OrderBy(a => a.Nome).ToList();

            dataGridTecnico.Update();
            dataGridTecnico.Refresh();

        }

        public void SalvarGrid()
        {
            
            tecnicoNegocio.SalvarGrid();

     
            MessageBox.Show("Alteração realizada com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataGridTecnico.Update();
            dataGridTecnico.Refresh();

            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarGrid();
        }
    }
}
