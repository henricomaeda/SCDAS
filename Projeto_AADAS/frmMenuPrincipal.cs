using System;
using System.Windows.Forms;


namespace Projeto_AADAS
{
    public partial class FrmMenuPrincipal : Form
    {
        readonly string acesso = string.Empty;
        public FrmMenuPrincipal(string tipo_acesso)
        {
            acesso = tipo_acesso.Trim();
            InitializeComponent();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.ActiveControl = btnPesquisar;
            if (acesso != "Administrador")
            {
                cadastroToolStripMenuItem.Visible = false;
                ferramentasToolStripMenuItem.Visible = false;

                btnFuncionarios.Enabled = false;
                btnCadastrar.Enabled = false;
                btnBackup.Enabled = false;
            }
        }

        private void FuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncionarios frmFuncionários = new FrmFuncionarios();
            frmFuncionários.ShowDialog();
        }

        private void AtendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAtendido frmAtendido = new FrmAtendido(string.Empty);
            frmAtendido.ShowDialog();
        }

        private void PesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPesquisa frmPesquisa = new FrmPesquisa(acesso);
            frmPesquisa.ShowDialog();
        }

        private void BackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBackup frmBackup = new FrmBackup();
            frmBackup.ShowDialog();
        }

        private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout frmAbout = new FrmAbout();
            frmAbout.ShowDialog();
        }

        private void TrocarDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var message = "Você tem certeza que deseja se desconectar?";
            var buttons = MessageBoxButtons.YesNo;
            var icon = MessageBoxIcon.Question;

            DialogResult result = MessageBox.Show(message, "SCDAS", buttons, icon);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.ShowDialog();
            }

        }

        private void FinalizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            var message = "Você tem certeza que deseja finalizar?";
            var buttons = MessageBoxButtons.YesNo;
            var icon = MessageBoxIcon.Question;

            DialogResult result = MessageBox.Show(message, "SCDAS", buttons, icon);
            if (result == DialogResult.Yes) Application.ExitThread();
            else e.Cancel = true;
        }
    }
}
