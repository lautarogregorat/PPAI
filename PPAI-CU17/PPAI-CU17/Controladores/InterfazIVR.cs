using PPAI_CU17.Interfaces;
using PPAI_CU17.Modelo;
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
            InformacionCliente infoCliente = new InformacionCliente("5200");
            Cliente cliente = new Cliente("Juan Roman Riquelme", "1212121210", "1010101010", infoCliente);
            Categoria categoriaOpcionSeleccionada = new Categoria("Si desea informar un robo y solicitar una nueva tarjeta marque 1\n Si desea informar un robo y anular su tarjeta marque 2\n Si desea finalizar la llamada marque 3", "Si quiere informar un robo marque 1", "Informar Robo", 1);
            Opcion opcionSeleccionada = new Opcion("Si cuenta con los datos de la tarjeta marque 1\nSi no cuenta con los datos de la tarjeta marque 2\nSi desea comunicarse con un responsable de atencion al cliente marque 3\n Si desea finalizar la llamada marque 4 ",
                "Si desea informar un robo y solicitar una nueva tarjeta marque 1", "Solicitar nueva tarjeta", 1, categoriaOpcionSeleccionada);
            Estado iniciada = new Estado("Iniciada");
            SubOpcion subOpcion = new SubOpcion("Solicitar nueva tarjeta", 10);
            VentanaRegistrarRespuesta ventanaRegistrarRespuesta = new VentanaRegistrarRespuesta();

            Llamada datosLlamada = new Llamada(cliente, opcionSeleccionada, subOpcion, iniciada, DateTime.Now);
            ControladorRegistrarRespuesta controladorRegistrarRespuesta = new ControladorRegistrarRespuesta(datosLlamada, ventanaRegistrarRespuesta);
        }

    }
}
