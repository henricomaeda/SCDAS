namespace Projeto_AADAS
{
    partial class FrmPesquisa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPesquisa));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbData = new System.Windows.Forms.RadioButton();
            this.cbData = new System.Windows.Forms.ComboBox();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.rbCPF = new System.Windows.Forms.RadioButton();
            this.rbCRA = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvAtendidos = new System.Windows.Forms.DataGridView();
            this.Column_01 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_02 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_03 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_04 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_05 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_06 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_07 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_08 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_09 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtendidos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.rbData);
            this.groupBox1.Controls.Add(this.cbData);
            this.groupBox1.Controls.Add(this.dtpFinal);
            this.groupBox1.Controls.Add(this.dtpInicial);
            this.groupBox1.Controls.Add(this.txtPesquisar);
            this.groupBox1.Controls.Add(this.rbCPF);
            this.groupBox1.Controls.Add(this.rbCRA);
            this.groupBox1.Controls.Add(this.rbNome);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(34, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por Atendidos";
            // 
            // rbData
            // 
            this.rbData.AutoSize = true;
            this.rbData.Location = new System.Drawing.Point(384, 48);
            this.rbData.Name = "rbData";
            this.rbData.Size = new System.Drawing.Size(14, 13);
            this.rbData.TabIndex = 7;
            this.rbData.TabStop = true;
            this.rbData.UseVisualStyleBackColor = true;
            this.rbData.CheckedChanged += new System.EventHandler(this.Atualizar);
            // 
            // cbData
            // 
            this.cbData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbData.FormattingEnabled = true;
            this.cbData.Items.AddRange(new object[] {
            "Data de Admissao",
            "Data de Audiometria",
            "Data de Cadastro",
            "Data de Desligamento",
            "Data de Nascimento"});
            this.cbData.Location = new System.Drawing.Point(404, 40);
            this.cbData.Name = "cbData";
            this.cbData.Size = new System.Drawing.Size(325, 30);
            this.cbData.TabIndex = 6;
            this.cbData.SelectedIndexChanged += new System.EventHandler(this.Atualizar);
            // 
            // dtpFinal
            // 
            this.dtpFinal.CustomFormat = "dd/MMM/yyyy";
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFinal.Location = new System.Drawing.Point(575, 83);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(154, 26);
            this.dtpFinal.TabIndex = 5;
            this.dtpFinal.ValueChanged += new System.EventHandler(this.Atualizar);
            // 
            // dtpInicial
            // 
            this.dtpInicial.CustomFormat = "dd/MMM/yyyy";
            this.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicial.Location = new System.Drawing.Point(404, 83);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(165, 26);
            this.dtpInicial.TabIndex = 4;
            this.dtpInicial.ValueChanged += new System.EventHandler(this.Atualizar);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(16, 83);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(314, 26);
            this.txtPesquisar.TabIndex = 3;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.TxtPesquisar_TextChanged);
            // 
            // rbCPF
            // 
            this.rbCPF.AutoSize = true;
            this.rbCPF.Location = new System.Drawing.Point(199, 41);
            this.rbCPF.Name = "rbCPF";
            this.rbCPF.Size = new System.Drawing.Size(56, 26);
            this.rbCPF.TabIndex = 2;
            this.rbCPF.Text = "CPF";
            this.rbCPF.UseVisualStyleBackColor = true;
            this.rbCPF.CheckedChanged += new System.EventHandler(this.Atualizar);
            // 
            // rbCRA
            // 
            this.rbCRA.AutoSize = true;
            this.rbCRA.Location = new System.Drawing.Point(271, 41);
            this.rbCRA.Name = "rbCRA";
            this.rbCRA.Size = new System.Drawing.Size(59, 26);
            this.rbCRA.TabIndex = 1;
            this.rbCRA.Text = "CRA";
            this.rbCRA.UseVisualStyleBackColor = true;
            this.rbCRA.CheckedChanged += new System.EventHandler(this.Atualizar);
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Checked = true;
            this.rbNome.Location = new System.Drawing.Point(16, 41);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(167, 26);
            this.rbNome.TabIndex = 0;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome do atendido";
            this.rbNome.UseVisualStyleBackColor = true;
            this.rbNome.CheckedChanged += new System.EventHandler(this.Atualizar);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = global::Projeto_AADAS.Properties.Resources.folder;
            this.btnLimpar.Location = new System.Drawing.Point(166, 442);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(115, 41);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Image = global::Projeto_AADAS.Properties.Resources.repeat;
            this.btnVoltar.Location = new System.Drawing.Point(34, 442);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(115, 41);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::Projeto_AADAS.Properties.Resources.note_edit;
            this.btnEditar.Location = new System.Drawing.Point(701, 442);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(115, 41);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // dgvAtendidos
            // 
            this.dgvAtendidos.AllowUserToAddRows = false;
            this.dgvAtendidos.AllowUserToDeleteRows = false;
            this.dgvAtendidos.AllowUserToResizeColumns = false;
            this.dgvAtendidos.AllowUserToResizeRows = false;
            this.dgvAtendidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAtendidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvAtendidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAtendidos.ColumnHeadersHeight = 40;
            this.dgvAtendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAtendidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_01,
            this.Column_02,
            this.Column_03,
            this.Column_04,
            this.Column_05,
            this.Column_06,
            this.Column_07,
            this.Column_08,
            this.Column_09,
            this.Column_10,
            this.Column_11,
            this.Column_12,
            this.Column_13,
            this.Column_14,
            this.Column_15,
            this.Column_16,
            this.Column_17,
            this.Column_18,
            this.Column_19,
            this.Column_20,
            this.Column_21,
            this.Column_22,
            this.Column_23,
            this.Column_24,
            this.Column_25,
            this.Column_26});
            this.dgvAtendidos.Location = new System.Drawing.Point(34, 161);
            this.dgvAtendidos.MultiSelect = false;
            this.dgvAtendidos.Name = "dgvAtendidos";
            this.dgvAtendidos.ReadOnly = true;
            this.dgvAtendidos.RowHeadersVisible = false;
            this.dgvAtendidos.RowHeadersWidth = 40;
            this.dgvAtendidos.Size = new System.Drawing.Size(782, 275);
            this.dgvAtendidos.TabIndex = 20;
            this.dgvAtendidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAtendidos_CellContentClick);
            // 
            // Column_01
            // 
            this.Column_01.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column_01.HeaderText = "Codigo";
            this.Column_01.Name = "Column_01";
            this.Column_01.ReadOnly = true;
            this.Column_01.Width = 65;
            // 
            // Column_02
            // 
            this.Column_02.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column_02.HeaderText = "Data de Admissão";
            this.Column_02.Name = "Column_02";
            this.Column_02.ReadOnly = true;
            this.Column_02.Width = 108;
            // 
            // Column_03
            // 
            this.Column_03.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column_03.HeaderText = "Data de Desligamento";
            this.Column_03.Name = "Column_03";
            this.Column_03.ReadOnly = true;
            this.Column_03.Width = 125;
            // 
            // Column_04
            // 
            this.Column_04.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column_04.HeaderText = "Programa ou Projeto Inserido";
            this.Column_04.Name = "Column_04";
            this.Column_04.ReadOnly = true;
            this.Column_04.Width = 120;
            // 
            // Column_05
            // 
            this.Column_05.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column_05.HeaderText = "Programa outros";
            this.Column_05.Name = "Column_05";
            this.Column_05.ReadOnly = true;
            // 
            // Column_06
            // 
            this.Column_06.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column_06.HeaderText = "Data de Cadastro";
            this.Column_06.Name = "Column_06";
            this.Column_06.ReadOnly = true;
            this.Column_06.Width = 106;
            // 
            // Column_07
            // 
            this.Column_07.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column_07.HeaderText = "Nome do Atendido";
            this.Column_07.Name = "Column_07";
            this.Column_07.ReadOnly = true;
            this.Column_07.Width = 110;
            // 
            // Column_08
            // 
            this.Column_08.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column_08.HeaderText = "GPA";
            this.Column_08.Name = "Column_08";
            this.Column_08.ReadOnly = true;
            this.Column_08.Width = 54;
            // 
            // Column_09
            // 
            this.Column_09.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column_09.HeaderText = "Data de Audiometria";
            this.Column_09.Name = "Column_09";
            this.Column_09.ReadOnly = true;
            this.Column_09.Width = 117;
            // 
            // Column_10
            // 
            this.Column_10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column_10.HeaderText = "Doenças Associadas";
            this.Column_10.Name = "Column_10";
            this.Column_10.ReadOnly = true;
            this.Column_10.Width = 121;
            // 
            // Column_11
            // 
            this.Column_11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column_11.HeaderText = "Data de Nascimento";
            this.Column_11.Name = "Column_11";
            this.Column_11.ReadOnly = true;
            this.Column_11.Width = 118;
            // 
            // Column_12
            // 
            this.Column_12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column_12.HeaderText = "CPF";
            this.Column_12.Name = "Column_12";
            this.Column_12.ReadOnly = true;
            this.Column_12.Width = 52;
            // 
            // Column_13
            // 
            this.Column_13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column_13.HeaderText = "RG";
            this.Column_13.Name = "Column_13";
            this.Column_13.ReadOnly = true;
            this.Column_13.Width = 48;
            // 
            // Column_14
            // 
            this.Column_14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column_14.HeaderText = "CRA";
            this.Column_14.Name = "Column_14";
            this.Column_14.ReadOnly = true;
            this.Column_14.Width = 54;
            // 
            // Column_15
            // 
            this.Column_15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column_15.HeaderText = "Nome do Pai";
            this.Column_15.Name = "Column_15";
            this.Column_15.ReadOnly = true;
            this.Column_15.Width = 72;
            // 
            // Column_16
            // 
            this.Column_16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column_16.HeaderText = "Nome da Mãe";
            this.Column_16.Name = "Column_16";
            this.Column_16.ReadOnly = true;
            this.Column_16.Width = 72;
            // 
            // Column_17
            // 
            this.Column_17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column_17.HeaderText = "Nome do (a) Responsável";
            this.Column_17.Name = "Column_17";
            this.Column_17.ReadOnly = true;
            this.Column_17.Width = 142;
            // 
            // Column_18
            // 
            this.Column_18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column_18.HeaderText = "RG do (a) Responsável";
            this.Column_18.Name = "Column_18";
            this.Column_18.ReadOnly = true;
            this.Column_18.Width = 131;
            // 
            // Column_19
            // 
            this.Column_19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column_19.HeaderText = "CPF do (a) Responsável";
            this.Column_19.Name = "Column_19";
            this.Column_19.ReadOnly = true;
            this.Column_19.Width = 134;
            // 
            // Column_20
            // 
            this.Column_20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column_20.HeaderText = "Endereço";
            this.Column_20.Name = "Column_20";
            this.Column_20.ReadOnly = true;
            this.Column_20.Width = 78;
            // 
            // Column_21
            // 
            this.Column_21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column_21.HeaderText = "Telefone";
            this.Column_21.Name = "Column_21";
            this.Column_21.ReadOnly = true;
            this.Column_21.Width = 74;
            // 
            // Column_22
            // 
            this.Column_22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column_22.HeaderText = "Celular";
            this.Column_22.Name = "Column_22";
            this.Column_22.ReadOnly = true;
            this.Column_22.Width = 64;
            // 
            // Column_23
            // 
            this.Column_23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column_23.HeaderText = "Telefone para Recados";
            this.Column_23.Name = "Column_23";
            this.Column_23.ReadOnly = true;
            this.Column_23.Width = 132;
            // 
            // Column_24
            // 
            this.Column_24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column_24.HeaderText = "Escola";
            this.Column_24.Name = "Column_24";
            this.Column_24.ReadOnly = true;
            this.Column_24.Width = 64;
            // 
            // Column_25
            // 
            this.Column_25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column_25.HeaderText = "Escolaridade";
            this.Column_25.Name = "Column_25";
            this.Column_25.ReadOnly = true;
            this.Column_25.Width = 93;
            // 
            // Column_26
            // 
            this.Column_26.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column_26.HeaderText = "Período";
            this.Column_26.Name = "Column_26";
            this.Column_26.ReadOnly = true;
            this.Column_26.Width = 70;
            // 
            // FrmPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(851, 495);
            this.Controls.Add(this.dgvAtendidos);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PESQUISAR";
            this.Load += new System.EventHandler(this.FrmPesquisa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtendidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.RadioButton rbCPF;
        private System.Windows.Forms.RadioButton rbCRA;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        public System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvAtendidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_01;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_02;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_03;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_04;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_05;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_06;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_07;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_08;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_09;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_22;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_23;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_24;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_25;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_26;
        private System.Windows.Forms.ComboBox cbData;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.RadioButton rbData;
    }
}