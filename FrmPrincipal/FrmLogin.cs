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
using System.Configuration;
using PasswordHashingLibrary;
using Fazenda.Models;

namespace FrmPrincipal
{
    
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

            pnlRecuperacaoSenha.Visible = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblEntrar_Click(object sender, EventArgs e)
        {

        }

        private void LnkEsqueceuSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Esconder controles de login
            pnlLogin.Visible = false;

            // Exibir controles de recuperação de senha
            pnlRecuperacaoSenha.Visible = true;
        }

        private void LblCancelar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Exibir controles de login novamente
            pnlLogin.Visible = true;

            // Esconder controles de recuperação de senha
            pnlRecuperacaoSenha.Visible = false;
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == "" || txtSenha.Text.Trim() == "")
            {
                MessageBox.Show("Por favor, preencha o nome de usuário e a senha.");
                return;
            }

            string nomeUsuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text.Trim();

            string connectionString = ConfigurationManager.ConnectionStrings["ConexaoFazenda"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT ID, Senha, Nome FROM tbUsuarios WHERE Usuario = @Usuario";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Usuario", nomeUsuario);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedHash = reader["Senha"].ToString();
                                int idUsuario = Convert.ToInt32(reader["ID"]);
                                string nomeCompleto = reader["Nome"].ToString();

                                string inputHash = PasswordHasher.HashSenha(senha);

                                if (storedHash == inputHash)
                                {
                                    AtualizarUltimoLogin(idUsuario);

                                    UsuarioLogado.UsuarioId = idUsuario;
                                    UsuarioLogado.NomeUsuario = nomeCompleto;

                                    FrmPrincipal frm = new FrmPrincipal();
                                    frm.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Usuário ou senha incorretos!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Usuário não encontrado!");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
                }
            }
        }

        private void AtualizarUltimoLogin(int idUsuario)
        {
            string sqlUpdate = "UPDATE tbUsuarios SET UltimoLogin = @ultimoLogin WHERE ID = @idUsuario";

            using (ConexaoDB conexao = new ConexaoDB())
            {
                using (SqlCommand cmd = new SqlCommand(sqlUpdate))
                {
                    cmd.Parameters.AddWithValue("@ultimoLogin", DateTime.Now);
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                    try
                    {
                        conexao.ExecutarComando(cmd);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao atualizar o último login: " + ex.Message);
                    }
                }
            }
        }


        private void BtnRecuperarSenha_Click(object sender, EventArgs e)
            {
                if (TxtVerificarEmail.Text.Trim() == "")
                {
                    MessageBox.Show("Por favor, preencha o nome de usuário ou e-mail");

                    return;
                }

            }

        private void pnlRecuperacaoSenha_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }
