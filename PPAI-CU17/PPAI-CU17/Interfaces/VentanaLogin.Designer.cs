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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaLogin));
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            labelUsuario = new Label();
            labelPassword = new Label();
            btnLogin = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(169, 133);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(241, 23);
            txtUsuario.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(169, 189);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(241, 23);
            txtPassword.TabIndex = 1;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Cascadia Code", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelUsuario.Location = new Point(60, 129);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(120, 27);
            labelUsuario.TabIndex = 2;
            labelUsuario.Text = "Usuario: ";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Cascadia Mono", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.Location = new Point(24, 185);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(156, 27);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Contraseña: ";
            labelPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LightSteelBlue;
            btnLogin.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            btnLogin.Location = new Point(160, 268);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(117, 57);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(178, 60);
            label1.Name = "label1";
            label1.Size = new Size(89, 32);
            label1.TabIndex = 5;
            label1.Text = "LOGIN";
            // 
            // VentanaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(450, 417);
            Controls.Add(label1);
            Controls.Add(txtUsuario);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(labelPassword);
            Controls.Add(labelUsuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VentanaLogin";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label label1;
    }
}