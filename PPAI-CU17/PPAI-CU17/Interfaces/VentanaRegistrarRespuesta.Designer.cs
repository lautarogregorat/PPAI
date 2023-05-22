namespace PPAI_CU17.Interfaces
{
    partial class VentanaRegistrarRespuesta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaRegistrarRespuesta));
            lblLlamada = new Label();
            txtDatosLlamada = new TextBox();
            SuspendLayout();
            // 
            // lblLlamada
            // 
            lblLlamada.AutoSize = true;
            lblLlamada.Location = new Point(69, 33);
            lblLlamada.Name = "lblLlamada";
            lblLlamada.Size = new Size(107, 15);
            lblLlamada.TabIndex = 0;
            lblLlamada.Text = "Datos de Llamada: ";
            // 
            // txtDatosLlamada
            // 
            txtDatosLlamada.BackColor = Color.Gray;
            txtDatosLlamada.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDatosLlamada.ForeColor = Color.Black;
            txtDatosLlamada.Location = new Point(193, 30);
            txtDatosLlamada.Multiline = true;
            txtDatosLlamada.Name = "txtDatosLlamada";
            txtDatosLlamada.ReadOnly = true;
            txtDatosLlamada.Size = new Size(559, 325);
            txtDatosLlamada.TabIndex = 1;
            // 
            // VentanaRegistrarRespuesta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDatosLlamada);
            Controls.Add(lblLlamada);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VentanaRegistrarRespuesta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar respuesta de operador";
            Load += VentanaRegistrarRespuesta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLlamada;
        private TextBox txtDatosLlamada;
    }
}