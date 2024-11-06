namespace FrmPrincipal
{
    partial class FrmCadastrarTarefa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarTarefa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblMsgTarefa = new System.Windows.Forms.Label();
            this.txtTituloTarefa = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescTarefa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFuncionario = new System.Windows.Forms.ComboBox();
            this.lblMsgFuncionario = new System.Windows.Forms.Label();
            this.cmbPrioridade = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMsgPrioridade = new System.Windows.Forms.Label();
            this.dtpDataLimite = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMsgDataLimite = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.lblMsgDataLimite);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtpDataLimite);
            this.panel1.Controls.Add(this.lblMsgPrioridade);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.cmbPrioridade);
            this.panel1.Controls.Add(this.lblMsgFuncionario);
            this.panel1.Controls.Add(this.cmbFuncionario);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtDescTarefa);
            this.panel1.Controls.Add(this.lblMsgTarefa);
            this.panel1.Controls.Add(this.txtTituloTarefa);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(271, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 583);
            this.panel1.TabIndex = 12;
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
            this.btnCancelar.Location = new System.Drawing.Point(401, 525);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(129, 37);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnCadastrar.FlatAppearance.BorderSize = 2;
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(401, 478);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(129, 37);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Salvar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblMsgTarefa
            // 
            this.lblMsgTarefa.AutoSize = true;
            this.lblMsgTarefa.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgTarefa.ForeColor = System.Drawing.Color.Red;
            this.lblMsgTarefa.Location = new System.Drawing.Point(30, 204);
            this.lblMsgTarefa.Name = "lblMsgTarefa";
            this.lblMsgTarefa.Size = new System.Drawing.Size(242, 17);
            this.lblMsgTarefa.TabIndex = 9;
            this.lblMsgTarefa.Text = "O campo Título da Tarefa é obrigatório.";
            // 
            // txtTituloTarefa
            // 
            this.txtTituloTarefa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTituloTarefa.Location = new System.Drawing.Point(33, 171);
            this.txtTituloTarefa.Name = "txtTituloTarefa";
            this.txtTituloTarefa.Size = new System.Drawing.Size(497, 30);
            this.txtTituloTarefa.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::FrmPrincipal.Properties.Resources.icons8_peercoin_50__1_;
            this.pictureBox1.Location = new System.Drawing.Point(255, 16);
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
            this.label1.Location = new System.Drawing.Point(206, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Tarefa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Título da Tarefa:";
            // 
            // txtDescTarefa
            // 
            this.txtDescTarefa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescTarefa.Location = new System.Drawing.Point(33, 255);
            this.txtDescTarefa.Multiline = true;
            this.txtDescTarefa.Name = "txtDescTarefa";
            this.txtDescTarefa.Size = new System.Drawing.Size(497, 82);
            this.txtDescTarefa.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Descrição da Tarefa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Funcionário Responsável:";
            // 
            // cmbFuncionario
            // 
            this.cmbFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuncionario.FormattingEnabled = true;
            this.cmbFuncionario.Location = new System.Drawing.Point(33, 387);
            this.cmbFuncionario.Name = "cmbFuncionario";
            this.cmbFuncionario.Size = new System.Drawing.Size(188, 31);
            this.cmbFuncionario.TabIndex = 3;
            // 
            // lblMsgFuncionario
            // 
            this.lblMsgFuncionario.AutoSize = true;
            this.lblMsgFuncionario.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgFuncionario.ForeColor = System.Drawing.Color.Red;
            this.lblMsgFuncionario.Location = new System.Drawing.Point(30, 424);
            this.lblMsgFuncionario.Name = "lblMsgFuncionario";
            this.lblMsgFuncionario.Size = new System.Drawing.Size(236, 17);
            this.lblMsgFuncionario.TabIndex = 14;
            this.lblMsgFuncionario.Text = "Selecione um Funcionário Responsável.";
            // 
            // cmbPrioridade
            // 
            this.cmbPrioridade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbPrioridade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridade.FormattingEnabled = true;
            this.cmbPrioridade.Items.AddRange(new object[] {
            "Alta",
            "Média",
            "Baixa"});
            this.cmbPrioridade.Location = new System.Drawing.Point(339, 387);
            this.cmbPrioridade.Name = "cmbPrioridade";
            this.cmbPrioridade.Size = new System.Drawing.Size(191, 31);
            this.cmbPrioridade.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(335, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Prioridade:";
            // 
            // lblMsgPrioridade
            // 
            this.lblMsgPrioridade.AutoSize = true;
            this.lblMsgPrioridade.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgPrioridade.ForeColor = System.Drawing.Color.Red;
            this.lblMsgPrioridade.Location = new System.Drawing.Point(336, 421);
            this.lblMsgPrioridade.Name = "lblMsgPrioridade";
            this.lblMsgPrioridade.Size = new System.Drawing.Size(196, 17);
            this.lblMsgPrioridade.TabIndex = 17;
            this.lblMsgPrioridade.Text = "Atribua uma Prioridade a tarefa.";
            // 
            // dtpDataLimite
            // 
            this.dtpDataLimite.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataLimite.Location = new System.Drawing.Point(33, 480);
            this.dtpDataLimite.Name = "dtpDataLimite";
            this.dtpDataLimite.Size = new System.Drawing.Size(142, 30);
            this.dtpDataLimite.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "Data Limite:";
            // 
            // lblMsgDataLimite
            // 
            this.lblMsgDataLimite.AutoSize = true;
            this.lblMsgDataLimite.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgDataLimite.ForeColor = System.Drawing.Color.Red;
            this.lblMsgDataLimite.Location = new System.Drawing.Point(30, 513);
            this.lblMsgDataLimite.Name = "lblMsgDataLimite";
            this.lblMsgDataLimite.Size = new System.Drawing.Size(306, 17);
            this.lblMsgDataLimite.TabIndex = 20;
            this.lblMsgDataLimite.Text = "A data limite não pode ser anterior a data de hoje.";
            // 
            // FrmCadastrarTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1053, 700);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmCadastrarTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Tarefas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblMsgTarefa;
        private System.Windows.Forms.TextBox txtTituloTarefa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMsgFuncionario;
        private System.Windows.Forms.ComboBox cmbFuncionario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescTarefa;
        private System.Windows.Forms.Label lblMsgPrioridade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPrioridade;
        private System.Windows.Forms.Label lblMsgDataLimite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDataLimite;
    }
}