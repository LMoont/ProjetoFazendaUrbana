using PasswordHashingLibrary;
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
    public partial class FrmCadastrarUsuario : Form
    {
        ConexaoDB conexaoDB = new ConexaoDB();

        public FrmCadastrarUsuario()
        {
            InitializeComponent();
            EsvaziarLbl();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ValidarCampos()
        {
            EsvaziarLbl();

            bool temErro = false;

            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                lblMensagemNome.Text = "O campo Nome é obrigatório.";
                temErro = true;
            }

            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || txtUsuario.Text.Length < 3)
            {
                lblMensagemUsuario.Text = "O usuário deve ter pelo menos 3 caracteres.";
                temErro = true;
            }

            if (!ValidarEmail(txtEmail.Text))
            {
                lblMensagemEmail.Text = "O Email fornecido não é válido.";
                temErro = true;
            }

            if (string.IsNullOrWhiteSpace(txtSenha.Text) || txtSenha.Text.Length < 6)
            {
                lblMensagemSenha.Text = "A Senha deve ter pelo menos 6 caracteres.";
                temErro = true;
            }

            if (txtSenha.Text != txtConfirmarSenha.Text)
            {
                lblMensagemConfirmarSenha.Text = "A Senha e a confirmação devem ser iguais.";
                temErro = true;
            }

            if (cmbNivelAcesso.SelectedItem == null)
            {
                lblMensagemNivelAcesso.Text = "Selecione um nível de acesso.";
                temErro = true;
            }

            if (conexaoDB.UsuarioJaExiste(txtUsuario.Text))
            {
                lblMensagemUsuario.Text += "O nome de usuário já existe.";
                temErro = true;
            }

            if (temErro)
            {
                MessageBox.Show("Por favor, corrija os campos destacados antes de prosseguir.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CadastrarUsuario();
        }

        private void CadastrarUsuario()
        {
            string sqlInsert = "INSERT INTO tbUsuarios (Nome, Usuario, Email, Senha, NivelAcesso) VALUES (@Nome, @Usuario, @Email, @Senha, @NivelAcesso)";

            using (ConexaoDB conexao = new ConexaoDB())
            {
                using (SqlCommand cmd = new SqlCommand(sqlInsert))
                {
                    cmd.Parameters.AddWithValue("@Nome", txtNome.Text.Trim());
                    cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@Senha", PasswordHasher.HashSenha(txtSenha.Text));
                    cmd.Parameters.AddWithValue("@NivelAcesso", cmbNivelAcesso.SelectedItem.ToString());

                    try
                    {
                        conexao.ExecutarComando(cmd);
                        MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtNome.Text = "";
                        txtUsuario.Text = "";
                        txtEmail.Text = "";
                        txtSenha.Text = "";
                        txtConfirmarSenha.Text = "";
                        cmbNivelAcesso.SelectedIndex = -1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void EsvaziarLbl()
        {
            lblMensagemNome.Text = "";
            lblMensagemUsuario.Text = "";
            lblMensagemEmail.Text = "";
            lblMensagemSenha.Text = "";
            lblMensagemConfirmarSenha.Text = "";
            lblMensagemNivelAcesso.Text = "";
        }
    }
}
