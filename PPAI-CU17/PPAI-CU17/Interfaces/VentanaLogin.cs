using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_CU17.Interfaces
{
    public partial class VentanaLogin : Form
    {
        // Esta clase representa la ventana inicial de logeo de los usuarios del sistema, por ahora no está implementada la verificación
        // de las credenciales del usuario
        public VentanaLogin()
        {
            InitializeComponent();
        }

        // Método que se activa en respuesta al click en el botón de login, y que instancia un objeto de clase InterfazSistema, para mostrar
        // las opciones del sistema y entrar posteriormente al caso de uso. Muestra la interfaz del sistema y oculta la ventana actual. 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            InterfazSistema interfaz = new InterfazSistema();
            interfaz.Show();
            this.Hide();
        }

        private void VentanaLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
