using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrmPrincipal
{
    public partial class FrmCadastrarTarefa : Form
    {
        ConexaoDB conexaoDB = new ConexaoDB();
        public FrmCadastrarTarefa()
        {
            InitializeComponent();
            ListarFuncionario();
            LimparLbl();
        }

        private void ListarFuncionario()
        {
            string sqlSelect = "SELECT Nome, FuncionarioId FROM tbFuncionario ORDER BY Nome ASC";

            using (ConexaoDB conexao = new ConexaoDB())
            {
                using (SqlCommand cmd = new SqlCommand(sqlSelect))
                {
                    try
                    {
                        DataTable funcionario = conexao.ExecutarConsulta(cmd);
                        cmbFuncionario.DataSource = funcionario;
                        cmbFuncionario.DisplayMember = "Nome";
                        cmbFuncionario.ValueMember = "FuncionarioId";
                        cmbFuncionario.SelectedIndex = -1;
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
            lblMsgTarefa.Text = "";
            lblMsgFuncionario.Text = "";
            lblMsgPrioridade.Text = "";
            lblMsgDataLimite.Text = "";
        }

        private void ValidarCampos()
        {
            LimparLbl();

            bool temErro = false;

            if (string.IsNullOrWhiteSpace(txtTituloTarefa.Text))
            {
                lblMsgTarefa.Text = "O campo Título da Tarefa é obrigatório.";
                temErro = true;
            }

            if (cmbFuncionario.SelectedItem == null)
            {
                lblMsgFuncionario.Text = "Selecione um Funcionário Responsável.";
                temErro = true;
            }
            
            if (cmbPrioridade.SelectedItem == null)
            {
                lblMsgPrioridade.Text = "Atribua uma Prioridade a tarefa.";
                temErro = true;
            }

            if (dtpDataLimite.Value < DateTime.Now.Date)
            {
                lblMsgDataLimite.Text = "A data limite não pode ser anterior a data de hoje.";
                temErro = true;
            }

            if (temErro)
            {
                MessageBox.Show("Por favor, corrija os campos destacados antes de prosseguir.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SalvarTarefa();
        }

        private void SalvarTarefa()
        {
            string tarefa = txtTituloTarefa.Text.Trim();
            string descricao = txtDescTarefa.Text.Trim();
            int funcionarioId = (int)cmbFuncionario.SelectedValue;
            string prioridade = cmbPrioridade.Text;
            DateTime dataLimite = dtpDataLimite.Value;


            string sqlInsert = "INSERT INTO tb_tarefa (titulo, descricao, funcionario_id, prioridade, data_limite) " +
                                "VALUES (@Titulo, @Descricao, @FuncionarioId, @Prioridade, @DataLimite)";

            using (ConexaoDB conexao = new ConexaoDB())
            {
                using (SqlCommand cmd = new SqlCommand(sqlInsert, conexao.AbrirConexao()))
                {
                    cmd.Parameters.AddWithValue("@Titulo", tarefa);
                    cmd.Parameters.AddWithValue("@Descricao", descricao);
                    cmd.Parameters.AddWithValue("@FuncionarioId", funcionarioId);
                    cmd.Parameters.AddWithValue("@Prioridade", prioridade);
                    cmd.Parameters.AddWithValue("@DataLimite", dataLimite);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Tarefa registrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimparCampos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao registrar tarefa: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LimparCampos()
        {
            txtTituloTarefa.Text = "";
            txtDescTarefa.Text = "";
            cmbFuncionario.SelectedIndex = -1;
            cmbPrioridade.SelectedIndex = -1;
            dtpDataLimite.Value = DateTime.Now;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ValidarCampos();
        }
    }
}
