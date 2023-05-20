namespace PPAI_CU17.Interfaces
{
    partial class VentanaLogin
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
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            labelUsuario = new Label();
            labelPassword = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(112, 133);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(244, 23);
            txtUsuario.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(112, 187);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(244, 23);
            txtPassword.TabIndex = 1;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(44, 133);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(53, 15);
            labelUsuario.TabIndex = 2;
            labelUsuario.Text = "Usuario: ";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(24, 187);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(73, 15);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Contraseña: ";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(155, 256);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(117, 50);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // VentanaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 450);
            Controls.Add(btnLogin);
            Controls.Add(labelPassword);
            Controls.Add(labelUsuario);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Name = "VentanaLogin";
            Text = "Login - Sistema IVR";
            Load += VentanaLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Label labelUsuario;
        private Label labelPassword;
        private Button btnLogin;
    }
}