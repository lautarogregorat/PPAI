using PPAI_CU17.Modelo;

namespace PPAI_CU17.Modelo;
	public class Opcion
	{
	// atributos para opcion
	private string audioMensajeSubopcion;
        private string mensajeOpcion;
        private string nombreOpcion;
        private int nroOrdenOpcion;
        private List<SubOpcion> subopciones;
        public Categoria categoria;
      
      // constructor para opcion
        public Opcion(string audioMensajeSubopciones, string mensajeOpcion, string nombreOpcion, int nroOrdenOpcion, Categoria categoriaSuperior)
        {
            this.audioMensajeSubopcion = audioMensajeSubopciones;
            this.mensajeOpcion = mensajeOpcion;
            this.nombreOpcion = nombreOpcion;
            this.nroOrdenOpcion = nroOrdenOpcion;
            this.subopciones = new List<SubOpcion>();
            this.categoria = null;
        }

        // Agregamos subopciones a la opcion
        public void agregarSubopcion(SubOpcion _subopcion)
        {
            _subopcion.opcionPadre = this;
            subopciones.Add(_subopcion);
        }

        // metodos get para opcion

        public string getAudioMensajeSubopcion()
        {
            return audioMensajeSubopcion;
        }

        public string getMensajeOpcion()
        {
            return this.mensajeOpcion;
        }

        public string getNombreOpcion()
        {
            return this.nombreOpcion;
        }

        public int getNroOrdenOpcion()
        {
            return this.nroOrdenOpcion;
        }

        // get categoria
        public String getCategoria()
        {
        return this.categoria.getDatos();
        }

        public string getDatos() 
        {
        return this.ToString();
        }
	
	// get validacion
	public Validacion getValidacion()
	{
		return validacion;
	}
	
	}
