﻿namespace FrmPrincipal.cadastrar
{
    partial class FrmCadastrarInsumo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarInsumo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMsgValor = new System.Windows.Forms.Label();
            this.numericQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMsgQuantidade = new System.Windows.Forms.Label();
            this.numericValor = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbUnidadeMedida = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMsgCategoria = new System.Windows.Forms.Label();
            this.lblMsgUnidadeMedida = new System.Windows.Forms.Label();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.lblMsgNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.lblMsgValor);
            this.panel1.Controls.Add(this.numericQuantidade);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblMsgQuantidade);
            this.panel1.Controls.Add(this.numericValor);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.txtDescricao);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbUnidadeMedida);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblMsgCategoria);
            this.panel1.Controls.Add(this.lblMsgUnidadeMedida);
            this.panel1.Controls.Add(this.cmbFornecedor);
            this.panel1.Controls.Add(this.lblMsgNome);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(271, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 635);
            this.panel1.TabIndex = 10;
            // 
            // lblMsgValor
            // 
            this.lblMsgValor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgValor.ForeColor = System.Drawing.Color.Red;
            this.lblMsgValor.Location = new System.Drawing.Point(355, 376);
            this.lblMsgValor.Name = "lblMsgValor";
            this.lblMsgValor.Size = new System.Drawing.Size(118, 39);
            this.lblMsgValor.TabIndex = 37;
            this.lblMsgValor.Text = "O valor deve ser maior que zero.";
            // 
            // numericQuantidade
            // 
            this.numericQuantidade.Location = new System.Drawing.Point(33, 343);
            this.numericQuantidade.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericQuantidade.Name = "numericQuantidade";
            this.numericQuantidade.Size = new System.Drawing.Size(100, 30);
            this.numericQuantidade.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 23);
            this.label8.TabIndex = 24;
            this.label8.Text = "Quantidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(354, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 23);
            this.label5.TabIndex = 36;
            this.label5.Text = "Valor Unitário:";
            // 
            // lblMsgQuantidade
            // 
            this.lblMsgQuantidade.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgQuantidade.ForeColor = System.Drawing.Color.Red;
            this.lblMsgQuantidade.Location = new System.Drawing.Point(30, 377);
            this.lblMsgQuantidade.Name = "lblMsgQuantidade";
            this.lblMsgQuantidade.Size = new System.Drawing.Size(131, 39);
            this.lblMsgQuantidade.TabIndex = 30;
            this.lblMsgQuantidade.Text = "A quantidade deve ser maior que zero.";
            // 
            // numericValor
            // 
            this.numericValor.Location = new System.Drawing.Point(358, 343);
            this.numericValor.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericValor.Name = "numericValor";
            this.numericValor.Size = new System.Drawing.Size(115, 30);
            this.numericValor.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 23);
            this.label4.TabIndex = 34;
            this.label4.Text = "Descrição:";
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
            this.btnCancelar.Location = new System.Drawing.Point(194, 585);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(129, 37);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnCadastrar.FlatAppearance.BorderSize = 2;
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(194, 538);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(129, 37);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.Location = new System.Drawing.Point(33, 444);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(440, 79);
            this.txtDescricao.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(166, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "Unidade de medida:";
            // 
            // cmbUnidadeMedida
            // 
            this.cmbUnidadeMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidadeMedida.FormattingEnabled = true;
            this.cmbUnidadeMedida.Items.AddRange(new object[] {
            "Kg",
            "Litros",
            "Unidade",
            "Pacote",
            "Caixa"});
            this.cmbUnidadeMedida.Location = new System.Drawing.Point(170, 343);
            this.cmbUnidadeMedida.Name = "cmbUnidadeMedida";
            this.cmbUnidadeMedida.Size = new System.Drawing.Size(153, 31);
            this.cmbUnidadeMedida.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fornecedor:";
            // 
            // lblMsgCategoria
            // 
            this.lblMsgCategoria.AutoSize = true;
            this.lblMsgCategoria.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgCategoria.ForeColor = System.Drawing.Color.Red;
            this.lblMsgCategoria.Location = new System.Drawing.Point(30, 289);
            this.lblMsgCategoria.Name = "lblMsgCategoria";
            this.lblMsgCategoria.Size = new System.Drawing.Size(212, 17);
            this.lblMsgCategoria.TabIndex = 14;
            this.lblMsgCategoria.Text = "Selecione o Fornecedor associado.";
            this.lblMsgCategoria.Click += new System.EventHandler(this.lblMsgCategoria_Click);
            // 
            // lblMsgUnidadeMedida
            // 
            this.lblMsgUnidadeMedida.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgUnidadeMedida.ForeColor = System.Drawing.Color.Red;
            this.lblMsgUnidadeMedida.Location = new System.Drawing.Point(167, 377);
            this.lblMsgUnidadeMedida.Name = "lblMsgUnidadeMedida";
            this.lblMsgUnidadeMedida.Size = new System.Drawing.Size(156, 39);
            this.lblMsgUnidadeMedida.TabIndex = 21;
            this.lblMsgUnidadeMedida.Text = "Selecione uma unidade de medida.";
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Location = new System.Drawing.Point(33, 255);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(440, 31);
            this.cmbFornecedor.TabIndex = 4;
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
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(33, 171);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(440, 30);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
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
            this.label1.Location = new System.Drawing.Point(165, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrada de Insumo";
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
            // FrmCadastrarInsumo
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
            this.Name = "FrmCadastrarInsumo";
            this.Text = "Cadastrar Insumo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMsgQuantidade;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMsgCategoria;
        private System.Windows.Forms.Label lblMsgUnidadeMedida;
        private System.Windows.Forms.ComboBox cmbFornecedor;
        private System.Windows.Forms.Label lblMsgNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUnidadeMedida;
        private System.Windows.Forms.NumericUpDown numericQuantidade;
        private System.Windows.Forms.NumericUpDown numericValor;
        private System.Windows.Forms.Label lblMsgValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescricao;
    }
}