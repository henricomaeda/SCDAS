using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_AADAS
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            this.Enabled = false;
            progressBar.Maximum = 100;

            try
            {
                Task.Run(() =>
                {
                    for (int i = 0; i <= 100; i += 2)
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            progressBar.Value = i;
                        });
                        Thread.Sleep(40);
                    }
                    Thread.Sleep(500);
                    Invoke((MethodInvoker)delegate
                    {
                        FrmLogin login = new FrmLogin();
                        this.Hide();
                        login.ShowDialog();
                    });
                });
            }
            catch { }
        }
    }
}
