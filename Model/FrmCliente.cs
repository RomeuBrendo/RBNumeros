using System.Windows.Forms;
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
            AtualizaGrid();
        }
        
        public void AtualizaGrid()
        {
            tblCliente cliente = new tblCliente();
            ClienteNegocios clienteNegocios = new ClienteNegocios();
            RBNumerosEntities et = new RBNumerosEntities();

            //Todo
            //Lembrar de voltar validação por carteira
            dataGridCliente.DataSource = clienteNegocios.ConsultarCliente(_carteira);

            dataGridCliente.Update();
            dataGridCliente.Refresh();
        }

        public void AlterarPrioridadeCliente(string prioriodade)
        {
            tblCliente cliente = dataGridCliente.SelectedRows[0].DataBoundItem as tblCliente;

            cliente.Prioridade = prioriodade;

            clienteNegocios.AlteraPrioridade(cliente.Id, cliente.Prioridade);

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
