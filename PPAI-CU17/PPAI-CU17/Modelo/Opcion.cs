using PPAI_CU17.Modelo;

namespace PPAI_CU17.Modelo;
	public class Opcion
	{
	// atributos para opcion
	private string audioMensajeSubopcion;
        private string mensajeSubopcion;
        private string nombreSubop;
        private int nroOrdenSubop;
        private List<Subopcion> subopciones;
        public Categoria categoriaPadre;
      
      // constructor para opcion
        public Opcion(string audioMensajeSubopciones, string mensajeSubopciones, string nombre, int nroOrden)
        {
            this.audioMensajeSubopcion = audioMensajeSubopciones;
            this.mensajeSubopcion = mensajeSubopciones;
            this.nombreSubop = nombre;
            this.nroOrdenSubop = nroOrden;
            subopciones = new List<Subopcion>();
            categoriaPadre = null;
        }

        // Agregamos subopciones a la opcion
        public void AgregarSubopcion(Subopcion _subopcion)
        {
            _subopcion.opcionPadre = this;
            subopciones.Add(_subopcion);
        }

        // metodos get para opcion

        public string getAudioMensajeSubopcion()
        {
            return audioMensajeSubopcion;
        }

        public string getMensajeSubopcion()
        {
            return mensajeSubopcion;
        }

        public string getNombreSubop()
        {
            return nombreSubop;
        }

        public int getNroOrdenSubop()
        {
            return nroOrdenSubop;
        }

        // get categoria
        public Categoria getCategoria()
        {
            return categoriaPadre;
        }
	}
