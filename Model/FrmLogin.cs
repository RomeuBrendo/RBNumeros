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
            if (txtNome.Text == "ARTUR" && txtSenha.Text == "123")
            {
                FrmPrincipal frmPrincipal = new FrmPrincipal("A");

                frmPrincipal.Show();
            }

            else  if (txtNome.Text == "" && txtSenha.Text == "")
            {
                FrmPrincipal frmPrincipal = new FrmPrincipal("D");

                frmPrincipal.Show();
            }
            else if (txtNome.Text == "LAURA" && txtSenha.Text == "123")
            {
                FrmPrincipal frmPrincipal = new FrmPrincipal("C");

                frmPrincipal.Show();
            }
            else if(txtNome.Text == "ADM" && txtSenha.Text == "123")
            {
                FrmPrincipal frmPrincipal = new FrmPrincipal("%");

                frmPrincipal.Show();
            }
            else if (txtNome.Text == "DIEGO" && txtSenha.Text == "123")
            {
                FrmPrincipal frmPrincipal = new FrmPrincipal("D");

                frmPrincipal.Show();
            }
            else
            {
   
                MessageBox.Show("Usuario ou senha errado. Consulte o adm.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
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
