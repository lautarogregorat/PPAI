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
        // Esta clase representa la ventana del sistema, de donde accedemos a las opciones para el mismo, el resto de opciones no está
        // implementado, solamente el caso de uso registrar operador 
        public InterfazSistema()
        {
            InitializeComponent();
        }

        // Método que se activa al detectar un click en el botón de registrar respuesta de operador, y que crea una nueva instancia
        // de la clase InterfazIVR, enviandole el mensaje correspondiente al método para iniciar el flujo del caso de uso. 
        // Después oculta la ventana del sistema.
        private void btnRegistrarRespuestaOperador_Click(object sender, EventArgs e)
        {
            InterfazIVR interfazIVR = new InterfazIVR();
            interfazIVR.registrarRespuestaOperador();
            this.Hide();
        }

        private void InterfazSistema_Load(object sender, EventArgs e)
        {

        }
    }
}
