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
        public InterfazSistema()
        {
            InitializeComponent();
        }

        private void btnRegistrarRespuestaOperador_Click(object sender, EventArgs e)
        {
            InterfazIVR interfazIVR = new InterfazIVR();
            interfazIVR.registrarRespuesta();
        }
    }
}
