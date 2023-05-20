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
            datosLlamada = new Panel();
            lblNombreCliente = new Label();
            lblCategoria = new Label();
            lblOpcionSeleccionada = new Label();
            lblSubopcionSeleccionada = new Label();
            txtNombreCliente = new TextBox();
            txtCategoriaSeleccionada = new TextBox();
            txtOpcionSeleccionada = new TextBox();
            txtSubopcionSeleccionada = new TextBox();
            datosLlamada.SuspendLayout();
            SuspendLayout();
            // 
            // datosLlamada
            // 
            datosLlamada.Controls.Add(txtSubopcionSeleccionada);
            datosLlamada.Controls.Add(txtOpcionSeleccionada);
            datosLlamada.Controls.Add(txtCategoriaSeleccionada);
            datosLlamada.Controls.Add(txtNombreCliente);
            datosLlamada.Controls.Add(lblSubopcionSeleccionada);
            datosLlamada.Controls.Add(lblOpcionSeleccionada);
            datosLlamada.Controls.Add(lblCategoria);
            datosLlamada.Controls.Add(lblNombreCliente);
            datosLlamada.Location = new Point(101, 39);
            datosLlamada.Name = "datosLlamada";
            datosLlamada.Size = new Size(573, 172);
            datosLlamada.TabIndex = 0;
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Location = new Point(59, 23);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(116, 15);
            lblNombreCliente.TabIndex = 0;
            lblNombreCliente.Text = "Nombre del Cliente: ";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(40, 58);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(135, 15);
            lblCategoria.TabIndex = 1;
            lblCategoria.Text = "Categoria seleccionada: ";
            // 
            // lblOpcionSeleccionada
            // 
            lblOpcionSeleccionada.AutoSize = true;
            lblOpcionSeleccionada.Location = new Point(52, 94);
            lblOpcionSeleccionada.Name = "lblOpcionSeleccionada";
            lblOpcionSeleccionada.Size = new Size(123, 15);
            lblOpcionSeleccionada.TabIndex = 2;
            lblOpcionSeleccionada.Text = "Opcion seleccionada: ";
            // 
            // lblSubopcionSeleccionada
            // 
            lblSubopcionSeleccionada.AutoSize = true;
            lblSubopcionSeleccionada.Location = new Point(34, 129);
            lblSubopcionSeleccionada.Name = "lblSubopcionSeleccionada";
            lblSubopcionSeleccionada.Size = new Size(141, 15);
            lblSubopcionSeleccionada.TabIndex = 3;
            lblSubopcionSeleccionada.Text = "Subopcion seleccionada: ";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Enabled = false;
            txtNombreCliente.Location = new Point(203, 20);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(333, 23);
            txtNombreCliente.TabIndex = 4;
            // 
            // txtCategoriaSeleccionada
            // 
            txtCategoriaSeleccionada.Enabled = false;
            txtCategoriaSeleccionada.Location = new Point(203, 55);
            txtCategoriaSeleccionada.Name = "txtCategoriaSeleccionada";
            txtCategoriaSeleccionada.Size = new Size(333, 23);
            txtCategoriaSeleccionada.TabIndex = 5;
            // 
            // txtOpcionSeleccionada
            // 
            txtOpcionSeleccionada.Enabled = false;
            txtOpcionSeleccionada.Location = new Point(203, 91);
            txtOpcionSeleccionada.Name = "txtOpcionSeleccionada";
            txtOpcionSeleccionada.Size = new Size(333, 23);
            txtOpcionSeleccionada.TabIndex = 6;
            // 
            // txtSubopcionSeleccionada
            // 
            txtSubopcionSeleccionada.Enabled = false;
            txtSubopcionSeleccionada.Location = new Point(203, 126);
            txtSubopcionSeleccionada.Name = "txtSubopcionSeleccionada";
            txtSubopcionSeleccionada.Size = new Size(333, 23);
            txtSubopcionSeleccionada.TabIndex = 5;
            // 
            // VentanaRegistrarRespuesta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(datosLlamada);
            Name = "VentanaRegistrarRespuesta";
            Text = "VentanaRegistrarRespuesta";
            Load += VentanaRegistrarRespuesta_Load;
            datosLlamada.ResumeLayout(false);
            datosLlamada.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel datosLlamada;
        private TextBox txtSubopcionSeleccionada;
        private TextBox txtOpcionSeleccionada;
        private TextBox txtCategoriaSeleccionada;
        private TextBox txtNombreCliente;
        private Label lblSubopcionSeleccionada;
        private Label lblOpcionSeleccionada;
        private Label lblCategoria;
        private Label lblNombreCliente;
    }
}