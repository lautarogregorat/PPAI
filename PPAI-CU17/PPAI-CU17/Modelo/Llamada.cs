using PPAI_CU17.Modelo;
using System.Security.Cryptography.Xml;

namespace PPAI_CU17.Modelo
{
    public class Llamada

    {
        private Cliente cliente;
        private List<CambiodeEstado> cambioDeEstado;
        private Opcion opcionSeleccionada;
        private SubOpcion subopcionSeleccionada;

        private string descripcionOperador;
        private string detalleAccionRequerida;
        private TimeSpan duracion; 
        private Boolean encuestaEnviada;
        private string observacionAuditor;


        public Llamada(Cliente datosCliente, Opcion opcion, SubOpcion subOpcion, Estado estadoIniciada, DateTime fechaHoraInicio)
        {
            this.cliente = datosCliente;
            this.opcionSeleccionada = opcion;
            this.subopcionSeleccionada = subOpcion;
            this.cambioDeEstado = new List<CambiodeEstado>();
            this.crearCambioEstado(estadoIniciada, fechaHoraInicio);
             
       }

        public void setDetalleAccionRequerida(string accion)
        {
            this.detalleAccionRequerida = accion;
        }

        public void setDescripcionOperador(string descripcion)
        {
            this.descripcionOperador = descripcion;
        }

        public void enCurso(Estado enCurso, DateTime fechaHoraInicio)
        {
            crearCambioEstado(enCurso, fechaHoraInicio);
        }

        public String getCliente()
        {
            return this.cliente.getNombre();
        }
        public String getOpcion()
        {
            return this.opcionSeleccionada.getNombreOpcion();
        }

        public String getCategoriaOpcion()
        {
            return this.opcionSeleccionada.getCategoria();
        }

        public String getSubOpcion()
        {
            return this.subopcionSeleccionada.getNombreSubopcion();
        }

        public List<String> getValidaciones() 
        {
            return this.subopcionSeleccionada.getValidaciones();
        }

        private void crearCambioEstado(Estado estado, DateTime fechaHoraInicio)
        {
            CambiodeEstado nuevoCambioDeEstado = new CambiodeEstado(estado, fechaHoraInicio);
            this.cambioDeEstado.Add(nuevoCambioDeEstado);

        }

        public void finalizar(Estado estadoFinalizado, DateTime fechaHoraInicio)
        {
            crearCambioEstado(estadoFinalizado, fechaHoraInicio);
        }
        public bool validarInfoCliente(String respuesta)
        {
            List<Validacion> validaciones = this.subopcionSeleccionada.obtenerValidaciones();
            return this.cliente.esInformacionCorrecta(respuesta, validaciones);


        }

        public void calcularDuracion()
        {
            DateTime fechaHoraIniciada = new DateTime();
            DateTime fechaHoraFinalizada = new DateTime();

            this.cambioDeEstado.ForEach(cambio =>
            {
                if (cambio.esEstadoIniciada())
                {
                    fechaHoraIniciada = cambio.getFechaHoraInicio();
                }

                if (cambio.esEstadoFinalizada())
                {
                    fechaHoraFinalizada = cambio.getFechaHoraInicio();
                }
            });

            this.duracion = fechaHoraFinalizada - fechaHoraIniciada;
        }
        }
}