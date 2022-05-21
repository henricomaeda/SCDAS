using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Projeto_AADAS
{

    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtLogin.Focus();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o campo de usuário.", "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (txtSenha.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha o campo de senha.", "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (cbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o tipo de usuário.", "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string sql = @"Select Login, Senha, tipo from funcionarios where Login = @Login and Senha = @Senha and tipo = @Tipo";

                    Classes.Conexao.Conectar();
                    MySqlCommand cmd = new MySqlCommand(sql, Classes.Conexao.conn);
                    cmd.Parameters.AddWithValue("Login", txtLogin.Text);
                    cmd.Parameters.AddWithValue("Senha", txtSenha.Text);
                    cmd.Parameters.AddWithValue("Tipo", cbTipo.SelectedItem);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        this.Hide();
                        string tipo = cbTipo.SelectedItem.ToString();
                        FrmMenuPrincipal principal = new FrmMenuPrincipal(tipo);
                        principal.ShowDialog();
                    } else
                    {
                        MessageBox.Show("Usuário e/ou senha inválidos!", "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
                finally
                {
                    Classes.Conexao.Desconectar();
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmMenuPrincipal principal = new FrmMenuPrincipal("Administrador");
            principal.ShowDialog();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
