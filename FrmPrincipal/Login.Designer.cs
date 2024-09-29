namespace FrmPrincipal
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblEntrar = new System.Windows.Forms.Label();
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.LnkEsqueceuSenha = new System.Windows.Forms.LinkLabel();
            this.LblEmail = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblEntrar
            // 
            this.LblEntrar.AutoSize = true;
            this.LblEntrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEntrar.Location = new System.Drawing.Point(414, 121);
            this.LblEntrar.Name = "LblEntrar";
            this.LblEntrar.Size = new System.Drawing.Size(77, 24);
            this.LblEntrar.TabIndex = 0;
            this.LblEntrar.Text = "ENTRAR";
            this.LblEntrar.Click += new System.EventHandler(this.LblEntrar_Click);
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.BackColor = System.Drawing.Color.FloralWhite;
            this.BtnEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEntrar.Font = new System.Drawing.Font("Calibri", 10F);
            this.BtnEntrar.Location = new System.Drawing.Point(393, 323);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(130, 37);
            this.BtnEntrar.TabIndex = 1;
            this.BtnEntrar.Text = "Entrar";
            this.BtnEntrar.UseVisualStyleBackColor = false;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUsuario.Font = new System.Drawing.Font("Calibri", 10F);
            this.TxtUsuario.Location = new System.Drawing.Point(353, 199);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(215, 28);
            this.TxtUsuario.TabIndex = 2;
            this.TxtUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LnkEsqueceuSenha
            // 
            this.LnkEsqueceuSenha.AutoSize = true;
            this.LnkEsqueceuSenha.Font = new System.Drawing.Font("Calibri", 10F);
            this.LnkEsqueceuSenha.Location = new System.Drawing.Point(351, 284);
            this.LnkEsqueceuSenha.Name = "LnkEsqueceuSenha";
            this.LnkEsqueceuSenha.Size = new System.Drawing.Size(141, 21);
            this.LnkEsqueceuSenha.TabIndex = 4;
            this.LnkEsqueceuSenha.TabStop = true;
            this.LnkEsqueceuSenha.Text = "Esqueceu a Senha?";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(278, 200);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(69, 21);
            this.LblEmail.TabIndex = 5;
            this.LblEmail.Text = "Usuário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha:";
            // 
            // TxtSenha
            // 
            this.TxtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSenha.Font = new System.Drawing.Font("Calibri", 10F);
            this.TxtSenha.Location = new System.Drawing.Point(353, 243);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '*';
            this.TxtSenha.Size = new System.Drawing.Size(215, 28);
            this.TxtSenha.TabIndex = 3;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(912, 529);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LnkEsqueceuSenha);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.BtnEntrar);
            this.Controls.Add(this.LblEntrar);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEntrar;
        private System.Windows.Forms.Button BtnEntrar;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.LinkLabel LnkEsqueceuSenha;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSenha;
    }
}

