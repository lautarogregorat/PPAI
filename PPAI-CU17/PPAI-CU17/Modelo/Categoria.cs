using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.Modelo
{
    public class Categoria
    {
        // atributos para categoria
        private string audioMensajeOpcion; 
        private string mensajeOpcion;
        private string nombreCategoria;
        private int nroOrdenCategoria;
        private List<Opcion> opciones;

        // constructor Categoria
        public Categoria(string audioMensajeOpcion, string mensajeOpcion, string nombreCategoria, int nroOrdenCategoria)
        {
            this.audioMensajeOpcion = audioMensajeOpcion;
            this.mensajeOpcion = mensajeOpcion;
            this.nombreCategoria = nombreCategoria;
            this.nroOrdenCategoria = nroOrdenCategoria;
            opciones = new List<Opcion>();
        }

        // Agregamos opciones a la categoria
        public void agregarOpcion(Opcion _opcion)
        {
            _opcion.categoria = this;
            opciones.Add(_opcion);
        }

        // metodos get para categoria
        public string getAudioMensajeOpcion()
        {
            return audioMensajeOpcion;
        }

        public string getMensajeOpcion()
        {
            return mensajeOpcion;
        }

        public string getNombreCategoria()
        {
            return nombreCategoria;
        }

        public int getNroOrdenCategoria()
        {
            return nroOrdenCategoria;
        }
        public string getDatos() {

            string datosCategoria = "";

            datosCategoria += "Nro. orden de categoria: " + this.getNroOrdenCategoria() + "\n";
            datosCategoria += "Nombre de categoria: " + this.getNombreCategoria() + "\n";

            return datosCategoria;
        }


    }
}

