using Crud_Db_Win_Form.Models;
using Crud_Db_Win_Form.Models.DB;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Crud_Db_Win_Form.Views
{
    public partial class frmExame : Form
    {
        private bool modoEdicao = false;
        public frmExame()
        {
            InitializeComponent();
        }
        // =========================================================================
        private void frmExame_Load(object sender, EventArgs e)
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
                _table = Exame.Get();
                DataGridViewExames.DataSource = _table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        // =========================================================================
        private void dataGridViewExames_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.DataGridViewExames.Rows[e.RowIndex];

                    TxtId.Text = row.Cells[0].Value.ToString();
                    TxtNome.Text = row.Cells[1].Value.ToString();
                    TxtLocal.Text = row.Cells[2].Value.ToString();
                    TxtDataExame.Text = row.Cells[3].Value.ToString();
                    TxtResultado.Text = row.Cells[4].Value.ToString();
                    TxtDataEntrega.Text = row.Cells[5].Value.ToString();
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

            if (string.IsNullOrEmpty(TxtLocal.Text))
            {
                MessageBox.Show("O Local deve ser informado.", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtLocal.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(TxtDataExame.Text))
            {
                MessageBox.Show("A Data do Exame deve ser informada.", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtDataExame.Focus();
                return false;
            }

            return true;
        }

        // =========================================================================
        private void LimpaDados()
        {
            TxtId.Clear();
            TxtNome.Clear();
            TxtLocal.Clear();
            TxtDataExame.Clear();
            TxtResultado.Clear();
            TxtDataEntrega.Clear();
        }

        // =========================================================================
        private void InicializaControles()
        {
            modoEdicao = false;
            TxtId.Focus();

            TxtId.ReadOnly = true;
            TxtNome.ReadOnly = true;
            TxtLocal.ReadOnly = true;
            TxtDataExame.ReadOnly = true;
            TxtResultado.ReadOnly = true;
            TxtDataEntrega.ReadOnly = true;

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
                TxtResultado.ReadOnly = false;
                TxtLocal.ReadOnly = false;
                TxtDataExame.ReadOnly = false;
                TxtDataEntrega.ReadOnly = false;

                BtnPesquisar.Enabled = false;

                LimpaDados();
                TxtNome.Focus();
                return;
            }

            if (!ValidaEdicao(false))
                return;

            try
            {
                Exame exame = new();
                //exame.Id = Convert.ToInt32(TxtId.Text);
                exame.Nome = TxtNome.Text;
                exame.Resultado = TxtResultado.Text;
                exame.Local = TxtLocal.Text;
                exame.DataExame = TxtDataExame.Text;
                exame.DataEntrega = TxtDataEntrega.Text;

                Exame.Add(exame);

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
                Exame.Delete(codigo);
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
                TxtResultado.ReadOnly = false;
                TxtLocal.ReadOnly = false;
                TxtDataExame.ReadOnly = false;
                TxtDataEntrega.ReadOnly = false;

                TxtNome.Focus();
                return;
            }

            if (!ValidaEdicao(false))
                return;

            try
            {
                Exame exame = new();
                exame.Id = Convert.ToInt32(TxtId.Text);
                exame.Nome = TxtNome.Text;
                exame.Resultado = TxtResultado.Text;
                exame.Local = TxtLocal.Text;
                exame.DataExame = TxtDataExame.Text;
                exame.DataEntrega = TxtDataEntrega.Text;

                Exame.Update(exame);

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
