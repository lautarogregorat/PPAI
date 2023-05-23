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
        // Definicion de usuario y password a fines de simulacion de ingreso al sistema
        private String usuario;
        private String password;

        // Esta clase representa la ventana inicial de logeo de los usuarios del sistema, por ahora no está implementada la verificación
        // de las credenciales del usuario
        public VentanaLogin()
        {
            this.usuario = "operador";
            this.password = "operador";

            InitializeComponent();
        }

        // Método que se activa en respuesta al click en el botón de login, y que instancia un objeto de clase InterfazSistema, para mostrar
        // las opciones del sistema y entrar posteriormente al caso de uso. Muestra la interfaz del sistema y oculta la ventana actual. 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.txtPassword.Text.Equals(this.password) && (this.txtUsuario.Text.Equals(this.usuario))) {
                InterfazSistema interfaz = new InterfazSistema();
                interfaz.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Usuario incorrecto, intente otra vez", "Error de login");
            }
;
        }

        private void VentanaLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
