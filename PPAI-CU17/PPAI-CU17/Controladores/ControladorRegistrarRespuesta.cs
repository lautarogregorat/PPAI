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
        public VentanaRegistrarRespuesta ventanaRegistrarRespuesta;

        public ControladorRegistrarRespuesta(Llamada datosLlamada, VentanaRegistrarRespuesta _ventanaRegistrarRespuesta)
        {
            this.datosLlamada = datosLlamada;
            this.ventanaRegistrarRespuesta = _ventanaRegistrarRespuesta;
            this.ventanaRegistrarRespuesta.controladorRegistrarRespuesta = this;
        }

        public string getDescripcion()
        {
            return this.descripcion;
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
            this.respuesta = value;
        }

        public void setAccion(string value)
        {
            accion = value;
        }

        private void setEstadoEnCurso(Estado estado)
        {
            estadoEnCurso = estado;
        }

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

        private void registrarAccionRequerida(String accion)
        {
            GestorCU gestorCu = new GestorCU();
            gestorCu.registrarAccionRequerida(accion);
        }

        private void actualizarEstadoLlamada(Llamada llamadaIdentificada)
        {
            llamadaIdentificada.enCurso(estadoEnCurso);
        }

        private string buscarDatosLlamada()
        {
            String infoLlamada = "";
            infoLlamada += this.datosLlamada.getCliente() + "\n";
            infoLlamada += this.datosLlamada.getSubOpcion() + "\n";
            infoLlamada += this.datosLlamada.getOpcionyCategoria() + "\n";
            infoLlamada += this.datosLlamada.getValidaciones();

            return infoLlamada;
        }

        private void obtenerFechaYhoraActual()
        {
            DateTime fechaYhoraActualizada = DateTime.Now;
            this.fechaYhoraActual = fechaYhoraActualizada;
        }
        
        private bool validarRespuestas()
        {
            bool valida = false;

            // Para cada dato a validar (Es decir validacion a realizar)

            for(int i = 0; i < this.datosLlamada.getValidaciones().Count; i++)
            {
                this.ventanaRegistrarRespuesta.tomarRespuesta();
                valida = this.datosLlamada.validarInfoCliente(this.respuesta);
                
                if (!valida)
                {
                    return false;
                }
            }

            return valida;
        }

        public void registrarRespuesta()
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
            this.actualizarEstadoLlamada(datosLlamada);

            this.datosLlamada.enCurso(this.estadoEnCurso);

            string infoLlamada = this.buscarDatosLlamada();

            ventanaRegistrarRespuesta.habilitar();

            ventanaRegistrarRespuesta.mostrarDatosLlamada(infoLlamada);

            ventanaRegistrarRespuesta.mostrarValidaciones(this.datosLlamada.getValidaciones());
            
;

            if (!(this.validarRespuestas()))
            {
                // Hacer algo si las respuestas no validaron bien, se cancela el CU por ejemplo (Alternativa 2)
            } else
            {
                // Continua el CU
            }


            
        }


    }



}
