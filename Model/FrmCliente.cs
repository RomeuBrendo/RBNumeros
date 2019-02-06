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

        public FrmCliente(string carteira)
        {
            InitializeComponent();

            dataGridCliente.AutoGenerateColumns = false;
            _carteira = carteira;
            dataGridCliente.DataSource = clienteNegocios.ConsultarCliente(_carteira);
        }
        
        public void AtualizaGrid()
        {
       /*     tblCliente cliente = new tblCliente();
            ClienteNegocios clienteNegocios = new ClienteNegocios();
            RBNumerosEntities et = new RBNumerosEntities();

           
          //  dataGridCliente.DataSource = clienteNegocios.ConsultarCliente(_carteira);
          */
            dataGridCliente.Update();
            dataGridCliente.Refresh();
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

            AtualizaGrid();

            

        }

        private void dataGridCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.B)
            {
                AlterarPrioridadeCliente("BAIXA");
            }
            else if(e.KeyCode == Keys.M)
            {
                AlterarPrioridadeCliente("MÉDIA");
            }
            else if(e.KeyCode == Keys.A)
            {
                AlterarPrioridadeCliente("ALTA");
            }
        }
    }
}
