using FrmPrincipal.cadastrar;
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

namespace FrmPrincipal.gerenciar
{
    public partial class FrmGerenciarProduto : Form
    {
        bool clicado = false;
        public int produtoColhidoId { get; private set; }
        ConexaoDB conexaoDB = new ConexaoDB();
        public FrmGerenciarProduto()
        {
            InitializeComponent();
            ListarProduto();
            EsvaziarLbl();
            ListarTbProduto();
        }

        private void ListarProduto()
        {
            string sqlSelect = "SELECT * FROM tbProdutoColhido ORDER BY Nome asc";

            using (ConexaoDB conexao = new ConexaoDB())
            {
                using (SqlCommand cmd = new SqlCommand(sqlSelect))
                {
                    try
                    {
                        DataTable produtos = conexao.ExecutarConsulta(cmd);
                        cmbProduto.DataSource = produtos;
                        cmbProduto.DisplayMember = "Nome";
                        cmbProduto.ValueMember = "ProdutoColhidoId";
                        cmbProduto.SelectedIndex = -1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void EsvaziarLbl()
        {
            lblMsgProduto.Text = "";
            lblMsgQuantidade.Text = "";
            lblMsgPrecoUni.Text = "";
            lblMsgTotalVenda.Text = "";
        }

        private void FormatarDG()
        {
            gridProdutos.Columns[0].HeaderText = "ID";
            gridProdutos.Columns[1].HeaderText = "Nome";
            gridProdutos.Columns[2].HeaderText = "Categoria";
            gridProdutos.Columns[3].HeaderText = "Quantidade";
            gridProdutos.Columns[4].HeaderText = "Unidade de Medida";
            gridProdutos.Columns[5].HeaderText = "Preço";
            gridProdutos.Columns[6].HeaderText = "Data Colheita";
            gridProdutos.Columns[7].HeaderText = "Validade";

            gridProdutos.Columns[5].DefaultCellStyle.Format = "C2";
            gridProdutos.Columns[0].Visible = false;

            foreach (DataGridViewColumn coluna in gridProdutos.Columns)
            {
                coluna.HeaderCell.Style.Font = new Font("Calibri", 10, FontStyle.Bold);
                coluna.HeaderCell.Style.BackColor = Color.LightBlue;
            }

            gridProdutos.DefaultCellStyle.Font = new Font("Calibri", 10, FontStyle.Regular); // Estilo das células
            gridProdutos.DefaultCellStyle.BackColor = Color.White;

            gridProdutos.EnableHeadersVisualStyles = false;
        }

        private decimal ObterQuantidadeAtual(int produtoColhidoId)
        {
            string sqlSelect = "SELECT Quantidade FROM tbProdutoColhido WHERE ProdutoColhidoId = @ProdutoColhidoId";
            decimal quantidade = 0;

            using (ConexaoDB conexao = new ConexaoDB())
            {
                using (SqlCommand cmd = new SqlCommand(sqlSelect, conexao.AbrirConexao()))
                {
                    cmd.Parameters.AddWithValue("@ProdutoColhidoId", produtoColhidoId);

                    try
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            quantidade = Convert.ToDecimal(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao obter quantidade atual: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return quantidade;
        }

        private void ListarTbProduto()
        {
            string sqlSelect = "SELECT p.ProdutoColhidoId, p.Nome, c.Nome AS CategoriaNome, p.Quantidade, p.UnidadeDeMedida, p.PrecoVenda," +
                                "p.DataColheita, p.DataValidade " +
                                "FROM tbProdutoColhido p " +
                                "JOIN tbCategoriaProduto c ON p.CategoriaId = c.CategoriaId " +
                                "ORDER BY p.Nome;";

            using (ConexaoDB conexao = new ConexaoDB())
            {
                using (SqlCommand cmd = new SqlCommand(sqlSelect)) // Passa a conexão aqui
                {
                    try
                    {
                        DataTable produtos = conexao.ExecutarConsulta(cmd);
                        gridProdutos.DataSource = produtos;
                        FormatarDG();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro: {ex.Message}\n\nStack Trace: {ex.StackTrace}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }


        private void ValidarCampos()
        {
            EsvaziarLbl();
            bool temErro = false;

            if (cmbProduto.SelectedItem == null)
            {
                lblMsgProduto.Text = "Selecione um Produto.";
                temErro = true;
            }

            if (numericQuantidade.Value <= 0)
            {
                lblMsgQuantidade.Text = "A Quantidade deve ser maior que zero.";
                temErro = true;
            }

            if (temErro)
            {
                MessageBox.Show("Por favor, corrija os campos destacados antes de prosseguir.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AtualizarEstoque();
            RegistrarVenda();
        }

        private void AtualizarEstoque()
        {
            int produtoColhidoId = (int)cmbProduto.SelectedValue;
            decimal quantidadeAtual = ObterQuantidadeAtual(produtoColhidoId);
            decimal quantidade = Convert.ToDecimal(numericQuantidade.Value);


            quantidade = quantidadeAtual - quantidade;
            if (quantidade < 0) quantidade = 0;

            string sqlUpdateEstoque = "UPDATE tbProdutoColhido SET Quantidade = @Quantidade WHERE ProdutoColhidoId = @ProdutoColhidoId";

            using (ConexaoDB conexao = new ConexaoDB())
            {
                using (SqlCommand cmdEstoque = new SqlCommand(sqlUpdateEstoque, conexao.AbrirConexao()))
                {
                    cmdEstoque.Parameters.AddWithValue("@Quantidade", quantidade);
                    cmdEstoque.Parameters.AddWithValue("@ProdutoColhidoId", produtoColhidoId);

                    try
                    {
                        cmdEstoque.ExecuteNonQuery();
                        MessageBox.Show("Estoque atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarTbProduto();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao atualizar o estoque: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void RegistrarVenda()
        {
            int produtoColhidoId = (int)cmbProduto.SelectedValue;
            decimal quantidade = Convert.ToDecimal(numericQuantidade.Value);
            decimal precoVenda = ObterPrecoVenda(produtoColhidoId);
            DateTime dataVenda = DateTime.Now;

            string sqlInsert = "INSERT INTO tbVenda (ProdutoColhidoId, Quantidade, PrecoVenda, DataVenda) " +
                               "VALUES (@ProdutoColhidoId, @Quantidade, @PrecoVenda, @DataVenda)";

            using (ConexaoDB conexao = new ConexaoDB())
            {
                using (SqlCommand cmdEstoque = new SqlCommand(sqlInsert, conexao.AbrirConexao()))
                {
                    cmdEstoque.Parameters.AddWithValue("@ProdutoColhidoId", produtoColhidoId);
                    cmdEstoque.Parameters.AddWithValue("@Quantidade", quantidade);
                    cmdEstoque.Parameters.AddWithValue("@PrecoVenda", precoVenda);
                    cmdEstoque.Parameters.AddWithValue("@DataVenda", dataVenda);

                    try
                    {
                        cmdEstoque.ExecuteNonQuery();

                        MessageBox.Show("Venda registrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimparCampos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao registrar a venda: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private decimal ObterPrecoVenda(int produtoColhidoId)
        {
            decimal precoVenda = 0;

            string sqlSelect = "SELECT PrecoVenda FROM tbProdutoColhido WHERE ProdutoColhidoId = @ProdutoColhidoId";

            using (ConexaoDB conexao = new ConexaoDB())
            {
                using (SqlCommand cmd = new SqlCommand(sqlSelect, conexao.AbrirConexao()))
                {
                    cmd.Parameters.AddWithValue("@ProdutoColhidoId", produtoColhidoId);

                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        precoVenda = Convert.ToDecimal(result);
                    }
                }
            }

            return precoVenda;
        }

        private void FormatarPreco()
        {
            // Verifica se há um item selecionado no ComboBox
            if (cmbProduto.SelectedValue == null || !int.TryParse(cmbProduto.SelectedValue.ToString(), out int produtoColhidoId))
            {
                return; // Sai do método se não houver um valor selecionado válido
            }

            decimal precoUnitario = ObterPrecoVenda(produtoColhidoId);
            decimal quantidade = Convert.ToDecimal(numericQuantidade.Value);
            decimal precoTotal = precoUnitario * quantidade;

            lblMsgPrecoUni.Text = precoUnitario.ToString("C2");
            lblMsgTotalVenda.Text = precoTotal.ToString("C2");
        }


        private void LimparCampos()
        {
            lblMsgPrecoUni.Text = "";
            lblMsgTotalVenda.Text = "";
            numericQuantidade.Value = 0;
            cmbProduto.SelectedIndex = -1;
        }

        private void Excluir()
        {
            string sqlDelete = "DELETE FROM tbProdutoColhido WHERE ProdutoColhidoId = @ProdutoColhidoId";

            using (ConexaoDB conexao = new ConexaoDB())
            {
                using (SqlCommand cmd = new SqlCommand(sqlDelete, conexao.AbrirConexao()))
                {
                    cmd.Parameters.AddWithValue("@ProdutoColhidoId", produtoColhidoId);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Produto deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.None);
                        ListarTbProduto();
                        LimparCampos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao deletar produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void gridProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clicado = true;

            if (e.RowIndex > -1)
            {
                var cellValue = gridProdutos.CurrentRow.Cells[0].Value;

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int id))
                {
                    produtoColhidoId = id; // A conversão foi bem-sucedida
                }
                else
                {
                    MessageBox.Show("O valor na célula selecionada não é um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (clicado)
            {

                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este registro?",
                                             "Confirmação de Exclusão",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Excluir();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um registro para deletar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmCadastrarProduto frm = new FrmCadastrarProduto();
            frm.ShowDialog();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProduto.Items.Count == 0 || cmbProduto.SelectedValue == null)
            {
                return; // Sai do método se o ComboBox estiver vazio ou sem valor selecionado
            }

            FormatarPreco();
        }

        private void numericQuantidade_ValueChanged(object sender, EventArgs e)
        {
            FormatarPreco();
        }

        private void FrmGerenciarProduto_Load(object sender, EventArgs e)
        {
            ListarProduto();
        }
    }
}
