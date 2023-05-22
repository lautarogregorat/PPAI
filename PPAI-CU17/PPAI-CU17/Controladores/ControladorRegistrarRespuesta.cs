using PPAI_CU17.Interfaces;
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
        private DateTime fechaYhoraActual;
        private Llamada datosLlamada;
        private InformacionCliente informacionCliente;
        private Estado estadoFinalizado;

        public ControladorRegistrarRespuesta(Llamada datosLlamada)
        {
            this.datosLlamada = datosLlamada;
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
            return fechaYhoraActual;
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

        // Busca entre los objetos estado la instancia "enCurso" y setea usando el método arriba definido
        private void buscarEstadoEnCurso(List<Estado> Estados)
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

        private void actualizarEstadoLlamada()
        {
            this.datosLlamada.enCurso(estadoEnCurso, this.fechaYhoraActual);
        }

        private string buscarDatosLlamada()
        {
            String infoLlamada = "";
            infoLlamada.Concat(this.datosLlamada.getCliente());
            infoLlamada.Concat(this.datosLlamada.getSubOpcion());
            infoLlamada.Concat(this.datosLlamada.getOpcionyCategoria());
            infoLlamada.Concat(this.datosLlamada.getValidaciones());

            return infoLlamada;
        }

        // Obtiene y actualiza la fechaYhoraActual
        private void obtenerFechaYhoraActual()
        {
            DateTime fechaYhoraActualizada = DateTime.Now;
            this.fechaYhoraActual = fechaYhoraActualizada;
        }

        public void registrarRespuesta(Llamada llamadaIniciada)
        {
            List<Estado> estados = new List<Estado>();
            string[] stringsEstados = new string[9];

            stringsEstados.Append("Iniciada");
            stringsEstados.Append("EnCurso");
            stringsEstados.Append("Finalizada");
            stringsEstados.Append("Cancelada");
            stringsEstados.Append("PendienteEscucha");
            stringsEstados.Append("Correcta");
            stringsEstados.Append("Observada");
            stringsEstados.Append("Descartada");
            stringsEstados.Append("Encuestada");

            foreach (string str in stringsEstados)
            {
                Estado est = new Estado(str);
                estados.Add(est);
            }

            this.buscarEstadoEnCurso(estados);
            this.obtenerFechaYhoraActual();
            this.actualizarEstadoLlamada();

            this.datosLlamada.enCurso(this.estadoEnCurso, this.fechaYhoraActual);

            string infoLlamada = this.buscarDatosLlamada();

            VentanaRegistrarRespuesta ventanaRegistrarRespuesta = new VentanaRegistrarRespuesta();

            ventanaRegistrarRespuesta.habilitar();

            ventanaRegistrarRespuesta.mostrarDatosLlamada(infoLlamada);


        }


        private void setEstadoFinalizado(Estado estado)
        {
            estadoFinalizado = estado;
        }

        // Busca entre los objetos estado la instancia "Finalizado" y setea usando el método arriba definido
        public void buscarEstadoFinalizado(List<Estado> Estados)
        {

            foreach (Estado estado in Estados)
            {
                if (estado.esFinalizada())
                {
                    setEstadoFinalizado(estado);
                    break;

                }
            }
        }

        public void registrarFinDeLlamada(Estado estadoFinalizado)
        {
            // Será la FechaHoraInicio del CambiodeEstado 
            this.datosLlamada.finalizar(estadoFinalizado, this.fechaYhoraActual);

        }


    }

}
