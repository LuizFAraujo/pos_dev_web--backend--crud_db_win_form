namespace Crud_Db_Win_Form.Views
{
    partial class frmExame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExame));
            BtnCadastrar = new Button();
            BtnSair = new Button();
            BtnAtualizar = new Button();
            groupBox1 = new GroupBox();
            DataGridViewExames = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Resultado = new DataGridViewTextBoxColumn();
            Local = new DataGridViewTextBoxColumn();
            DataExame = new DataGridViewTextBoxColumn();
            DataEntrega = new DataGridViewTextBoxColumn();
            exameBindingSource = new BindingSource(components);
            TxtLocal = new TextBox();
            LbId = new Label();
            TxtNome = new TextBox();
            TxtDataEntrega = new TextBox();
            TxtDataExame = new TextBox();
            TxtResultado = new TextBox();
            TxtId = new TextBox();
            LbNome = new Label();
            LbResultado = new Label();
            LbDataEntrega = new Label();
            LbLocal = new Label();
            LbDataExame = new Label();
            groupBox2 = new GroupBox();
            BtnExcluir = new Button();
            BtnCancelar = new Button();
            groupBox3 = new GroupBox();
            BtnPesquisar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewExames).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exameBindingSource).BeginInit();
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
            groupBox1.Controls.Add(DataGridViewExames);
            groupBox1.Location = new Point(22, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(898, 347);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista Geral";
            // 
            // DataGridViewExames
            // 
            DataGridViewExames.AutoGenerateColumns = false;
            DataGridViewExames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewExames.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, Resultado, Local, DataExame, DataEntrega });
            DataGridViewExames.DataSource = exameBindingSource;
            DataGridViewExames.Location = new Point(16, 26);
            DataGridViewExames.Name = "DataGridViewExames";
            DataGridViewExames.RowTemplate.Height = 25;
            DataGridViewExames.Size = new Size(865, 305);
            DataGridViewExames.TabIndex = 100;
            DataGridViewExames.RowEnter += dataGridViewExames_RowEnter;
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
            // Resultado
            // 
            Resultado.DataPropertyName = "Resultado";
            Resultado.HeaderText = "Resultado";
            Resultado.Name = "Resultado";
            Resultado.Width = 175;
            // 
            // Local
            // 
            Local.DataPropertyName = "Local";
            Local.HeaderText = "Local";
            Local.Name = "Local";
            Local.Width = 175;
            // 
            // DataExame
            // 
            DataExame.DataPropertyName = "DataExame";
            DataExame.HeaderText = "Data Exame";
            DataExame.Name = "DataExame";
            DataExame.Width = 120;
            // 
            // DataEntrega
            // 
            DataEntrega.DataPropertyName = "DataEntrega";
            DataEntrega.HeaderText = "Data Entrega";
            DataEntrega.Name = "DataEntrega";
            DataEntrega.Width = 120;
            // 
            // exameBindingSource
            // 
            exameBindingSource.DataSource = typeof(Models.Exame);
            // 
            // TxtLocal
            // 
            TxtLocal.Location = new Point(504, 38);
            TxtLocal.Name = "TxtLocal";
            TxtLocal.Size = new Size(138, 27);
            TxtLocal.TabIndex = 5;
            TxtLocal.Text = "Lab. 120";
            // 
            // LbId
            // 
            LbId.AutoSize = true;
            LbId.Location = new Point(64, 38);
            LbId.Name = "LbId";
            LbId.Size = new Size(25, 19);
            LbId.TabIndex = 60;
            LbId.Text = "id.";
            LbId.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(95, 77);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(267, 27);
            TxtNome.TabIndex = 3;
            TxtNome.Text = "Leticia Leticia Leticia";
            // 
            // TxtDataEntrega
            // 
            TxtDataEntrega.Location = new Point(504, 122);
            TxtDataEntrega.Name = "TxtDataEntrega";
            TxtDataEntrega.Size = new Size(138, 27);
            TxtDataEntrega.TabIndex = 7;
            TxtDataEntrega.Text = "02/08/2025";
            // 
            // TxtDataExame
            // 
            TxtDataExame.Location = new Point(504, 80);
            TxtDataExame.Name = "TxtDataExame";
            TxtDataExame.Size = new Size(138, 27);
            TxtDataExame.TabIndex = 6;
            TxtDataExame.Text = "15/10/2024";
            // 
            // TxtResultado
            // 
            TxtResultado.Location = new Point(95, 119);
            TxtResultado.Name = "TxtResultado";
            TxtResultado.Size = new Size(267, 27);
            TxtResultado.TabIndex = 4;
            TxtResultado.Text = "Nada bom.";
            // 
            // TxtId
            // 
            TxtId.Location = new Point(95, 35);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(64, 27);
            TxtId.TabIndex = 2;
            TxtId.Text = "000";
            // 
            // LbNome
            // 
            LbNome.AutoSize = true;
            LbNome.Location = new Point(34, 80);
            LbNome.Name = "LbNome";
            LbNome.Size = new Size(55, 19);
            LbNome.TabIndex = 61;
            LbNome.Text = "*Nome";
            LbNome.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbResultado
            // 
            LbResultado.AutoSize = true;
            LbResultado.Location = new Point(15, 122);
            LbResultado.Name = "LbResultado";
            LbResultado.Size = new Size(74, 19);
            LbResultado.TabIndex = 62;
            LbResultado.Text = "Resultado";
            LbResultado.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbDataEntrega
            // 
            LbDataEntrega.AutoSize = true;
            LbDataEntrega.Location = new Point(403, 125);
            LbDataEntrega.Name = "LbDataEntrega";
            LbDataEntrega.Size = new Size(94, 19);
            LbDataEntrega.TabIndex = 65;
            LbDataEntrega.Text = "Data Entrega";
            LbDataEntrega.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbLocal
            // 
            LbLocal.AutoSize = true;
            LbLocal.Location = new Point(447, 41);
            LbLocal.Name = "LbLocal";
            LbLocal.Size = new Size(51, 19);
            LbLocal.TabIndex = 63;
            LbLocal.Text = "*Local";
            LbLocal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbDataExame
            // 
            LbDataExame.AutoSize = true;
            LbDataExame.Location = new Point(403, 83);
            LbDataExame.Name = "LbDataExame";
            LbDataExame.Size = new Size(95, 19);
            LbDataExame.TabIndex = 64;
            LbDataExame.Text = "*Data Exame";
            LbDataExame.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(LbDataExame);
            groupBox2.Controls.Add(LbLocal);
            groupBox2.Controls.Add(LbDataEntrega);
            groupBox2.Controls.Add(LbResultado);
            groupBox2.Controls.Add(LbNome);
            groupBox2.Controls.Add(TxtId);
            groupBox2.Controls.Add(TxtResultado);
            groupBox2.Controls.Add(TxtDataExame);
            groupBox2.Controls.Add(TxtDataEntrega);
            groupBox2.Controls.Add(TxtNome);
            groupBox2.Controls.Add(LbId);
            groupBox2.Controls.Add(TxtLocal);
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
            // frmExame
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
            Name = "frmExame";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EXAMES";
            Load += frmExame_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewExames).EndInit();
            ((System.ComponentModel.ISupportInitialize)exameBindingSource).EndInit();
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
        private DataGridView DataGridViewExames;
        private TextBox TxtLocal;
        private Label LbId;
        private TextBox TxtNome;
        private TextBox TxtDataEntrega;
        private TextBox TxtDataExame;
        private TextBox TxtResultado;
        private TextBox TxtId;
        private Label LbNome;
        private Label LbResultado;
        private Label LbDataEntrega;
        private Label LbLocal;
        private Label LbDataExame;
        private GroupBox groupBox2;
        private Button BtnExcluir;
        private Button BtnCancelar;
        private GroupBox groupBox3;
        private Button BtnPesquisar;
        private BindingSource exameBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Resultado;
        private DataGridViewTextBoxColumn Local;
        private DataGridViewTextBoxColumn DataExame;
        private DataGridViewTextBoxColumn DataEntrega;
    }
}