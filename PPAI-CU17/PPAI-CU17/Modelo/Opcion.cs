using PPAI_CU17.Modelo;

namespace PPAI_CU17.Modelo;
	public class Opcion
	{
	// Atibutos de la clase opcion
	    private String audioMensajeSubopcion;
        private String mensajeOpcion;
        private String nombre;
        private int nroOrden;
        private List<SubOpcion> subopciones;
        private List<Validacion> validacionRequerida;
        public Categoria categoria;
      
    // Metodos de la clase opcion

    // Constructor
        public Opcion(String audioMensajeSubopciones, String mensajeOpcion, String nombreOpcion, int nroOrdenOpcion)
        {
            this.audioMensajeSubopcion = audioMensajeSubopciones;
            this.mensajeOpcion = mensajeOpcion;
            this.nombre = nombreOpcion;
            this.nroOrden = nroOrdenOpcion;
            this.subopciones = new List<SubOpcion>();
            this.validacionRequerida = new List<Validacion>();
            this.categoria = null;
        }

        // Método para agregar subopciones a la opción 
        public void agregarSubopcion(SubOpcion _subopcion)
        {
            _subopcion.opcionPadre = this;
            subopciones.Add(_subopcion);
        }
        // Método para agregar validaciones requeridas a la opción 
        public void agregarValidacionRequerida(Validacion _validacionRequerida)
        {
            validacionRequerida.Add(_validacionRequerida);
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
            return this.nombre;
        }

        public int getNroOrdenOpcion()
        {
            return this.nroOrden;
        }

        // Retorna la categoria a la que pertenece la opcion, por una dependencia
        public Categoria getCategoria()
        {
            return this.categoria;
        }

        public List<Validacion> getValidaciones()
    {
        return this.validacionRequerida;

    }

        // Método que devuelve el string con el nombre de la categoria padre de la opcion, usando una dependencia
        public String getNombreCategoria()
        {
            return this.categoria.getNombreCategoria();
        }
        // Retorna el nombre de las validaciones asociadas a la opcion, como una lista de strings de cada nombre
        public List<String> getDatosValidaciones()
        {
            List<String> datosValidaciones = new List<String>();

            this.validacionRequerida.ForEach(validacion =>
            {
                datosValidaciones.Add(validacion.getNombreValidacion());
            });

            return datosValidaciones;
        }

        public void setAudioMensajeSubopcion(String value) 
        {
            this.audioMensajeSubopcion = value;
        }

        public void setMensajeOpcion(String value)
        {
            this.mensajeOpcion = value;
        }

        public void setNombreOpcion(String value) 
        {
            this.nombre = value;
        }

        public void setNroOrdenOpcion(int value) 
        {
            this.nroOrden = value;
        }

        public void setCategoria(Categoria categoria) 
        {
            this.categoria = categoria;
        }
    
      


}
