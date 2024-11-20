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
    public partial class FrmGerenciarCliente : Form
    {
        public int IDCliente { get; private set; }
        bool clicado = false;
        ConexaoDB conexaoDB = new ConexaoDB();

        public FrmGerenciarCliente()
        {
            InitializeComponent();
            ListarClientes();
            EsvaziarLbl();
        }

        public void EsvaziarLbl()
        {
            lblMsgNome.Text = "";
            lblMsgDocumento.Text = "";
            lblMsgEndereco.Text = "";
            lblMsgEmail.Text = "";
            lblMsgTelefone.Text = "";
        }

        private void FormatarDG()
        {
            

            // Define o HeaderText com base nos índices, mas apenas se a coluna existir
            if (gridClientes.Columns.Count > 0) gridClientes.Columns[0].HeaderText = "ID";
            if (gridClientes.Columns.Count > 1) gridClientes.Columns[1].HeaderText = "Nome";
            if (gridClientes.Columns.Count > 2) gridClientes.Columns[2].HeaderText = "CPF/CNPJ";
            if (gridClientes.Columns.Count > 3) gridClientes.Columns[3].HeaderText = "Endereço";
            if (gridClientes.Columns.Count > 4) gridClientes.Columns[4].HeaderText = "Telefone";
            if (gridClientes.Columns.Count > 5) gridClientes.Columns[5].HeaderText = "Email";
            if (gridClientes.Columns.Count > 6) gridClientes.Columns[6].HeaderText = "Data Cadastro";

            gridClientes.Columns[0].Visible = false;

            foreach (DataGridViewColumn coluna in gridClientes.Columns)
            {
                coluna.HeaderCell.Style.Font = new Font("Calibri", 10, FontStyle.Bold);
                coluna.HeaderCell.Style.BackColor = Color.LightBlue;
            }

            gridClientes.DefaultCellStyle.Font = new Font("Calibri", 10, FontStyle.Regular); // Estilo das células
            gridClientes.DefaultCellStyle.BackColor = Color.White;

            gridClientes.EnableHeadersVisualStyles = false;
        }


        private void HabilitarCampos()
        {
            btnSalvar.Enabled = true;
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            txtEmail.Enabled = true;
            maskedDocumento.Enabled = true;
            maskedTelefone.Enabled = true;
            lblEmail.Enabled = true;
            radioCNPJ.Enabled = true;
            radioCPF.Enabled = true;
            lblNome.Enabled = true;
            lblEndereco.Enabled = true;
            lblTelefone.Enabled = true;
        }

        private void DesabilitarCampos()
        {
            btnSalvar.Enabled = false;
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            txtEmail.Enabled = false;
            maskedDocumento.Enabled = false;
            maskedTelefone.Enabled = false;
            lblEmail.Enabled = false;
            radioCNPJ.Enabled = false;
            radioCPF.Enabled = false;
            lblNome.Enabled = false;
            lblEndereco.Enabled = false;
            lblTelefone.Enabled = false;
        }

        public void ListarClientes()
        {
            string sqlSelect = "SELECT ClienteId, Nome, CPF_CNPJ, Endereco, Telefone, Email, DataCadastro " +
                "FROM tbCliente";

            using (ConexaoDB conexao = new ConexaoDB())
            {
                using (SqlCommand cmd = new SqlCommand(sqlSelect))
                {
                    try
                    {
                        DataTable clientes = conexao.ExecutarConsulta(cmd);
                        gridClientes.DataSource = clientes;
                        FormatarDG();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
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
                MessageBox.Show("Por favor, selecione um cliente para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            if (conexaoDB.DocumentoJaExiste(maskedDocumento.Text, IDCliente))
            {
                lblMsgDocumento.Text = "O documento já está cadastrado.";
                temErro = true;
            }

            if (temErro)
            {
                MessageBox.Show("Por favor, corrija os campos destacados antes de prosseguir.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AtualizarCliente();
        }

        private void AtualizarCliente()
        {
            string nome = txtNome.Text.Trim();
            string endereco = txtEndereco.Text.Trim();
            string email = txtEmail.Text.Trim();
            string documento = maskedDocumento.Text.Trim();
            string telefone = maskedTelefone.Text.Trim();

            string sqlUpdate = "UPDATE tbCliente SET Nome = @Nome, Endereco = @Endereco, Email = @Email, " +
                "CPF_CNPJ = @Documento, Telefone = @Telefone WHERE ClienteId = @ClienteId";

            using (ConexaoDB conexao = new ConexaoDB())
            {
                using (SqlCommand cmdFornecedor = new SqlCommand(sqlUpdate, conexao.AbrirConexao()))
                {
                    cmdFornecedor.Parameters.AddWithValue("@ClienteId", IDCliente);
                    cmdFornecedor.Parameters.AddWithValue("@Nome", nome);
                    cmdFornecedor.Parameters.AddWithValue("@Endereco", endereco);
                    cmdFornecedor.Parameters.AddWithValue("@Email", email);
                    cmdFornecedor.Parameters.AddWithValue("@Documento", documento);
                    cmdFornecedor.Parameters.AddWithValue("@Telefone", telefone);

                    try
                    {
                        // Executa o comando de atualização de tbFornecedor
                        cmdFornecedor.ExecuteNonQuery();

                        MessageBox.Show("Cliente atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarClientes();
                        DesabilitarCampos();
                        LimparCampos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao atualizar cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void Excluir()
        {
            string sqlDelete = "DELETE FROM tbCliente WHERE ClienteId = @IDCliente";

            using (ConexaoDB conexao = new ConexaoDB())
            {
                using (SqlCommand cmd = new SqlCommand(sqlDelete, conexao.AbrirConexao()))
                {
                    cmd.Parameters.AddWithValue("@IDCliente", IDCliente);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.None);
                        ListarClientes();
                        LimparCampos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao deletar cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCadastrarClientes frm = new FrmCadastrarClientes();
            frm.ShowDialog();
        }

        private void gridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clicado = true;

            if (e.RowIndex > -1)
            {
                txtNome.Text = gridClientes.CurrentRow.Cells[1].Value.ToString();
                txtEndereco.Text = gridClientes.CurrentRow.Cells[3].Value.ToString();
                txtEmail.Text = gridClientes.CurrentRow.Cells[5].Value.ToString();
                maskedDocumento.Text = gridClientes.CurrentRow.Cells[2].Value.ToString();
                maskedTelefone.Text = gridClientes.CurrentRow.Cells[4].Value.ToString();

                IDCliente = Convert.ToInt32(gridClientes.CurrentRow.Cells[0].Value);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListarClientes();
        }
    }
}