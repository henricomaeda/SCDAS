using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Projeto_AADAS
{
    public partial class FrmBackup : Form
    {
        string backup = string.Empty;
        string restaurar = string.Empty;

        public FrmBackup()
        {
            InitializeComponent();
        }

        private void BtnProcurar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                backup = dlg.SelectedPath;
                txtBackup.Text = backup;
                btnBackup.Enabled = true;
            }
        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            if (backup == String.Empty) MessageBox.Show("Selecione uma pasta para realizar o backup!", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                try
                {
                    Classes.Conexao.Conectar();
                    MySqlCommand cmd = new MySqlCommand(backup, Classes.Conexao.conn);
                    MySqlBackup bkp = new MySqlBackup(cmd);
                    bkp.ExportToFile(backup + "\\backup (" + DateTime.Now.ToString("dd-MM-yyyy") + " " + DateTime.Now.ToString("hh-mm-ss") + ").sql");
                    cmd.ExecuteNonQuery();
                    txtBackup.Clear();
                    Classes.Conexao.Desconectar();

                    MessageBox.Show("Backup efetuado com sucesso!\nBackup salvo em:\n\n" + backup, "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    backup = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO: " + ex.Message, "Backup", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnProcurar_Restaurar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                restaurar = dlg.FileName;
                txtRestaurar.Text = restaurar;
                btnRestaurar.Enabled = true;
            }
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            if (restaurar != string.Empty)
            {
                if (System.IO.File.Exists(restaurar))
                {
                    try
                    {
                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            using (MySqlBackup mb = new MySqlBackup(cmd))
                            {
                                cmd.Connection = Classes.Conexao.conn;
                                Classes.Conexao.conn.Open();
                                mb.ImportFromFile(restaurar);
                                txtRestaurar.Clear();
                                Classes.Conexao.conn.Close();

                                MessageBox.Show("Backup restaurado com sucesso!\nBackup restaurado:\n\n" + restaurar, "Restauração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                restaurar = String.Empty;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERRO: " + ex.Message);
                    }
                }
                else MessageBox.Show("O arquivo de backup para restauração não foi encontrado.", "Restauração", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else MessageBox.Show("Selecione um arquivo de backup para restaurar!", "Restauração", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}



