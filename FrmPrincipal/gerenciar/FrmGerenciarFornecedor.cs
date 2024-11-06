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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FrmPrincipal.gerenciar
{
    public partial class FrmGerenciarFornecedor : Form
    {
        public int IDFornecedor { get; private set; }
        bool clicado = false;
        ConexaoDB conexaoDB = new ConexaoDB();

        public FrmGerenciarFornecedor()
        {
            InitializeComponent();
            ListarTipoFornecimento();
        }

        private void FrmGerenciarFornecedor_Load(object sender, EventArgs e)
        {
            ListarFornecedores();
            EsvaziarLbl();
        }

        public void EsvaziarLbl()
        {
            lblMsgNome.Text = "";
            lblMsgDocumento.Text = "";
            lblMsgEndereco.Text = "";
            lblMsgEmail.Text = "";
            lblMsgTelefone.Text = "";
            lblMsgTipoFornecimento.Text = "";
        }

        private void FormatarDG()
        {
            int[] colunasAutoResize = { 0, 1, 4, 5, 6, 7 };
            foreach (int col in colunasAutoResize)
            {
                gridFornecedores.AutoResizeColumn(col);
            }

            gridFornecedores.Columns["Endereco"].Width = 225;
            gridFornecedores.Columns["Email"].Width = 195;

            gridFornecedores.Columns[0].HeaderText = "ID";
            gridFornecedores.Columns[1].HeaderText = "Nome";
            gridFornecedores.Columns[2].HeaderText = "Endereço";
            gridFornecedores.Columns[3].HeaderText = "E-mail";
            gridFornecedores.Columns[4].HeaderText = "CNPJ/CPF";
            gridFornecedores.Columns[5].HeaderText = "Telefone";
            gridFornecedores.Columns[6].HeaderText = "Data Cadastro";
            gridFornecedores.Columns[7].HeaderText = "Categoria";



            gridFornecedores.Columns[0].Visible = false;

            foreach (DataGridViewColumn coluna in gridFornecedores.Columns)
            {
                coluna.HeaderCell.Style.Font = new Font("Calibri", 11, FontStyle.Bold);
                coluna.HeaderCell.Style.BackColor = Color.LightBlue;
            }
            gridFornecedores.EnableHeadersVisualStyles = false;

        }

        private void gridFornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clicado = true;

            if (e.RowIndex > -1)
            {
                txtNome.Text = gridFornecedores.CurrentRow.Cells[1].Value.ToString();
                txtEndereco.Text = gridFornecedores.CurrentRow.Cells[2].Value.ToString();
                txtEmail.Text = gridFornecedores.CurrentRow.Cells[3].Value.ToString();
                maskedDocumento.Text = gridFornecedores.CurrentRow.Cells[4].Value.ToString();
                maskedTelefone.Text = gridFornecedores.CurrentRow.Cells[5].Value.ToString();
                cmbTipoFornecimento.Text = gridFornecedores.CurrentRow.Cells[7].Value.ToString();

                IDFornecedor = Convert.ToInt32(gridFornecedores.CurrentRow.Cells[0].Value);
            }
        }

        private void HabilitarCampos()
        {
            btnSalvar.Enabled = true;
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            txtEmail.Enabled = true;
            maskedDocumento.Enabled = true;
            cmbTipoFornecimento.Enabled = true;
            maskedTelefone.Enabled = true;
            lblEmail.Enabled = true;
            radioCNPJ.Enabled = true;
            radioCPF.Enabled = true;
            lblNome.Enabled = true;
            lblEndereco.Enabled = true;
            lblTelefone.Enabled = true;
            lblCategoria.Enabled = true;
        }

        private void DesabilitarCampos()
        {
            btnSalvar.Enabled = false;
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            txtEmail.Enabled = false;
            maskedDocumento.Enabled = false;
            cmbTipoFornecimento.Enabled = false;
            maskedTelefone.Enabled = false;
            lblEmail.Enabled = false;
            radioCNPJ.Enabled = false;
            radioCPF.Enabled = false;
            lblNome.Enabled = false;
            lblEndereco.Enabled = false;
            lblTelefone.Enabled = false;
            lblCategoria.Enabled = false;
        }

        private void ListarFornecedores()
        {
            string sqlSelect = "SELECT f.FornecedorId, f.Nome, f.Endereco, f.Email, f.CNPJ_CPF, " +
                "f.Telefone, f.DataCadastro, c.Nome AS TipoFornecimento FROM tbFornecedor AS f " +
                "JOIN tbCategoriaInsumo AS c ON f.TipoFornecimentoId = c.ID ORDER BY f.Nome;";

            using (ConexaoDB conexao = new ConexaoDB())
            {
                using (SqlCommand cmd = new SqlCommand(sqlSelect))
                {
                    try
                    {
                        DataTable usuarios = conexao.ExecutarConsulta(cmd);
                        gridFornecedores.DataSource = usuarios;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            FormatarDG();
        }

        private void maskedDocumento_Click(object sender, EventArgs e)
        {
            maskedDocumento.Select(0, 0);
        }

        private void maskedDocumento_Enter(object sender, EventArgs e)
        {
            maskedDocumento.Select(0, 0);
        }

        private void maskedTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            maskedTelefone.Select(0, 0);
        }

        private void maskedTelefone_Enter(object sender, EventArgs e)
        {
            maskedTelefone.Select(0, 0);
        }

        private void radioCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            maskedDocumento.Mask = "00,000,000/0000-00";
            maskedDocumento.Select(0, 0);
            maskedDocumento.Enabled = true;
            maskedDocumento.Focus();
        }

        private void radioCPF_CheckedChanged(object sender, EventArgs e)
        {
            maskedDocumento.Mask = "000,000,000-00";
            maskedDocumento.Select(0, 0);
            maskedDocumento.Enabled = true;
            maskedDocumento.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private bool ValidarEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (clicado)
            {
                HabilitarCampos();
            }
            else
            {
                MessageBox.Show("Por favor, selecione um fornecedor para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ValidarCampos()
        {
            EsvaziarLbl();
            bool temErro = false;
            string documento = maskedDocumento.Text;

            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                lblMsgNome.Text = "O campo Nome é obrigatório.";
                temErro = true;
            }

            if (string.IsNullOrWhiteSpace(txtEndereco.Text))
            {
                lblMsgEndereco.Text = "O campo Endereço é obrigatório.";
                temErro = true;
            }

            if (!ValidarEmail(txtEmail.Text))
            {
                lblMsgEmail.Text = "O Email fornecido não é válido.";
                temErro = true;
            }

            if (radioCNPJ.Checked)
            {
                if (string.IsNullOrWhiteSpace(documento) || documento.Length != 18 || documento == "  .   .   /    -")
                {
                    lblMsgDocumento.Text = "O CNPJ não é válido.";
                    temErro = true;
                }
            }
            else if (radioCPF.Checked)
            {
                if (string.IsNullOrWhiteSpace(documento) || documento.Length != 14 || documento == "000.000.000-00")
                {
                    lblMsgDocumento.Text = "O CPF não é válido.";
                    temErro = true;
                }
            }

            if (string.IsNullOrWhiteSpace(maskedTelefone.Text) || maskedTelefone.Text.Length < 10)
            {
                lblMsgTelefone.Text = "O campo Telefone é obrigatório.";
                temErro = true;
            }

            if (cmbTipoFornecimento.SelectedItem == null)
            {
                lblMsgTipoFornecimento.Text = "Selecione um Tipo de Fornecimento.";
                temErro = true;
            }

            if (conexaoDB.DocumentoJaExiste(maskedDocumento.Text, IDFornecedor))
            {
                lblMsgDocumento.Text = "O documento já está cadastrado.";
                temErro = true;
            }

            if (temErro)
            {
                MessageBox.Show("Por favor, corrija os campos destacados antes de prosseguir.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AtualizarFornecedor();
        }

        private void AtualizarFornecedor()
        {
            string nome = txtNome.Text.Trim();
            string endereco = txtEndereco.Text.Trim();
            string email = txtEmail.Text.Trim();
            string documento = maskedDocumento.Text.Trim();
            string telefone = maskedTelefone.Text.Trim();
            //string tipoFornecimento = cmbTipoFornecimento.Text;

            string sqlUpdateFornecedor = "UPDATE tbFornecedor SET Nome = @Nome, Endereco = @Endereco, Email = @Email, " +
                "CNPJ_CPF = @Documento, Telefone = @Telefone, TipoFornecimentoId = @TipoFornecimento WHERE FornecedorId = @IDFornecedor";

            using (ConexaoDB conexao = new ConexaoDB())
            {
                using (SqlCommand cmdFornecedor = new SqlCommand(sqlUpdateFornecedor, conexao.AbrirConexao()))
                {
                    cmdFornecedor.Parameters.AddWithValue("@IDFornecedor", IDFornecedor);
                    cmdFornecedor.Parameters.AddWithValue("@Nome", nome);
                    cmdFornecedor.Parameters.AddWithValue("@Endereco", endereco);
                    cmdFornecedor.Parameters.AddWithValue("@Email", email);
                    cmdFornecedor.Parameters.AddWithValue("@Documento", documento);
                    cmdFornecedor.Parameters.AddWithValue("@Telefone", telefone);
                    cmdFornecedor.Parameters.AddWithValue("@TipoFornecimento", cmbTipoFornecimento.SelectedValue);

                    try
                    {
                        // Executa o comando de atualização de tbFornecedor
                        cmdFornecedor.ExecuteNonQuery();

                        MessageBox.Show("Fornecedor atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarFornecedores();
                        DesabilitarCampos();
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
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtEmail.Text = "";
            maskedDocumento.Text = "";
            maskedTelefone.Text = "";
            cmbTipoFornecimento.SelectedIndex = -1;
        }

        private void Excluir()
        {
            string sqlDelete = "DELETE FROM tbFornecedor WHERE FornecedorId = @IDFornecedor";

            using (ConexaoDB conexao = new ConexaoDB())
            {
                using (SqlCommand cmd = new SqlCommand(sqlDelete, conexao.AbrirConexao()))
                {
                    cmd.Parameters.AddWithValue("@IDFornecedor", IDFornecedor);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Fornecedor deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.None);
                        ListarFornecedores();
                        LimparCampos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao deletar fornecedor: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private void ListarTipoFornecimento()
        {
            string sqlSelect = "SELECT * FROM tbCategoriaInsumo ORDER BY Nome asc";

            using (ConexaoDB conexao = new ConexaoDB())
            {
                using (SqlCommand cmd = new SqlCommand(sqlSelect))
                {
                    try
                    {
                        DataTable tipoFornecimento = conexao.ExecutarConsulta(cmd);
                        cmbTipoFornecimento.DataSource = tipoFornecimento;
                        cmbTipoFornecimento.DisplayMember = "Nome";
                        cmbTipoFornecimento.ValueMember = "ID";
                        cmbTipoFornecimento.SelectedIndex = -1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCadastrarFornecedor frm = new FrmCadastrarFornecedor();
            frm.ShowDialog();
        }
    }
}
