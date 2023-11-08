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
        // Esta clase se corresponde a la interfaz que inicia el caso de uso, es decir, la que nos da los datos de la llamada
        // Contiene todos los datos hardcodeados para iniciar el flujo descripto en el caso de uso
        public void registrarRespuestaOperador()
        {

            // Datos de prueba 


            //  Inicializacion de Validaciones
            Validacion validacionSubOpcionCantidadHijos = new Validacion("Ingrese la cantidad de hijos: ", "Cantidad de hijos");
            
            /*
            Validacion validacionSubOpcionFecha = new Validacion("Ingrese su fecha de nacimiento dd/mm/aaaa", "Fecha Nacimiento");
            Validacion validacionSubOpcionCantidadHijos = new Validacion("Ingrese su codigo postal: ", "Codigo postal");
            */

            // Informacion del cliente

            InformacionCliente infoClienteCp = new InformacionCliente("3", validacionSubOpcionCantidadHijos);
           
            /*
            InformacionCliente infoClienteFecha = new InformacionCliente("12/10/12", validacionSubOpcionFecha);
            InformacionCliente infoClienteCantHijos = new InformacionCliente("5200", validacionSubOpcionCp);
            */

            // Cliente
            Cliente cliente = new Cliente("Juan Roman Riquelme", "1212121210", "1010101010");
            cliente.agregarInfo(infoClienteCp);
            
            /*
            cliente.agregarInfo(infoClienteFecha);
            cliente.agregarInfo(infoClienteCp);
            */

            // Subopcion
            SubOpcion subOpcionSeleccionada = new SubOpcion("Si cuenta con los datos de la tarjeta marque 1", 1);
            subOpcionSeleccionada.agregarValidacion(validacionSubOpcionCantidadHijos);
            
            /*
            subOpcionSeleccionada.agregarValidacion(validacionSubOpcionFecha);
            subOpcionSeleccionada.agregarValidacion(validacionSubOpcionCp);
            */


            // Opcion
            Opcion opcionSeleccionada = new Opcion("Si cuenta con los datos de la tarjeta marque 1\nSi no cuenta con los datos de la tarjeta marque 2\nSi desea comunicarse con un responsable de atencion al cliente marque 3\n Si desea finalizar la llamada marque 4 ",
                "Si desea informar un robo y solicitar una nueva tarjeta marque 1", "Solicitar nueva tarjeta", 1);
            opcionSeleccionada.agregarSubopcion(subOpcionSeleccionada);

            // Categoria
            Categoria categoriaOpcionSeleccionada = new Categoria("Si desea informar un robo y solicitar una nueva tarjeta marque 1\n Si desea informar un robo y anular su tarjeta marque 2\n Si desea finalizar la llamada marque 3", "Si quiere informar un robo marque 1", "Informar Robo", 1);
            categoriaOpcionSeleccionada.agregarOpcion(opcionSeleccionada);
            
                       
            // Estado (YA NO SE CREA, DEPRECADO DEL ANÁLISIS)
            // Estado iniciada = new Estado("Iniciada");

            // Llamada
            DateTime fechaHoraInicio = DateTime.Now; 

            Llamada datosLlamada = new Llamada(cliente, opcionSeleccionada, subOpcionSeleccionada, fechaHoraInicio);

            // Ventana y Controlador

            VentanaRegistrarRespuesta ventanaRegistrarRespuesta = new VentanaRegistrarRespuesta();

            ControladorRegistrarRespuesta controladorRegistrarRespuesta = new ControladorRegistrarRespuesta(datosLlamada, ventanaRegistrarRespuesta);

            // llamada al método del controlador que empieza el flujo del caso de uso

            controladorRegistrarRespuesta.registrarRespuesta();
        }

    }
}
