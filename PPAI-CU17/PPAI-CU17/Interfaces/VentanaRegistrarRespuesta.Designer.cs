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
            listValidaciones2 = new CheckedListBox();
            SuspendLayout();
            // 
            // listValidaciones2
            // 
            listValidaciones2.FormattingEnabled = true;
            listValidaciones2.Location = new Point(297, 179);
            listValidaciones2.Name = "listValidaciones2";
            listValidaciones2.Size = new Size(120, 94);
            listValidaciones2.TabIndex = 0;
            // 
            // VentanaRegistrarRespuesta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listValidaciones2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VentanaRegistrarRespuesta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VentanaRegistrarRespuesta";
            Load += VentanaRegistrarRespuesta_Load;
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox listValidaciones2;
    }
}