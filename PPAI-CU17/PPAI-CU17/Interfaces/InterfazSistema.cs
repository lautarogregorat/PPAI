using PPAI_CU17.BaseDeDatos;
using PPAI_CU17.Controladores;
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
    public partial class InterfazSistema : Form
    {
        public PPAIContext? dbContext;
        // Esta clase representa la ventana del sistema, de donde accedemos a las opciones para el mismo, el resto de opciones no está
        // implementado, solamente el caso de uso registrar operador 
        public InterfazSistema(PPAIContext? _dbContext)
        {
            this.dbContext = _dbContext;
            InitializeComponent();
        }

        // Método que se activa al detectar un click en el botón de registrar respuesta de operador, y que crea una nueva instancia
        // de la clase InterfazIVR, enviandole el mensaje correspondiente al método para iniciar el flujo del caso de uso. 
        // Después oculta la ventana del sistema.
        private void btnRegistrarRespuestaOperador_Click(object sender, EventArgs e)
        {
            InterfazIVR interfazIVR = new InterfazIVR();
            interfazIVR.registrarRespuestaOperador(dbContext);
            this.Hide();
        }

        private void InterfazSistema_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultarEncuesta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad no implementada en XeneiTech...", "Mensaje del sistema");
        }

        private void lblTituloSistema_Click(object sender, EventArgs e)
        {

        }
    }
}
