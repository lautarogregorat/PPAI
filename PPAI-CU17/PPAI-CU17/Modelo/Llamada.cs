
using PPAI_CU17.Modelo.Estados.Estado;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PPAI_CU17.Modelo
{
    public class Llamada

    {
        // Atributos de la clase llamada
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idLlamada { get; set;}
        [Column("descripcion_operador", TypeName = "varchar(200)")]
        public String? descripcionOperador;
        [Column("detalle_accion_requerida", TypeName = "varchar(200)")]
        public String? detalleAccionRequerida;
        [Column("duracion", TypeName = "varchar(200)")]
        public TimeSpan duracion;
        [Column("encuestaEnviada", TypeName = "bit")]
        public Boolean encuestaEnviada;
        [Column("observacion_auditor", TypeName = "varchar(200)")]
        public String? observacionAuditor;

        [ForeignKey("idCliente")]
        public int idCliente { get; set; }
        public Cliente cliente { get; set; } = null!;

        public List<CambiodeEstado> cambioDeEstado;

        public Estado estadoActual;

        [ForeignKey("idOpcion")]
        public int? idOpcion { get; set; }
        public Opcion? opcionSeleccionada;

        [ForeignKey("idSubOpcion")]
        public int? idSubOpcion { get; set; }
        public SubOpcion subopcionSeleccionada;
        // Metodos de la clase llamada

        // Constructor

        public Llamada()
        {

        }
        public Llamada( Cliente datosCliente, Opcion opcion, SubOpcion subOpcion, DateTime fechaHoraInicio)
        {

            this.cliente = datosCliente;
            this.opcionSeleccionada = opcion;
            this.subopcionSeleccionada = subOpcion;
            this.cambioDeEstado = new List<CambiodeEstado>();
            this.setEstadoActual(new Iniciada("Iniciada"));
            this.crearCambioEstado(this.estadoActual, fechaHoraInicio);
             
       }

        // Metodos get y set


        public String getDescripcionOperador()
        {
            return this.descripcionOperador;
        }

        public String getDetalleAccionRequerida()
        {
            return this.detalleAccionRequerida;
        }


        public List<CambiodeEstado> getCambioDeEstado()
        {
            return this.cambioDeEstado;
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

        // Método que devuelve una lista de strings con los datos a validar del cliente, es decir, las respuestas correctas a las validaciones
        public List<String> getDatosInformacionCliente()
        {
            return this.cliente.getDatosInformacionCliente();
        }

        public bool getEncuestaEnviada()
        {
            return this.encuestaEnviada;
        }

        public String getObservacionAuditor()
        {
            return this.observacionAuditor;
        }

        public void setObservacionAuditor(String value)
        {
            this.observacionAuditor = value;
        }

        public void setDetalleAccionRequerida(String value)
        {
            this.detalleAccionRequerida = value;
        }

        public void setDescripcionOperador(String value)
        {
            this.descripcionOperador = value;
        }

        public void setCliente(Cliente cliente)
        {
            this.cliente = cliente;
        }

        public void setEncuestaEnviada(bool enviada)
        {
            this.encuestaEnviada = enviada;
        }

        // Crea un CambiodeEstado pasando como parámetros el estado y la fechaHoraInicio
        private void crearCambioEstado(Estado estado, DateTime fechaHoraInicio)
        {
            CambiodeEstado nuevoCambioDeEstado = new CambiodeEstado(estado, fechaHoraInicio);
            this.agregarCambioEstado(nuevoCambioDeEstado);

        }

        // Agrega un cambio de estado a la coleccion de cambios de estado de la llamada
        public void agregarCambioEstado(CambiodeEstado ce)
        {
            this.cambioDeEstado.Add(ce);
        }

        public void setEstadoActual(Estado e)
        {
            this.estadoActual = e;
        }

        // Cambia el estado de la llamada a "enCurso", para eso recibe el nuevo estado "EnCurso" y la fechaHoraInicio para crear un nuevo cambio
        // de estado y agregarlo a la lista de cambios de estados de la llamada en cuestion

        public void enCurso (DateTime fechaHoraInicio) {

            this.estadoActual.enCurso(fechaHoraInicio, this);
        }

        // Finaliza la llamada delegando la responsabilidad del cambio de estado al estado actual, que es EnCurso
        public void finalizar(DateTime fechaHoraInicio)
        {
            this.estadoActual.finalizar(fechaHoraInicio, this);
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