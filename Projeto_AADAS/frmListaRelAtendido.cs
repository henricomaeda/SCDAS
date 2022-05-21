using System;
using System.Windows.Forms;

namespace Projeto_AADAS
{
    public partial class FrmListaRelAtendido : Form
    {
        public FrmListaRelAtendido()
        {
            InitializeComponent();
        }

        private void FrmListaRelAtendido_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'scdasDataSet.atendidosListaCPF'. Você pode movê-la ou removê-la conforme necessário.
            this.atendidosListaCPFTableAdapter.Fill(this.scdasDataSet.atendidosListaCPF);
            // TODO: esta linha de código carrega dados na tabela 'u294496755_db_aadasDataSet.atendidos'. Você pode movê-la ou removê-la conforme necessário.
            var setup = this.reportViewer1.GetPageSettings();
            setup.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            this.atendidosListaCPFTableAdapter.Fill(this.scdasDataSet.atendidosListaCPF);
            this.reportViewer1.SetPageSettings(setup);
            this.reportViewer1.RefreshReport();

            comboBox1.SelectedIndex = 0;
            dateTimePicker1.CustomFormat = "dd/MMM/yyyy";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (comboBox1.SelectedIndex == 0) Buscar("DataAdmissao");
                else if (comboBox1.SelectedIndex == 1) Buscar("DataDesligamento");
                else if (comboBox1.SelectedIndex == 2) Buscar("DataCadastro");
                else if (comboBox1.SelectedIndex == 3) Buscar("DataAudiometria");
                else if (comboBox1.SelectedIndex == 4) Buscar("DataNascimento");
                else MessageBox.Show("Selecione a data que deseja buscar!", "Busca de dados", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                if (mskCPFAtendido.Text.Length < 14) MessageBox.Show("Preencha o CPF do atendido!", "Busca de dados", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                else Buscar("CPF");
            }
        }

        private void Buscar(string filtro)
        {
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("DataAdmissao", (string)null));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("DataDesligamento", (string)null));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("DataCadastro", (string)null));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("DataAudiometria", (string)null));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("DataNascimento", (string)null));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("CPF", (string)null));
            if (filtro == "Todos")
            {
                radioButton1.Checked = true;
                comboBox1.SelectedIndex = 0;
                dateTimePicker1.Value = DateTime.Now;
                mskCPFAtendido.Clear();
            }
            else
            {
                if (filtro == "CPF") this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("CPF", mskCPFAtendido.Text));
                //else this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter(filtro, dateTimePicker1.Text));
            }
            this.reportViewer1.RefreshReport();
        }

        private void BtnMostrarTodos_Click(object sender, EventArgs e)
        {
            Buscar("Todos");
        }

        
    }
}
