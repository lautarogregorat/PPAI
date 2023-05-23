using PPAI_CU17.Modelo;
using System.Security.Cryptography.Xml;

namespace PPAI_CU17.Modelo
{
    public class Llamada

    {
        // Atributos de la clase llamada
        private Cliente cliente;
        private List<CambiodeEstado> cambioDeEstado;
        private Opcion opcionSeleccionada;
        private SubOpcion subopcionSeleccionada;
        private String descripcionOperador;
        private String detalleAccionRequerida;
        private TimeSpan duracion; 
        private Boolean encuestaEnviada;
        private String observacionAuditor;

        // Metodos de la clase llamada

        // Constructor
        public Llamada(Cliente datosCliente, Opcion opcion, SubOpcion subOpcion, Estado estadoIniciada, DateTime fechaHoraInicio)
        {
            this.cliente = datosCliente;
            this.opcionSeleccionada = opcion;
            this.subopcionSeleccionada = subOpcion;
            this.cambioDeEstado = new List<CambiodeEstado>();
            this.crearCambioEstado(estadoIniciada, fechaHoraInicio);
             
       }

        // Metodos get y set

        public void setObservacionAuditor(String value) 
        {   
            this.observacionAuditor = value;
        }

        public void setDetalleAccionRequerida(String value)
        {
            this.detalleAccionRequerida = value;
        }

        public String getDescripcionOperador()
        {
            return this.descripcionOperador;
        }

        public void setDescripcionOperador(String value)
        {
            this.descripcionOperador = value;
        }

        public void setCliente(Cliente cliente) 
        {
            this.cliente = cliente;
        }

        public CambiodeEstado getCambioDeEstado()
        {
            return this.cambioDeEstado.Last();
        }
        
        public TimeSpan getDuracion()
        {
            return this.duracion;
        }



        public String getNombreCliente()
        {
            return this.cliente.getNombre();
        }
        
        public Cliente getCliente()
        {
            return this.cliente;
        }

        public Opcion getOpcion()
        {
            return this.opcionSeleccionada;
        }

        public SubOpcion getSubOpcion()
        {
            return this.subopcionSeleccionada;
        }

        public String getNombreOpcion()
        {
            return this.opcionSeleccionada.getNombreOpcion();
        }

        public String getNombreCategoriaOpcion()
        {
            return this.opcionSeleccionada.getNombreCategoria();
        }

        public String getNombreSubOpcion()
        {
            return this.subopcionSeleccionada.getNombreSubopcion();
        }

        // Devuelve la lista de referencias a validaciones asociadas a la subopcion de la llamada
        public List<Validacion> getValidacionesSubopcion()
        {
            return this.subopcionSeleccionada.getValidaciones();
        }
        
        // Método que devuelve una lista de strings con los nombres de las validaciones para la subopcion asociada a la llamada
        public List<String> getNombreValidacionesSubOpcion() 
        {
            return this.subopcionSeleccionada.getNombresValidaciones();
        }

        // Crea un CambiodeEstado pasando como parámetros el estado y la fechaHoraInicio
        private void crearCambioEstado(Estado estado, DateTime fechaHoraInicio)
        {
            CambiodeEstado nuevoCambioDeEstado = new CambiodeEstado(estado, fechaHoraInicio);
            this.cambioDeEstado.Add(nuevoCambioDeEstado);

        }

        // Finaliza la llamada creando un cambio de estado con estado finalizado
        public void finalizar(Estado estadoFinalizado, DateTime fechaHoraInicio)
        {
            crearCambioEstado(estadoFinalizado, fechaHoraInicio);
        }
        
        // Método que delega la responsabilidad de validar la informacionCliente al Cliente
        public bool validarInfoCliente(String respuesta)
        {
            List<Validacion> validaciones = this.subopcionSeleccionada.getValidaciones();
            return this.cliente.esInformacionCorrecta(respuesta, validaciones);


        }
        
        /* Calcula la duración de la llamada como la diferencia entre la fechaHoraInicio del CambiodeEstado "Iniciada" y la 
        fechaHoraInicio del CambiodeEstado "Finalizada"----(Esta resta tiene como resultado un tipo de dato TimeSpan)*/ 
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