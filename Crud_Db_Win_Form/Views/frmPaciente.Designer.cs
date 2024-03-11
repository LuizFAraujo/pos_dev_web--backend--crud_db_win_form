namespace Crud_Db_Win_Form.Views
{
    partial class frmPaciente
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaciente));
            BtnCadastrar = new Button();
            BtnSair = new Button();
            BtnAtualizar = new Button();
            groupBox1 = new GroupBox();
            DataGridViewPacientes = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rGDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cPFDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataNasctoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            TxtRg = new TextBox();
            LbId = new Label();
            TxtNome = new TextBox();
            TxtDataNascto = new TextBox();
            TxtCpf = new TextBox();
            TxtEmail = new TextBox();
            TxtId = new TextBox();
            LbNome = new Label();
            LbEmail = new Label();
            LbDataNascto = new Label();
            LbRg = new Label();
            LbCpf = new Label();
            pacienteBindingSource = new BindingSource(components);
            groupBox2 = new GroupBox();
            BtnExcluir = new Button();
            BtnCancelar = new Button();
            groupBox3 = new GroupBox();
            BtnPesquisar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewPacientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pacienteBindingSource).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
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
            // BtnSair
            // 
            BtnSair.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSair.Image = Properties.Resources.img_Sair_32x32;
            BtnSair.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSair.Location = new Point(751, 589);
            BtnSair.Margin = new Padding(3, 5, 3, 5);
            BtnSair.Name = "BtnSair";
            BtnSair.Padding = new Padding(22, 0, 22, 0);
            BtnSair.Size = new Size(137, 49);
            BtnSair.TabIndex = 20;
            BtnSair.Text = "Sair";
            BtnSair.TextAlign = ContentAlignment.MiddleRight;
            BtnSair.UseVisualStyleBackColor = true;
            BtnSair.Click += btnSair_Click;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(DataGridViewPacientes);
            groupBox1.Location = new Point(22, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(898, 347);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista Geral";
            // 
            // DataGridViewPacientes
            // 
            DataGridViewPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewPacientes.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, rGDataGridViewTextBoxColumn, cPFDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, dataNasctoDataGridViewTextBoxColumn });
            DataGridViewPacientes.Location = new Point(16, 26);
            DataGridViewPacientes.Name = "DataGridViewPacientes";
            DataGridViewPacientes.RowTemplate.Height = 25;
            DataGridViewPacientes.Size = new Size(865, 305);
            DataGridViewPacientes.TabIndex = 100;
            DataGridViewPacientes.RowEnter += dataGridViewPacientes_RowEnter;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 35;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.Width = 180;
            // 
            // rGDataGridViewTextBoxColumn
            // 
            rGDataGridViewTextBoxColumn.DataPropertyName = "RG";
            rGDataGridViewTextBoxColumn.HeaderText = "RG";
            rGDataGridViewTextBoxColumn.Name = "rGDataGridViewTextBoxColumn";
            rGDataGridViewTextBoxColumn.Width = 120;
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            cPFDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.Width = 200;
            // 
            // dataNasctoDataGridViewTextBoxColumn
            // 
            dataNasctoDataGridViewTextBoxColumn.DataPropertyName = "DataNascto";
            dataNasctoDataGridViewTextBoxColumn.HeaderText = "Data Nascto";
            dataNasctoDataGridViewTextBoxColumn.Name = "dataNasctoDataGridViewTextBoxColumn";
            dataNasctoDataGridViewTextBoxColumn.Width = 120;
            // 
            // TxtRg
            // 
            TxtRg.Location = new Point(504, 38);
            TxtRg.Name = "TxtRg";
            TxtRg.Size = new Size(138, 27);
            TxtRg.TabIndex = 5;
            TxtRg.Text = "27.005.223-9";
            // 
            // LbId
            // 
            LbId.AutoSize = true;
            LbId.Location = new Point(46, 38);
            LbId.Name = "LbId";
            LbId.Size = new Size(25, 19);
            LbId.TabIndex = 60;
            LbId.Text = "id.";
            LbId.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(77, 77);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(267, 27);
            TxtNome.TabIndex = 3;
            TxtNome.Text = "Leticia Leticia Leticia";
            // 
            // TxtDataNascto
            // 
            TxtDataNascto.Location = new Point(504, 122);
            TxtDataNascto.Name = "TxtDataNascto";
            TxtDataNascto.Size = new Size(138, 27);
            TxtDataNascto.TabIndex = 7;
            TxtDataNascto.Text = "02/08/1989";
            // 
            // TxtCpf
            // 
            TxtCpf.Location = new Point(504, 80);
            TxtCpf.Name = "TxtCpf";
            TxtCpf.Size = new Size(138, 27);
            TxtCpf.TabIndex = 6;
            TxtCpf.Text = "969.151.920-85";
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(77, 119);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(267, 27);
            TxtEmail.TabIndex = 4;
            TxtEmail.Text = "leticia@leticia.com";
            // 
            // TxtId
            // 
            TxtId.Location = new Point(77, 35);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(64, 27);
            TxtId.TabIndex = 2;
            TxtId.Text = "000";
            // 
            // LbNome
            // 
            LbNome.AutoSize = true;
            LbNome.Location = new Point(16, 80);
            LbNome.Name = "LbNome";
            LbNome.Size = new Size(55, 19);
            LbNome.TabIndex = 61;
            LbNome.Text = "*Nome";
            LbNome.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbEmail
            // 
            LbEmail.AutoSize = true;
            LbEmail.Location = new Point(21, 122);
            LbEmail.Name = "LbEmail";
            LbEmail.Size = new Size(50, 19);
            LbEmail.TabIndex = 62;
            LbEmail.Text = "E-mail";
            LbEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbDataNascto
            // 
            LbDataNascto.AutoSize = true;
            LbDataNascto.Location = new Point(409, 125);
            LbDataNascto.Name = "LbDataNascto";
            LbDataNascto.Size = new Size(89, 19);
            LbDataNascto.TabIndex = 65;
            LbDataNascto.Text = "Data Nascto";
            LbDataNascto.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbRg
            // 
            LbRg.AutoSize = true;
            LbRg.Location = new Point(470, 41);
            LbRg.Name = "LbRg";
            LbRg.Size = new Size(28, 19);
            LbRg.TabIndex = 63;
            LbRg.Text = "RG";
            LbRg.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbCpf
            // 
            LbCpf.AutoSize = true;
            LbCpf.Location = new Point(457, 83);
            LbCpf.Name = "LbCpf";
            LbCpf.Size = new Size(41, 19);
            LbCpf.TabIndex = 64;
            LbCpf.Text = "*CPF";
            LbCpf.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(LbCpf);
            groupBox2.Controls.Add(LbRg);
            groupBox2.Controls.Add(LbDataNascto);
            groupBox2.Controls.Add(LbEmail);
            groupBox2.Controls.Add(LbNome);
            groupBox2.Controls.Add(TxtId);
            groupBox2.Controls.Add(TxtEmail);
            groupBox2.Controls.Add(TxtCpf);
            groupBox2.Controls.Add(TxtDataNascto);
            groupBox2.Controls.Add(TxtNome);
            groupBox2.Controls.Add(LbId);
            groupBox2.Controls.Add(TxtRg);
            groupBox2.Location = new Point(22, 489);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(675, 176);
            groupBox2.TabIndex = 40;
            groupBox2.TabStop = false;
            groupBox2.Text = "Item";
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
            // groupBox3
            // 
            groupBox3.Controls.Add(BtnPesquisar);
            groupBox3.Controls.Add(BtnCancelar);
            groupBox3.Controls.Add(BtnExcluir);
            groupBox3.Controls.Add(BtnAtualizar);
            groupBox3.Controls.Add(BtnCadastrar);
            groupBox3.Location = new Point(22, 374);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(898, 100);
            groupBox3.TabIndex = 50;
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
            // frmPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 686);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(BtnSair);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmPaciente";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PACIENTES";
            Load += frmPaciente_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewPacientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pacienteBindingSource).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button BtnCadastrar;
        private Button BtnSair;
        private Button BtnAtualizar;
        private GroupBox groupBox1;
        private DataGridView DataGridViewPacientes;
        private TextBox TxtRg;
        private Label LbId;
        private TextBox TxtNome;
        private TextBox TxtDataNascto;
        private TextBox TxtCpf;
        private TextBox TxtEmail;
        private TextBox TxtId;
        private Label LbNome;
        private Label LbEmail;
        private Label LbDataNascto;
        private Label LbRg;
        private Label LbCpf;
        private BindingSource pacienteBindingSource;
        private GroupBox groupBox2;
        private Button BtnExcluir;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rGDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataNasctoDataGridViewTextBoxColumn;
        private Button BtnCancelar;
        private GroupBox groupBox3;
        private Button BtnPesquisar;
    }
}