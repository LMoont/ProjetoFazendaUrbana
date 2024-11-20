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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.LblNomeUsuario = new System.Windows.Forms.Label();
            this.LblSaudacao = new System.Windows.Forms.Label();
            this.btnColheita = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumeroVendas = new System.Windows.Forms.Label();
            this.blocoVendas = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblReceitaAcumulada = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCriarTarefa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInsumo = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblDataColheita = new System.Windows.Forms.Label();
            this.lblQuantidadeColhida = new System.Windows.Forms.Label();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbTipoRelatorio = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.btnCadastrarUsuario = new System.Windows.Forms.Button();
            this.btnGerenciarClientes = new System.Windows.Forms.Button();
            this.btnCadInsumo = new System.Windows.Forms.Button();
            this.btnCadFornecedor = new System.Windows.Forms.Button();
            this.btnGerenciarUsuarios = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.blocoVendas.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.panel1.Controls.Add(this.btnCadInsumo);
            this.panel1.Controls.Add(this.btnCadFornecedor);
            this.panel1.Controls.Add(this.btnGerenciarUsuarios);
            this.panel1.Controls.Add(this.btnGerenciarClientes);
            this.panel1.Controls.Add(this.btnCadastrarUsuario);
            this.panel1.Controls.Add(this.btnCadastrarCliente);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.LblNomeUsuario);
            this.panel1.Controls.Add(this.LblSaudacao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 725);
            this.panel1.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(147, 635);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(68, 57);
            this.btnSair.TabIndex = 2;
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // LblNomeUsuario
            // 
            this.LblNomeUsuario.AutoSize = true;
            this.LblNomeUsuario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomeUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblNomeUsuario.Location = new System.Drawing.Point(104, 99);
            this.LblNomeUsuario.Name = "LblNomeUsuario";
            this.LblNomeUsuario.Size = new System.Drawing.Size(0, 19);
            this.LblNomeUsuario.TabIndex = 1;
            this.LblNomeUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSaudacao
            // 
            this.LblSaudacao.AutoSize = true;
            this.LblSaudacao.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSaudacao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblSaudacao.Location = new System.Drawing.Point(116, 50);
            this.LblSaudacao.Name = "LblSaudacao";
            this.LblSaudacao.Size = new System.Drawing.Size(99, 19);
            this.LblSaudacao.TabIndex = 0;
            this.LblSaudacao.Text = "Bem-vindo";
            this.LblSaudacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnColheita
            // 
            this.btnColheita.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnColheita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColheita.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColheita.Image = ((System.Drawing.Image)(resources.GetObject("btnColheita.Image")));
            this.btnColheita.Location = new System.Drawing.Point(303, 92);
            this.btnColheita.Name = "btnColheita";
            this.btnColheita.Padding = new System.Windows.Forms.Padding(6);
            this.btnColheita.Size = new System.Drawing.Size(160, 58);
            this.btnColheita.TabIndex = 6;
            this.btnColheita.Text = "Registrar Colheita";
            this.btnColheita.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnColheita.UseVisualStyleBackColor = false;
            this.btnColheita.Click += new System.EventHandler(this.btnColheita_Click);
            this.btnColheita.MouseEnter += new System.EventHandler(this.btnColheita_MouseEnter);
            this.btnColheita.MouseLeave += new System.EventHandler(this.btnColheita_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(146, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vendas do Dia";
            // 
            // lblNumeroVendas
            // 
            this.lblNumeroVendas.AutoSize = true;
            this.lblNumeroVendas.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroVendas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNumeroVendas.Location = new System.Drawing.Point(21, 92);
            this.lblNumeroVendas.Name = "lblNumeroVendas";
            this.lblNumeroVendas.Size = new System.Drawing.Size(92, 19);
            this.lblNumeroVendas.TabIndex = 1;
            this.lblNumeroVendas.Text = "Vendas: 0";
            // 
            // blocoVendas
            // 
            this.blocoVendas.BackColor = System.Drawing.Color.OrangeRed;
            this.blocoVendas.Controls.Add(this.button1);
            this.blocoVendas.Controls.Add(this.lblReceitaAcumulada);
            this.blocoVendas.Controls.Add(this.lblNumeroVendas);
            this.blocoVendas.Controls.Add(this.label1);
            this.blocoVendas.Location = new System.Drawing.Point(389, 39);
            this.blocoVendas.Name = "blocoVendas";
            this.blocoVendas.Size = new System.Drawing.Size(483, 182);
            this.blocoVendas.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LemonChiffon;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(311, 77);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(6);
            this.button1.Size = new System.Drawing.Size(152, 65);
            this.button1.TabIndex = 7;
            this.button1.Text = "Registrar Venda";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // lblReceitaAcumulada
            // 
            this.lblReceitaAcumulada.AutoSize = true;
            this.lblReceitaAcumulada.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceitaAcumulada.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblReceitaAcumulada.Location = new System.Drawing.Point(21, 123);
            this.lblReceitaAcumulada.Name = "lblReceitaAcumulada";
            this.lblReceitaAcumulada.Size = new System.Drawing.Size(141, 19);
            this.lblReceitaAcumulada.TabIndex = 2;
            this.lblReceitaAcumulada.Text = "Receita: R$ 0,00";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Controls.Add(this.btnCriarTarefa);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(389, 269);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 182);
            this.panel2.TabIndex = 8;
            // 
            // btnCriarTarefa
            // 
            this.btnCriarTarefa.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnCriarTarefa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriarTarefa.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarTarefa.Image = ((System.Drawing.Image)(resources.GetObject("btnCriarTarefa.Image")));
            this.btnCriarTarefa.Location = new System.Drawing.Point(311, 84);
            this.btnCriarTarefa.Name = "btnCriarTarefa";
            this.btnCriarTarefa.Padding = new System.Windows.Forms.Padding(6);
            this.btnCriarTarefa.Size = new System.Drawing.Size(152, 58);
            this.btnCriarTarefa.TabIndex = 7;
            this.btnCriarTarefa.Text = "Criar Tarefa";
            this.btnCriarTarefa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCriarTarefa.UseVisualStyleBackColor = false;
            this.btnCriarTarefa.Click += new System.EventHandler(this.btnCriarTarefa_Click);
            this.btnCriarTarefa.MouseEnter += new System.EventHandler(this.btnCriarTarefa_MouseEnter);
            this.btnCriarTarefa.MouseLeave += new System.EventHandler(this.btnCriarTarefa_MouseLeave);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(21, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 65);
            this.label2.TabIndex = 8;
            this.label2.Text = "Registre novas tarefas e associe a funcionários específicos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(206, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tarefas";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Brown;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnInsumo);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(389, 499);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(483, 182);
            this.panel3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(21, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 65);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gerencie seu estoque de insumos aqui";
            // 
            // btnInsumo
            // 
            this.btnInsumo.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnInsumo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsumo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsumo.Image = ((System.Drawing.Image)(resources.GetObject("btnInsumo.Image")));
            this.btnInsumo.Location = new System.Drawing.Point(311, 84);
            this.btnInsumo.Name = "btnInsumo";
            this.btnInsumo.Padding = new System.Windows.Forms.Padding(6);
            this.btnInsumo.Size = new System.Drawing.Size(152, 58);
            this.btnInsumo.TabIndex = 7;
            this.btnInsumo.Text = "Gerenciar Insumos";
            this.btnInsumo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnInsumo.UseVisualStyleBackColor = false;
            this.btnInsumo.Click += new System.EventHandler(this.btnInsumo_Click);
            this.btnInsumo.MouseEnter += new System.EventHandler(this.btnInsumo_MouseEnter);
            this.btnInsumo.MouseLeave += new System.EventHandler(this.btnInsumo_MouseLeave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(86, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(308, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Gerenciar Estoque de Insumos";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(929, 499);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(483, 182);
            this.panel4.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(21, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 66);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gerencie os fornecedores de insumos da fazenda aqui";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(125, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Gerenciar Fornecedores";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkBlue;
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.cmbTipoRelatorio);
            this.panel5.Controls.Add(this.btnGerarRelatorio);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(929, 269);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(483, 182);
            this.panel5.TabIndex = 11;
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnGerarRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerarRelatorio.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btnGerarRelatorio.Image")));
            this.btnGerarRelatorio.Location = new System.Drawing.Point(303, 84);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Padding = new System.Windows.Forms.Padding(6);
            this.btnGerarRelatorio.Size = new System.Drawing.Size(160, 58);
            this.btnGerarRelatorio.TabIndex = 7;
            this.btnGerarRelatorio.Text = "Gerar Relatório";
            this.btnGerarRelatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGerarRelatorio.UseVisualStyleBackColor = false;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            this.btnGerarRelatorio.MouseEnter += new System.EventHandler(this.btnGerarRelatorio_MouseEnter);
            this.btnGerarRelatorio.MouseLeave += new System.EventHandler(this.btnGerarRelatorio_MouseLeave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(197, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Relatórios";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel6.Controls.Add(this.btnColheita);
            this.panel6.Controls.Add(this.lblDataColheita);
            this.panel6.Controls.Add(this.lblQuantidadeColhida);
            this.panel6.Controls.Add(this.lblNomeProduto);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Location = new System.Drawing.Point(929, 39);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(483, 182);
            this.panel6.TabIndex = 10;
            // 
            // lblDataColheita
            // 
            this.lblDataColheita.AutoSize = true;
            this.lblDataColheita.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataColheita.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDataColheita.Location = new System.Drawing.Point(21, 138);
            this.lblDataColheita.Name = "lblDataColheita";
            this.lblDataColheita.Size = new System.Drawing.Size(164, 19);
            this.lblDataColheita.TabIndex = 10;
            this.lblDataColheita.Text = "Data da Colheita: -";
            // 
            // lblQuantidadeColhida
            // 
            this.lblQuantidadeColhida.AutoSize = true;
            this.lblQuantidadeColhida.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeColhida.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblQuantidadeColhida.Location = new System.Drawing.Point(21, 108);
            this.lblQuantidadeColhida.Name = "lblQuantidadeColhida";
            this.lblQuantidadeColhida.Size = new System.Drawing.Size(123, 19);
            this.lblQuantidadeColhida.TabIndex = 9;
            this.lblQuantidadeColhida.Text = "Quantidade: -";
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProduto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNomeProduto.Location = new System.Drawing.Point(21, 77);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(88, 19);
            this.lblNomeProduto.TabIndex = 8;
            this.lblNomeProduto.Text = "Produto: -";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(166, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 23);
            this.label12.TabIndex = 0;
            this.label12.Text = "Última Colheita";
            // 
            // cmbTipoRelatorio
            // 
            this.cmbTipoRelatorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoRelatorio.FormattingEnabled = true;
            this.cmbTipoRelatorio.Items.AddRange(new object[] {
            "Vendas",
            "Movimentação Insumos"});
            this.cmbTipoRelatorio.Location = new System.Drawing.Point(25, 105);
            this.cmbTipoRelatorio.Name = "cmbTipoRelatorio";
            this.cmbTipoRelatorio.Size = new System.Drawing.Size(237, 29);
            this.cmbTipoRelatorio.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(21, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tipo de Relatório:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LemonChiffon;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(287, 84);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(6);
            this.button2.Size = new System.Drawing.Size(176, 58);
            this.button2.TabIndex = 12;
            this.button2.Text = "Gerenciar Fornecedores";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnCadastrarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarCliente.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarCliente.Image")));
            this.btnCadastrarCliente.Location = new System.Drawing.Point(59, 175);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Padding = new System.Windows.Forms.Padding(6);
            this.btnCadastrarCliente.Size = new System.Drawing.Size(239, 58);
            this.btnCadastrarCliente.TabIndex = 9;
            this.btnCadastrarCliente.Text = "Cadastrar Cliente";
            this.btnCadastrarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCadastrarCliente.UseVisualStyleBackColor = false;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            this.btnCadastrarCliente.MouseEnter += new System.EventHandler(this.btnCadastrarCliente_MouseEnter);
            this.btnCadastrarCliente.MouseLeave += new System.EventHandler(this.btnCadastrarCliente_MouseLeave);
            // 
            // btnCadastrarUsuario
            // 
            this.btnCadastrarUsuario.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnCadastrarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarUsuario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarUsuario.Image")));
            this.btnCadastrarUsuario.Location = new System.Drawing.Point(59, 315);
            this.btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            this.btnCadastrarUsuario.Padding = new System.Windows.Forms.Padding(6);
            this.btnCadastrarUsuario.Size = new System.Drawing.Size(239, 58);
            this.btnCadastrarUsuario.TabIndex = 10;
            this.btnCadastrarUsuario.Text = "Cadastrar Usuário";
            this.btnCadastrarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCadastrarUsuario.UseVisualStyleBackColor = false;
            this.btnCadastrarUsuario.Click += new System.EventHandler(this.btnCadastrarUsuario_Click);
            this.btnCadastrarUsuario.MouseEnter += new System.EventHandler(this.btnCadastrarUsuario_MouseEnter);
            this.btnCadastrarUsuario.MouseLeave += new System.EventHandler(this.btnCadastrarUsuario_MouseLeave);
            // 
            // btnGerenciarClientes
            // 
            this.btnGerenciarClientes.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnGerenciarClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerenciarClientes.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnGerenciarClientes.Image")));
            this.btnGerenciarClientes.Location = new System.Drawing.Point(59, 245);
            this.btnGerenciarClientes.Name = "btnGerenciarClientes";
            this.btnGerenciarClientes.Padding = new System.Windows.Forms.Padding(6);
            this.btnGerenciarClientes.Size = new System.Drawing.Size(239, 58);
            this.btnGerenciarClientes.TabIndex = 11;
            this.btnGerenciarClientes.Text = "Gerenciar Clientes";
            this.btnGerenciarClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGerenciarClientes.UseVisualStyleBackColor = false;
            this.btnGerenciarClientes.Click += new System.EventHandler(this.btnGerenciarClientes_Click);
            this.btnGerenciarClientes.MouseEnter += new System.EventHandler(this.btnGerenciarClientes_MouseEnter);
            this.btnGerenciarClientes.MouseLeave += new System.EventHandler(this.btnGerenciarClientes_MouseLeave);
            // 
            // btnCadInsumo
            // 
            this.btnCadInsumo.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnCadInsumo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadInsumo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadInsumo.Image = ((System.Drawing.Image)(resources.GetObject("btnCadInsumo.Image")));
            this.btnCadInsumo.Location = new System.Drawing.Point(59, 455);
            this.btnCadInsumo.Name = "btnCadInsumo";
            this.btnCadInsumo.Padding = new System.Windows.Forms.Padding(6);
            this.btnCadInsumo.Size = new System.Drawing.Size(239, 58);
            this.btnCadInsumo.TabIndex = 14;
            this.btnCadInsumo.Text = "Cadastrar Insumo";
            this.btnCadInsumo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCadInsumo.UseVisualStyleBackColor = false;
            this.btnCadInsumo.Click += new System.EventHandler(this.btnCadInsumo_Click);
            this.btnCadInsumo.MouseEnter += new System.EventHandler(this.btnCadInsumo_MouseEnter);
            this.btnCadInsumo.MouseLeave += new System.EventHandler(this.btnCadInsumo_MouseLeave);
            // 
            // btnCadFornecedor
            // 
            this.btnCadFornecedor.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnCadFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadFornecedor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnCadFornecedor.Image")));
            this.btnCadFornecedor.Location = new System.Drawing.Point(59, 525);
            this.btnCadFornecedor.Name = "btnCadFornecedor";
            this.btnCadFornecedor.Padding = new System.Windows.Forms.Padding(6);
            this.btnCadFornecedor.Size = new System.Drawing.Size(239, 58);
            this.btnCadFornecedor.TabIndex = 13;
            this.btnCadFornecedor.Text = "Cadastrar Fornecedor";
            this.btnCadFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadFornecedor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCadFornecedor.UseVisualStyleBackColor = false;
            this.btnCadFornecedor.Click += new System.EventHandler(this.btnCadFornecedor_Click);
            this.btnCadFornecedor.MouseEnter += new System.EventHandler(this.btnCadFornecedor_MouseEnter);
            this.btnCadFornecedor.MouseLeave += new System.EventHandler(this.btnCadFornecedor_MouseLeave);
            // 
            // btnGerenciarUsuarios
            // 
            this.btnGerenciarUsuarios.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnGerenciarUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerenciarUsuarios.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnGerenciarUsuarios.Image")));
            this.btnGerenciarUsuarios.Location = new System.Drawing.Point(59, 385);
            this.btnGerenciarUsuarios.Name = "btnGerenciarUsuarios";
            this.btnGerenciarUsuarios.Padding = new System.Windows.Forms.Padding(6);
            this.btnGerenciarUsuarios.Size = new System.Drawing.Size(239, 58);
            this.btnGerenciarUsuarios.TabIndex = 12;
            this.btnGerenciarUsuarios.Text = "Gerenciar Usuários";
            this.btnGerenciarUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGerenciarUsuarios.UseVisualStyleBackColor = false;
            this.btnGerenciarUsuarios.Click += new System.EventHandler(this.btnGerenciarUsuarios_Click);
            this.btnGerenciarUsuarios.MouseEnter += new System.EventHandler(this.btnGerenciarUsuarios_MouseEnter);
            this.btnGerenciarUsuarios.MouseLeave += new System.EventHandler(this.btnGerenciarUsuarios_MouseLeave);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1443, 725);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.blocoVendas);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.blocoVendas.ResumeLayout(false);
            this.blocoVendas.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblNomeUsuario;
        private System.Windows.Forms.Label LblSaudacao;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnColheita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumeroVendas;
        private System.Windows.Forms.Panel blocoVendas;
        private System.Windows.Forms.Label lblReceitaAcumulada;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnInsumo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCriarTarefa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblDataColheita;
        private System.Windows.Forms.Label lblQuantidadeColhida;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTipoRelatorio;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCadInsumo;
        private System.Windows.Forms.Button btnCadFornecedor;
        private System.Windows.Forms.Button btnGerenciarUsuarios;
        private System.Windows.Forms.Button btnGerenciarClientes;
        private System.Windows.Forms.Button btnCadastrarUsuario;
        private System.Windows.Forms.Button btnCadastrarCliente;
    }
}