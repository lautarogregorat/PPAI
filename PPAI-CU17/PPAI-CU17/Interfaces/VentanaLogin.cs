using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using PPAI_CU17.BaseDeDatos;
using PPAI_CU17.Modelo;
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
        private PPAIContext? dbContext;

        // Esta clase representa la ventana inicial de logeo de los usuarios del sistema, por ahora no está implementada la verificación
        // de las credenciales del usuario
        public VentanaLogin()
        {
            this.usuario = "1";
            this.password = "1";
            InitializeComponent();
        }

        // Método que se activa en respuesta al click en el botón de login, y que instancia un objeto de clase InterfazSistema, para mostrar
        // las opciones del sistema y entrar posteriormente al caso de uso. Muestra la interfaz del sistema y oculta la ventana actual. 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.dbContext!.SaveChanges();
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

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new PPAIContext();

            // Comprueba si la base de datos ya existe
            var databaseExists = this.dbContext.Database.GetService<IRelationalDatabaseCreator>().Exists();

            // Si la base de datos no existe, crea la base de datos y las tablas
            if (!databaseExists)
            {
                this.dbContext.Database.EnsureCreated();
            }

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }
    }
}
