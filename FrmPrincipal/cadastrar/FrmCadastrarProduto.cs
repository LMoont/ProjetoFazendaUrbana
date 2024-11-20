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
    public partial class FrmCadastrarProduto : Form
    {
        FrmPrincipal FrmPrincipal = new FrmPrincipal();
        public FrmCadastrarProduto()
        {
            InitializeComponent();
            AdicionarControles();
            ListarCategoria();
            LimparLbl();
        }

        private void AdicionarControles()
        {
            numericPreco.DecimalPlaces = 2;
            numericPreco.Minimum = 0;
        }

        private void ListarCategoria()
        {
            string sqlSelect = "SELECT Nome, CategoriaId FROM tbCategoriaProduto ORDER BY Nome ASC";

            using (ConexaoDB conexao = new ConexaoDB())
            {
                using (SqlCommand cmd = new SqlCommand(sqlSelect))
                {
                    try
                    {
                        DataTable categoria = conexao.ExecutarConsulta(cmd);
                        cmbCategoria.DataSource = categoria;
                        cmbCategoria.DisplayMember = "Nome";
                        cmbCategoria.ValueMember = "CategoriaId";
                        cmbCategoria.SelectedIndex = -1;
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
            lblMsgDataColheita.Text = "";
            lblMsgDataValidade.Text = "";
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

            if (cmbCategoria.SelectedItem == null)
            {
                lblMsgCategoria.Text = "Selecione a Categoria do produto.";
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

            if (numericPreco.Value <= 0)
            {
                lblMsgValor.Text = "O Valor deve ser maior que zero.";
                temErro = true;
            }

            if (string.IsNullOrWhiteSpace(maskedDataC.Text) || maskedDataC.Text.Length < 10)
            {
                lblMsgDataColheita.Text = "Adicione uma Data de Colheita.";
                temErro = true;
            }
            else if (!DateTime.TryParse(maskedDataC.Text, out DateTime dataColheita))
            {
                lblMsgDataColheita.Text = "Data de Colheita inválida.";
                temErro = true;
            }

            if (string.IsNullOrWhiteSpace(maskedDataV.Text) || maskedDataV.Text.Length < 10)
            {
                lblMsgDataValidade.Text = "Adicione uma Data de Vencimento.";
                temErro = true;
            }
            else if (!DateTime.TryParse(maskedDataV.Text, out DateTime dataVencimento))
            {
                lblMsgDataValidade.Text = "Data de Vencimento inválida.";
                temErro = true;
            }

            if (temErro)
            {
                return;
            }

            CadastrarProduto();
        }

        private void CadastrarProduto()
        {
            string nome = txtNome.Text.Trim();
            int categoriaId = (int)cmbCategoria.SelectedValue;
            decimal quantidade = Convert.ToDecimal(numericQuantidade.Value);
            decimal preco = Convert.ToDecimal(numericPreco.Value);
            string unidadeMedida = cmbUnidadeMedida.Text;
            string dataColheita = maskedDataC.Text;
            string dataValidade = maskedDataV.Text;

            string sqlInsert = "INSERT INTO tbProdutoColhido (Nome, CategoriaId, Quantidade, UnidadeDeMedida, DataColheita, DataValidade, PrecoVenda) " +
                               "VALUES (@Nome, @CategoriaId, @Quantidade, @UnidadeMedida, @DataColheita, @DataValidade, @PrecoVenda)";

            using (ConexaoDB conexao = new ConexaoDB())
            {
                using (SqlCommand cmd = new SqlCommand(sqlInsert, conexao.AbrirConexao()))
                {
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.Parameters.AddWithValue("@CategoriaId", categoriaId);
                    cmd.Parameters.AddWithValue("@Quantidade", quantidade);
                    cmd.Parameters.AddWithValue("@UnidadeMedida", unidadeMedida);
                    cmd.Parameters.AddWithValue("@DataColheita", dataColheita);
                    cmd.Parameters.AddWithValue("@DataValidade", dataValidade);
                    cmd.Parameters.AddWithValue("@PrecoVenda", preco);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Colheita registrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimparCampos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao registrar colheita: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            cmbCategoria.SelectedIndex = -1;
            numericQuantidade.Value = 0;
            cmbUnidadeMedida.SelectedIndex = -1;
            numericPreco.Value = 0;
            maskedDataC.Text = "";
            maskedDataV.Text = "";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ValidarCampos();
            FrmPrincipal.ExibirUltimoProdutoColhido();
        }
    }
}
