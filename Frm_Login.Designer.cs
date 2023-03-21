namespace PiTrabalho
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.PnlLogin = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LblCopy = new System.Windows.Forms.Label();
            this.PnlCadastro = new System.Windows.Forms.Panel();
            this.LinkCadastro = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.Lblsenha = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.PnlSenha = new System.Windows.Forms.Panel();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.PanelUserName = new System.Windows.Forms.Panel();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblLogin = new System.Windows.Forms.Label();
            this.PnlLogin.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PnlCadastro.SuspendLayout();
            this.PnlSenha.SuspendLayout();
            this.PanelUserName.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlLogin
            // 
            this.PnlLogin.Controls.Add(this.PnlCadastro);
            this.PnlLogin.ForeColor = System.Drawing.Color.White;
            this.PnlLogin.Location = new System.Drawing.Point(335, 36);
            this.PnlLogin.Margin = new System.Windows.Forms.Padding(0);
            this.PnlLogin.Name = "PnlLogin";
            this.PnlLogin.Size = new System.Drawing.Size(453, 463);
            this.PnlLogin.TabIndex = 0;
            this.PnlLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.LblCopy);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Location = new System.Drawing.Point(-5, 36);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 463);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(77, 180);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(263, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // LblCopy
            // 
            this.LblCopy.AutoSize = true;
            this.LblCopy.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCopy.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblCopy.Location = new System.Drawing.Point(7, 444);
            this.LblCopy.Name = "LblCopy";
            this.LblCopy.Size = new System.Drawing.Size(220, 17);
            this.LblCopy.TabIndex = 2;
            this.LblCopy.Text = "®  2023 Todos os direitos reservados";
            // 
            // PnlCadastro
            // 
            this.PnlCadastro.Controls.Add(this.LinkCadastro);
            this.PnlCadastro.Controls.Add(this.label2);
            this.PnlCadastro.Controls.Add(this.BtnLogin);
            this.PnlCadastro.Controls.Add(this.Lblsenha);
            this.PnlCadastro.Controls.Add(this.LblEmail);
            this.PnlCadastro.Controls.Add(this.PnlSenha);
            this.PnlCadastro.Controls.Add(this.PanelUserName);
            this.PnlCadastro.Controls.Add(this.LblLogin);
            this.PnlCadastro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlCadastro.Location = new System.Drawing.Point(0, 0);
            this.PnlCadastro.Name = "PnlCadastro";
            this.PnlCadastro.Size = new System.Drawing.Size(453, 463);
            this.PnlCadastro.TabIndex = 8;
            this.PnlCadastro.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlCadastro_Paint);
            // 
            // LinkCadastro
            // 
            this.LinkCadastro.AutoSize = true;
            this.LinkCadastro.Location = new System.Drawing.Point(204, 402);
            this.LinkCadastro.Name = "LinkCadastro";
            this.LinkCadastro.Size = new System.Drawing.Size(90, 21);
            this.LinkCadastro.TabIndex = 15;
            this.LinkCadastro.TabStop = true;
            this.LinkCadastro.Text = "Cadastrar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(155, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Não Possui uma conta?";
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Location = new System.Drawing.Point(147, 325);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(207, 35);
            this.BtnLogin.TabIndex = 13;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            // 
            // Lblsenha
            // 
            this.Lblsenha.AutoSize = true;
            this.Lblsenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblsenha.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Lblsenha.Location = new System.Drawing.Point(100, 244);
            this.Lblsenha.Name = "Lblsenha";
            this.Lblsenha.Size = new System.Drawing.Size(59, 21);
            this.Lblsenha.TabIndex = 12;
            this.Lblsenha.Text = "Senha";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblEmail.Location = new System.Drawing.Point(100, 139);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(51, 21);
            this.LblEmail.TabIndex = 10;
            this.LblEmail.Text = "Email";
            // 
            // PnlSenha
            // 
            this.PnlSenha.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PnlSenha.Controls.Add(this.TxtSenha);
            this.PnlSenha.Location = new System.Drawing.Point(104, 268);
            this.PnlSenha.Name = "PnlSenha";
            this.PnlSenha.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.PnlSenha.Size = new System.Drawing.Size(300, 30);
            this.PnlSenha.TabIndex = 11;
            // 
            // TxtSenha
            // 
            this.TxtSenha.BackColor = System.Drawing.Color.White;
            this.TxtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSenha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtSenha.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.TxtSenha.Location = new System.Drawing.Point(0, 0);
            this.TxtSenha.Multiline = true;
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(300, 27);
            this.TxtSenha.TabIndex = 0;
            // 
            // PanelUserName
            // 
            this.PanelUserName.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PanelUserName.Controls.Add(this.TxtEmail);
            this.PanelUserName.Location = new System.Drawing.Point(104, 163);
            this.PanelUserName.Name = "PanelUserName";
            this.PanelUserName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.PanelUserName.Size = new System.Drawing.Size(300, 30);
            this.PanelUserName.TabIndex = 9;
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.Color.White;
            this.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtEmail.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.TxtEmail.Location = new System.Drawing.Point(0, 0);
            this.TxtEmail.Multiline = true;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(300, 27);
            this.TxtEmail.TabIndex = 0;
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblLogin.Location = new System.Drawing.Point(49, 38);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(74, 28);
            this.LblLogin.TabIndex = 8;
            this.LblLogin.Text = "Login";
            // 
            // Frm_Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(789, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PnlLogin);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.PnlLogin.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PnlCadastro.ResumeLayout(false);
            this.PnlCadastro.PerformLayout();
            this.PnlSenha.ResumeLayout(false);
            this.PnlSenha.PerformLayout();
            this.PanelUserName.ResumeLayout(false);
            this.PanelUserName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LblCopy;
        private System.Windows.Forms.Panel PnlCadastro;
        private System.Windows.Forms.LinkLabel LinkCadastro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label Lblsenha;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Panel PnlSenha;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Panel PanelUserName;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblLogin;
    }
}

