using MySql.Data.MySqlClient;
using System;

namespace Projeto_AADAS.Classes
{
    class Atendido
    {
        public static void Inserir(DateTime dataAdm, DateTime dataDes, string programaIns, string outroPrograma, DateTime dataCad, string nomeUsuar, string grauPerdAudio, DateTime ultAudio, string doencasAsso, DateTime dataNasci, string cpf, string rg, string cra, string nomePai, string nomeMae, string nomeResp, string rgResp, string cpfResp, string endereco, string telefone, string celular, string telRecado, string escola, string escolaridade, string periodo)
        {
            string sql = @"insert into atendidos values (null, @DataAdmissao, @DataDesligamento, @ProgramaIns, @OutroPrograma, @DataCadastro, @NomeUsuario, @GrauPerdaAud, @UltimaAud, @DoencasAss,@DataNascimento, @CPF, @RG, @CRA, @NomePai, @NomeMae, @NomeResp, @RGResp, @CPFResp, @Endereco, @Telefone, @Celular, @TelRecado, @Escola, @Escolaridade, @Periodo)";

            MySqlCommand cmd = new MySqlCommand(sql, Conexao.conn);

            cmd.Parameters.AddWithValue("DataAdmissao", dataAdm);
            cmd.Parameters.AddWithValue("DataDesligamento", dataDes);
            cmd.Parameters.AddWithValue("ProgramaIns", programaIns);
            cmd.Parameters.AddWithValue("OutroPrograma", outroPrograma);
            cmd.Parameters.AddWithValue("DataCadastro", dataCad);
            cmd.Parameters.AddWithValue("NomeUsuario", nomeUsuar);
            cmd.Parameters.AddWithValue("GrauPerdaAud", grauPerdAudio);
            cmd.Parameters.AddWithValue("UltimaAud", ultAudio);
            cmd.Parameters.AddWithValue("DoencasAss", doencasAsso);
            cmd.Parameters.AddWithValue("DataNascimento", dataNasci);
            cmd.Parameters.AddWithValue("CPF", cpf);
            cmd.Parameters.AddWithValue("RG", rg);
            cmd.Parameters.AddWithValue("CRA", cra);
            cmd.Parameters.AddWithValue("NomePai", nomePai);
            cmd.Parameters.AddWithValue("NomeMae", nomeMae);
            cmd.Parameters.AddWithValue("NomeResp", nomeResp);
            cmd.Parameters.AddWithValue("RGResp", rgResp);
            cmd.Parameters.AddWithValue("CPFResp", cpfResp);
            cmd.Parameters.AddWithValue("Endereco", endereco);
            cmd.Parameters.AddWithValue("Telefone", telefone);
            cmd.Parameters.AddWithValue("Celular", celular);
            cmd.Parameters.AddWithValue("TelRecado", telRecado);
            cmd.Parameters.AddWithValue("Escola", escola);
            cmd.Parameters.AddWithValue("Escolaridade", escolaridade);
            cmd.Parameters.AddWithValue("Periodo", periodo);

            cmd.ExecuteNonQuery();
        }

        public static void Atualizar(DateTime dataAdm, DateTime dataDes, string programaIns, string outroPrograma, DateTime dataCad, string nomeUsuar, string grauPerdAudio, DateTime ultAudio, string doencasAsso, DateTime dataNasci, string cpf, string rg, string cra, string nomePai, string nomeMae, string nomeResp, string rgResp, string cpfResp, string endereco, string telefone, string celular, string telRecado, string escola, string escolaridade, string periodo, int codigo)
        {

            string sql = @"update atendidos set DataAdmissao=@DataAdmissao, DataDesligamento=@DataDesligamento, ProgramaIns=@ProgramaIns, OutroPrograma=@OutroPrograma, DataCadastro=@DataCadastro, NomeUsuario=@NomeUsuario, GrauPerdaAud=@GrauPerdaAud, DataAudiometria=@UltimaAud, DoencasAss=@DoencasAss, DataNascimento=@DataNascimento, CPF=@CPF, RG=@RG, CRA=@CRA, NomePai=@NomePai, NomeMae=@NomeMae, NomeResp=@NomeResp, RGResp=@RGResp, CPFResp=@CPFResp, Endereco=@Endereco, Telefone=@Telefone, Celular=@Celular, TelRecado=@TelRecado, Escola=@Escola, Escolaridade=@Escolaridade, Periodo=@Periodo where Codigo=@Codigo";

            MySqlCommand cmd = new MySqlCommand(sql, Conexao.conn);

            cmd.Parameters.AddWithValue("DataAdmissao", dataAdm);
            cmd.Parameters.AddWithValue("DataDesligamento", dataDes);
            cmd.Parameters.AddWithValue("ProgramaIns", programaIns);
            cmd.Parameters.AddWithValue("OutroPrograma", outroPrograma);
            cmd.Parameters.AddWithValue("DataCadastro", dataCad);
            cmd.Parameters.AddWithValue("NomeUsuario", nomeUsuar);
            cmd.Parameters.AddWithValue("GrauPerdaAud", grauPerdAudio);
            cmd.Parameters.AddWithValue("UltimaAud", ultAudio);
            cmd.Parameters.AddWithValue("DoencasAss", doencasAsso);
            cmd.Parameters.AddWithValue("DataNascimento", dataNasci);
            cmd.Parameters.AddWithValue("CPF", cpf);
            cmd.Parameters.AddWithValue("RG", rg);
            cmd.Parameters.AddWithValue("CRA", cra);
            cmd.Parameters.AddWithValue("NomePai", nomePai);
            cmd.Parameters.AddWithValue("NomeMae", nomeMae);
            cmd.Parameters.AddWithValue("NomeResp", nomeResp);
            cmd.Parameters.AddWithValue("RGResp", rgResp);
            cmd.Parameters.AddWithValue("CPFResp", cpfResp);
            cmd.Parameters.AddWithValue("Endereco", endereco);
            cmd.Parameters.AddWithValue("Telefone", telefone);
            cmd.Parameters.AddWithValue("Celular", celular);
            cmd.Parameters.AddWithValue("TelRecado", telRecado);
            cmd.Parameters.AddWithValue("Escola", escola);
            cmd.Parameters.AddWithValue("Escolaridade", escolaridade);
            cmd.Parameters.AddWithValue("Periodo", periodo);
            cmd.Parameters.AddWithValue("Codigo", codigo);

            cmd.ExecuteNonQuery();
        }

        public static void Excluir(int codigo_atendido)
        {
            string sql = @"delete from atendidos where Codigo=@Codigo";

            MySqlCommand cmd = new MySqlCommand(sql, Conexao.conn);
            cmd.Parameters.AddWithValue("Codigo", codigo_atendido);
            cmd.ExecuteNonQuery();
        }

        public static string fechar = "";
    }
}

