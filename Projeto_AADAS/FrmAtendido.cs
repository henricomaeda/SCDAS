using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Projeto_AADAS
{
    public partial class FrmAtendido : Form
    {
        int Codigo = 0;
        string CPF = string.Empty;

        public FrmAtendido(string CPF_Editar)
        {
            CPF = CPF_Editar;
            InitializeComponent();
        }

        private void FrmAtendido2_Load(object sender, EventArgs e)
        {
            if (CPF != string.Empty)
            {
                txtCPFConsulta.Text = CPF;
                BtnPesquisar_Click(sender, e);
            }
        }

        public void Limpar()
        {
            dtpDataAdmissao.Value = DateTime.Now;
            dtpDataDesligamento.Value = DateTime.Now;
            dtpDataCadastro.Value = DateTime.Now;
            dtpDataAudiometria.Value = DateTime.Now;
            txtNomeUsuario.Clear();
            cbProgramaProjeto.SelectedIndex = -1;
            txtProgramaOutros.Clear();
            txtGPA.Clear();
            txtDoencaAss.Clear();
            dtpDataNascimento.Value = DateTime.Now;
            mskCPF.Clear();
            mskRG.Clear();
            txtCRA.Clear();

            txtNomePai.Clear();
            txtNomeMae.Clear();
            txtNomeResp.Clear();
            mskCPFResp.Clear();
            mskRGResp.Clear();
            txtEndereco.Clear();
            mskTelefone.Clear();
            mskCelular.Clear();
            mskTelRec.Clear();
            txtEscola.Clear();
            txtEscolaridade.Clear();
            cbPeriodo.SelectedIndex = -1;

            txtCPFConsulta.Clear();
            this.dataGridView1.Rows.Clear();

            btnExcluir.Enabled = false;
            btnAtualizar.Enabled = false;
            btnRelAtend.Enabled = false;
            btnCadastrar.Enabled = true;
            dataGridView1.DataSource = null;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Classes.Conexao.Conectar();
                if (txtNomeUsuario.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Preencha o nome do atendido.");
                }
                else if (cbProgramaProjeto.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecione o programa / projeto inserido.");
                }
                else if (txtDoencaAss.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Preencha as doenças associadas.");
                }
                else if (txtGPA.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Preencha o grau de perda auditiva.");
                }
                else if (mskCPF.Text.Length != 14)
                {
                    MessageBox.Show("Preencha o CPF.");
                }
                else if (mskRG.Text.Length != 12)
                {
                    MessageBox.Show("Preencha o RG.");
                }
                else if (txtCRA.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Preencha o CRA.");
                }
                else if (txtNomePai.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Preencha o nome do pai.");
                }
                else if (txtNomeMae.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Preencha o nome da mãe.");
                }
                else if (txtNomeResp.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Preencha o nome do responsável.");
                }
                else if (mskCPFResp.Text.Length != 14)
                {
                    MessageBox.Show("Preencha o CPF do responsável.");
                }
                else if (mskRGResp.Text.Length != 12)
                {
                    MessageBox.Show("Preencha o RG do responsável.");
                }
                else if (txtEndereco.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Preencha o endereço.");
                }
                else if (mskTelefone.Text.Length != 13)
                {
                    MessageBox.Show("Preencha o telefone.");
                }
                else if (mskCelular.Text.Length != 14)
                {
                    MessageBox.Show("Preencha o celular.");
                }
                else if (mskTelRec.Text.Length != 14)
                {
                    MessageBox.Show("Preencha o telefone para contato.");
                }
                else if (txtEscolaridade.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Preencha a escolaridade.");
                }
                else if (txtEscola.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Preencha o nome da escola.");
                }
                else if (cbPeriodo.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Preencha o período escolar.");
                }
                else
                {
                    string sql = @"select CPF from atendidos where CPF = @CPF";

                    Classes.Conexao.Conectar();
                    MySqlCommand cmd = new MySqlCommand(sql, Classes.Conexao.conn);
                    cmd.Parameters.AddWithValue("CPF", mskCPF.Text);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows) MessageBox.Show("Já existe um Atendido com este CPF.");
                    else
                    {
                        string sql1 = @"select CRA from atendidos where CRA = @CRA";

                        Classes.Conexao.Conectar();
                        MySqlCommand cmd1 = new MySqlCommand(sql1, Classes.Conexao.conn);
                        cmd1.Parameters.AddWithValue("CRA", txtCRA.Text);
                        MySqlDataReader dr1 = cmd1.ExecuteReader();

                        if (dr1.HasRows) MessageBox.Show("Já existe um Atendido com este CRA.");
                        else
                        {
                            Classes.Conexao.Conectar();
                            Classes.Atendido.Inserir(dtpDataAdmissao.Value, dtpDataDesligamento.Value, cbProgramaProjeto.Text, txtProgramaOutros.Text, dtpDataCadastro.Value, txtNomeUsuario.Text, txtGPA.Text, dtpDataAudiometria.Value, txtDoencaAss.Text, dtpDataNascimento.Value, mskCPF.Text, mskRG.Text, txtCRA.Text, txtNomePai.Text, txtNomeMae.Text, txtNomeResp.Text, mskRGResp.Text, mskCPFResp.Text, txtEndereco.Text, mskTelefone.Text, mskCelular.Text, mskTelRec.Text, txtEscola.Text, txtEscolaridade.Text, cbPeriodo.Text);
                            MessageBox.Show("Cadastro efetuado com sucesso !!!");
                            Limpar();

                            dr1.Close();
                        }
                        dr.Close();
                    }
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

            Classes.Atendido.fechar = "OK";
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Classes.Conexao.Conectar();
                Classes.Atendido.Atualizar(dtpDataAdmissao.Value, dtpDataDesligamento.Value, cbProgramaProjeto.Text, txtProgramaOutros.Text, dtpDataCadastro.Value, txtNomeUsuario.Text, txtGPA.Text, dtpDataAudiometria.Value, txtDoencaAss.Text, dtpDataNascimento.Value, mskCPF.Text, mskRG.Text, txtCRA.Text, txtNomePai.Text, txtNomeMae.Text, txtNomeResp.Text, mskRGResp.Text, mskCPFResp.Text, txtEndereco.Text, mskTelefone.Text, mskCelular.Text, mskTelRec.Text, txtEscola.Text, txtEscolaridade.Text, cbPeriodo.Text, Codigo);
                MessageBox.Show("Atendido atualizado com sucesso !!!");
                Limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro :" + ex.Message);
            }
            finally
            {
                Classes.Conexao.Desconectar();

            }

            Classes.Atendido.fechar = "OK";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult op = MessageBox.Show("Deseja excluir o Registro?", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (op == DialogResult.Yes)
            {
                try
                {
                    Classes.Conexao.Conectar();
                    Classes.Atendido.Excluir(Codigo);
                    MessageBox.Show("Atendido foi excluído com sucesso !!!");
                    Button3_Click(null, null);
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

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtCPFConsulta.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha com o CPF");
                txtCPFConsulta.Focus();
            }
            else
            {
                try
                {
                    string sql = @"select * from atendidos where cpf like '" + txtCPFConsulta.Text + "%' ";

                    Codigo = 0;
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
                    string CPF = string.Empty;
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

                    this.dataGridView1.Rows.Clear();
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

                        if (Codigo == 0)
                        {
                            dtpDataAdmissao.Text = DataAdmissao.ToString();
                            dtpDataDesligamento.Text = DataDesligamento.ToString();
                            dtpDataCadastro.Text = DataCadastro.ToString();
                            dtpDataAudiometria.Text = DataAudiometria.ToString();
                            txtNomeUsuario.Text = NomeUsuario;
                            cbProgramaProjeto.Text = ProgramaProjeto;
                            txtDoencaAss.Text = DoencaAssociadas;
                            txtGPA.Text = GPA;
                            txtProgramaOutros.Text = ProgramaOutros;
                            dtpDataNascimento.Text = DataNascimento.ToString();
                            mskCPF.Text = CPF;
                            mskRG.Text = RG;
                            txtCRA.Text = CRA;
                            txtNomePai.Text = NomePai;
                            txtNomeMae.Text = NomeMae;
                            txtNomeResp.Text = NomeResponsavel;
                            mskRGResp.Text = RGResponsavel;
                            mskCPFResp.Text = CPFResponsavel;
                            txtEndereco.Text = Endereco;
                            mskTelefone.Text = Telefone;
                            mskCelular.Text = Celular;
                            mskTelRec.Text = TelefoneRecado;
                            txtEscolaridade.Text = Escolaridade;
                            txtEscola.Text = Escola;
                            cbPeriodo.Text = Periodo;
                            Codigo = int.Parse(reader["Codigo"].ToString());
                        }
                        this.dataGridView1.Rows.Add(int.Parse(reader["Codigo"].ToString()), DataAdmissao.ToString("dd/MMM/yyyy"), DataDesligamento.ToString("dd/MMM/yyyy"), ProgramaProjeto, ProgramaOutros, DataCadastro.ToString("dd/MMM/yyyy"), NomeUsuario, GPA, DataAudiometria.ToString("dd/MMM/yyyy"), DoencaAssociadas, DataNascimento.ToString("dd/MMM/yyyy"), CPF, RG, CRA, NomePai, NomeMae, NomeResponsavel, RGResponsavel, CPFResponsavel, Endereco, Telefone, Celular, TelefoneRecado, Escola, Escolaridade, Periodo);
                        btnExcluir.Enabled = true;
                        btnAtualizar.Enabled = true;
                        btnRelAtend.Enabled = true;
                        btnCadastrar.Enabled = false;
                    }

                    if (Codigo == 0)
                    {
                        Limpar();
                        MessageBox.Show("Não há atendido cadastrado com esse CPF!");
                    }
                    else
                    {
                        btnExcluir.Enabled = true;
                        btnAtualizar.Enabled = true;
                        btnRelAtend.Enabled = true;
                        btnCadastrar.Enabled = false;
                    }

                    dataGridView1.ClearSelection();
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
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void BtnRelAtend_Click(object sender, EventArgs e)
        {
            FrmRelAtendido form = new FrmRelAtendido(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            form.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var message = "Você tem certeza que deseja alterar os dados exibidos?";
                var buttons = MessageBoxButtons.YesNo;
                var icon = MessageBoxIcon.Question;

                DialogResult result = MessageBox.Show(message, "Atendidos", buttons, icon);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    CPF = row.Cells[11].Value.ToString();

                    string sql = @"select * from atendidos where cpf = '" + CPF + "' ";
                    Classes.Conexao.Conectar();
                    MySqlCommand cmd = new MySqlCommand(sql, Classes.Conexao.conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        DateTime DataAdmissao = Convert.ToDateTime(reader["DataAdmissao"].ToString());
                        DateTime DataDesligamento = Convert.ToDateTime(reader["DataDesligamento"].ToString());
                        string ProgramaProjeto = reader["ProgramaIns"].ToString();
                        string ProgramaOutros = reader["OutroPrograma"].ToString();
                        DateTime DataCadastro = Convert.ToDateTime(reader["DataCadastro"].ToString());
                        string NomeUsuario = reader["NomeUsuario"].ToString();
                        string GPA = reader["GrauPerdaAud"].ToString();
                        DateTime DataAudiometria = Convert.ToDateTime(reader["DataAudiometria"].ToString());
                        string DoencaAssociadas = reader["DoencasAss"].ToString();
                        DateTime DataNascimento = Convert.ToDateTime(reader["DataNascimento"].ToString());
                        string RG = reader["RG"].ToString();
                        string CRA = reader["CRA"].ToString();
                        string NomePai = reader["NomePai"].ToString();
                        string NomeMae = reader["NomeMae"].ToString();
                        string NomeResponsavel = reader["NomeResp"].ToString();
                        string RGResponsavel = reader["RGResp"].ToString();
                        string CPFResponsavel = reader["CPFResp"].ToString();
                        string Endereco = reader["Endereco"].ToString();
                        string Telefone = reader["Telefone"].ToString();
                        string Celular = reader["Celular"].ToString();
                        string TelefoneRecado = reader["TelRecado"].ToString();
                        string Escola = reader["Escola"].ToString();
                        string Escolaridade = reader["Escolaridade"].ToString();
                        string Periodo = reader["Periodo"].ToString();

                        Codigo = int.Parse(reader["Codigo"].ToString());
                        dtpDataAdmissao.Text = DataAdmissao.ToString();
                        dtpDataDesligamento.Text = DataDesligamento.ToString();
                        dtpDataCadastro.Text = DataCadastro.ToString();
                        dtpDataAudiometria.Text = DataAudiometria.ToString();
                        txtNomeUsuario.Text = NomeUsuario;
                        cbProgramaProjeto.Text = ProgramaProjeto;
                        txtDoencaAss.Text = DoencaAssociadas;
                        txtGPA.Text = GPA;
                        txtProgramaOutros.Text = ProgramaOutros;
                        dtpDataNascimento.Text = DataNascimento.ToString();
                        mskCPF.Text = CPF;
                        mskRG.Text = RG;
                        txtCRA.Text = CRA;
                        txtNomePai.Text = NomePai;
                        txtNomeMae.Text = NomeMae;
                        txtNomeResp.Text = NomeResponsavel;
                        mskRGResp.Text = RGResponsavel;
                        mskCPFResp.Text = CPFResponsavel;
                        txtEndereco.Text = Endereco;
                        mskTelefone.Text = Telefone;
                        mskCelular.Text = Celular;
                        mskTelRec.Text = TelefoneRecado;
                        txtEscolaridade.Text = Escolaridade;
                        txtEscola.Text = Escola;
                        cbPeriodo.Text = Periodo;
                    }
                }
            }
        }
    }
}





