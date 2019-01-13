using System;
using System.Windows.Forms;

namespace Model
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            ValidacaoUsuario();
            
           
        }

        public void ValidacaoUsuario()
        {
            if (txtNome.Text == "ARTHUR" && txtSenha.Text == "123")
            {
                FrmPrincipal frmPrincipal = new FrmPrincipal("A");

                frmPrincipal.Show();
            }

            else  if (txtNome.Text == "" && txtSenha.Text == "")
            {
                FrmPrincipal frmPrincipal = new FrmPrincipal("B");

                frmPrincipal.Show();
            }
            else if(txtNome.Text == "ADM" && txtSenha.Text == "123")
            {
                FrmPrincipal frmPrincipal = new FrmPrincipal("T");

                frmPrincipal.Show();
            }
            else if (txtNome.Text == "DIEGO" && txtSenha.Text == "123")
            {
                FrmPrincipal frmPrincipal = new FrmPrincipal("D");

                frmPrincipal.Show();
            }
            else
            {
                //Menssagem pronta do windows gutembergue
                //  MessageBox.Show("Usuario ou senha errado. Consulte o adm.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MessageBox.Show("Teste Gutembergue.", "TESTE CABEÇARIO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            ValidacaoUsuario();
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
                ValidacaoUsuario();

            else if (e.KeyCode == Keys.Exsel)
                this.Close();
        }
    }
}
