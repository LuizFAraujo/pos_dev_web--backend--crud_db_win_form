using Crud_Db_Win_Form.Models;
using Crud_Db_Win_Form.Models.DB;

namespace Crud_Db_Win_Form.Views
{
    public partial class frmBancoUtils : Form
    {
        public bool isBancoOn, existBancoDir, existBancoArq;

        public frmBancoUtils()
        {
            InitializeComponent();
        }

        // =========================================================================
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // =========================================================================
        private void btnTestarConexao_Click(object sender, EventArgs e)
        {
            string msg = DbUtils.IsBancoConectado() ? "Banco Conectado" : "Banco NÃO Conectado";
            MessageBox.Show(msg, "Conexão", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // =========================================================================
        private void btnGerarBanco_Click(object sender, EventArgs e)
        {
            if (!DbUtils.IsBancoConectado())
                DbUtils.GerarBanco();
            //else
            //    MessageBox.Show("O Banco de Dados já existente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // =========================================================================
        private void btnGerarTabelas_Click(object sender, EventArgs e)
        {
            Consulta.GerarTabela();
            Exame.GerarTabela();
            Paciente.GerarTabela();
        }

        // =========================================================================
        private void btnExcluirTabelas_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Todos os dados serão perdidos!\n" +
                                          "Deseja mesmo excluir todas as tabelas?",
                                          "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Consulta.ExcluirTabela();
                Exame.ExcluirTabela();
                Paciente.ExcluirTabela();
            }
        }

        // =========================================================================
        private void btnGerarDados_Click(object sender, EventArgs e)
        {
            Consulta.GerarDadosIniciais();
            Exame.GerarDadosIniciais();
            Paciente.GerarDadosIniciais();
        }

    }
}
