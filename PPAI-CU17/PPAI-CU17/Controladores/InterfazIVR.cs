using Microsoft.EntityFrameworkCore;
using PPAI_CU17.BaseDeDatos;
using PPAI_CU17.Interfaces;
using PPAI_CU17.Modelo;
using PPAI_CU17.Modelo.Estados.Estado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.Controladores
{
    internal class InterfazIVR
    {
        PPAIContext? dbContext;
        // Esta clase se corresponde a la interfaz que inicia el caso de uso, es decir, la que nos da los datos de la llamada
        // Levanta todos los datos desde la BD para pasarlo como parámetro al Controlador del C.U. de Registrar Respuesta, con los datos de la llamada y seteando el estado actual "Iniciada"
        public void registrarRespuestaOperador(PPAIContext dbContext)
        {
            this.dbContext = dbContext;

            Llamada datosLlamada = dbContext.Llamadas
                .Include(l => l.opcionSeleccionada)
                    .ThenInclude(o => o.categoria)
                .Include(l => l.subopcionSeleccionada)
                    .ThenInclude(s => s.validaciones)
                .Include(l => l.cliente)
                    .ThenInclude(c => c.info)
                        .ThenInclude(i => i.validacion)
                .Include(l => l.cambioDeEstado)
                    .ThenInclude(ce => ce.estado)
                .FirstOrDefault();

            Iniciada estadoIniciada = new Iniciada();
            datosLlamada.setEstadoActual(estadoIniciada);

            // Ventana y Controlador

            VentanaRegistrarRespuesta ventanaRegistrarRespuesta = new VentanaRegistrarRespuesta();

            ControladorRegistrarRespuesta controladorRegistrarRespuesta = new ControladorRegistrarRespuesta(datosLlamada, ventanaRegistrarRespuesta, dbContext);

            // llamada al método del controlador que empieza el flujo del caso de uso

            controladorRegistrarRespuesta.registrarRespuesta();
        }

    }
}
