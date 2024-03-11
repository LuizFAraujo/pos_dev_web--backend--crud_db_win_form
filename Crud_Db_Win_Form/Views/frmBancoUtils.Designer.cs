namespace Crud_Db_Win_Form.Views
{
    partial class frmBancoUtils
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
            btnFechar = new Button();
            btnTestarConexao = new Button();
            btnGerarBanco = new Button();
            btnGerarTabelas = new Button();
            btnExcluirTabelas = new Button();
            btnGerarDados = new Button();
            SuspendLayout();
            // 
            // btnFechar
            // 
            btnFechar.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFechar.Location = new Point(285, 66);
            btnFechar.Margin = new Padding(3, 4, 3, 4);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(120, 39);
            btnFechar.TabIndex = 6;
            btnFechar.Text = "&Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnTestarConexao
            // 
            btnTestarConexao.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTestarConexao.Location = new Point(12, 66);
            btnTestarConexao.Margin = new Padding(3, 4, 3, 4);
            btnTestarConexao.Name = "btnTestarConexao";
            btnTestarConexao.Size = new Size(120, 39);
            btnTestarConexao.TabIndex = 4;
            btnTestarConexao.Text = "Testar Conexão";
            btnTestarConexao.UseVisualStyleBackColor = true;
            btnTestarConexao.Click += btnTestarConexao_Click;
            // 
            // btnGerarBanco
            // 
            btnGerarBanco.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGerarBanco.Location = new Point(12, 13);
            btnGerarBanco.Margin = new Padding(3, 4, 3, 4);
            btnGerarBanco.Name = "btnGerarBanco";
            btnGerarBanco.Size = new Size(120, 39);
            btnGerarBanco.TabIndex = 1;
            btnGerarBanco.Text = "Gerar Banco";
            btnGerarBanco.UseVisualStyleBackColor = true;
            btnGerarBanco.Click += btnGerarBanco_Click;
            // 
            // btnGerarTabelas
            // 
            btnGerarTabelas.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGerarTabelas.Location = new Point(148, 13);
            btnGerarTabelas.Margin = new Padding(3, 4, 3, 4);
            btnGerarTabelas.Name = "btnGerarTabelas";
            btnGerarTabelas.Size = new Size(120, 39);
            btnGerarTabelas.TabIndex = 2;
            btnGerarTabelas.Text = "Gerar Tabelas";
            btnGerarTabelas.UseVisualStyleBackColor = true;
            btnGerarTabelas.Click += btnGerarTabelas_Click;
            // 
            // btnExcluirTabelas
            // 
            btnExcluirTabelas.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExcluirTabelas.Location = new Point(148, 66);
            btnExcluirTabelas.Margin = new Padding(3, 4, 3, 4);
            btnExcluirTabelas.Name = "btnExcluirTabelas";
            btnExcluirTabelas.Size = new Size(120, 39);
            btnExcluirTabelas.TabIndex = 5;
            btnExcluirTabelas.Text = "Excluir Tabelas";
            btnExcluirTabelas.UseVisualStyleBackColor = true;
            btnExcluirTabelas.Click += btnExcluirTabelas_Click;
            // 
            // btnGerarDados
            // 
            btnGerarDados.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGerarDados.Location = new Point(285, 13);
            btnGerarDados.Margin = new Padding(3, 4, 3, 4);
            btnGerarDados.Name = "btnGerarDados";
            btnGerarDados.Size = new Size(120, 39);
            btnGerarDados.TabIndex = 3;
            btnGerarDados.Text = "Gerar Dados";
            btnGerarDados.UseVisualStyleBackColor = true;
            btnGerarDados.Click += btnGerarDados_Click;
            // 
            // frmBancoUtils
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 119);
            Controls.Add(btnGerarDados);
            Controls.Add(btnGerarTabelas);
            Controls.Add(btnExcluirTabelas);
            Controls.Add(btnGerarBanco);
            Controls.Add(btnTestarConexao);
            Controls.Add(btnFechar);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmBancoUtils";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Banco de Dados - Utilitários";
            ResumeLayout(false);
        }

        #endregion

        private Button btnFechar;
        private Button btnTestarConexao;
        private Button btnGerarBanco;
        private Button btnGerarTabelas;
        private Button btnExcluirTabelas;
        private Button btnGerarDados;
    }
}