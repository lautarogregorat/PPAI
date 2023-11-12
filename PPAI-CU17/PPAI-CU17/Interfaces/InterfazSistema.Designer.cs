namespace PPAI_CU17.Interfaces
{
    partial class InterfazSistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazSistema));
            btnRegistrarRespuestaOperador = new Button();
            btnConsultarEncuesta = new Button();
            lblTituloSistema = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnRegistrarRespuestaOperador
            // 
            btnRegistrarRespuestaOperador.BackColor = Color.LightSteelBlue;
            btnRegistrarRespuestaOperador.Cursor = Cursors.Hand;
            btnRegistrarRespuestaOperador.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            btnRegistrarRespuestaOperador.Location = new Point(280, 116);
            btnRegistrarRespuestaOperador.Margin = new Padding(2);
            btnRegistrarRespuestaOperador.Name = "btnRegistrarRespuestaOperador";
            btnRegistrarRespuestaOperador.Size = new Size(192, 52);
            btnRegistrarRespuestaOperador.TabIndex = 0;
            btnRegistrarRespuestaOperador.Text = "Registrar respuesta de operador";
            btnRegistrarRespuestaOperador.UseVisualStyleBackColor = false;
            btnRegistrarRespuestaOperador.Click += btnRegistrarRespuestaOperador_Click;
            // 
            // btnConsultarEncuesta
            // 
            btnConsultarEncuesta.BackColor = Color.LightSteelBlue;
            btnConsultarEncuesta.Cursor = Cursors.Hand;
            btnConsultarEncuesta.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            btnConsultarEncuesta.Location = new Point(280, 179);
            btnConsultarEncuesta.Margin = new Padding(2);
            btnConsultarEncuesta.Name = "btnConsultarEncuesta";
            btnConsultarEncuesta.Size = new Size(192, 50);
            btnConsultarEncuesta.TabIndex = 1;
            btnConsultarEncuesta.Text = "Consultar encuestas";
            btnConsultarEncuesta.UseVisualStyleBackColor = false;
            btnConsultarEncuesta.Click += btnConsultarEncuesta_Click;
            // 
            // lblTituloSistema
            // 
            lblTituloSistema.AutoSize = true;
            lblTituloSistema.Font = new Font("Cascadia Mono SemiBold", 40F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTituloSistema.Location = new Point(240, 50);
            lblTituloSistema.Margin = new Padding(2, 0, 2, 0);
            lblTituloSistema.Name = "lblTituloSistema";
            lblTituloSistema.Size = new Size(304, 55);
            lblTituloSistema.TabIndex = 2;
            lblTituloSistema.Text = "SISTEMA IVR ";
            lblTituloSistema.UseCompatibleTextRendering = true;
            lblTituloSistema.Click += lblTituloSistema_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.ivrlogo;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 199);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // InterfazSistema
            // 
            AutoScaleDimensions = new SizeF(5F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(532, 295);
            Controls.Add(lblTituloSistema);
            Controls.Add(btnConsultarEncuesta);
            Controls.Add(btnRegistrarRespuestaOperador);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Pixel);
            ForeColor = Color.FromArgb(0, 0, 64);
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "InterfazSistema";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InterfazSistema";
            Load += InterfazSistema_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrarRespuestaOperador;
        private Button btnConsultarEncuesta;
        private Label lblTituloSistema;
        private PictureBox pictureBox1;
    }
}