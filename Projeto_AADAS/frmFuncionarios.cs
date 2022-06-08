using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Projeto_AADAS
{
    public partial class FrmFuncionarios : Form
    {
        int Codigo = 0;
        bool load = false;

        public FrmFuncionarios()
        {
            InitializeComponent();
        }

        private void FrmFuncionarios_Load(object sender, EventArgs e)
        {
            load = true;
            BtnPesquisar_Click_1(sender, e);
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Preencha o nome do Funcionário");
                }
                else if (txtCPF.Text.Length != 14)
                {
                    MessageBox.Show("Preencha com o CPF do Funcionário");
                }
                else if (mskCel.Text.Length != 14)
                {
                    MessageBox.Show("Preencha com o Celular do Funcionário");
                }
                else if (txtPrograma.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Preencha com o Programa do Funcionário");
                }
                else if (txtCargo.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Preencha com o Cargo do Funcionário");
                }
                else if (cbPermissao.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecione a Permissão");
                }
                else if (txtLogin.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Preencha o Login do Funcionário");
                }
                else if (txtPassword.Text.Trim().Length < 6 || txtPassword.Text.Trim().Length > 8)
                {
                    MessageBox.Show("A senha precisa ter de 6 a 8 caracteres");
                }
                else if (txtEmail.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Preencha com o email do Funcionário");
                }
                else
                {
                    string sql = @"Select * from funcionarios where Login = @Login";

                    Classes.Conexao.Conectar();
                    MySqlCommand cmd = new MySqlCommand(sql, Classes.Conexao.conn);
                    cmd.Parameters.AddWithValue("Login", txtLogin.Text);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows) MessageBox.Show("Já existe um funcionário com esse Login.");
                    else
                    {
                        string sql1 = @"Select * from funcionarios where CPF = @CPF";

                        Classes.Conexao.Conectar();
                        MySqlCommand cmd1 = new MySqlCommand(sql1, Classes.Conexao.conn);
                        cmd1.Parameters.AddWithValue("CPF", txtCPF.Text);
                        MySqlDataReader dr1 = cmd1.ExecuteReader();

                        if (dr1.HasRows) MessageBox.Show("Já existe um funcionario com este CPF.");
                        else
                        {
                            Classes.Conexao.Conectar();
                            Classes.Funcionarios.Inserir(txtNome.Text, txtPrograma.Text, mskCel.Text, txtCargo.Text, txtLogin.Text, txtPassword.Text, txtEmail.Text, cbPermissao.Text, txtCPF.Text);
                            MessageBox.Show("Funcionario cadastrado com sucesso !!!");
                            Limpar();
                            load = true;
                            BtnPesquisar_Click_1(sender, e);

                            dr1.Close();
                        }
                    }
                    dr.Close();
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
        public void Limpar()
        {
            txtNome.Clear();
            txtCPF.Clear();
            mskCel.Clear();
            txtPrograma.Clear();
            txtCargo.Clear();
            cbPermissao.SelectedIndex = -1;
            txtLogin.Clear();
            txtPassword.Clear();
            txtEmail.Clear();

            txtCPFConsulta.Clear();
            dataGridView1.DataSource = null;
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Classes.Conexao.Conectar();
                Classes.Funcionarios.Atualizar(txtNome.Text, txtPrograma.Text, mskCel.Text, txtCargo.Text, txtLogin.Text, txtPassword.Text, txtEmail.Text, cbPermissao.Text, txtCPF.Text, Codigo);
                MessageBox.Show("Funcionário atualizado com sucesso !!!");
                Limpar();
                load = true;
                BtnPesquisar_Click_1(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro :" + ex.Message);
            }
            finally
            {
                Classes.Conexao.Desconectar();
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult op = MessageBox.Show("Deseja excluir o Registro?", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (op == DialogResult.Yes)
            {
                try
                {
                    Classes.Conexao.Conectar();
                    Classes.Funcionarios.Excluir(Codigo);
                    MessageBox.Show("Funcionário foi excluído com sucesso !!!");
                    BtnLimpar_Click(null, null);
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

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            load = true;
            txtCPFConsulta.Text = String.Empty;
            BtnPesquisar_Click_1(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtCPFConsulta.Text = row.Cells[9].Value.ToString();
                BtnPesquisar_Click_1(sender, e);
            }
        }

        private void BtnPesquisar_Click_1(object sender, EventArgs e)
        {
            void AtivarCadastro(bool ativar = true)
            {
                if (ativar)
                {
                    btnExcluir.Enabled = false;
                    btnAtualizar.Enabled = false;
                    btnCadastrar.Enabled = true;
                }
                else
                {
                    btnExcluir.Enabled = true;
                    btnAtualizar.Enabled = true;
                    btnCadastrar.Enabled = false;
                }
            }

            try
            {
                string sql = String.Empty;
                bool cpf = false;

                if (txtCPFConsulta.Text.Trim().Length == 0) sql = @"select * from funcionarios order by Codigo desc";
                else
                {
                    sql = @"select * from funcionarios where cpf like '" + txtCPFConsulta.Text + "%'";
                    cpf = true;
                }

                Codigo = 0;
                string Nome = string.Empty;
                string Programa = string.Empty;
                string Celular = string.Empty;
                string Cargo = string.Empty;
                string Login = string.Empty;
                string Senha = string.Empty;
                string Email = string.Empty;
                string Permissao = string.Empty;
                string CPF = string.Empty;

                Classes.Conexao.Conectar();
                MySqlCommand cmd = new MySqlCommand(sql, Classes.Conexao.conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                this.dataGridView1.Rows.Clear();
                while (reader.Read())
                {
                    Nome = reader["Nome"].ToString();
                    Programa = reader["ProgramaProjeto"].ToString();
                    Celular = reader["Celular"].ToString();
                    Cargo = reader["Cargo"].ToString();
                    Login = reader["Login"].ToString();
                    Senha = reader["Senha"].ToString();
                    Email = reader["Email"].ToString();
                    Permissao = reader["tipo"].ToString();
                    CPF = reader["cpf"].ToString();

                    if (Codigo == 0)
                    {
                        txtNome.Text = Nome;
                        txtPrograma.Text = Programa;
                        mskCel.Text = Celular;
                        txtCargo.Text = Cargo;
                        txtLogin.Text = Login;
                        txtPassword.Text = Senha;
                        txtEmail.Text = Email;
                        cbPermissao.Text = Permissao;
                        txtCPF.Text = CPF;
                    }

                    Codigo = int.Parse(reader["Codigo"].ToString());
                    this.dataGridView1.Rows.Add(Codigo, Nome, Programa, Celular, Cargo, Login, Senha, Email, Permissao, CPF);
                }

                if (cpf)
                {

                }
                else
                {
                    Limpar();
                    if (load) load = false;
                    else MessageBox.Show("Preencha o campo com o CPF!");
                }

                if (Codigo == 0)
                {
                    Limpar();
                    load = true;
                    BtnPesquisar_Click_1(sender, e);
                    MessageBox.Show("Não há funcionário cadastrado com esse CPF!");
                    AtivarCadastro();
                }
                else
                {
                    if (cpf) AtivarCadastro(false);
                    else AtivarCadastro();
                }

                dataGridView1.ClearSelection();
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
}