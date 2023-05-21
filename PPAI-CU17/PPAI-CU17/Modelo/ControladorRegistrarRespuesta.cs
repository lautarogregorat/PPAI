using PPAI_CU17.Entidades;
using PPAI_CU17.Interfaces;
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
        public string getRespuesta()
        {
            return this.respuesta;
        }

        public string getAccion()
        {
            return this.accion;
        }

        public Estado getEstadoEnCurso()
        {
            return this.estadoEnCurso;
        }

        public DateTime getHoraActual()
        {
            return this.horaActual;
        }

        public Llamada getDatosLlamada()
        {
            return this.datosLlamada;
        }

        public InformacionCliente getInformacionCliente()
        {
            return this.informacionCliente;
        }

        public Estado getEstadoFinalizado()
        {
            return this.estadoFinalizado;
        }

        public void setDescripcion(string value)
        {
            this.descripcion = value;
        }

        public void tomarRespuesta(string value)
        {
            this.respuesta = value;
        }

        public void setAccion(string value)
        {
            this.accion = value;
        }

        private void setEstadoEnCurso(Estado estado)
        {
            this.estadoEnCurso = estado;
        }

        public void registrarRespuesta(/*ACA VAN LLAMADA CLIENTE OPCION Y SUBOPCION*/)
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

        private void actualizarEstadoLlamada(Llamada llamadaIdentificada) 
        {
            llamadaIdentificada.enCurso(this.estadoEnCurso);
        }

        private void buscarDatosLlamada(Llamada llamadaIdentificada, Cliente cliente, Opcion opcion, Categoria categoria, Subopcion subopcion)
        {
            llamadaIdentificada.getCliente(cliente);
            llamadaIdentificada.getOpcionyCategoria(opcion, categoria);
            llamadaIdentificada.getSubOpcion(subopcion);
            llamadaIdentificada.getValidaciones(subopcion);
            
        }

        private void validarRespuestas() 
        {


        }
        private void registrarAccionRequerida()
        {

        }

        private void buscarEstadoFinalizado()
        {

        }

        private void registrarFindeLLamada()
        {

        }


    }



}
