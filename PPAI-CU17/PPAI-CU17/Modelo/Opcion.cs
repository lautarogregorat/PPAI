using PPAI_CU17.Modelo;

namespace PPAI_CU17.Modelo;
	public class Opcion
	{
	// Atibutos de la clase opcion
	    private String audioMensajeSubopcion;
        private String mensajeOpcion;
        private String nombreOpcion;
        private int nroOrdenOpcion;
        private List<SubOpcion> subopciones;
        private List<Validacion> validacionRequerida;
        public Categoria categoria;
      
      // Metodos de la clase opcion

    // Constructor
        public Opcion(String audioMensajeSubopciones, String mensajeOpcion, String nombreOpcion, int nroOrdenOpcion, Categoria categoriaSuperior)
        {
            this.audioMensajeSubopcion = audioMensajeSubopciones;
            this.mensajeOpcion = mensajeOpcion;
            this.nombreOpcion = nombreOpcion;
            this.nroOrdenOpcion = nroOrdenOpcion;
            this.subopciones = new List<SubOpcion>();
            this.categoria = categoriaSuperior;
        }

        // Método para agregar subopciones a la opción 
        public void agregarSubopcion(SubOpcion _subopcion)
        {
            _subopcion.opcionPadre = this;
            subopciones.Add(_subopcion);
        }

        // Métodos get y set

        public String getAudioMensajeSubopcion()
        {
            return audioMensajeSubopcion;
        }

        public String getMensajeOpcion()
        {
            return this.mensajeOpcion;
        }

        public String getNombreOpcion()
        {
            return this.nombreOpcion;
        }

        public int getNroOrdenOpcion()
        {
            return this.nroOrdenOpcion;
        }

        // Retorna la categoria a la que pertenece la opcion, por una dependencia
        public Categoria getCategoria()
        {
            return this.categoria;
        }

        // Método que devuelve el string con el nombre de la categoria padre de la opcion, usando una dependencia
        public String getNombreCategoria()
        {
            return this.categoria.getNombreCategoria();
        }
        // Retorna el nombre de las validaciones asociadas a la opcion, como una lista de strings de cada nombre
        public List<String> getValidaciones()
        {
            List<String> datosValidaciones = new List<String>();

            this.validacionRequerida.ForEach(validacion =>
            {
                datosValidaciones.Add(validacion.getNombreValidacion());
            });

            return datosValidaciones;
        }

}
