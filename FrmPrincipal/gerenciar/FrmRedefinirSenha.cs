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
            string novaSenha = txtNovaSenha.Text;
            string senhaConfirmacao = txtConfirmarSenha.Text;

            limparCampos();

            bool temErro = false;

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
            AtualizarSenha();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limparCampos()
        {
            lblMensagemNovaSenha.Text = "";
            lblMensagemConfirmarSenha.Text = "";
        }
    }
}
