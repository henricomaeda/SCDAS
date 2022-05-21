using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;


namespace Projeto_AADAS
{
    public partial class FrmBackup : Form
    {
        public FrmBackup()
        {
            InitializeComponent();
        }

        private void BtnProcurar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtBackup.Text = dlg.SelectedPath;
                btnBackup.Enabled = true;
            }
        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            Classes.Conexao.Conectar();
            string backup = "C:\\Backup\\backup.sql";
            MySqlCommand cmd = new MySqlCommand(backup, Classes.Conexao.conn);
            MySqlBackup bkp = new MySqlBackup(cmd);
            bkp.ExportToFile(backup);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Backup efetuado com sucesso");
            btnBackup.Enabled = false;
            txtBackup.Clear();
            Classes.Conexao.Desconectar();

            /*
            if (System.IO.File.Exists(@"C:\Backup\projeto_aadas.sql"))
            {
                string caminho = "projeto_aadas" + DateTime.Now.ToString();
                caminho = caminho.Replace("/", "_");
                caminho = caminho.Replace(" ", "_");
                caminho = caminho.Replace(":", "");
                System.IO.File.Move(@"C:\Backup\Projeto_aadas.sql", @"C:\Backup\" + caminho + ".sql");
            }
                
            string sql = @"BACKUP DATABASE projeto_aadas TO DISK = '" + txtBackup.Text + "\\projeto_aadas.sql'";
            MySqlCommand cmd = new MySqlCommand(sql, Classes.Conexao.conn);
            MySqlBackup bkp = new MySqlBackup(cmd);
            bkp.ExportToFile(sql);
                
            cmd.ExecuteNonQuery();
            MessageBox.Show("Backup efetuado com sucesso");
            btnBackup.Enabled = false;
            txtBackup.Clear();
            Classes.Conexao.Desconectar();
            */
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"C:\Backup\backup.sql"))
            {
                try
                {
                    MessageBox.Show("Restauração efetuada com sucesso!\nNecessário reiniciar o sistema...");
                    System.IO.File.Move(@"C:\Backup\backup.sql", @"C:\Backup\backup_RESTAURA.sql");
                    Application.Restart();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro :" + ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Não existe arquivos de backup" + " para a restauração.\nFavor realizar backup", "Realizar Backup", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}



