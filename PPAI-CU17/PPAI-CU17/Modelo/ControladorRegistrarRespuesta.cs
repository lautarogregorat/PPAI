using PPAI_CU17.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.Modelo
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
            return this.descripcion;
        }
        public string GetRespuesta()
        {
            return this.respuesta;
        }

        public string GetAccion()
        {
            return this.accion;
        }

        public Estado GetEstadoEnCurso()
        {
            return this.estadoEnCurso;
        }

        public DateTime GetHoraActual()
        {
            return this.horaActual;
        }

        public Llamada GetDatosLlamada()
        {
            return this.datosLlamada;
        }

        public InformacionCliente GetInformacionCliente()
        {
            return this.informacionCliente;
        }

        public Estado GetEstadoFinalizado()
        {
            return this.estadoFinalizado;
        }

        public void SetDescripcion(string value)
        {
            this.descripcion = value;
        }

        public void TomarRespuesta(string value)
        {
            this.respuesta = value;
        }

        public void SetAccion(string value)
        {
            this.accion = value;
        }

        private void setEstadoEnCurso(Estado estado)
        {
            this.estadoEnCurso = estado;
        }

        public void registrarRespuesta(string respuesta)
        {
            
        }
        private void buscarEstadoEnCurso(Array Estados) 
        {
            foreach (Estado estado in Estados)
            {
                if (estado.sosEnCurso())
                {
                    this.setEstadoEnCurso(estado);
                    break;

                }
            }
        }

    }



}
