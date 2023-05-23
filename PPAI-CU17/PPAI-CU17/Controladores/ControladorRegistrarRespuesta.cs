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
        // Atributos de la clase controlador registrar respuesta
        private String respuesta;
        private String descripcion;
        private String accion;
        private Estado estadoEnCurso;
        private DateTime fechaYhoraActual;
        private Llamada datosLlamada;
        private InformacionCliente informacionCliente;
        private Estado estadoFinalizada;
        private TimeSpan duracionLlamada;

        // definicion de los estados posibles que puede tomar una llamada, para buscarlos con los métodos correspondientes (solo para pruebas)
        private List<Estado> estadosLlamada;

        public VentanaRegistrarRespuesta ventanaRegistrarRespuesta;

        // Metodos de la clase controlador registrar respuesta
        public ControladorRegistrarRespuesta(Llamada datosLlamada, VentanaRegistrarRespuesta _ventanaRegistrarRespuesta)
        {
            this.respuesta = "";
            this.descripcion = "";
            this.accion = "";
            this.datosLlamada = datosLlamada;
            this.ventanaRegistrarRespuesta = _ventanaRegistrarRespuesta;
            this.ventanaRegistrarRespuesta.controladorRegistrarRespuesta = this;

            // Inicializacion de los estados posibles para la llamada, a efecto de pruebas

            this.estadosLlamada = new List<Estado>();
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
                this.estadosLlamada.Add(estadoInicializado);
            });

        }

        // Metodos get y set del controlador
        public String getDescripcion()
        {
            return this.descripcion;
        }
        public String getRespuesta()
        {
            return this.respuesta;
        }

        public String getAccion()
        {
            return accion;
        }

        public Estado getEstadoEnCurso()
        {
            return estadoEnCurso;
        }

        public DateTime getHoraActual()
        {
            return this.fechaYhoraActual;
        }

        public Llamada getDatosLlamada()
        {
            return this.datosLlamada;
        }

        public InformacionCliente getInformacionCliente()
        {
            return this.informacionCliente;
        }

        public Estado getEstadoFinalizada()
        {
            return this.estadoFinalizada;
        }

        public void setRespuesta(String value) 
        {
            this.respuesta = value;
        }

        public void setEstadoEnCurso(Estado estado) 
        {
            this.estadoEnCurso = estado;
        }

        public void setEstadoFinalizada(Estado estado) 
        {
            this.estadoFinalizada = estado;
        }
        public void setDescripcion(String value)
        {
            this.descripcion = value;
        }

        public void setDatosLlamada(Llamada datosLlamada)
        {
            this.datosLlamada = datosLlamada;
        }
    
        public void setAccion(String value)
        {
            this.accion = value;
        }
        // Métodos de implementación

        // Toma la respuesta ingresada desde la ventana de interfaz
        public void tomarRespuesta(String value)
        {
            this.respuesta = value;
            this.validarRespuesta();
        }

        // Busca entre los objetos estado la instancia "enCurso" y setea usando el método arriba definido
        private void buscarEstadoEnCurso(List<Estado> Estados)
        {

            Estados.ForEach((Estado estado) =>
            {
                if (estado.sosEnCurso())
                {
                    this.estadoEnCurso = estado;
                    return;
                }
            });
        }

        // Busca entre los objetos estado la instancia "Finalizada" de la llamada y setea usando el método arriba definido
        public void buscarEstadoFinalizada(List<Estado> Estados)
        {

            foreach (Estado estado in Estados)
            {
                if (estado.esFinalizada())
                {
                    this.setEstadoFinalizada(estado);
                    break;

                }
            }
        }

        // Toma la descripcion de la respuesta ingresada por el operador desde la ventana
        public void tomarDescripcion(String descripcionIngresada)
        {
            this.descripcion = descripcionIngresada;
        }

        // Toma la accion requerida por el cliente, ingresada por el operador desde la ventana
        public void tomarAccion(String accionRequerida)
        {
            this.accion = accionRequerida;
        }

        // Toma la confirmación realizada en el boton de confirmar la operación en la ventana
        public void tomarConfirmacion()
        {
            this.registrarAccionRequerida();
            return;
            
        }

        // Registra la accion requerida por el cliente, instancia un nuevo objeto de la clase GestorCU, enviandole un mensaje
        // para realizar dicha tarea, esto simula la llamada al caso de uso 28. Devuelve true o false según si el caso de uso se ejecutó
        // de manera correcta
        private void registrarAccionRequerida()
        {
            GestorCU gestorRegistrarAccion = new GestorCU();
            bool registrada = gestorRegistrarAccion.registrarAccionRequerida(this.accion);

            
            if (registrada)
            {
                this.ventanaRegistrarRespuesta.mostrarMsgRegistroAccion();
                this.registrarFinDeLlamada();
            }
            else
            {
                // Flujo alternativo A3: El CU 28 no se ejecuta con éxito
                this.ventanaRegistrarRespuesta.mostrarMsgRegistroAccionIncorrecta();
            }

            this.finCu();

        }

        // Método que actualiza el estado de la llamada actual en el controlador, llamando al método enCurso de la llamada que 
        // genera un nuevo cambio de estado
        private void actualizarEstadoLlamada()
        {
            this.datosLlamada.enCurso(estadoEnCurso, this.fechaYhoraActual);
        }

        // obtiene los datos de la llamada seleccionada y los retorna como una lista de cadenas
        public List<String> buscarDatosLlamada()
        {
            List<String> infoLlamada = new List<String>();
            infoLlamada.Add(this.datosLlamada.getNombreCliente());
            infoLlamada.Add(this.datosLlamada.getNombreOpcion());
            infoLlamada.Add(this.datosLlamada.getNombreCategoriaOpcion());
            infoLlamada.Add(this.datosLlamada.getNombreSubOpcion());
                      
            return infoLlamada;
        }

        // Obtiene y actualiza la fechaYhoraActual
        private void obtenerFechaYhoraActual()
        {
            DateTime fechaYhoraActualizada = DateTime.Now;
            this.fechaYhoraActual = fechaYhoraActualizada;
        }
        
        // Valida la respuesta del cliente ingresada por el operador a las validaciones, para ello llama al método validarInfoCliente
        // de la llamada asociada, para obtener un boolean que indica si la respuesta fue o no correcta.
        private void validarRespuesta()
        {
            bool rtaValida = this.datosLlamada.validarInfoCliente(this.respuesta);
                
                if (rtaValida)
            {
                this.ventanaRegistrarRespuesta.mostrarMsgValidacionCorrecta();
            } else
            {
                // Flujo alternativo A2: algun dato de las validaciones es incorrecto
                this.ventanaRegistrarRespuesta.mostrarMsgValidacionIncorrecta();
                this.finCu();
            };
                
        }
        // registra el finde la llamada asociada, para ello llama al método finalizar() en la llamada, que crea un nuevo cambio de estado
        // ejecuta los métodos "set" para la descripcion y accion ingresadas, y despues delega la responsabilidad de calcular la duración
        // a la llamada
        public void registrarFinDeLlamada()
        {
            this.obtenerFechaYhoraActual();
            this.buscarEstadoFinalizada(this.estadosLlamada);
            this.datosLlamada.finalizar(this.estadoFinalizada, this.fechaYhoraActual);
            this.datosLlamada.setDescripcionOperador(this.descripcion);
            this.datosLlamada.setDetalleAccionRequerida(this.accion);

            this.datosLlamada.calcularDuracion();
            this.duracionLlamada = this.datosLlamada.getDuracion();
            this.ventanaRegistrarRespuesta.mostrarDatosFinDeLlamada(this.duracionLlamada.ToString(), this.descripcion);

        }

        // Finaliza el caso de uso, cierra la ventana y sale de la ejecución
        public void finCu()
        {
            this.ventanaRegistrarRespuesta.Close();
            return;
        }

        // Inicia la funcionalidad principal del flujo del caso de uso
        public void registrarRespuesta()
        {
                        
            this.buscarEstadoEnCurso(this.estadosLlamada);

            this.obtenerFechaYhoraActual();

            this.actualizarEstadoLlamada();
            
            List<String> infoLlamada = this.buscarDatosLlamada();

            ventanaRegistrarRespuesta.habilitar();


            ventanaRegistrarRespuesta.mostrarDatosLlamada(infoLlamada);

            List<String> infoValidaciones = this.datosLlamada.getNombreValidacionesSubOpcion();

            ventanaRegistrarRespuesta.mostrarValidaciones(infoValidaciones, this.datosLlamada.getDatosInformacionCliente());


        }
        
    }

}
