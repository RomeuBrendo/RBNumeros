using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Servicos.Entidades;
using Servicos;

namespace Model
{
    public partial class FrmNR : Form
    {
        string _carteira;

        public FrmNR(string carteira)
        {
            InitializeComponent();
            _carteira = carteira;

            dataGridNR.AutoGenerateColumns = false;
            dataGridNRDetalhado.AutoGenerateColumns = false;
        }

        public void ValidaData()
        {
            if (dateTimeFinal.Value.Date < dateTimeInicial.Value.Date)
            {
                MessageBox.Show("Data final inferior a data inicial.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        public void CarregarDados()
        {
            if (panelNRDetalhado.Visible == false)
            {
                ClienteNRColecao clienteNRColecao = new ClienteNRColecao();

                ClienteNegocios clienteNegocios = new ClienteNegocios();


                clienteNRColecao = clienteNegocios.ChamadosNR(_carteira, dateTimeInicial.Value.Date, dateTimeFinal.Value.Date, checkBoxRecorrente.Checked, checkBoxPerdido.Checked);

                dataGridNR.DataSource = null;

                dataGridNR.DataSource = clienteNRColecao.OrderByDescending(f => f.Quantidade).ToList();
                lblTotal.Text = clienteNRColecao.Sum(w => w.Quantidade).ToString();

                dataGridNR.Update();
                dataGridNR.Refresh();

                dataGridNR.Select();
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        public void CarregarNrDetalhado(int id)
        {
            ClienteNegocios clienteNegocios = new ClienteNegocios();

            var chamadoColecao = clienteNegocios.ConsultarNrDetalhado(id, dateTimeInicial.Value, dateTimeFinal.Value, checkBoxRecorrente.Checked, checkBoxPerdido.Checked);

            dataGridNRDetalhado.DataSource = null;
            dataGridNRDetalhado.DataSource = chamadoColecao;


            dataGridNRDetalhado.Refresh();
            dataGridNRDetalhado.Update();

            
        }

        private void dataGridNR_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.D)||(e.KeyCode == Keys.Enter))
            {
                dataGridNRDetalhado.Focus();
                ClienteNR clienteSelecionado = dataGridNR.SelectedRows[0].DataBoundItem as ClienteNR;

                CarregarNrDetalhado(clienteSelecionado.IdCliente);
                e.SuppressKeyPress = true;

                panelNRDetalhado.Visible = true;

                dataGridNRDetalhado.Select();

            }

            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            else if(e.KeyCode == Keys.F4)
            {
                CarregarDados();
            }


        }

        private void dataGridNRDetalhado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                panelNRDetalhado.Visible = false;
                dataGridNR.Select();
            }
        }

        private void FrmNR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            else if (e.KeyCode == Keys.F4)
            {
                CarregarDados();
            }
        }
    }
}
