using MySql.Data.MySqlClient;

namespace Projeto_AADAS.Classes
{
    class Conexao
    {
        public static MySqlConnection conn;

        // Conexão com o banco de dados online:
        // private static readonly string conexao = "Server=sql111.main-hosting.eu; Port=3306; User ID=u294496755_adm_aadas; Pwd=a1729DS$hhaft; Database=u294496755_db_aadas";
        
        // Conexão com o banco de dados local:
        protected static readonly string conexao = "Server=localhost; Port=3306; Database=scdas; Uid=root; Pwd=''; SslMode=None;";

        public static void Conectar()
        {
            conn = new MySqlConnection(conexao);
            conn.Open();
        }

        public static void Desconectar()
        {
            conn.Close();
        }
    }
}
