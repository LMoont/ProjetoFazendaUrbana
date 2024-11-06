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
    
    public partial class FrmCadastrarFornecedor : Form
    {
        ConexaoDB conexaoDB = new ConexaoDB();
        public FrmCadastrarFornecedor()
        {
            InitializeComponent();
            ListarTipoFornecimento();
            EsvaziarLbl();
        }

        private void ListarTipoFornecimento()
        {
            string sqlSelect = "SELECT Nome, ID FROM tbCategoriaInsumo ORDER BY Nome ASC";

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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBoxDocumento.Mask = "00,000,000/0000-00";
            maskedTextBoxDocumento.Select(0, 0);
            maskedTextBoxDocumento.Enabled = true;
            maskedTextBoxDocumento.Focus();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBoxDocumento.Mask = "000,000,000-00";
            maskedTextBoxDocumento.Select(0, 0);
            maskedTextBoxDocumento.Enabled = true;
            maskedTextBoxDocumento.Focus();
        }

        private void cmbTipoFornecimento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ValidarCampos()
        {
            EsvaziarLbl(); // Limpa os labels de erro
            bool temErro = false;
            string documento = maskedTextBoxDocumento.Text;

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

            if (radioButton1.Checked) // CNPJ
            {
                if (string.IsNullOrWhiteSpace(documento) || documento.Length != 18 || documento == "  .   .   /    -")
                {
                    lblMsgDocumento.Text = "O CNPJ não é válido.";
                    temErro = true;
                }
            }
            else if (radioButton2.Checked) // CPF
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

            if (conexaoDB.DocumentoJaExiste(maskedTextBoxDocumento.Text))
            {
                lblMsgDocumento.Text = "O documento já está cadastrado.";
                temErro = true;
            }

            if (temErro)
            {
                MessageBox.Show("Por favor, corrija os campos destacados antes de prosseguir.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CadastrarFornecedor();
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

        public void EsvaziarLbl()
        {
            lblMsgNome.Text = "";
            lblMsgDocumento.Text = "";
            lblMsgEndereco.Text = "";
            lblMsgEmail.Text = "";
            lblMsgTelefone.Text = "";
            lblMsgTipoFornecimento.Text = "";
        }

        private void maskedTextBoxDocumento_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void maskedTextBoxDocumento_Enter(object sender, EventArgs e)
        {
            maskedTextBoxDocumento.Select(0, 0);
        }

        private void maskedTextBoxDocumento_Click(object sender, EventArgs e)
        {
            maskedTextBoxDocumento.Select(0, 0);
        }

        private void maskedTelefone_Click(object sender, EventArgs e)
        {
            maskedTelefone.Select(0, 0);
        }

        private void maskedTelefone_Enter(object sender, EventArgs e)
        {
            maskedTelefone.Select(0, 0);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void CadastrarFornecedor()
        {
            string sqlInsert = "INSERT INTO tbFornecedor (Nome, Endereco, Email, CNPJ_CPF, Telefone, TipoFornecimentoId) " +
                               "VALUES (@Nome, @Endereco, @Email, @CNPJ_CPF, @Telefone, @TipoFornecimentoId)";

            using (ConexaoDB conexao = new ConexaoDB())
            {
                using (SqlCommand cmd = new SqlCommand(sqlInsert))
                {
                    cmd.Parameters.AddWithValue("@Nome", txtNome.Text.Trim());
                    cmd.Parameters.AddWithValue("@Endereco", txtEndereco.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@CNPJ_CPF", maskedTextBoxDocumento.Text.Trim());
                    cmd.Parameters.AddWithValue("@Telefone", maskedTelefone.Text.Trim());
                    cmd.Parameters.AddWithValue("@TipoFornecimentoId", cmbTipoFornecimento.SelectedValue);

                    try
                    {
                        conexao.ExecutarComando(cmd);
                        MessageBox.Show("Fornecedor cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      
                        txtNome.Text = "";
                        txtEndereco.Text = "";
                        txtEmail.Text = "";
                        maskedTextBoxDocumento.Text = "";
                        maskedTelefone.Text = "";
                        cmbTipoFornecimento.SelectedIndex = -1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar fornecedor: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void maskedTextBoxDocumento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
