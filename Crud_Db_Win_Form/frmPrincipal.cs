using Crud_Db_Win_Form.Models;
using Crud_Db_Win_Form.Models.DB;
using Crud_Db_Win_Form.Views;
using System.Data;

namespace Crud_Db_Win_Form
{
    public partial class frmPrincipal : Form
    {
        public bool isBancoOn, existBancoDir, existBancoArq;
        private bool modoEdicao = false;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        // =========================================================================
        public void atualizarInfo()
        {
            isBancoOn = DbUtils.IsBancoConectado() ? true : false;
            existBancoDir = DbUtils.ExistsBancoDir() ? true : false;
            existBancoArq = DbUtils.ExistsBancoArq() ? true : false;

            if (isBancoOn)
            {
                toolStripStatusLabel1.Text = " BD Conectado.";
                toolStripStatusLabel1.Image = Properties.Resources.img_Banco_On_256x256;
            }
            else
            {
                string info = " BD Desconectado.";

                if (!existBancoArq)
                    info = " Não encontrado o arquivo do BD!";

                if (!existBancoDir)
                    info = " Não encontrado o caminho do BD!";

                toolStripStatusLabel1.Text = info;
                toolStripStatusLabel1.Image = Properties.Resources.img_Banco_Off_256x256;
            }
        }

        // =========================================================================
        private void frmPrincipal_Activated(object sender, EventArgs e)
        {

            // ================================= PROVISÓRIO (CORRIGIR E APAGAR DAQUI)
            // ------ BTN GERAR BANCO
            if (!DbUtils.IsBancoConectado())
                DbUtils.GerarBanco();

            // ------ BTN GERAR TABELAS
            Consulta.GerarTabela();
            Exame.GerarTabela();
            Paciente.GerarTabela();

            // ------ BTN GERAR DADOS
            Consulta.GerarDadosIniciais();
            Exame.GerarDadosIniciais();
            Paciente.GerarDadosIniciais();

            // ================================= PROVISÓRIO (CORRIGIR E APAGAR DAQUI)


            atualizarInfo();

            ExibirDados();
            LimpaDados();
            InicializaControles();

        }

        // =========================================================================
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // =========================================================================
        private void ExibirDados()
        {
            try
            {
                DataTable _table = new DataTable();
                _table = Consulta.Get();
                DataGridViewConsultas.DataSource = _table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        // =========================================================================
        private void DataGridViewConsultas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.DataGridViewConsultas.Rows[e.RowIndex];

                    //TxtId.Text = row.Cells[0].Value.ToString();
                    ////TxtPacienteId.Text = row.Cells[1].Value.ToString();
                    //TxtMedico.Text = row.Cells[2].Value.ToString();
                    ////TxtExameId.Text = row.Cells[3].Value.ToString();
                    //TxtDiagnostico.Text = row.Cells[4].Value.ToString();
                    //TxtDataConsulta.Text = row.Cells[5].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        // =========================================================================
        private bool ValidaEdicao(bool isById = true)
        {
            if (isById)
                if (string.IsNullOrEmpty(TxtId.Text))
                {
                    MessageBox.Show("O ID deve ser informado.", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtId.Focus();
                    return false;
                }

            // ----------------

            if (string.IsNullOrEmpty(TxtMedico.Text))
            {
                MessageBox.Show("O Nome do Médico deve ser informado.", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtMedico.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(TxtPacienteId.Text))
            {
                MessageBox.Show("O Código do Paciente deve ser informado.", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtPacienteId.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(TxtExameId.Text))
            {
                MessageBox.Show("O Código do Exame deve ser informado.", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtExameId.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(TxtDataConsulta.Text))
            {
                MessageBox.Show("A Data da Consulta deve ser informada.", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtDataConsulta.Focus();
                return false;
            }

            return true;
        }

        // =========================================================================
        private void LimpaDados()
        {
            TxtId.Clear();
            TxtMedico.Clear();
            TxtPacienteId.Clear();
            TxtPaciente.Clear();
            TxtExameId.Clear();
            TxtExameNome.Clear();
            TxtDiagnostico.Clear();
            TxtDataConsulta.Clear();
        }

        // =========================================================================
        private void InicializaControles()
        {
            modoEdicao = false;
            TxtId.Focus();

            TxtId.ReadOnly = true;
            TxtMedico.ReadOnly = true;
            TxtPacienteId.ReadOnly = true;
            TxtPaciente.ReadOnly = true;
            TxtExameId.ReadOnly = true;
            TxtExameNome.ReadOnly = true;
            TxtDiagnostico.ReadOnly = true;
            TxtDataConsulta.ReadOnly = true;

            BtnCadastrar.Enabled = true;
            BtnExcluir.Enabled = true;
            BtnAtualizar.Enabled = true;
            BtnCancelar.Enabled = false;
            BtnPesquisar.Enabled = true;

            BtnBancoConfig.Enabled = true;
            BtnPacientes.Enabled = true;
            BtnExames.Enabled = true;
            BtnFechar.Enabled = true;

            BtnCadastrar.Text = "Cadastrar";
            BtnExcluir.Text = "Excluir";
            BtnAtualizar.Text = "Atualizar";

            BtnCadastrar.Image = Properties.Resources.img_Cadastrar_32x32;
            BtnExcluir.Image = Properties.Resources.img_Deletar_32x32;
            BtnAtualizar.Image = Properties.Resources.img_Atualizar_32x32;
        }

        // =========================================================================
        private void HabilitaEdicao(Button botao)
        {
            modoEdicao = true;

            BtnCadastrar.Enabled = false;
            BtnExcluir.Enabled = false;
            BtnAtualizar.Enabled = false;
            BtnCancelar.Enabled = true;

            BtnBancoConfig.Enabled = false;
            BtnPacientes.Enabled = false;
            BtnExames.Enabled = false;
            BtnFechar.Enabled = false;

            botao.Enabled = true;

            botao.Text = "Confirmar";
            botao.Image = Properties.Resources.img_Confirmar_32x32;
        }

        // =========================================================================
        private void BtnBancoConfig_Click(object sender, EventArgs e)
        {
            var frm = new frmBancoUtils();
            frm.ShowDialog(this);
        }

        // =========================================================================
        private void BtnPacientes_Click(object sender, EventArgs e)
        {
            var frm = new frmPaciente();
            frm.ShowDialog(this);
        }

        // =========================================================================
        private void BtnExames_Click(object sender, EventArgs e)
        {
            var frm = new frmExame();
            frm.ShowDialog(this);
        }

        // =========================================================================
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            InicializaControles();
        }

        // =========================================================================
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (!modoEdicao)
            {
                HabilitaEdicao(BtnCadastrar);

                TxtMedico.ReadOnly = false;
                TxtPacienteId.ReadOnly = false;
                TxtExameId.ReadOnly = false;
                TxtDiagnostico.ReadOnly = false;
                TxtDataConsulta.ReadOnly = false;

                BtnPesquisar.Enabled = false;

                LimpaDados();
                TxtMedico.Focus();
                return;
            }

            if (!ValidaEdicao(false))
                return;

            try
            {
                Consulta consulta = new();
                //consulta.Id = Convert.ToInt32(TxtId.Text);
                consulta.PacienteId = Convert.ToInt32(TxtPacienteId.Text);
                consulta.Medico = TxtMedico.Text;
                consulta.ExameId = Convert.ToInt32(TxtExameId.Text);
                consulta.Diagnostico = TxtDiagnostico.Text;
                consulta.DataConsulta = TxtDataConsulta.Text;

                Consulta.Add(consulta);

                ExibirDados();
                LimpaDados();
                InicializaControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }

            InicializaControles();
        }

        // =========================================================================
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (!modoEdicao)
            {
                HabilitaEdicao(BtnExcluir);

                TxtId.ReadOnly = false;
                TxtId.Focus();
                return;
            }

            if (!ValidaEdicao())
                return;

            try
            {
                int codigo = Convert.ToInt32(TxtId.Text);
                Consulta.Delete(codigo);
                ExibirDados();
                LimpaDados();
                InicializaControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        // =========================================================================
        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            if (!modoEdicao)
            {
                HabilitaEdicao(BtnAtualizar);

                TxtMedico.ReadOnly = false;
                TxtPacienteId.ReadOnly = false;
                TxtExameId.ReadOnly = false;
                TxtDiagnostico.ReadOnly = false;
                TxtDataConsulta.ReadOnly = false;

                TxtMedico.Focus();
                return;
            }

            if (!ValidaEdicao(false))
                return;

            try
            {
                Consulta consulta = new();
                consulta.Id = Convert.ToInt32(TxtId.Text);
                consulta.PacienteId = Convert.ToInt32(TxtPacienteId.Text);
                consulta.Medico = TxtMedico.Text;
                consulta.ExameId = Convert.ToInt32(TxtExameId.Text);
                consulta.Diagnostico = TxtDiagnostico.Text;
                consulta.DataConsulta = TxtDataConsulta.Text;

                Consulta.Update(consulta);

                ExibirDados();
                LimpaDados();
                InicializaControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }

            InicializaControles();
        }

        // =========================================================================
        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Função ainda não implementada!", "*** Aviso ***",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
