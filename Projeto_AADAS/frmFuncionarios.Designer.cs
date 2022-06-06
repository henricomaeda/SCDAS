namespace Projeto_AADAS
{
    partial class FrmFuncionarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFuncionarios));
            this.gbDadosFuncionario = new System.Windows.Forms.GroupBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtCPFConsulta = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.mskCel = new System.Windows.Forms.MaskedTextBox();
            this.cbPermissao = new System.Windows.Forms.ComboBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPrograma = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.gbDadosFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDadosFuncionario
            // 
            this.gbDadosFuncionario.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gbDadosFuncionario.Controls.Add(this.txtCPF);
            this.gbDadosFuncionario.Controls.Add(this.txtCPFConsulta);
            this.gbDadosFuncionario.Controls.Add(this.btnPesquisar);
            this.gbDadosFuncionario.Controls.Add(this.label5);
            this.gbDadosFuncionario.Controls.Add(this.mskCel);
            this.gbDadosFuncionario.Controls.Add(this.cbPermissao);
            this.gbDadosFuncionario.Controls.Add(this.txtLogin);
            this.gbDadosFuncionario.Controls.Add(this.txtPassword);
            this.gbDadosFuncionario.Controls.Add(this.txtCargo);
            this.gbDadosFuncionario.Controls.Add(this.txtEmail);
            this.gbDadosFuncionario.Controls.Add(this.txtPrograma);
            this.gbDadosFuncionario.Controls.Add(this.txtNome);
            this.gbDadosFuncionario.Controls.Add(this.label11);
            this.gbDadosFuncionario.Controls.Add(this.label10);
            this.gbDadosFuncionario.Controls.Add(this.label9);
            this.gbDadosFuncionario.Controls.Add(this.label8);
            this.gbDadosFuncionario.Controls.Add(this.label7);
            this.gbDadosFuncionario.Controls.Add(this.label4);
            this.gbDadosFuncionario.Controls.Add(this.label3);
            this.gbDadosFuncionario.Controls.Add(this.label2);
            this.gbDadosFuncionario.Controls.Add(this.label1);
            this.gbDadosFuncionario.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosFuncionario.Location = new System.Drawing.Point(40, 15);
            this.gbDadosFuncionario.Name = "gbDadosFuncionario";
            this.gbDadosFuncionario.Size = new System.Drawing.Size(862, 246);
            this.gbDadosFuncionario.TabIndex = 9;
            this.gbDadosFuncionario.TabStop = false;
            this.gbDadosFuncionario.Text = "Dados do Funcionário";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(488, 32);
            this.txtCPF.Mask = "999,999,999-99";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(128, 22);
            this.txtCPF.TabIndex = 137;
            this.txtCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCPFConsulta
            // 
            this.txtCPFConsulta.Location = new System.Drawing.Point(607, 216);
            this.txtCPFConsulta.Name = "txtCPFConsulta";
            this.txtCPFConsulta.Size = new System.Drawing.Size(122, 22);
            this.txtCPFConsulta.TabIndex = 135;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.Image = global::Projeto_AADAS.Properties.Resources.search;
            this.btnPesquisar.Location = new System.Drawing.Point(735, 209);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(105, 34);
            this.btnPesquisar.TabIndex = 26;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 14);
            this.label5.TabIndex = 24;
            this.label5.Text = "Consulta por CPF:";
            // 
            // mskCel
            // 
            this.mskCel.Location = new System.Drawing.Point(706, 33);
            this.mskCel.Mask = "(99)99999-9999";
            this.mskCel.Name = "mskCel";
            this.mskCel.Size = new System.Drawing.Size(134, 22);
            this.mskCel.TabIndex = 19;
            this.mskCel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbPermissao
            // 
            this.cbPermissao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPermissao.FormattingEnabled = true;
            this.cbPermissao.Items.AddRange(new object[] {
            "Administrador",
            "Funcionário"});
            this.cbPermissao.Location = new System.Drawing.Point(106, 129);
            this.cbPermissao.Name = "cbPermissao";
            this.cbPermissao.Size = new System.Drawing.Size(150, 22);
            this.cbPermissao.TabIndex = 17;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(361, 129);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(240, 22);
            this.txtLogin.TabIndex = 16;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(706, 129);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(134, 22);
            this.txtPassword.TabIndex = 15;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(506, 83);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(334, 22);
            this.txtCargo.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(91, 176);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(749, 22);
            this.txtEmail.TabIndex = 12;
            // 
            // txtPrograma
            // 
            this.txtPrograma.Location = new System.Drawing.Point(166, 83);
            this.txtPrograma.Name = "txtPrograma";
            this.txtPrograma.Size = new System.Drawing.Size(257, 22);
            this.txtPrograma.TabIndex = 11;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(78, 33);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(345, 22);
            this.txtNome.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(626, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 14);
            this.label11.TabIndex = 10;
            this.label11.Text = "Password:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(643, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 14);
            this.label10.TabIndex = 9;
            this.label10.Text = "Celular:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(446, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 14);
            this.label9.TabIndex = 8;
            this.label9.Text = "CPF:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 14);
            this.label8.TabIndex = 7;
            this.label8.Text = "Programa / Projeto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(446, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cargo :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(309, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Login:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Permissão:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_01,
            this.Column_02,
            this.Column_03,
            this.Column_04,
            this.Column_05,
            this.Column_06,
            this.Column_07,
            this.Column_08,
            this.Column_09,
            this.Column_10});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 331);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.Size = new System.Drawing.Size(944, 237);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column_01
            // 
            this.Column_01.HeaderText = "Código";
            this.Column_01.Name = "Column_01";
            this.Column_01.ReadOnly = true;
            this.Column_01.Width = 50;
            // 
            // Column_02
            // 
            this.Column_02.HeaderText = "Nome do Funcionário";
            this.Column_02.Name = "Column_02";
            this.Column_02.ReadOnly = true;
            this.Column_02.Width = 133;
            // 
            // Column_03
            // 
            this.Column_03.HeaderText = "Programa";
            this.Column_03.Name = "Column_03";
            this.Column_03.ReadOnly = true;
            // 
            // Column_04
            // 
            this.Column_04.HeaderText = "Celular";
            this.Column_04.Name = "Column_04";
            this.Column_04.ReadOnly = true;
            // 
            // Column_05
            // 
            this.Column_05.HeaderText = "Cargo";
            this.Column_05.Name = "Column_05";
            this.Column_05.ReadOnly = true;
            // 
            // Column_06
            // 
            this.Column_06.HeaderText = "Login";
            this.Column_06.Name = "Column_06";
            this.Column_06.ReadOnly = true;
            // 
            // Column_07
            // 
            this.Column_07.HeaderText = "Senha";
            this.Column_07.Name = "Column_07";
            this.Column_07.ReadOnly = true;
            this.Column_07.Width = 80;
            // 
            // Column_08
            // 
            this.Column_08.HeaderText = "E-mail";
            this.Column_08.Name = "Column_08";
            this.Column_08.ReadOnly = true;
            this.Column_08.Width = 111;
            // 
            // Column_09
            // 
            this.Column_09.HeaderText = "Permissão";
            this.Column_09.Name = "Column_09";
            this.Column_09.ReadOnly = true;
            this.Column_09.Width = 72;
            // 
            // Column_10
            // 
            this.Column_10.HeaderText = "CPF";
            this.Column_10.Name = "Column_10";
            this.Column_10.ReadOnly = true;
            this.Column_10.Width = 98;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = global::Projeto_AADAS.Properties.Resources.folder;
            this.btnLimpar.Location = new System.Drawing.Point(277, 271);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(111, 46);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Image = global::Projeto_AADAS.Properties.Resources.repeat;
            this.btnVoltar.Location = new System.Drawing.Point(160, 271);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(96, 46);
            this.btnVoltar.TabIndex = 14;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.Enabled = false;
            this.btnAtualizar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Image = global::Projeto_AADAS.Properties.Resources.note_edit;
            this.btnAtualizar.Location = new System.Drawing.Point(529, 271);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(120, 46);
            this.btnAtualizar.TabIndex = 13;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::Projeto_AADAS.Properties.Resources.note_remove;
            this.btnExcluir.Location = new System.Drawing.Point(409, 271);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(97, 46);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Image = global::Projeto_AADAS.Properties.Resources.add;
            this.btnCadastrar.Location = new System.Drawing.Point(671, 271);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(115, 46);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // FrmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(944, 568);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.gbDadosFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FUNCIONÁRIOS [PESQUISA / CADASTRO]";
            this.gbDadosFuncionario.ResumeLayout(false);
            this.gbDadosFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox gbDadosFuncionario;
        public System.Windows.Forms.MaskedTextBox mskCel;
        public System.Windows.Forms.ComboBox cbPermissao;
        public System.Windows.Forms.TextBox txtLogin;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.TextBox txtCargo;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtPrograma;
        public System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtCPFConsulta;
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
        public System.Windows.Forms.MaskedTextBox txtCPF;
    }
}