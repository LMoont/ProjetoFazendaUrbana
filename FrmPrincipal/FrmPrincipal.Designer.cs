namespace FrmPrincipal
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MenuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuGerenciar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuGerenciarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarFornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNovosPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPedidosEmAndamento = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHistóricoDePedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatório = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLançarVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEntradasSaídas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDespesas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatórios = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatórioProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatórioVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatórioEntradasSaidas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatorioDespesas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Img03 = new System.Windows.Forms.PictureBox();
            this.insumoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insumosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img03)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastro,
            this.MenuGerenciar,
            this.MenuPedidos,
            this.MenuRelatório,
            this.MenuRelatórios,
            this.MenuSair});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(1160, 28);
            this.MenuPrincipal.TabIndex = 0;
            this.MenuPrincipal.Text = "MenuPrincipal";
            // 
            // MenuCadastro
            // 
            this.MenuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuUsuario,
            this.MenuFornecedor,
            this.funcionárioToolStripMenuItem,
            this.insumoToolStripMenuItem});
            this.MenuCadastro.Name = "MenuCadastro";
            this.MenuCadastro.Size = new System.Drawing.Size(86, 24);
            this.MenuCadastro.Text = "Cadastrar";
            this.MenuCadastro.Click += new System.EventHandler(this.MenuCadastro_Click);
            // 
            // MenuUsuario
            // 
            this.MenuUsuario.Name = "MenuUsuario";
            this.MenuUsuario.Size = new System.Drawing.Size(224, 26);
            this.MenuUsuario.Text = "Usuário";
            this.MenuUsuario.Click += new System.EventHandler(this.MenuUsuario_Click_1);
            // 
            // MenuFornecedor
            // 
            this.MenuFornecedor.Name = "MenuFornecedor";
            this.MenuFornecedor.Size = new System.Drawing.Size(224, 26);
            this.MenuFornecedor.Text = "Fornecedor";
            this.MenuFornecedor.Click += new System.EventHandler(this.MenuFornecedor_Click);
            // 
            // funcionárioToolStripMenuItem
            // 
            this.funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            this.funcionárioToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.funcionárioToolStripMenuItem.Text = "Funcionário";
            // 
            // MenuGerenciar
            // 
            this.MenuGerenciar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuGerenciarUsuario,
            this.gerenciarFornecedoresToolStripMenuItem,
            this.MenuEstoque});
            this.MenuGerenciar.Name = "MenuGerenciar";
            this.MenuGerenciar.Size = new System.Drawing.Size(86, 24);
            this.MenuGerenciar.Text = "Gerenciar";
            this.MenuGerenciar.Click += new System.EventHandler(this.MenuGerenciar_Click);
            // 
            // MenuGerenciarUsuario
            // 
            this.MenuGerenciarUsuario.Name = "MenuGerenciarUsuario";
            this.MenuGerenciarUsuario.Size = new System.Drawing.Size(248, 26);
            this.MenuGerenciarUsuario.Text = "Gerenciar Usuários";
            this.MenuGerenciarUsuario.Click += new System.EventHandler(this.MenuGerenciarUsuario_Click);
            // 
            // gerenciarFornecedoresToolStripMenuItem
            // 
            this.gerenciarFornecedoresToolStripMenuItem.Name = "gerenciarFornecedoresToolStripMenuItem";
            this.gerenciarFornecedoresToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.gerenciarFornecedoresToolStripMenuItem.Text = "Gerenciar Fornecedores";
            this.gerenciarFornecedoresToolStripMenuItem.Click += new System.EventHandler(this.gerenciarFornecedoresToolStripMenuItem_Click);
            // 
            // MenuEstoque
            // 
            this.MenuEstoque.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insumosToolStripMenuItem});
            this.MenuEstoque.Name = "MenuEstoque";
            this.MenuEstoque.Size = new System.Drawing.Size(248, 26);
            this.MenuEstoque.Text = "Estoque";
            // 
            // MenuPedidos
            // 
            this.MenuPedidos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuNovosPedidos,
            this.MenuPedidosEmAndamento,
            this.MenuHistóricoDePedidos});
            this.MenuPedidos.Name = "MenuPedidos";
            this.MenuPedidos.Size = new System.Drawing.Size(75, 24);
            this.MenuPedidos.Text = "Pedidos";
            // 
            // MenuNovosPedidos
            // 
            this.MenuNovosPedidos.Name = "MenuNovosPedidos";
            this.MenuNovosPedidos.Size = new System.Drawing.Size(251, 26);
            this.MenuNovosPedidos.Text = "Novos Pedidos";
            // 
            // MenuPedidosEmAndamento
            // 
            this.MenuPedidosEmAndamento.Name = "MenuPedidosEmAndamento";
            this.MenuPedidosEmAndamento.Size = new System.Drawing.Size(251, 26);
            this.MenuPedidosEmAndamento.Text = "Pedidos em Andamento";
            // 
            // MenuHistóricoDePedidos
            // 
            this.MenuHistóricoDePedidos.Name = "MenuHistóricoDePedidos";
            this.MenuHistóricoDePedidos.Size = new System.Drawing.Size(251, 26);
            this.MenuHistóricoDePedidos.Text = "Histórico de Pedidos";
            // 
            // MenuRelatório
            // 
            this.MenuRelatório.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuLançarVenda,
            this.MenuEntradasSaídas,
            this.MenuDespesas});
            this.MenuRelatório.Name = "MenuRelatório";
            this.MenuRelatório.Size = new System.Drawing.Size(91, 24);
            this.MenuRelatório.Text = "Financeiro";
            // 
            // MenuLançarVenda
            // 
            this.MenuLançarVenda.Name = "MenuLançarVenda";
            this.MenuLançarVenda.Size = new System.Drawing.Size(206, 26);
            this.MenuLançarVenda.Text = "Lançar Venda";
            // 
            // MenuEntradasSaídas
            // 
            this.MenuEntradasSaídas.Name = "MenuEntradasSaídas";
            this.MenuEntradasSaídas.Size = new System.Drawing.Size(206, 26);
            this.MenuEntradasSaídas.Text = "Entradas / Saídas";
            // 
            // MenuDespesas
            // 
            this.MenuDespesas.Name = "MenuDespesas";
            this.MenuDespesas.Size = new System.Drawing.Size(206, 26);
            this.MenuDespesas.Text = "Despesas";
            // 
            // MenuRelatórios
            // 
            this.MenuRelatórios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuRelatórioProdutos,
            this.MenuRelatórioVendas,
            this.MenuRelatórioEntradasSaidas,
            this.MenuRelatorioDespesas});
            this.MenuRelatórios.Name = "MenuRelatórios";
            this.MenuRelatórios.Size = new System.Drawing.Size(90, 24);
            this.MenuRelatórios.Text = "Relatórios";
            // 
            // MenuRelatórioProdutos
            // 
            this.MenuRelatórioProdutos.Name = "MenuRelatórioProdutos";
            this.MenuRelatórioProdutos.Size = new System.Drawing.Size(206, 26);
            this.MenuRelatórioProdutos.Text = "Produtos";
            // 
            // MenuRelatórioVendas
            // 
            this.MenuRelatórioVendas.Name = "MenuRelatórioVendas";
            this.MenuRelatórioVendas.Size = new System.Drawing.Size(206, 26);
            this.MenuRelatórioVendas.Text = "Vendas";
            // 
            // MenuRelatórioEntradasSaidas
            // 
            this.MenuRelatórioEntradasSaidas.Name = "MenuRelatórioEntradasSaidas";
            this.MenuRelatórioEntradasSaidas.Size = new System.Drawing.Size(206, 26);
            this.MenuRelatórioEntradasSaidas.Text = "Entradas / Saídas";
            // 
            // MenuRelatorioDespesas
            // 
            this.MenuRelatorioDespesas.Name = "MenuRelatorioDespesas";
            this.MenuRelatorioDespesas.Size = new System.Drawing.Size(206, 26);
            this.MenuRelatorioDespesas.Text = "Despesas";
            // 
            // MenuSair
            // 
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(48, 24);
            this.MenuSair.Text = "Sair";
            this.MenuSair.Click += new System.EventHandler(this.MenuSair_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(293, 71);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(314, 264);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(650, 118);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(314, 264);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(650, 407);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 264);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Img03
            // 
            this.Img03.Location = new System.Drawing.Point(293, 355);
            this.Img03.Name = "Img03";
            this.Img03.Size = new System.Drawing.Size(314, 264);
            this.Img03.TabIndex = 3;
            this.Img03.TabStop = false;
            // 
            // insumoToolStripMenuItem
            // 
            this.insumoToolStripMenuItem.Name = "insumoToolStripMenuItem";
            this.insumoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.insumoToolStripMenuItem.Text = "Insumo";
            this.insumoToolStripMenuItem.Click += new System.EventHandler(this.insumoToolStripMenuItem_Click);
            // 
            // insumosToolStripMenuItem
            // 
            this.insumosToolStripMenuItem.Name = "insumosToolStripMenuItem";
            this.insumosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.insumosToolStripMenuItem.Text = "Insumos";
            this.insumosToolStripMenuItem.Click += new System.EventHandler(this.insumosToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1160, 778);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Img03);
            this.Controls.Add(this.MenuPrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img03)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastro;
        private System.Windows.Forms.ToolStripMenuItem MenuGerenciar;
        private System.Windows.Forms.ToolStripMenuItem MenuPedidos;
        private System.Windows.Forms.ToolStripMenuItem MenuRelatório;
        private System.Windows.Forms.ToolStripMenuItem MenuSair;
        private System.Windows.Forms.PictureBox Img03;
        private System.Windows.Forms.ToolStripMenuItem MenuUsuario;
        private System.Windows.Forms.ToolStripMenuItem MenuFornecedor;
        private System.Windows.Forms.ToolStripMenuItem MenuGerenciarUsuario;
        private System.Windows.Forms.ToolStripMenuItem MenuEstoque;
        private System.Windows.Forms.ToolStripMenuItem MenuLançarVenda;
        private System.Windows.Forms.ToolStripMenuItem MenuEntradasSaídas;
        private System.Windows.Forms.ToolStripMenuItem MenuDespesas;
        private System.Windows.Forms.ToolStripMenuItem MenuRelatórios;
        private System.Windows.Forms.ToolStripMenuItem MenuRelatórioProdutos;
        private System.Windows.Forms.ToolStripMenuItem MenuRelatórioVendas;
        private System.Windows.Forms.ToolStripMenuItem MenuRelatórioEntradasSaidas;
        private System.Windows.Forms.ToolStripMenuItem MenuRelatorioDespesas;
        private System.Windows.Forms.ToolStripMenuItem MenuPedidosEmAndamento;
        private System.Windows.Forms.ToolStripMenuItem MenuHistóricoDePedidos;
        private System.Windows.Forms.ToolStripMenuItem MenuNovosPedidos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarFornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insumoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insumosToolStripMenuItem;
    }
}