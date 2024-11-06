using FrmPrincipal.cadastrar;
using FrmPrincipal.gerenciar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        private void MenuSair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja sair?",
                                             "Sair",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void MenuCadastro_Click(object sender, EventArgs e)
        {

        }

        private void MenuUsuario_Click_1(object sender, EventArgs e)
        {
            cadastrar.FrmCadastrarUsuario frm = new cadastrar.FrmCadastrarUsuario();
            frm.ShowDialog();
        }

        private void MenuGerenciarUsuario_Click(object sender, EventArgs e)
        {
            FrmGerenciarUsuarios frm = new FrmGerenciarUsuarios();
            frm.ShowDialog();
        }

        private void MenuGerenciar_Click(object sender, EventArgs e)
        {

        }

        private void MenuFornecedor_Click(object sender, EventArgs e)
        {
            FrmCadastrarFornecedor fmr = new FrmCadastrarFornecedor();
            fmr.ShowDialog();
        }

        private void gerenciarFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGerenciarFornecedor frm = new FrmGerenciarFornecedor();
            frm.ShowDialog();
        }

        private void insumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastrarInsumo frm = new FrmCadastrarInsumo();
            frm.ShowDialog();
        }

        private void insumosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGerenciarInsumo frm = new FrmGerenciarInsumo();
            frm.ShowDialog();
        }
    }
}
