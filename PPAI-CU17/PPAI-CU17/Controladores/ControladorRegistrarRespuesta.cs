using PPAI_CU17.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.Controladores
{
    public class ControladorRegistrarRespuesta
    {
        private string respuesta;
        private string descripcion;
        private string accion;
        private Estado estadoEnCurso;
        private DateTime horaActual;
        private Llamada datosLlamada;
        private InformacionCliente informacionCliente;
        private Estado estadoFinalizado;

        public ControladorRegistrarRespuesta(string respuesta, string descripcion, string accion, Estado estadoEnCurso, DateTime horaActual, Llamada datosLlamada,
        InformacionCliente informacionCliente, Estado estadoFinalizado)
        {
            this.respuesta = respuesta;
            this.descripcion = descripcion;
            this.accion = accion;
            this.estadoEnCurso = estadoEnCurso;
            this.horaActual = horaActual;
            this.datosLlamada = datosLlamada;
            this.informacionCliente = informacionCliente;
            this.estadoFinalizado = estadoFinalizado;
        }

        public string getDescripcion()
        {
            return descripcion;
        }
        public string getRespuesta()
        {
            return respuesta;
        }

        public string getAccion()
        {
            return accion;
        }

        public Estado getEstadoEnCurso()
        {
            return estadoEnCurso;
        }

        public DateTime getHoraActual()
        {
            return horaActual;
        }

        public Llamada getDatosLlamada()
        {
            return datosLlamada;
        }

        public InformacionCliente getInformacionCliente()
        {
            return informacionCliente;
        }

        public Estado getEstadoFinalizado()
        {
            return estadoFinalizado;
        }

        public void setDescripcion(string value)
        {
            descripcion = value;
        }

        public void tomarRespuesta(string value)
        {
            respuesta = value;
        }

        public void setAccion(string value)
        {
            accion = value;
        }

        private void setEstadoEnCurso(Estado estado)
        {
            estadoEnCurso = estado;
        }

        public void registrarRespuesta(Llamada llamadaIniciada, Cliente clienteIdentificado, Opcion opcionIdentificada, Subopcion subopcionIdentificada)
        {

        }
        private void buscarEstadoEnCurso(Array Estados)
        {
            foreach (Estado estado in Estados)
            {
                if (estado.sosEnCurso())
                {
                    setEstadoEnCurso(estado);
                    break;

                }
            }
        }

        private void actualizarEstadoLlamada(Llamada llamadaIdentificada)
        {
            llamadaIdentificada.enCurso(estadoEnCurso);
        }

        private void buscarDatosLlamada(Llamada llamadaIdentificada, Cliente cliente, Opcion opcion, Categoria categoria, Subopcion subopcion)
        {
            llamadaIdentificada.getCliente();
            llamadaIdentificada.getOpcionyCategoria(opcion, categoria);
            llamadaIdentificada.getSubOpcion(subopcion);
            llamadaIdentificada.getValidaciones(subopcion);
        }
    }



}
