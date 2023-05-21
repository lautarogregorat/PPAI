using PPAI_CU17.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.Controladores
{
    internal class InterfazIVR
    {
        public void registrarRespuestaOperador()
        {
            VentanaRegistrarRespuesta ventanaRegistrarRespuesta = new VentanaRegistrarRespuesta();
            ventanaRegistrarRespuesta.habilitar();
            ventanaRegistrarRespuesta.mostrarDatosLlamada("Fede","Informar un robo y solicitar una tarjeta","Si cuenta con los datos de la tarjeta", "Informar un robo");
        }

    }
}
