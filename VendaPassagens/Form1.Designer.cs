namespace VendaPassagens
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblUsuario;
        private Label lblSenha;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Button btnLogin;
        private Label lblTitulo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            lblUsuario = new Label();
            lblSenha = new Label();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            btnLogin = new Button();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(81, 98);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(62, 20);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuário:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(91, 142);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(52, 20);
            lblSenha.TabIndex = 1;
            lblSenha.Text = "Senha:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(149, 95);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(207, 27);
            txtUsuario.TabIndex = 2;
            txtUsuario.Text = "admin";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(149, 139);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(207, 27);
            txtSenha.TabIndex = 3;
            txtSenha.Text = "1234";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(149, 187);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(207, 38);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(81, 29);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(301, 38);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Venda de Passagens";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 273);
            Controls.Add(lblTitulo);
            Controls.Add(btnLogin);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(lblSenha);
            Controls.Add(lblUsuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - Venda de Passagens";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
    }
}