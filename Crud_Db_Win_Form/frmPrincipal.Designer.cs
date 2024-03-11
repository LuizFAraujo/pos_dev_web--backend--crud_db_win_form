namespace Crud_Db_Win_Form
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            groupBox3 = new GroupBox();
            BtnPesquisar = new Button();
            BtnCancelar = new Button();
            BtnExcluir = new Button();
            BtnAtualizar = new Button();
            BtnCadastrar = new Button();
            groupBox2 = new GroupBox();
            LbExameNome = new Label();
            TxtPacienteId = new TextBox();
            LbDiagnostico = new Label();
            TxtExameNome = new TextBox();
            TxtId = new TextBox();
            LbMedico = new Label();
            LbDataConsulta = new Label();
            LbPacienteId = new Label();
            LbId = new Label();
            TxtMedico = new TextBox();
            LbExameId = new Label();
            TxtExameId = new TextBox();
            TxtDataConsulta = new TextBox();
            LbPaciente = new Label();
            TxtDiagnostico = new TextBox();
            TxtPaciente = new TextBox();
            groupBox1 = new GroupBox();
            DataGridViewConsultas = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pacienteIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            medicoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            exameIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            diagnosticoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataConsultaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            consultaBindingSource = new BindingSource(components);
            BtnFechar = new Button();
            BtnBancoConfig = new Button();
            BtnPacientes = new Button();
            BtnExames = new Button();
            statusStrip1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewConsultas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)consultaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 758);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(943, 22);
            statusStrip1.TabIndex = 6;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripStatusLabel1.Image = Properties.Resources.img_Banco_Off_256x256;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(261, 17);
            toolStripStatusLabel1.Text = " Arquivo de banco de dados não encontrado!";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(BtnPesquisar);
            groupBox3.Controls.Add(BtnCancelar);
            groupBox3.Controls.Add(BtnExcluir);
            groupBox3.Controls.Add(BtnAtualizar);
            groupBox3.Controls.Add(BtnCadastrar);
            groupBox3.Location = new Point(19, 374);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(898, 100);
            groupBox3.TabIndex = 54;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ações";
            // 
            // BtnPesquisar
            // 
            BtnPesquisar.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPesquisar.Image = Properties.Resources.img_Pesquisar_32x32;
            BtnPesquisar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnPesquisar.Location = new Point(729, 28);
            BtnPesquisar.Margin = new Padding(3, 5, 3, 5);
            BtnPesquisar.Name = "BtnPesquisar";
            BtnPesquisar.Padding = new Padding(10, 0, 10, 0);
            BtnPesquisar.Size = new Size(137, 49);
            BtnPesquisar.TabIndex = 12;
            BtnPesquisar.Text = "Pesquisar";
            BtnPesquisar.TextAlign = ContentAlignment.MiddleRight;
            BtnPesquisar.UseVisualStyleBackColor = true;
            BtnPesquisar.Click += BtnPesquisar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCancelar.Image = Properties.Resources.img_Cancelar_32x32;
            BtnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCancelar.Location = new Point(554, 28);
            BtnCancelar.Margin = new Padding(3, 5, 3, 5);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Padding = new Padding(10, 0, 10, 0);
            BtnCancelar.Size = new Size(137, 49);
            BtnCancelar.TabIndex = 11;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.TextAlign = ContentAlignment.MiddleRight;
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnExcluir
            // 
            BtnExcluir.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnExcluir.Image = Properties.Resources.img_Deletar_32x32;
            BtnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            BtnExcluir.Location = new Point(207, 28);
            BtnExcluir.Margin = new Padding(3, 5, 3, 5);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Padding = new Padding(10, 0, 10, 0);
            BtnExcluir.Size = new Size(137, 49);
            BtnExcluir.TabIndex = 9;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.TextAlign = ContentAlignment.MiddleRight;
            BtnExcluir.UseVisualStyleBackColor = true;
            BtnExcluir.Click += BtnExcluir_Click;
            // 
            // BtnAtualizar
            // 
            BtnAtualizar.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAtualizar.Image = Properties.Resources.img_Atualizar_32x32;
            BtnAtualizar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAtualizar.Location = new Point(380, 28);
            BtnAtualizar.Margin = new Padding(3, 5, 3, 5);
            BtnAtualizar.Name = "BtnAtualizar";
            BtnAtualizar.Padding = new Padding(10, 0, 10, 0);
            BtnAtualizar.Size = new Size(137, 49);
            BtnAtualizar.TabIndex = 10;
            BtnAtualizar.Text = "Atualizar";
            BtnAtualizar.TextAlign = ContentAlignment.MiddleRight;
            BtnAtualizar.UseVisualStyleBackColor = true;
            BtnAtualizar.Click += BtnAtualizar_Click;
            // 
            // BtnCadastrar
            // 
            BtnCadastrar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCadastrar.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCadastrar.Image = Properties.Resources.img_Cadastrar_32x32;
            BtnCadastrar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCadastrar.Location = new Point(31, 28);
            BtnCadastrar.Margin = new Padding(3, 5, 3, 5);
            BtnCadastrar.Name = "BtnCadastrar";
            BtnCadastrar.Padding = new Padding(10, 0, 10, 0);
            BtnCadastrar.Size = new Size(137, 49);
            BtnCadastrar.TabIndex = 8;
            BtnCadastrar.Text = "Cadastrar";
            BtnCadastrar.TextAlign = ContentAlignment.MiddleRight;
            BtnCadastrar.UseVisualStyleBackColor = true;
            BtnCadastrar.Click += BtnCadastrar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(LbExameNome);
            groupBox2.Controls.Add(TxtPacienteId);
            groupBox2.Controls.Add(LbDiagnostico);
            groupBox2.Controls.Add(TxtExameNome);
            groupBox2.Controls.Add(TxtId);
            groupBox2.Controls.Add(LbMedico);
            groupBox2.Controls.Add(LbDataConsulta);
            groupBox2.Controls.Add(LbPacienteId);
            groupBox2.Controls.Add(LbId);
            groupBox2.Controls.Add(TxtMedico);
            groupBox2.Controls.Add(LbExameId);
            groupBox2.Controls.Add(TxtExameId);
            groupBox2.Controls.Add(TxtDataConsulta);
            groupBox2.Controls.Add(LbPaciente);
            groupBox2.Controls.Add(TxtDiagnostico);
            groupBox2.Controls.Add(TxtPaciente);
            groupBox2.Location = new Point(19, 489);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(898, 176);
            groupBox2.TabIndex = 53;
            groupBox2.TabStop = false;
            groupBox2.Text = "Item";
            // 
            // LbExameNome
            // 
            LbExameNome.AutoSize = true;
            LbExameNome.Location = new Point(219, 122);
            LbExameNome.Name = "LbExameNome";
            LbExameNome.Size = new Size(52, 19);
            LbExameNome.TabIndex = 67;
            LbExameNome.Text = "Exame";
            LbExameNome.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TxtPacienteId
            // 
            TxtPacienteId.Location = new Point(116, 77);
            TxtPacienteId.Name = "TxtPacienteId";
            TxtPacienteId.Size = new Size(64, 27);
            TxtPacienteId.TabIndex = 66;
            TxtPacienteId.Text = "5";
            // 
            // LbDiagnostico
            // 
            LbDiagnostico.AutoSize = true;
            LbDiagnostico.Location = new Point(603, 39);
            LbDiagnostico.Name = "LbDiagnostico";
            LbDiagnostico.Size = new Size(86, 19);
            LbDiagnostico.TabIndex = 64;
            LbDiagnostico.Text = "Diagnóstico";
            LbDiagnostico.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TxtExameNome
            // 
            TxtExameNome.Location = new Point(279, 119);
            TxtExameNome.Name = "TxtExameNome";
            TxtExameNome.Size = new Size(267, 27);
            TxtExameNome.TabIndex = 66;
            TxtExameNome.Text = "Hemograma";
            // 
            // TxtId
            // 
            TxtId.Location = new Point(116, 33);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(64, 27);
            TxtId.TabIndex = 2;
            TxtId.Text = "000";
            // 
            // LbMedico
            // 
            LbMedico.AutoSize = true;
            LbMedico.Location = new Point(209, 36);
            LbMedico.Name = "LbMedico";
            LbMedico.Size = new Size(65, 19);
            LbMedico.TabIndex = 62;
            LbMedico.Text = "*Médico";
            LbMedico.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbDataConsulta
            // 
            LbDataConsulta.AutoSize = true;
            LbDataConsulta.Location = new Point(580, 81);
            LbDataConsulta.Name = "LbDataConsulta";
            LbDataConsulta.Size = new Size(109, 19);
            LbDataConsulta.TabIndex = 65;
            LbDataConsulta.Text = "*Data Consulta";
            LbDataConsulta.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbPacienteId
            // 
            LbPacienteId.AutoSize = true;
            LbPacienteId.Location = new Point(4, 80);
            LbPacienteId.Name = "LbPacienteId";
            LbPacienteId.Size = new Size(106, 19);
            LbPacienteId.TabIndex = 67;
            LbPacienteId.Text = "*Cód. Paciente";
            LbPacienteId.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbId
            // 
            LbId.AutoSize = true;
            LbId.Location = new Point(85, 36);
            LbId.Name = "LbId";
            LbId.Size = new Size(25, 19);
            LbId.TabIndex = 60;
            LbId.Text = "id.";
            LbId.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TxtMedico
            // 
            TxtMedico.Location = new Point(279, 33);
            TxtMedico.Name = "TxtMedico";
            TxtMedico.Size = new Size(267, 27);
            TxtMedico.TabIndex = 4;
            TxtMedico.Text = "Dr. Médico";
            // 
            // LbExameId
            // 
            LbExameId.AutoSize = true;
            LbExameId.Location = new Point(17, 122);
            LbExameId.Name = "LbExameId";
            LbExameId.Size = new Size(93, 19);
            LbExameId.TabIndex = 63;
            LbExameId.Text = "*Cód. Exame";
            LbExameId.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TxtExameId
            // 
            TxtExameId.Location = new Point(116, 119);
            TxtExameId.Name = "TxtExameId";
            TxtExameId.Size = new Size(64, 27);
            TxtExameId.TabIndex = 5;
            TxtExameId.Text = "9";
            // 
            // TxtDataConsulta
            // 
            TxtDataConsulta.Location = new Point(695, 78);
            TxtDataConsulta.Name = "TxtDataConsulta";
            TxtDataConsulta.Size = new Size(171, 27);
            TxtDataConsulta.TabIndex = 7;
            TxtDataConsulta.Text = "02/08/2025";
            // 
            // LbPaciente
            // 
            LbPaciente.AutoSize = true;
            LbPaciente.Location = new Point(224, 80);
            LbPaciente.Name = "LbPaciente";
            LbPaciente.Size = new Size(47, 19);
            LbPaciente.TabIndex = 61;
            LbPaciente.Text = "Nome";
            LbPaciente.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TxtDiagnostico
            // 
            TxtDiagnostico.Location = new Point(695, 36);
            TxtDiagnostico.Name = "TxtDiagnostico";
            TxtDiagnostico.Size = new Size(171, 27);
            TxtDiagnostico.TabIndex = 6;
            TxtDiagnostico.Text = "Normal";
            // 
            // TxtPaciente
            // 
            TxtPaciente.Location = new Point(279, 77);
            TxtPaciente.Name = "TxtPaciente";
            TxtPaciente.Size = new Size(267, 27);
            TxtPaciente.TabIndex = 3;
            TxtPaciente.Text = "Paciente João";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DataGridViewConsultas);
            groupBox1.Location = new Point(19, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(898, 347);
            groupBox1.TabIndex = 52;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista Geral";
            // 
            // DataGridViewConsultas
            // 
            DataGridViewConsultas.AutoGenerateColumns = false;
            DataGridViewConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewConsultas.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, pacienteIdDataGridViewTextBoxColumn, medicoDataGridViewTextBoxColumn, exameIdDataGridViewTextBoxColumn, diagnosticoDataGridViewTextBoxColumn, dataConsultaDataGridViewTextBoxColumn });
            DataGridViewConsultas.DataSource = consultaBindingSource;
            DataGridViewConsultas.Location = new Point(16, 26);
            DataGridViewConsultas.Name = "DataGridViewConsultas";
            DataGridViewConsultas.RowTemplate.Height = 25;
            DataGridViewConsultas.Size = new Size(865, 305);
            DataGridViewConsultas.TabIndex = 100;
            DataGridViewConsultas.RowEnter += DataGridViewConsultas_RowEnter;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 35;
            // 
            // pacienteIdDataGridViewTextBoxColumn
            // 
            pacienteIdDataGridViewTextBoxColumn.DataPropertyName = "PacienteId";
            pacienteIdDataGridViewTextBoxColumn.HeaderText = "Cód. Paciente";
            pacienteIdDataGridViewTextBoxColumn.Name = "pacienteIdDataGridViewTextBoxColumn";
            pacienteIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // medicoDataGridViewTextBoxColumn
            // 
            medicoDataGridViewTextBoxColumn.DataPropertyName = "Medico";
            medicoDataGridViewTextBoxColumn.HeaderText = "Médico";
            medicoDataGridViewTextBoxColumn.Name = "medicoDataGridViewTextBoxColumn";
            medicoDataGridViewTextBoxColumn.Width = 205;
            // 
            // exameIdDataGridViewTextBoxColumn
            // 
            exameIdDataGridViewTextBoxColumn.DataPropertyName = "ExameId";
            exameIdDataGridViewTextBoxColumn.HeaderText = "Cód. Exame";
            exameIdDataGridViewTextBoxColumn.Name = "exameIdDataGridViewTextBoxColumn";
            exameIdDataGridViewTextBoxColumn.Width = 110;
            // 
            // diagnosticoDataGridViewTextBoxColumn
            // 
            diagnosticoDataGridViewTextBoxColumn.DataPropertyName = "Diagnostico";
            diagnosticoDataGridViewTextBoxColumn.HeaderText = "Diagnóstico";
            diagnosticoDataGridViewTextBoxColumn.Name = "diagnosticoDataGridViewTextBoxColumn";
            diagnosticoDataGridViewTextBoxColumn.Width = 205;
            // 
            // dataConsultaDataGridViewTextBoxColumn
            // 
            dataConsultaDataGridViewTextBoxColumn.DataPropertyName = "DataConsulta";
            dataConsultaDataGridViewTextBoxColumn.HeaderText = "Data Consulta";
            dataConsultaDataGridViewTextBoxColumn.Name = "dataConsultaDataGridViewTextBoxColumn";
            dataConsultaDataGridViewTextBoxColumn.Width = 125;
            // 
            // consultaBindingSource
            // 
            consultaBindingSource.DataSource = typeof(Models.Consulta);
            // 
            // BtnFechar
            // 
            BtnFechar.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnFechar.Image = Properties.Resources.img_Sair_32x32;
            BtnFechar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnFechar.Location = new Point(780, 684);
            BtnFechar.Margin = new Padding(3, 5, 3, 5);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Padding = new Padding(22, 0, 22, 0);
            BtnFechar.Size = new Size(137, 49);
            BtnFechar.TabIndex = 55;
            BtnFechar.Text = "Sair";
            BtnFechar.TextAlign = ContentAlignment.MiddleRight;
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // BtnBancoConfig
            // 
            BtnBancoConfig.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnBancoConfig.Image = Properties.Resources.img_ConfigDb_32x32;
            BtnBancoConfig.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBancoConfig.Location = new Point(19, 684);
            BtnBancoConfig.Margin = new Padding(3, 5, 3, 5);
            BtnBancoConfig.Name = "BtnBancoConfig";
            BtnBancoConfig.Padding = new Padding(5, 0, 5, 0);
            BtnBancoConfig.Size = new Size(137, 49);
            BtnBancoConfig.TabIndex = 56;
            BtnBancoConfig.Text = "Banco Util.";
            BtnBancoConfig.TextAlign = ContentAlignment.MiddleRight;
            BtnBancoConfig.UseVisualStyleBackColor = true;
            BtnBancoConfig.Click += BtnBancoConfig_Click;
            // 
            // BtnPacientes
            // 
            BtnPacientes.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPacientes.Image = Properties.Resources.img_Paciente_32x32;
            BtnPacientes.ImageAlign = ContentAlignment.MiddleLeft;
            BtnPacientes.Location = new Point(252, 684);
            BtnPacientes.Margin = new Padding(3, 5, 3, 5);
            BtnPacientes.Name = "BtnPacientes";
            BtnPacientes.Padding = new Padding(8, 0, 8, 0);
            BtnPacientes.Size = new Size(137, 49);
            BtnPacientes.TabIndex = 57;
            BtnPacientes.Text = "Pacientes";
            BtnPacientes.TextAlign = ContentAlignment.MiddleRight;
            BtnPacientes.UseVisualStyleBackColor = true;
            BtnPacientes.Click += BtnPacientes_Click;
            // 
            // BtnExames
            // 
            BtnExames.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnExames.Image = Properties.Resources.img_Exame_32x32;
            BtnExames.ImageAlign = ContentAlignment.MiddleLeft;
            BtnExames.Location = new Point(508, 684);
            BtnExames.Margin = new Padding(3, 5, 3, 5);
            BtnExames.Name = "BtnExames";
            BtnExames.Padding = new Padding(10, 0, 10, 0);
            BtnExames.Size = new Size(137, 49);
            BtnExames.TabIndex = 58;
            BtnExames.Text = "Exames";
            BtnExames.TextAlign = ContentAlignment.MiddleRight;
            BtnExames.UseVisualStyleBackColor = true;
            BtnExames.Click += BtnExames_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 780);
            Controls.Add(BtnExames);
            Controls.Add(BtnPacientes);
            Controls.Add(BtnBancoConfig);
            Controls.Add(BtnFechar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(statusStrip1);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUD DB";
            Activated += frmPrincipal_Activated;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewConsultas).EndInit();
            ((System.ComponentModel.ISupportInitialize)consultaBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private GroupBox groupBox3;
        private Button BtnPesquisar;
        private Button BtnCancelar;
        private Button BtnExcluir;
        private Button BtnAtualizar;
        private Button BtnCadastrar;
        private GroupBox groupBox2;
        private Label LbDiagnostico;
        private Label LbExameId;
        private Label LbDataConsulta;
        private Label LbMedico;
        private Label LbPaciente;
        private TextBox TxtId;
        private TextBox TxtMedico;
        private TextBox TxtDiagnostico;
        private TextBox TxtDataConsulta;
        private TextBox TxtPaciente;
        private Label LbId;
        private TextBox TxtExameId;
        private GroupBox groupBox1;
        private DataGridView DataGridViewConsultas;
        private BindingSource consultaBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pacienteIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn medicoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn exameIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diagnosticoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataConsultaDataGridViewTextBoxColumn;
        private TextBox TxtPacienteId;
        private Label LbPacienteId;
        private Label LbExameNome;
        private TextBox TxtExameNome;
        private Button BtnFechar;
        private Button BtnBancoConfig;
        private Button BtnPacientes;
        private Button BtnExames;
    }
}
