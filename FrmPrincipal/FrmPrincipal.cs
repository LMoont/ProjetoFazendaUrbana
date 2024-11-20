using Fazenda.Models;
using FrmPrincipal.cadastrar;
using FrmPrincipal.gerenciar;
using FrmPrincipal.Models;
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

namespace FrmPrincipal
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            AtualizarBlocoVendas();
            ExibirUltimoProdutoColhido();
        }
        public void ExibirUltimoProdutoColhido()
        {
            Colheita ultimoProduto = ObterUltimoProdutoColhido();

            if (ultimoProduto != null)
            {
                lblNomeProduto.Text = "Produto: " + ultimoProduto.NomeProduto;
                lblQuantidadeColhida.Text = "Quantidade: " + ultimoProduto.QuantidadeColhida + " unidades";
                lblDataColheita.Text = "Data da Colheita: " + ultimoProduto.DataColheita.ToString("dd/MM/yyyy");
            }
            else
            {
                lblNomeProduto.Text = "Produto: -";
                lblQuantidadeColhida.Text = "Quantidade: -";
                lblDataColheita.Text = "Data da Colheita: -";
            }
        }

        public Colheita ObterUltimoProdutoColhido()
        {
            Colheita ultimoProduto = null;
            string query = "SELECT TOP 1 Nome, Quantidade, DataColheita FROM tbProdutoColhido ORDER BY DataColheita DESC";

            using (ConexaoDB conexao = new ConexaoDB())
            {
                using (SqlCommand cmd = new SqlCommand(query, conexao.AbrirConexao()))
                {
                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            Console.WriteLine("Dados encontrados para o último produto colhido.");

                            ultimoProduto = new Colheita
                            {
                                NomeProduto = reader["Nome"].ToString(),
                                QuantidadeColhida = Convert.ToDecimal(reader["Quantidade"]),
                                DataColheita = Convert.ToDateTime(reader["DataColheita"])
                            };
                        }
                        else
                        {
                            Console.WriteLine("Nenhum dado encontrado na tabela tbProdutoColhido.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erro ao obter o último produto colhido: " + ex.Message);
                    }
                }
            }

            return ultimoProduto;
        }




        public void AtualizarBlocoVendas()
        {
            int numeroVendas = ObterNumeroVendasDoDia();
            decimal receitaAcumulada = ObterReceitaAcumuladaDoDia();

            lblNumeroVendas.Text = $"Vendas: {numeroVendas}";
            lblReceitaAcumulada.Text = $"Receita: R$ {receitaAcumulada:F2}";
        }

        private int ObterNumeroVendasDoDia()
        {
            int numeroVendas = 0;

            string sqlSelect = "SELECT COUNT(*) FROM tbVenda WHERE DataVenda = CAST(GETDATE() AS DATE)";

            using (ConexaoDB conexao = new ConexaoDB())
            {
                using (SqlCommand cmd = new SqlCommand(sqlSelect, conexao.AbrirConexao()))
                {

                    try
                    {
                        numeroVendas = (int)cmd.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erro ao obter o número de vendas: " + ex.Message);
                    }

                }
            }

            return numeroVendas;
        }

        private decimal ObterReceitaAcumuladaDoDia()
        {
            decimal receitaAcumulada = 0;

            string sqlSelect = "SELECT ISNULL(SUM(TotalVenda), 0) FROM tbVenda WHERE CONVERT(DATE, DataVenda) = CONVERT(DATE, GETDATE())";

            using (ConexaoDB conexao = new ConexaoDB())
            {
                using (SqlCommand cmd = new SqlCommand(sqlSelect, conexao.AbrirConexao()))
                {

                    try
                    {
                        receitaAcumulada = Convert.ToDecimal(cmd.ExecuteScalar());

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erro ao obter a receita acumulada: " + ex.Message);
                    }

                }
            }

            return receitaAcumulada;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRegistrarVenda frm = new FrmRegistrarVenda();
            frm.ShowDialog();
        }

        private void btnCriarTarefa_Click(object sender, EventArgs e)
        {
            FrmCadastrarTarefa frm = new FrmCadastrarTarefa();
            frm.ShowDialog();
        }

        private void btnInsumo_Click(object sender, EventArgs e)
        {
            FrmGerenciarInsumo frm = new FrmGerenciarInsumo();
            frm.ShowDialog();
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            RelatorioService relatorioService = new RelatorioService();

            if(cmbTipoRelatorio.Text == "Vendas")
            {
                relatorioService.GerarRelatorioVendasExcel();
            }

            if(cmbTipoRelatorio.Text == "Movimentação Insumos")
            {
                relatorioService.GerarRelatorioMovimentacaoInsumoExcel  ();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja sair?",
                                          "Sair",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();

                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Show();

                this.Close();
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            LblSaudacao.Text = "Bem-vindo";
            LblSaudacao.TextAlign = ContentAlignment.MiddleCenter;

            if (UsuarioLogado.Nome != null && !string.IsNullOrEmpty(UsuarioLogado.Nome))
            {
                LblNomeUsuario.Text = UsuarioLogado.Nome;
            }
            else
            {
                LblNomeUsuario.Text = "Usuário não encontrado";
            }
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            FrmCadastrarClientes frm = new FrmCadastrarClientes();
            frm.ShowDialog();
        }

        private void btnGerenciarClientes_Click(object sender, EventArgs e)
        {
            FrmGerenciarCliente frm = new FrmGerenciarCliente();
            frm.ShowDialog();
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            FrmCadastrarUsuario frm = new FrmCadastrarUsuario();
            frm.ShowDialog();
        }

        private void btnGerenciarUsuarios_Click(object sender, EventArgs e)
        {
            FrmGerenciarUsuarios frm = new FrmGerenciarUsuarios();
            frm.ShowDialog();
        }

        private void btnCadInsumo_Click(object sender, EventArgs e)
        {
            FrmCadastrarInsumo frm = new FrmCadastrarInsumo();
            frm.ShowDialog();
        }

        private void btnCadFornecedor_Click(object sender, EventArgs e)
        {
            FrmCadastrarFornecedor frm = new FrmCadastrarFornecedor();
            frm.ShowDialog();
        }

        private void btnColheita_Click(object sender, EventArgs e)
        {
            FrmCadastrarProduto frm = new FrmCadastrarProduto();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmGerenciarFornecedor frm = new FrmGerenciarFornecedor();
            frm.ShowDialog();
        }

        private void btnCadastrarCliente_MouseEnter(object sender, EventArgs e)
        {
            btnCadastrarCliente.BackColor = Color.Gold;
        }

        private void btnCadastrarCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCadastrarCliente.BackColor = Color.LemonChiffon;
        }

        private void btnGerenciarClientes_MouseEnter(object sender, EventArgs e)
        {
            btnGerenciarClientes.BackColor = Color.Gold;
        }

        private void btnGerenciarClientes_MouseLeave(object sender, EventArgs e)
        {
            btnGerenciarClientes.BackColor = Color.LemonChiffon;
        }

        private void btnCadastrarUsuario_MouseEnter(object sender, EventArgs e)
        {
            btnCadastrarUsuario.BackColor = Color.Gold;
        }

        private void btnCadastrarUsuario_MouseLeave(object sender, EventArgs e)
        {
            btnCadastrarUsuario.BackColor = Color.LemonChiffon;
        }

        private void btnGerenciarUsuarios_MouseEnter(object sender, EventArgs e)
        {
            btnGerenciarUsuarios.BackColor = Color.Gold;
        }

        private void btnGerenciarUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnGerenciarUsuarios.BackColor = Color.LemonChiffon;
        }

        private void btnCadInsumo_MouseEnter(object sender, EventArgs e)
        {
            btnCadInsumo.BackColor = Color.Gold;
        }

        private void btnCadInsumo_MouseLeave(object sender, EventArgs e)
        {
            btnCadInsumo.BackColor = Color.LemonChiffon;
        }

        private void btnCadFornecedor_MouseEnter(object sender, EventArgs e)
        {
            btnCadFornecedor.BackColor = Color.Gold;
        }

        private void btnCadFornecedor_MouseLeave(object sender, EventArgs e)
        {
            btnCadFornecedor.BackColor = Color.LemonChiffon;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gold;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.LemonChiffon;
        }

        private void btnCriarTarefa_MouseEnter(object sender, EventArgs e)
        {
            btnCriarTarefa.BackColor = Color.Gold;
        }

        private void btnCriarTarefa_MouseLeave(object sender, EventArgs e)
        {
            btnCriarTarefa.BackColor = Color.LemonChiffon;
        }

        private void btnInsumo_MouseEnter(object sender, EventArgs e)
        {
            btnInsumo.BackColor = Color.Gold;
        }

        private void btnInsumo_MouseLeave(object sender, EventArgs e)
        {
            btnInsumo.BackColor= Color.LemonChiffon;
        }

        private void btnColheita_MouseEnter(object sender, EventArgs e)
        {
            btnColheita.BackColor = Color.Gold;
        }

        private void btnColheita_MouseLeave(object sender, EventArgs e)
        {
            btnColheita.BackColor = Color.LemonChiffon;
        }

        private void btnGerarRelatorio_MouseEnter(object sender, EventArgs e)
        {
            btnGerarRelatorio.BackColor = Color.Gold;
        }

        private void btnGerarRelatorio_MouseLeave(object sender, EventArgs e)
        {
            btnGerarRelatorio.BackColor = Color.LemonChiffon;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Gold;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.LemonChiffon;
        }
    }
}
