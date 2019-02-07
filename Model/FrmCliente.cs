using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Servicos.Entidades;
using Servicos;

namespace Model
{
    public partial class FrmCliente : Form
    {
        ClienteNegocios clienteNegocios = new ClienteNegocios();
        string _carteira;
        bool situaçãoGrid = true;

        public FrmCliente(string carteira)
        {
            InitializeComponent();

            dataGridCliente.AutoGenerateColumns = false;
            _carteira = carteira;
            CarregarGrid();
        }
        
        public void AtualizaGrid()
        {       
            dataGridCliente.Update();
            dataGridCliente.Refresh();
        }

        public void CarregarGrid()
        {
            dataGridCliente.DataSource = clienteNegocios.ConsultarCliente(_carteira);
        }

        public void CarregarGridSemPrioridade()
        {
            dataGridCliente.DataSource = clienteNegocios.ConsultarClienteSemPrioridade(_carteira);
        }

        public void AlterarPrioridadeCliente(string prioriodade)
        {
            tblCliente cliente = dataGridCliente.SelectedRows[0].DataBoundItem as tblCliente;

            var linha = dataGridCliente.SelectedRows;

            cliente.Prioridade = prioriodade;

            var idRede = cliente.IdRede;

                        

            DialogResult dialogResultRede = MessageBox.Show("Deja alterar prioridade de toda a rede? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dialogResultRede == DialogResult.No)
            {
                clienteNegocios.AlteraPrioridade(cliente.Id, cliente.Prioridade);
            }
            else
            {
                clienteNegocios.AlterarPrioridadeRede(cliente.IdRede.Value, cliente.Carteira, prioriodade);
                AtualizaGrid();
            }

            MessageBox.Show("Prioridade alterada com sucesso! ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (situaçãoGrid == true)
            {
                AtualizaGrid();
            }
            else
            {
                CarregarGridSemPrioridade();
            }

            

        }

        private void dataGridCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.B)
            {
                AlterarPrioridadeCliente("BAIXA");
            }
            else if (e.KeyCode == Keys.M)
            {
                AlterarPrioridadeCliente("MÉDIA");
            }
            else if (e.KeyCode == Keys.A)
            {
                AlterarPrioridadeCliente("ALTA");
            }

            else if (e.KeyCode == Keys.S)
            {
                CarregarGridSemPrioridade();
                situaçãoGrid = false;
            }

            else if (e.KeyCode == Keys.Escape)
            {
                CarregarGrid();
                situaçãoGrid = true;
            }
        }

    }
}
