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
    public partial class FrmGerenciarInsumo : Form
    {
        bool clicado = false;
        public int InsumoId { get; private set; }
        ConexaoDB conexaoDB = new ConexaoDB();
        public FrmGerenciarInsumo()
        {
            InitializeComponent();
            ListarInsumo();
            EsvaziarLbl();
            ListarTbInsumos();
        }

        private void ListarInsumo()
        {
            string sqlSelect = "SELECT * FROM tbInsumo ORDER BY Nome asc";

            using (ConexaoDB conexao = new ConexaoDB())
            {
                using (SqlCommand cmd = new SqlCommand(sqlSelect))
                {
                    try
                    {
                        DataTable insumo = conexao.ExecutarConsulta(cmd);
                        cmbInsumo.DataSource = insumo;
                        cmbInsumo.DisplayMember = "Nome";
                        cmbInsumo.ValueMember = "InsumoId";
                        cmbInsumo.SelectedIndex = -1;
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
            lblMsgInsumo.Text = "";
            lblMsgMovimentacao.Text = "";
            lblMsgQuantidade.Text = "";
        }

        private void FormatarDG()
        {
            int[] colunasAutoResize = { 0, 2, 3, 4, 5, 6, 7 };
            foreach (int col in colunasAutoResize)
            {
                gridInsumos.AutoResizeColumn(col);
            }

            gridInsumos.Columns["Descricao"].Width = 225;
            gridInsumos.Columns["InsumoNome"].Width = 250;
            gridInsumos.Columns["FornecedorNome"].Width = 250;

            gridInsumos.Columns[0].HeaderText = "ID";
            gridInsumos.Columns[1].HeaderText = "Nome";
            gridInsumos.Columns[2].HeaderText = "Quantidade";
            gridInsumos.Columns[3].HeaderText = "Unidade de Medida";
            gridInsumos.Columns[4].HeaderText = "Valor Unitário";
            gridInsumos.Columns[5].HeaderText = "Valor Total";
            gridInsumos.Columns[6].HeaderText = "Descrição";
            gridInsumos.Columns[7].HeaderText = "Fornecedor";

            gridInsumos.Columns[0].Visible = false;
            gridInsumos.Columns[5].Visible = false;

            gridInsumos.Columns[4].DefaultCellStyle.Format = "C2"; 
            gridInsumos.Columns[5].DefaultCellStyle.Format = "C2";

            foreach (DataGridViewColumn coluna in gridInsumos.Columns)
            {
                coluna.HeaderCell.Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                coluna.HeaderCell.Style.BackColor = Color.LightBlue;
            }

            gridInsumos.DefaultCellStyle.Font = new Font("Calibri", 10, FontStyle.Regular); // Estilo das células
            gridInsumos.DefaultCellStyle.BackColor = Color.White;

            gridInsumos.EnableHeadersVisualStyles = false;
        }


        private decimal ObterQuantidadeAtual(int insumoId)
        {
            string sqlSelect = "SELECT Quantidade FROM tbInsumo WHERE InsumoId = @InsumoId";
            decimal quantidade = 0;

            using (ConexaoDB conexao = new ConexaoDB())
            {
                using (SqlCommand cmd = new SqlCommand(sqlSelect, conexao.AbrirConexao()))
                {
                    cmd.Parameters.AddWithValue("@InsumoId", insumoId);

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


        private void ListarTbInsumos()
        {
            string sqlSelect = "SELECT i.InsumoId, i.Nome AS InsumoNome, i.Quantidade, i.UnidadeMedida," +
               "i.ValorUnitario, i.ValorTotal, i.Descricao, f.Nome AS FornecedorNome FROM tbInsumo i JOIN tbFornecedor f " +
               "ON i.FornecedorId = f.FornecedorId ORDER BY i.Nome; ";

            using (ConexaoDB conexao = new ConexaoDB())
            {
                using (SqlCommand cmd = new SqlCommand(sqlSelect))
                {
                    try
                    {
                        DataTable insumos = conexao.ExecutarConsulta(cmd);
                        gridInsumos.DataSource = insumos;
                        FormatarDG();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
        }


        private void ValidarCampos()
        {
            EsvaziarLbl();
            bool temErro = false;

            if (!radioEntrada.Checked && !radioSaida.Checked)
            {
                lblMsgMovimentacao.Text = "Selecione um tipo de movimentação.";
                temErro = true;
            }

            if (cmbInsumo.SelectedItem == null)
            {
                lblMsgInsumo.Text = "Selecione um Insumo específico.";
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
            InserirMovimentacao();
        }

        private void AtualizarEstoque()
        {
            int insumoId = (int)cmbInsumo.SelectedValue;
            decimal quantidadeAtual = ObterQuantidadeAtual(insumoId);
            decimal quantidade = Convert.ToDecimal(numericQuantidade.Value);

            if (radioEntrada.Checked)
            {
                quantidade += quantidadeAtual;
            }
            else if (radioSaida.Checked)
            {
                quantidade = quantidadeAtual - quantidade;
                if (quantidade < 0) quantidade = 0;
            }

            string sqlUpdateEstoque = "UPDATE tbInsumo SET Quantidade = @Quantidade WHERE InsumoId = @InsumoId";

            using (ConexaoDB conexao = new ConexaoDB())
            {
                using (SqlCommand cmdEstoque = new SqlCommand(sqlUpdateEstoque, conexao.AbrirConexao()))
                {
                    cmdEstoque.Parameters.AddWithValue("@Quantidade", quantidade);
                    cmdEstoque.Parameters.AddWithValue("@InsumoId", insumoId);

                    try
                    {
                        cmdEstoque.ExecuteNonQuery();
                        MessageBox.Show("Estoque atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarTbInsumos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao atualizar o estoque: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void InserirMovimentacao()
        {
            string tipoMovimentacao = "";

            if (radioEntrada.Checked)
            {
                tipoMovimentacao = radioEntrada.Text;
            }
            else if (radioSaida.Checked)
            {
                tipoMovimentacao = radioSaida.Text;
            }

            int insumoId = (int)cmbInsumo.SelectedValue;
            decimal quantidade = Convert.ToDecimal(numericQuantidade.Value);

            string sqlInsert = "INSERT INTO tbMovimentacaoInsumo (InsumoId, TipoMovimentacao," +
                "Quantidade) VALUES (@InsumoId, @TipoMovimentacao, @Quantidade)";

            using (ConexaoDB conexao = new ConexaoDB())
            {
                using (SqlCommand cmdEstoque = new SqlCommand(sqlInsert, conexao.AbrirConexao()))
                {
                    cmdEstoque.Parameters.AddWithValue("@Quantidade", quantidade);
                    cmdEstoque.Parameters.AddWithValue("@InsumoId", insumoId);
                    cmdEstoque.Parameters.AddWithValue("@TipoMovimentacao", tipoMovimentacao);

                    try
                    {
                        cmdEstoque.ExecuteNonQuery();

                        MessageBox.Show("Movimentação registrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimparCampos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao atualizar fornecedor: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LimparCampos()
        {
            radioEntrada.Checked = false;
            radioSaida.Checked = false;
            numericQuantidade.Value = 0;
            cmbInsumo.SelectedIndex = -1;
        }

        private void Excluir()
        {
            string sqlDelete = "DELETE FROM tbInsumo WHERE InsumoId = @InsumoId";

            using (ConexaoDB conexao = new ConexaoDB())
            {
                using (SqlCommand cmd = new SqlCommand(sqlDelete, conexao.AbrirConexao()))
                {
                    cmd.Parameters.AddWithValue("@InsumoId", InsumoId);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Insumo deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.None);
                        ListarTbInsumos();
                        LimparCampos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao deletar fornecedor: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void gridInsumos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clicado = true;

            if (e.RowIndex > -1)
            {
                InsumoId = Convert.ToInt32(gridInsumos.CurrentRow.Cells[0].Value);
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
            FrmCadastrarInsumo frm = new FrmCadastrarInsumo();
            frm.ShowDialog();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ValidarCampos();
        }
    }


}
