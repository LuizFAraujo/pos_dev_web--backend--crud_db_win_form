using Crud_Db_Win_Form.Models;
using Crud_Db_Win_Form.Models.DB;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Crud_Db_Win_Form.Views
{
    public partial class frmPaciente : Form
    {
        private bool modoEdicao = false;
        public frmPaciente()
        {
            InitializeComponent();
        }
        // =========================================================================
        private void frmPaciente_Load(object sender, EventArgs e)
        {
            ExibirDados();
            LimpaDados();
            InicializaControles();
        }

        // =========================================================================
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // =========================================================================
        private void ExibirDados()
        {
            try
            {
                DataTable _table = new DataTable();
                _table = Paciente.Get();
                DataGridViewPacientes.DataSource = _table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        // =========================================================================
        private void dataGridViewPacientes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.DataGridViewPacientes.Rows[e.RowIndex];

                    TxtId.Text = row.Cells[0].Value.ToString();
                    TxtNome.Text = row.Cells[1].Value.ToString();
                    TxtRg.Text = row.Cells[2].Value.ToString();
                    TxtCpf.Text = row.Cells[3].Value.ToString();
                    TxtEmail.Text = row.Cells[4].Value.ToString();
                    TxtDataNascto.Text = row.Cells[5].Value.ToString();
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

            if (string.IsNullOrEmpty(TxtNome.Text))
            {
                MessageBox.Show("O Nome deve ser informado.", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNome.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(TxtCpf.Text))
            {
                MessageBox.Show("O CPF deve ser informado.", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtCpf.Focus();
                return false;
            }

            return true;
        }

        // =========================================================================
        private void LimpaDados()
        {
            TxtId.Clear();
            TxtNome.Clear();
            TxtRg.Clear();
            TxtCpf.Clear();
            TxtEmail.Clear();
            TxtDataNascto.Clear();
        }

        // =========================================================================
        private void InicializaControles()
        {
            modoEdicao = false;
            TxtId.Focus();

            TxtId.ReadOnly = true;
            TxtNome.ReadOnly = true;
            TxtRg.ReadOnly = true;
            TxtCpf.ReadOnly = true;
            TxtEmail.ReadOnly = true;
            TxtDataNascto.ReadOnly = true;

            BtnCadastrar.Enabled = true;
            BtnExcluir.Enabled = true;
            BtnAtualizar.Enabled = true;
            BtnCancelar.Enabled = false;
            BtnPesquisar.Enabled = true;
            BtnSair.Enabled = true;

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
            BtnSair.Enabled = false;

            botao.Enabled = true;

            botao.Text = "Confirmar";
            botao.Image = Properties.Resources.img_Confirmar_32x32;
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

                TxtNome.ReadOnly = false;
                TxtEmail.ReadOnly = false;
                TxtRg.ReadOnly = false;
                TxtCpf.ReadOnly = false;
                TxtDataNascto.ReadOnly = false;

                BtnPesquisar.Enabled = false;

                LimpaDados();
                TxtNome.Focus();
                return;
            }

            if (!ValidaEdicao(false))
                return;

            try
            {
                Paciente paciente = new();
                //paciente.Id = Convert.ToInt32(TxtId.Text);
                paciente.Nome = TxtNome.Text;
                paciente.Email = TxtEmail.Text;
                paciente.RG = TxtRg.Text;
                paciente.CPF = TxtCpf.Text;
                paciente.DataNascto = TxtDataNascto.Text;

                Paciente.Add(paciente);

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
                Paciente.Delete(codigo);
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

                TxtNome.ReadOnly = false;
                TxtEmail.ReadOnly = false;
                TxtRg.ReadOnly = false;
                TxtCpf.ReadOnly = false;
                TxtDataNascto.ReadOnly = false;

                TxtNome.Focus();
                return;
            }

            if (!ValidaEdicao(false))
                return;

            try
            {
                Paciente paciente = new();
                paciente.Id = Convert.ToInt32(TxtId.Text);
                paciente.Nome = TxtNome.Text;
                paciente.Email = TxtEmail.Text;
                paciente.RG = TxtRg.Text;
                paciente.CPF = TxtCpf.Text;
                paciente.DataNascto = TxtDataNascto.Text;

                Paciente.Update(paciente);

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

            //////if (!modoEdicao)
            //////{
            //////    HabilitaEdicao(BtnPesquisar);

            //////    TxtId.ReadOnly = false;
            //////    TxtId.Focus();
            //////    return;
            //////}

            ////TxtId.ReadOnly = false;

            //////if (!ValidaEdicao())
            //////    return;

            ////try
            ////{
            ////    DataTable data = new();
            ////    int codigo = Convert.ToInt32(TxtId.Text);
            ////    //Paciente.Delete(codigo);
            ////    data = Paciente.Get(codigo);
            ////    DataGridViewPacientes.DataSource = data; 

            ////    //ExibirDados();
            ////    //LimpaDados();
            ////    //InicializaControles();
            ////}
            ////catch (Exception ex)
            ////{
            ////    MessageBox.Show("Erro : " + ex.Message);
            ////}
        }


    }
}
