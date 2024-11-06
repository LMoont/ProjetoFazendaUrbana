using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmPrincipal.cadastrar
{
    public partial class FrmCadastrarInsumo : Form
    {
        public FrmCadastrarInsumo()
        {
            InitializeComponent();
            ListarFornecedor();
            LimparLbl();
            AdicionarControles();
        }

        private void AdicionarControles()
        {
            numericValor.DecimalPlaces = 2;
            numericValor.Minimum = 0;
        }

        private void ListarFornecedor()
        {
            string sqlSelect = "SELECT Nome, FornecedorId FROM tbFornecedor ORDER BY Nome ASC";

            using (ConexaoDB conexao = new ConexaoDB())
            {
                using (SqlCommand cmd = new SqlCommand(sqlSelect))
                {
                    try
                    {
                        DataTable fornecedor = conexao.ExecutarConsulta(cmd);
                        cmbFornecedor.DataSource = fornecedor;
                        cmbFornecedor.DisplayMember = "Nome";
                        cmbFornecedor.ValueMember = "FornecedorId";
                        cmbFornecedor.SelectedIndex = -1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimparLbl()
        {
            lblMsgNome.Text = "";
            lblMsgCategoria.Text = "";
            lblMsgUnidadeMedida.Text = "";
            lblMsgQuantidade.Text = "";
            lblMsgValor.Text = "";
        }

        private void ValidarCampos()
        {
            LimparLbl();

            bool temErro = false;

            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                lblMsgNome.Text = "O campo Nome é obrigatório.";
                temErro = true;
            }

            if (cmbFornecedor.SelectedItem == null)
            {
                lblMsgCategoria.Text = "Selecione o Fornecedor associado.";
                temErro = true;
            }

            if (string.IsNullOrWhiteSpace(cmbUnidadeMedida.Text))
            {
                lblMsgUnidadeMedida.Text = "Selecione uma Unidade de Medida.";
                temErro = true;
            }

            if (numericQuantidade.Value <= 0)
            {
                lblMsgQuantidade.Text = "A Quantidade deve ser maior que zero.";
                temErro = true;
            }

            if (numericValor.Value <= 0)
            {
                lblMsgValor.Text = "O Valor deve ser maior que zero.";
                temErro = true;
            }

            if (temErro)
            {
                return;
            }

            CadastrarInsumo();
        }

        private void CadastrarInsumo()
        {
            string nome = txtNome.Text.Trim();
            int fornecedorId = (int)cmbFornecedor.SelectedValue;
            decimal quantidade = Convert.ToDecimal(numericQuantidade.Value);
            decimal valorUnitario = Convert.ToDecimal(numericValor.Value);
            string unidadeMedida = cmbUnidadeMedida.Text;
            string descricao = txtDescricao.Text;

            decimal valorTotal = valorUnitario * quantidade;

            string sqlInsert = "INSERT INTO tbInsumo (Nome, FornecedorId, Quantidade, UnidadeMedida, ValorUnitario, ValorTotal, Descricao) " +
                               "VALUES (@Nome, @FornecedorId, @Quantidade, @UnidadeMedida, @ValorUnitario, @ValorTotal, @Descricao)";

            using (ConexaoDB conexao = new ConexaoDB())
            {
                using (SqlCommand cmd = new SqlCommand(sqlInsert, conexao.AbrirConexao()))
                {
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.Parameters.AddWithValue("@FornecedorId", fornecedorId);
                    cmd.Parameters.AddWithValue("@Quantidade", quantidade);
                    cmd.Parameters.AddWithValue("@UnidadeMedida", unidadeMedida);
                    cmd.Parameters.AddWithValue("@ValorUnitario", valorUnitario);
                    cmd.Parameters.AddWithValue("@ValorTotal", valorTotal);
                    cmd.Parameters.AddWithValue("@Descricao", descricao);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Insumo cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimparCampos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar insumo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            cmbFornecedor.SelectedIndex = -1;
            numericQuantidade.Value = 0;
            cmbUnidadeMedida.SelectedIndex = -1;
            txtDescricao.Text = "";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void lblMsgCategoria_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }

    
}
