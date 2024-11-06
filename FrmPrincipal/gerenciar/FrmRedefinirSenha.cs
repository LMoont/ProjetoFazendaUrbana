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
using PasswordHashingLibrary;

namespace FrmPrincipal.gerenciar
{
    public partial class FrmRedefinirSenha : Form
    {
        private int idUsuario;
        public FrmRedefinirSenha(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;

            limparCampos();
        }

        private void FrmRedefinirSenha_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string senhaAtual = txtSenhaAtual.Text;
            string novaSenha = txtNovaSenha.Text;
            string senhaConfirmacao = txtConfirmarSenha.Text;

            limparCampos();

            bool temErro = false;

            if (string.IsNullOrWhiteSpace(txtSenhaAtual.Text))
            {
                lblMensagemSenhaAtual.Text = "Preencha o campo com a senha atual.";
                temErro = true;
            }

            if (string.IsNullOrWhiteSpace(txtNovaSenha.Text))
            {
                lblMensagemNovaSenha.Text = "A nova senha deve ter pelo menos 6 caracteres.";
                temErro = true;
            }

            if (novaSenha != senhaConfirmacao)
            {
                lblMensagemConfirmarSenha.Text = "A Senha e a confirmação devem ser iguais.";
                temErro = true;
            }

            if (temErro)
            {
                return;
            }

            if (novaSenha == senhaAtual)
            {
                MessageBox.Show("A nova senha não pode ser igual a senha atual!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string senhaArmazenada = "";

            string sqlSelect = "SELECT Senha FROM tbUsuarios WHERE ID = @idUsuario";

            using (ConexaoDB conexao = new ConexaoDB())
            {
                using (SqlCommand cmd = new SqlCommand(sqlSelect, conexao.AbrirConexao()))
                {
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        senhaArmazenada = result.ToString();
                    }

                    if (PasswordHasher.HashSenha(senhaAtual) == senhaArmazenada)
                    {
                        AtualizarSenha();
                    }
                   
                    else
                    {
                        MessageBox.Show("Senha atual incorreta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                        txtSenhaAtual.Text = "";
                        txtNovaSenha.Text = "";
                        txtConfirmarSenha.Text = "";
                        txtSenhaAtual.Focus();
                       
                        return;
                    }
                }
            }
        }

        private void AtualizarSenha()
        {
            string novaSenha = txtNovaSenha.Text;
            string confirmarSenha = txtConfirmarSenha.Text;

            if (string.IsNullOrWhiteSpace(novaSenha) || string.IsNullOrWhiteSpace(confirmarSenha))
            {
                MessageBox.Show("As senhas não podem estar vazias!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (novaSenha == confirmarSenha)
            
            {
                string senhaNovaHashed = PasswordHasher.HashSenha(novaSenha);
                string sqlUpdate = "UPDATE tbUsuarios SET Senha = @senha WHERE ID = @idUsuario";

                using (ConexaoDB conexao = new ConexaoDB())
                {
                    using (SqlCommand cmd = new SqlCommand(sqlUpdate))
                    {
                        cmd.Parameters.AddWithValue("@senha", senhaNovaHashed);
                        cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                        try
                        {
                            conexao.ExecutarConsulta(cmd);
                            MessageBox.Show("Senha redefinida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro ao redefinir senha: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("As senhas não coincidem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limparCampos()
        {
            lblMensagemSenhaAtual.Text = "";
            lblMensagemNovaSenha.Text = "";
            lblMensagemConfirmarSenha.Text = "";
        }
    }
}
