namespace FrmPrincipal.cadastrar
{
    partial class FrmCadastrarFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarFornecedor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.maskedTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblMsgTelefone = new System.Windows.Forms.Label();
            this.lblMsgEmail = new System.Windows.Forms.Label();
            this.maskedTextBoxDocumento = new System.Windows.Forms.MaskedTextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMsgTipoFornecimento = new System.Windows.Forms.Label();
            this.lblMsgDocumento = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.cmbTipoFornecimento = new System.Windows.Forms.ComboBox();
            this.lblMsgNome = new System.Windows.Forms.Label();
            this.lblMsgEndereco = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.maskedTelefone);
            this.panel1.Controls.Add(this.lblMsgTelefone);
            this.panel1.Controls.Add(this.lblMsgEmail);
            this.panel1.Controls.Add(this.maskedTextBoxDocumento);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblMsgTipoFornecimento);
            this.panel1.Controls.Add(this.lblMsgDocumento);
            this.panel1.Controls.Add(this.txtEndereco);
            this.panel1.Controls.Add(this.cmbTipoFornecimento);
            this.panel1.Controls.Add(this.lblMsgNome);
            this.panel1.Controls.Add(this.lblMsgEndereco);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(271, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 621);
            this.panel1.TabIndex = 9;
            // 
            // maskedTelefone
            // 
            this.maskedTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTelefone.Location = new System.Drawing.Point(277, 436);
            this.maskedTelefone.Mask = "(99) 0000-0000";
            this.maskedTelefone.Name = "maskedTelefone";
            this.maskedTelefone.Size = new System.Drawing.Size(196, 30);
            this.maskedTelefone.TabIndex = 31;
            this.maskedTelefone.Click += new System.EventHandler(this.maskedTelefone_Click);
            this.maskedTelefone.Enter += new System.EventHandler(this.maskedTelefone_Enter);
            // 
            // lblMsgTelefone
            // 
            this.lblMsgTelefone.AutoSize = true;
            this.lblMsgTelefone.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgTelefone.ForeColor = System.Drawing.Color.Red;
            this.lblMsgTelefone.Location = new System.Drawing.Point(274, 470);
            this.lblMsgTelefone.Name = "lblMsgTelefone";
            this.lblMsgTelefone.Size = new System.Drawing.Size(200, 17);
            this.lblMsgTelefone.TabIndex = 30;
            this.lblMsgTelefone.Text = "O campo Telefone é obrigatório.";
            // 
            // lblMsgEmail
            // 
            this.lblMsgEmail.AutoSize = true;
            this.lblMsgEmail.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgEmail.ForeColor = System.Drawing.Color.Red;
            this.lblMsgEmail.Location = new System.Drawing.Point(30, 374);
            this.lblMsgEmail.Name = "lblMsgEmail";
            this.lblMsgEmail.Size = new System.Drawing.Size(192, 17);
            this.lblMsgEmail.TabIndex = 29;
            this.lblMsgEmail.Text = "O Email fornecido não é válido.";
            // 
            // maskedTextBoxDocumento
            // 
            this.maskedTextBoxDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBoxDocumento.Enabled = false;
            this.maskedTextBoxDocumento.Location = new System.Drawing.Point(33, 437);
            this.maskedTextBoxDocumento.Name = "maskedTextBoxDocumento";
            this.maskedTextBoxDocumento.Size = new System.Drawing.Size(196, 30);
            this.maskedTextBoxDocumento.TabIndex = 28;
            this.maskedTextBoxDocumento.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxDocumento_MaskInputRejected);
            this.maskedTextBoxDocumento.Click += new System.EventHandler(this.maskedTextBoxDocumento_Click);
            this.maskedTextBoxDocumento.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTextBoxDocumento_MouseClick);
            this.maskedTextBoxDocumento.Enter += new System.EventHandler(this.maskedTextBoxDocumento_Enter);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(110, 404);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 27);
            this.radioButton2.TabIndex = 27;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "CPF";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(33, 404);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 27);
            this.radioButton1.TabIndex = 26;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "CNPJ";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnCadastrar.FlatAppearance.BorderSize = 2;
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(351, 515);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(129, 37);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCancelar.Location = new System.Drawing.Point(351, 562);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(129, 37);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 497);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tipo de Fornecimento:";
            // 
            // lblMsgTipoFornecimento
            // 
            this.lblMsgTipoFornecimento.AutoSize = true;
            this.lblMsgTipoFornecimento.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgTipoFornecimento.ForeColor = System.Drawing.Color.Red;
            this.lblMsgTipoFornecimento.Location = new System.Drawing.Point(30, 558);
            this.lblMsgTipoFornecimento.Name = "lblMsgTipoFornecimento";
            this.lblMsgTipoFornecimento.Size = new System.Drawing.Size(215, 17);
            this.lblMsgTipoFornecimento.TabIndex = 14;
            this.lblMsgTipoFornecimento.Text = "Selecione um tipo de fornecimento.";
            // 
            // lblMsgDocumento
            // 
            this.lblMsgDocumento.AutoSize = true;
            this.lblMsgDocumento.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgDocumento.ForeColor = System.Drawing.Color.Red;
            this.lblMsgDocumento.Location = new System.Drawing.Point(30, 470);
            this.lblMsgDocumento.Name = "lblMsgDocumento";
            this.lblMsgDocumento.Size = new System.Drawing.Size(156, 17);
            this.lblMsgDocumento.TabIndex = 21;
            this.lblMsgDocumento.Text = "O CNPJ/CPF não é válido.";
            // 
            // txtEndereco
            // 
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndereco.Location = new System.Drawing.Point(33, 256);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(440, 30);
            this.txtEndereco.TabIndex = 2;
            // 
            // cmbTipoFornecimento
            // 
            this.cmbTipoFornecimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoFornecimento.FormattingEnabled = true;
            this.cmbTipoFornecimento.Location = new System.Drawing.Point(33, 524);
            this.cmbTipoFornecimento.Name = "cmbTipoFornecimento";
            this.cmbTipoFornecimento.Size = new System.Drawing.Size(259, 31);
            this.cmbTipoFornecimento.TabIndex = 4;
            this.cmbTipoFornecimento.SelectedIndexChanged += new System.EventHandler(this.cmbTipoFornecimento_SelectedIndexChanged);
            // 
            // lblMsgNome
            // 
            this.lblMsgNome.AutoSize = true;
            this.lblMsgNome.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgNome.ForeColor = System.Drawing.Color.Red;
            this.lblMsgNome.Location = new System.Drawing.Point(30, 204);
            this.lblMsgNome.Name = "lblMsgNome";
            this.lblMsgNome.Size = new System.Drawing.Size(187, 17);
            this.lblMsgNome.TabIndex = 9;
            this.lblMsgNome.Text = "O campo Nome é obrigatório.";
            // 
            // lblMsgEndereco
            // 
            this.lblMsgEndereco.AutoSize = true;
            this.lblMsgEndereco.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgEndereco.ForeColor = System.Drawing.Color.Red;
            this.lblMsgEndereco.Location = new System.Drawing.Point(30, 289);
            this.lblMsgEndereco.Name = "lblMsgEndereco";
            this.lblMsgEndereco.Size = new System.Drawing.Size(206, 17);
            this.lblMsgEndereco.TabIndex = 11;
            this.lblMsgEndereco.Text = "O campo Endereço é obrigatório.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(273, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 23);
            this.label8.TabIndex = 24;
            this.label8.Text = "Telefone:";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(33, 341);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(440, 30);
            this.txtEmail.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(33, 171);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(440, 30);
            this.txtNome.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::FrmPrincipal.Properties.Resources.icons8_peercoin_50__1_;
            this.pictureBox1.Location = new System.Drawing.Point(229, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Fornecedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Endereço:";
            // 
            // FrmCadastrarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1053, 707);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastrarFornecedor";
            this.Text = "Cadastrar Fornecedor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMsgDocumento;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblMsgNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTipoFornecimento;
        private System.Windows.Forms.Label lblMsgTipoFornecimento;
        private System.Windows.Forms.Label lblMsgEndereco;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label lblMsgEmail;
        private System.Windows.Forms.Label lblMsgTelefone;
        private System.Windows.Forms.MaskedTextBox maskedTelefone;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDocumento;
    }
}