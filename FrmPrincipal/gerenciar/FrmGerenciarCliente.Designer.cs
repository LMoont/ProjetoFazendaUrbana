namespace FrmPrincipal.gerenciar
{
    partial class FrmGerenciarCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGerenciarCliente));
            this.gridClientes = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMsgEmail = new System.Windows.Forms.Label();
            this.lblMsgNome = new System.Windows.Forms.Label();
            this.lblMsgEndereco = new System.Windows.Forms.Label();
            this.maskedTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblMsgTelefone = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblMsgDocumento = new System.Windows.Forms.Label();
            this.maskedDocumento = new System.Windows.Forms.MaskedTextBox();
            this.radioCPF = new System.Windows.Forms.RadioButton();
            this.radioCNPJ = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridClientes
            // 
            this.gridClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridClientes.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.gridClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gridClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClientes.GridColor = System.Drawing.SystemColors.Desktop;
            this.gridClientes.Location = new System.Drawing.Point(189, 433);
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.RowHeadersWidth = 51;
            this.gridClientes.RowTemplate.Height = 26;
            this.gridClientes.Size = new System.Drawing.Size(1066, 329);
            this.gridClientes.TabIndex = 15;
            this.gridClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridClientes_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.lblMsgEmail);
            this.panel1.Controls.Add(this.lblMsgNome);
            this.panel1.Controls.Add(this.lblMsgEndereco);
            this.panel1.Controls.Add(this.maskedTelefone);
            this.panel1.Controls.Add(this.lblMsgTelefone);
            this.panel1.Controls.Add(this.lblTelefone);
            this.panel1.Controls.Add(this.lblMsgDocumento);
            this.panel1.Controls.Add(this.maskedDocumento);
            this.panel1.Controls.Add(this.radioCPF);
            this.panel1.Controls.Add(this.radioCNPJ);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtEndereco);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblEndereco);
            this.panel1.Location = new System.Drawing.Point(189, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 351);
            this.panel1.TabIndex = 11;
            // 
            // lblMsgEmail
            // 
            this.lblMsgEmail.AutoSize = true;
            this.lblMsgEmail.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgEmail.ForeColor = System.Drawing.Color.Red;
            this.lblMsgEmail.Location = new System.Drawing.Point(122, 319);
            this.lblMsgEmail.Name = "lblMsgEmail";
            this.lblMsgEmail.Size = new System.Drawing.Size(192, 17);
            this.lblMsgEmail.TabIndex = 41;
            this.lblMsgEmail.Text = "O Email fornecido não é válido.";
            // 
            // lblMsgNome
            // 
            this.lblMsgNome.AutoSize = true;
            this.lblMsgNome.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgNome.ForeColor = System.Drawing.Color.Red;
            this.lblMsgNome.Location = new System.Drawing.Point(122, 145);
            this.lblMsgNome.Name = "lblMsgNome";
            this.lblMsgNome.Size = new System.Drawing.Size(187, 17);
            this.lblMsgNome.TabIndex = 39;
            this.lblMsgNome.Text = "O campo Nome é obrigatório.";
            // 
            // lblMsgEndereco
            // 
            this.lblMsgEndereco.AutoSize = true;
            this.lblMsgEndereco.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgEndereco.ForeColor = System.Drawing.Color.Red;
            this.lblMsgEndereco.Location = new System.Drawing.Point(122, 230);
            this.lblMsgEndereco.Name = "lblMsgEndereco";
            this.lblMsgEndereco.Size = new System.Drawing.Size(206, 17);
            this.lblMsgEndereco.TabIndex = 40;
            this.lblMsgEndereco.Text = "O campo Endereço é obrigatório.";
            // 
            // maskedTelefone
            // 
            this.maskedTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTelefone.Enabled = false;
            this.maskedTelefone.Location = new System.Drawing.Point(694, 198);
            this.maskedTelefone.Mask = "(99) 0000-0000";
            this.maskedTelefone.Name = "maskedTelefone";
            this.maskedTelefone.Size = new System.Drawing.Size(196, 30);
            this.maskedTelefone.TabIndex = 35;
            this.maskedTelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTelefone_MaskInputRejected);
            this.maskedTelefone.Enter += new System.EventHandler(this.maskedTelefone_Enter);
            // 
            // lblMsgTelefone
            // 
            this.lblMsgTelefone.AutoSize = true;
            this.lblMsgTelefone.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgTelefone.ForeColor = System.Drawing.Color.Red;
            this.lblMsgTelefone.Location = new System.Drawing.Point(691, 232);
            this.lblMsgTelefone.Name = "lblMsgTelefone";
            this.lblMsgTelefone.Size = new System.Drawing.Size(200, 17);
            this.lblMsgTelefone.TabIndex = 34;
            this.lblMsgTelefone.Text = "O campo Telefone é obrigatório.";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Enabled = false;
            this.lblTelefone.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(690, 172);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(78, 23);
            this.lblTelefone.TabIndex = 33;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblMsgDocumento
            // 
            this.lblMsgDocumento.AutoSize = true;
            this.lblMsgDocumento.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgDocumento.ForeColor = System.Drawing.Color.Red;
            this.lblMsgDocumento.Location = new System.Drawing.Point(691, 145);
            this.lblMsgDocumento.Name = "lblMsgDocumento";
            this.lblMsgDocumento.Size = new System.Drawing.Size(156, 17);
            this.lblMsgDocumento.TabIndex = 32;
            this.lblMsgDocumento.Text = "O CNPJ/CPF não é válido.";
            // 
            // maskedDocumento
            // 
            this.maskedDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedDocumento.Enabled = false;
            this.maskedDocumento.Location = new System.Drawing.Point(694, 112);
            this.maskedDocumento.Name = "maskedDocumento";
            this.maskedDocumento.Size = new System.Drawing.Size(196, 30);
            this.maskedDocumento.TabIndex = 31;
            this.maskedDocumento.Click += new System.EventHandler(this.maskedDocumento_Click);
            this.maskedDocumento.Enter += new System.EventHandler(this.maskedDocumento_Enter);
            // 
            // radioCPF
            // 
            this.radioCPF.AutoSize = true;
            this.radioCPF.Enabled = false;
            this.radioCPF.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCPF.Location = new System.Drawing.Point(771, 79);
            this.radioCPF.Name = "radioCPF";
            this.radioCPF.Size = new System.Drawing.Size(61, 27);
            this.radioCPF.TabIndex = 30;
            this.radioCPF.TabStop = true;
            this.radioCPF.Text = "CPF";
            this.radioCPF.UseVisualStyleBackColor = true;
            this.radioCPF.CheckedChanged += new System.EventHandler(this.radioCPF_CheckedChanged);
            // 
            // radioCNPJ
            // 
            this.radioCNPJ.AutoSize = true;
            this.radioCNPJ.Enabled = false;
            this.radioCNPJ.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCNPJ.Location = new System.Drawing.Point(694, 79);
            this.radioCNPJ.Name = "radioCNPJ";
            this.radioCNPJ.Size = new System.Drawing.Size(71, 27);
            this.radioCNPJ.TabIndex = 29;
            this.radioCNPJ.TabStop = true;
            this.radioCNPJ.Text = "CNPJ";
            this.radioCNPJ.UseVisualStyleBackColor = true;
            this.radioCNPJ.CheckedChanged += new System.EventHandler(this.radioCNPJ_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "Gerenciar Clientes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::FrmPrincipal.Properties.Resources.icons8_peercoin_50__1_;
            this.pictureBox1.Location = new System.Drawing.Point(1000, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(124, 287);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(279, 30);
            this.txtEmail.TabIndex = 3;
            // 
            // txtEndereco
            // 
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Location = new System.Drawing.Point(125, 198);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(431, 30);
            this.txtEndereco.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(125, 112);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(431, 30);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Enabled = false;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(121, 86);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(61, 23);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Enabled = false;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(120, 260);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 23);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Enabled = false;
            this.lblEndereco.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(121, 172);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(85, 23);
            this.lblEndereco.TabIndex = 3;
            this.lblEndereco.Text = "Endereço:";
            // 
            // button1
            // 
            this.button1.AccessibleName = "Salvar";
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.button1.FlatAppearance.BorderSize = 10;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::FrmPrincipal.Properties.Resources.icons8_add_24;
            this.button1.Location = new System.Drawing.Point(451, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 39);
            this.button1.TabIndex = 16;
            this.button1.Text = "Novo";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.AccessibleName = "Editar";
            this.btnEditar.BackColor = System.Drawing.Color.Gold;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnEditar.FlatAppearance.BorderSize = 2;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Image = global::FrmPrincipal.Properties.Resources.icons8_edit_24;
            this.btnEditar.Location = new System.Drawing.Point(729, 379);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(132, 39);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AccessibleName = "Salvar";
            this.btnSalvar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnSalvar.FlatAppearance.BorderSize = 10;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.Image = global::FrmPrincipal.Properties.Resources.icons8_save_24;
            this.btnSalvar.Location = new System.Drawing.Point(591, 379);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(132, 39);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.AccessibleName = "Deletar";
            this.btnDeletar.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnDeletar.FlatAppearance.BorderSize = 2;
            this.btnDeletar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeletar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.ForeColor = System.Drawing.Color.Black;
            this.btnDeletar.Image = global::FrmPrincipal.Properties.Resources.icons8_trash_24;
            this.btnDeletar.Location = new System.Drawing.Point(867, 378);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(132, 40);
            this.btnDeletar.TabIndex = 13;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // button2
            // 
            this.button2.AccessibleName = "Salvar";
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.button2.FlatAppearance.BorderSize = 10;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = global::FrmPrincipal.Properties.Resources.icons8_update_left_rotation_24;
            this.button2.Location = new System.Drawing.Point(1203, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 39);
            this.button2.TabIndex = 17;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmGerenciarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1429, 774);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.gridClientes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnDeletar);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGerenciarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Fornecedores";
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView gridClientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.MaskedTextBox maskedDocumento;
        private System.Windows.Forms.RadioButton radioCPF;
        private System.Windows.Forms.RadioButton radioCNPJ;
        private System.Windows.Forms.Label lblMsgDocumento;
        private System.Windows.Forms.MaskedTextBox maskedTelefone;
        private System.Windows.Forms.Label lblMsgTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblMsgEmail;
        private System.Windows.Forms.Label lblMsgNome;
        private System.Windows.Forms.Label lblMsgEndereco;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}