using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using PasswordHashingLibrary;
using FrmPrincipal.gerenciar;

namespace FrmPrincipal.cadastrar
{
    public partial class FrmGerenciarUsuarios : Form
    {
        public int idUsuario { get; private set; }
        bool clicado = false;
        ConexaoDB conexaoDB = new ConexaoDB();

        public FrmGerenciarUsuarios()
        {
            InitializeComponent();
            lblMensagemNome.Text = "";
            lblMensagemUsuario.Text = "";
            lblMensagemEmail.Text = "";
            lblMensagemNivelAcesso.Text = "";
        }

        private void FormatarDG()
        {
            gridUsuarios.AutoResizeColumn(0);
            gridUsuarios.AutoResizeColumn(1);
            gridUsuarios.AutoResizeColumn(2);
            gridUsuarios.AutoResizeColumn(4);
            gridUsuarios.AutoResizeColumn(5);
            gridUsuarios.AutoResizeColumn(6);
            gridUsuarios.AutoResizeColumn(7);
            gridUsuarios.AutoResizeColumn(8);
            gridUsuarios.Columns["email"].Width = 191;

            gridUsuarios.Columns[0].HeaderText = "ID";
            gridUsuarios.Columns[1].HeaderText = "Nome";
            gridUsuarios.Columns[2].HeaderText = "Usuário";
            gridUsuarios.Columns[3].HeaderText = "E-mail";
            gridUsuarios.Columns[4].HeaderText = "Senha";
            gridUsuarios.Columns[5].HeaderText = "Data Cadastro";
            gridUsuarios.Columns[6].HeaderText = "Último Login";
            gridUsuarios.Columns[7].HeaderText = "Nível Acesso";
            gridUsuarios.Columns[8].HeaderText = "Ativo";


            gridUsuarios.Columns[0].Visible = false;
            gridUsuarios.Columns[4].Visible = false;

            foreach (DataGridViewColumn coluna in gridUsuarios.Columns)
            {
                coluna.HeaderCell.Style.Font = new Font("Calibri", 11, FontStyle.Bold);
                coluna.HeaderCell.Style.BackColor = Color.LightBlue;
            }
            gridUsuarios.EnableHeadersVisualStyles = false;

        }

        private void Listar()
        {
            string sqlSelect = "SELECT * FROM tbUsuarios ORDER BY nome ASC";

            using (ConexaoDB conexao = new ConexaoDB())
            {
                using (SqlCommand cmd = new SqlCommand(sqlSelect))
                {
                    try
                    {
                        DataTable usuarios = conexao.ExecutarConsulta(cmd);
                        gridUsuarios.DataSource = usuarios;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            FormatarDG();
        }

        private void FrmCadastrarUsuario_Load(object sender, EventArgs e)
        {
            Listar();
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

        private void gridUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clicado = true;

            if (e.RowIndex > -1)
            {
                txtNome.Text = gridUsuarios.CurrentRow.Cells[1].Value.ToString();
                txtUsuario.Text = gridUsuarios.CurrentRow.Cells[2].Value.ToString();
                txtEmail.Text = gridUsuarios.CurrentRow.Cells[3].Value.ToString();
                cmbNivelAcesso.Text = gridUsuarios.CurrentRow.Cells[7].Value.ToString();
                idUsuario = Convert.ToInt32(gridUsuarios.CurrentRow.Cells[0].Value);
            }
        }

        private void lnkRedefinirSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRedefinirSenha frm = new FrmRedefinirSenha(idUsuario);    
            frm.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (clicado)
            {
                habilitarCampos();
            }
            else
            {
                MessageBox.Show("Por favor, selecione um usuário para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void habilitarCampos()
        {
            btnSalvar.Enabled = true;
            txtNome.Enabled = true;
            txtUsuario.Enabled = true;
            txtEmail.Enabled = true;
            cmbNivelAcesso.Enabled = true;
            lnkRedefinirSenha.Enabled = true;
            lblEmail.Enabled = true;
            lblNivelAcesso.Enabled = true;
            lblNome.Enabled = true;
            lblUsuario.Enabled = true;
        }

        private void desabilitarCampos()
        {
            btnSalvar.Enabled = false;
            txtNome.Enabled = false;
            txtUsuario.Enabled = false;
            txtEmail.Enabled = false;
            cmbNivelAcesso.Enabled = false;
            lnkRedefinirSenha.Enabled = false;
            lblEmail.Enabled = false;
            lblNivelAcesso.Enabled = false;
            lblNome.Enabled = false;
            lblUsuario.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            lblMensagemNome.Text = "";
            lblMensagemUsuario.Text = "";
            lblMensagemEmail.Text = "";
            lblMensagemNivelAcesso.Text = "";

            string nome = txtNome.Text.Trim();
            string usuario = txtUsuario.Text.Trim();
            string email = txtEmail.Text.Trim();
            string nivelAcesso = cmbNivelAcesso.Text;

            bool temErro = false;

            if (string.IsNullOrWhiteSpace(nome))
            {
                lblMensagemNome.Text = "O campo Nome é obrigatório.";
                temErro = true;
            }

            if (string.IsNullOrWhiteSpace(usuario) || usuario.Length < 3)
            {
                lblMensagemUsuario.Text = "O usuário deve ter pelo menos 3 caracteres.";
                temErro = true;
            }

            if (!ValidarEmail(email))
            {
                lblMensagemEmail.Text = "O Email fornecido não é válido.";
                temErro = true;
            }

            if (cmbNivelAcesso.SelectedItem == null)
            {
                lblMensagemNivelAcesso.Text = "Selecione um nível de acesso.";
                temErro = true;
            }

            if (conexaoDB.UsuarioJaExiste(usuario, idUsuario))
            {
                lblMensagemUsuario.Text = "Nome de usuário já está em uso.";
                temErro = true;
            }

            if (temErro)
            {
                return;
            }

            string sqlUpdate = "UPDATE tbUsuarios SET Nome = @Nome, Usuario = @Usuario, Email = @Email, " +
                "NivelAcesso = @NivelAcesso WHERE ID = @IDUsuario";

            using (ConexaoDB conexao = new ConexaoDB())
            {
                using (SqlCommand cmd = new SqlCommand(sqlUpdate, conexao.AbrirConexao()))
                {
                    cmd.Parameters.AddWithValue("@IDUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@NivelAcesso", nivelAcesso);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Usuário atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Listar();
                        desabilitarCampos();
                        LimparCampos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao atualizar usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Por favor, selecione um usuário para deletar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Excluir()
        {
            string sqlDelete = "DELETE FROM tbUsuarios WHERE ID = @idUsuario";

            using (ConexaoDB conexao = new ConexaoDB())
            {
                using (SqlCommand cmd = new SqlCommand(sqlDelete, conexao.AbrirConexao()))
                {
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Usuário deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.None);
                        Listar();
                        LimparCampos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao deletar usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);                    }
                }
            }
        }
        private void LimparCampos()
        {
            txtNome.Text = "";
            txtUsuario.Text = "";
            txtEmail.Text = "";
            cmbNivelAcesso.SelectedIndex = -1;
        }
        
    }
}
