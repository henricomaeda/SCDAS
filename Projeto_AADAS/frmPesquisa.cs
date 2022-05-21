using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Projeto_AADAS
{
    public partial class FrmPesquisa : Form
    {
        readonly string tipo = string.Empty;
        string CPF = string.Empty;

        public FrmPesquisa(string acesso)
        {
            tipo = acesso.Trim();
            InitializeComponent();
        }

        private void FrmPesquisa_Load(object sender, EventArgs e)
        {
            if (tipo != "Administrador") btnEditar.Enabled = false;
        }

        private void Atualizar(object sender, EventArgs e)
        {
            if (rbData.Checked)
            {
                if (cbData.SelectedIndex != -1)
                {
                    Classes.Conexao.Conectar();
                    TxtPesquisar_TextChanged(sender, e);
                }
                else this.dgvAtendidos.Rows.Clear();
            }
            else if (txtPesquisar.Text != "")
            {
                Classes.Conexao.Conectar();
                TxtPesquisar_TextChanged(sender, e);
            }
            else this.dgvAtendidos.Rows.Clear();
        }

        private void TxtPesquisar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "";
                if (rbData.Checked)
                {
                    string data = cbData.Text;
                    data = data.Replace(" de ", string.Empty);

                    sql = @"select * from atendidos where " + data + " between '" + dtpInicial.Value.ToString("yyyy/MM/dd") + "' and '" + dtpFinal.Value.ToString("yyyy/MM/dd") + "'";
                    
                    int Codigo = 0;
                    DateTime DataAdmissao = DateTime.Now;
                    DateTime DataDesligamento = DateTime.Now;
                    string ProgramaProjeto = string.Empty;
                    string ProgramaOutros = string.Empty;
                    DateTime DataCadastro = DateTime.Now;
                    string NomeUsuario = string.Empty;
                    string GPA = string.Empty;
                    DateTime DataAudiometria = DateTime.Now;
                    string DoencaAssociadas = string.Empty;
                    DateTime DataNascimento = DateTime.Now;
                    CPF = string.Empty;
                    string RG = string.Empty;
                    string CRA = string.Empty;
                    string NomePai = string.Empty;
                    string NomeMae = string.Empty;
                    string NomeResponsavel = string.Empty;
                    string RGResponsavel = string.Empty;
                    string CPFResponsavel = string.Empty;
                    string Endereco = string.Empty;
                    string Telefone = string.Empty;
                    string Celular = string.Empty;
                    string TelefoneRecado = string.Empty;
                    string Escola = string.Empty;
                    string Escolaridade = string.Empty;
                    string Periodo = string.Empty;

                    Classes.Conexao.Conectar();
                    MySqlCommand cmd = new MySqlCommand(sql, Classes.Conexao.conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    this.dgvAtendidos.Rows.Clear();
                    while (reader.Read())
                    {
                        DataAdmissao = Convert.ToDateTime(reader["DataAdmissao"].ToString());
                        DataDesligamento = Convert.ToDateTime(reader["DataDesligamento"].ToString());
                        ProgramaProjeto = reader["ProgramaIns"].ToString();
                        ProgramaOutros = reader["OutroPrograma"].ToString();
                        DataCadastro = Convert.ToDateTime(reader["DataCadastro"].ToString());
                        NomeUsuario = reader["NomeUsuario"].ToString();
                        GPA = reader["GrauPerdaAud"].ToString();
                        DataAudiometria = Convert.ToDateTime(reader["DataAudiometria"].ToString());
                        DoencaAssociadas = reader["DoencasAss"].ToString();
                        DataNascimento = Convert.ToDateTime(reader["DataNascimento"].ToString());
                        CPF = reader["CPF"].ToString();
                        RG = reader["RG"].ToString();
                        CRA = reader["CRA"].ToString();
                        NomePai = reader["NomePai"].ToString();
                        NomeMae = reader["NomeMae"].ToString();
                        NomeResponsavel = reader["NomeResp"].ToString();
                        RGResponsavel = reader["RGResp"].ToString();
                        CPFResponsavel = reader["CPFResp"].ToString();
                        Endereco = reader["Endereco"].ToString();
                        Telefone = reader["Telefone"].ToString();
                        Celular = reader["Celular"].ToString();
                        TelefoneRecado = reader["TelRecado"].ToString();
                        Escola = reader["Escola"].ToString();
                        Escolaridade = reader["Escolaridade"].ToString();
                        Periodo = reader["Periodo"].ToString();

                        Codigo = int.Parse(reader["Codigo"].ToString());
                        this.dgvAtendidos.Rows.Add(Codigo, DataAdmissao.ToString("dd/MMM/yyyy"), DataDesligamento.ToString("dd/MMM/yyyy"), ProgramaProjeto, ProgramaOutros, DataCadastro.ToString("dd/MMM/yyyy"), NomeUsuario, GPA, DataAudiometria.ToString("dd/MMM/yyyy"), DoencaAssociadas, DataNascimento.ToString("dd/MMM/yyyy"), CPF, RG, CRA, NomePai, NomeMae, NomeResponsavel, CPFResponsavel, RGResponsavel, Endereco, Telefone, Celular, TelefoneRecado, Escola, Escolaridade, Periodo);
                    }

                    dgvAtendidos.ClearSelection();
                }
                else
                {
                    if (txtPesquisar.Text != "")
                    {
                        if (rbNome.Checked)
                        {
                            sql = @"select * from atendidos where NomeUsuario like '" + txtPesquisar.Text + "%'";
                        }
                        else if(rbCPF.Checked)
                        {
                            sql = @"select * from atendidos where CPF like '" + txtPesquisar.Text + "%'";
                        }
                        else if (rbCRA.Checked)
                        {
                            sql = @"select * from atendidos where CRA like '" + txtPesquisar.Text + "%'";
                        }

                        int Codigo = 0;
                        DateTime DataAdmissao = DateTime.Now;
                        DateTime DataDesligamento = DateTime.Now;
                        string ProgramaProjeto = string.Empty;
                        string ProgramaOutros = string.Empty;
                        DateTime DataCadastro = DateTime.Now;
                        string NomeUsuario = string.Empty;
                        string GPA = string.Empty;
                        DateTime DataAudiometria = DateTime.Now;
                        string DoencaAssociadas = string.Empty;
                        DateTime DataNascimento = DateTime.Now;
                        CPF = string.Empty;
                        string RG = string.Empty;
                        string CRA = string.Empty;
                        string NomePai = string.Empty;
                        string NomeMae = string.Empty;
                        string NomeResponsavel = string.Empty;
                        string RGResponsavel = string.Empty;
                        string CPFResponsavel = string.Empty;
                        string Endereco = string.Empty;
                        string Telefone = string.Empty;
                        string Celular = string.Empty;
                        string TelefoneRecado = string.Empty;
                        string Escola = string.Empty;
                        string Escolaridade = string.Empty;
                        string Periodo = string.Empty;

                        Classes.Conexao.Conectar();
                        MySqlCommand cmd = new MySqlCommand(sql, Classes.Conexao.conn);
                        MySqlDataReader reader = cmd.ExecuteReader();

                        this.dgvAtendidos.Rows.Clear();
                        while (reader.Read())
                        {
                            DataAdmissao = Convert.ToDateTime(reader["DataAdmissao"].ToString());
                            DataDesligamento = Convert.ToDateTime(reader["DataDesligamento"].ToString());
                            ProgramaProjeto = reader["ProgramaIns"].ToString();
                            ProgramaOutros = reader["OutroPrograma"].ToString();
                            DataCadastro = Convert.ToDateTime(reader["DataCadastro"].ToString());
                            NomeUsuario = reader["NomeUsuario"].ToString();
                            GPA = reader["GrauPerdaAud"].ToString();
                            DataAudiometria = Convert.ToDateTime(reader["DataAudiometria"].ToString());
                            DoencaAssociadas = reader["DoencasAss"].ToString();
                            DataNascimento = Convert.ToDateTime(reader["DataNascimento"].ToString());
                            CPF = reader["CPF"].ToString();
                            RG = reader["RG"].ToString();
                            CRA = reader["CRA"].ToString();
                            NomePai = reader["NomePai"].ToString();
                            NomeMae = reader["NomeMae"].ToString();
                            NomeResponsavel = reader["NomeResp"].ToString();
                            RGResponsavel = reader["RGResp"].ToString();
                            CPFResponsavel = reader["CPFResp"].ToString();
                            Endereco = reader["Endereco"].ToString();
                            Telefone = reader["Telefone"].ToString();
                            Celular = reader["Celular"].ToString();
                            TelefoneRecado = reader["TelRecado"].ToString();
                            Escola = reader["Escola"].ToString();
                            Escolaridade = reader["Escolaridade"].ToString();
                            Periodo = reader["Periodo"].ToString();

                            Codigo = int.Parse(reader["Codigo"].ToString());
                            this.dgvAtendidos.Rows.Add(Codigo, DataAdmissao.ToString("dd/MMM/yyyy"), DataDesligamento.ToString("dd/MMM/yyyy"), ProgramaProjeto, ProgramaOutros, DataCadastro.ToString("dd/MMM/yyyy"), NomeUsuario, GPA, DataAudiometria.ToString("dd/MMM/yyyy"), DoencaAssociadas, DataNascimento.ToString("dd/MMM/yyyy"), CPF, RG, CRA, NomePai, NomeMae, NomeResponsavel, CPFResponsavel, RGResponsavel, Endereco, Telefone, Celular, TelefoneRecado, Escola, Escolaridade, Periodo);
                        }

                        dgvAtendidos.ClearSelection();
                    }
                    else this.dgvAtendidos.Rows.Clear();
                }
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

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtPesquisar.Clear();
            rbNome.Checked = true;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var caption = "ERRO";
            var buttons = MessageBoxButtons.OKCancel;
            var icon = MessageBoxIcon.Error;

            txtPesquisar.Focus();

            if (CPF == "") MessageBox.Show("Nenhum atendido foi encontrado!", caption, buttons, icon);
            else
            {
                if (rbData.Checked)
                {
                    if (cbData.SelectedIndex == -1) MessageBox.Show("Selecione uma data para alterar os dados!", caption, buttons, icon);
                    else
                    {
                        this.Hide();
                        FrmAtendido frmAtendido = new FrmAtendido(CPF);
                        frmAtendido.ShowDialog();
                    }
                }
                else
                {
                    if (txtPesquisar.Text.Trim().Length == 0) MessageBox.Show("Preencha o campo para alterar os dados!", caption, buttons, icon);
                    else
                    {
                        this.Hide();
                        FrmAtendido frmAtendido = new FrmAtendido(CPF);
                        frmAtendido.ShowDialog();
                    }
                }
            }
        }

        private void dgvAtendidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvAtendidos.Rows[e.RowIndex];
                CPF = row.Cells[11].Value.ToString();
            }
        }
    }
}