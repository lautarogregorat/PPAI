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
        private Estado estadoFinalizada;
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
            return estadoFinalizada;
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

        /*
        private void setEstadoEnCurso(Estado estado)
        {
            this.estadoEnCurso = estado;
        }
        */

        // Busca entre los objetos estado la instancia "enCurso" y setea usando el método arriba definido
        private void buscarEstadoEnCurso(List<Estado> Estados)
        {
            /*
            foreach (Estado estado in Estados)
            {
                if (estado.sosEnCurso())
                {
                    this.estadoEnCurso = estado;
                    return;

                }
            }
            */

            Estados.ForEach((Estado estado) =>
            {
                if (estado.sosEnCurso())
                {
                    this.estadoEnCurso = estado;
                    return;
                }
            });
        }

        private void setEstadoFinalizada(Estado estado)
        {
            this.estadoFinalizada = estado;
        }

        // Busca entre los objetos estado la instancia "Finalizado" y setea usando el método arriba definido
        public void buscarEstadoFinalizada(List<Estado> Estados)
        {

            foreach (Estado estado in Estados)
            {
                if (estado.esFinalizada())
                {
                    setEstadoFinalizada(estado);
                    break;

                }
            }
        }

        public void tomarDescripcion(string descripcionIngresada)
        {
            this.descripcion = descripcionIngresada;
        }

        public void tomarAccion(string accionRequerida)
        {
            this.accion = accionRequerida;
        }

        public void tomarConfirmacion()
        {
            return;
        }

        private bool registrarAccionRequerida()
        {
            GestorCU gestorRegistrarAccion = new GestorCU();
            return gestorRegistrarAccion.registrarAccionRequerida(this.accion);
        }

        private void actualizarEstadoLlamada()
        {
            this.datosLlamada.enCurso(estadoEnCurso, this.fechaYhoraActual);
        }

        private List<String> buscarDatosLlamada()
        {
            List<String> infoLlamada = new List<String>();
            infoLlamada.Add(this.datosLlamada.getCliente());
            infoLlamada.Add(this.datosLlamada.getOpcion());
            infoLlamada.Add(this.datosLlamada.getCategoriaOpcion());
            infoLlamada.Add(this.datosLlamada.getSubOpcion());
                       
            
            return infoLlamada;
        }

        // Obtiene y actualiza la fechaYhoraActual
        private void obtenerFechaYhoraActual()
        {
            DateTime fechaYhoraActualizada = DateTime.Now;
            this.fechaYhoraActual = fechaYhoraActualizada;
        }
        
        private bool validarRespuesta()
        {
            bool valida = false;

            // Para cada dato a validar (Es decir validacion a realizar)

            for (int i = 0; i < this.datosLlamada.getValidaciones().Count; i++)
            {
                valida = this.datosLlamada.validarInfoCliente(this.respuesta);
                
                if (!valida)
                {
                    return false;
                }
            }

            return valida;
        }

        public void registrarFinDeLlamada()
        {
            // Será la FechaHoraInicio del CambiodeEstado 
            this.datosLlamada.finalizar(this.estadoFinalizada, this.fechaYhoraActual);
            this.datosLlamada.setDescripcionOperador(this.descripcion);
            this.datosLlamada.setDetalleAccionRequerida(this.accion);
            this.datosLlamada.calcularDuracion();

        }

        public void finCu()
        {
            return;
        }

        public void registrarRespuesta()
        {

            // Estados posibles para la llamada 

            List<Estado> estados = new List<Estado>();
            List<String> stringsEstados = new List<string>();

            stringsEstados.Add("Iniciada");
            stringsEstados.Add("EnCurso");
            stringsEstados.Add("Finalizada");
            stringsEstados.Add("Cancelada");
            stringsEstados.Add("PendienteEscucha");
            stringsEstados.Add("Correcta");
            stringsEstados.Add("Observada");
            stringsEstados.Add("Descartada");
            stringsEstados.Add("Encuestada");

            stringsEstados.ForEach((nombre) =>
            {
                Estado estadoInicializado = new Estado(nombre);
                estados.Add(estadoInicializado);
            });



            // Buscar el estado EnCurso

            /*
              Prueba de estados
              foreach (Estado est in estados)
            {
                MessageBox.Show(est.getNombre());
            }

            MessageBox.Show(estados.ToString());
            
            */
            // Obtener la fecha y hora actual

            this.buscarEstadoEnCurso(estados);

            // Prueba estado en curso
            MessageBox.Show(this.estadoEnCurso.getNombre());

            this.obtenerFechaYhoraActual();
            // Prueba fecha y hora
            MessageBox.Show(this.fechaYhoraActual.ToString());
            
            this.actualizarEstadoLlamada();


            List<string> infoLlamada = this.buscarDatosLlamada();

            ventanaRegistrarRespuesta.habilitar();

            ventanaRegistrarRespuesta.mostrarDatosLlamada(infoLlamada);

            ventanaRegistrarRespuesta.mostrarValidaciones(this.datosLlamada.getValidaciones());

            for (int i = 0; i < this.datosLlamada.getValidaciones().Count; i++)
            {
                ventanaRegistrarRespuesta.solicitarRespuesta();

                while(this.respuesta != "")
                {
                    if (!this.validarRespuesta())
                    {

                    };
                }
            }            
           

            ventanaRegistrarRespuesta.solicitarDescripcion();
            ventanaRegistrarRespuesta.solicitarAccion();
            ventanaRegistrarRespuesta.solicitarConfirmacion();

            // Paso número 8 - Llamada al CU 28 Registrar accion requerida

            if (!(this.registrarAccionRequerida())){
                // Flujo alternativo 3 - El CU 28 no ejecuta con éxito
            };

            this.ventanaRegistrarRespuesta.mostrarMsgRegistroAccion();

            this.buscarEstadoFinalizada(estados);

            this.registrarFinDeLlamada();

            this.finCu();

            return;
        
        }
        
    }

}
