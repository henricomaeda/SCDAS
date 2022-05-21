using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_AADAS
{
    public partial class FrmRelAtendido : Form
    {
        public string Codigo { get; set; }

        public FrmRelAtendido(string codigo)
        {
            InitializeComponent();
            Codigo = codigo;
        }

        private void FrmRelAtendido_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'u294496755_db_aadasDataSet.atendidos'. Você pode movê-la ou removê-la conforme necessário.
            this.atendidosTableAdapter.Fill(this.scdasDataSet.atendidos, int.Parse(Codigo));
            var setup = this.reportViewer1.GetPageSettings();
            setup.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            //setup.PaperSize.Height = 11;
            this.reportViewer1.SetPageSettings(setup);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
