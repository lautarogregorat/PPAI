using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.Modelo
{
    public class Categoria
    {
        // Atributos de la clase categoria
        private String audioMensajeOpcion; 
        private String mensajeOpcion;
        private String nombreCategoria;
        private int nroOrdenCategoria;
        private List<Opcion> opciones;

        // Metodos de la clase categoria
        // Constructor
        public Categoria(String audioMensajeOpcion, String mensajeOpcion, String nombreCategoria, int nroOrdenCategoria)
        {
            this.audioMensajeOpcion = audioMensajeOpcion;
            this.mensajeOpcion = mensajeOpcion;
            this.nombreCategoria = nombreCategoria;
            this.nroOrdenCategoria = nroOrdenCategoria;
            opciones = new List<Opcion>();
        }

        // Método para agregar opciones a la categoria
        public void agregarOpcion(Opcion _opcion)
        {
            _opcion.categoria = this;
            opciones.Add(_opcion);
        }

        // Metodos get y set
        public String getAudioMensajeOpcion()
        {
            return audioMensajeOpcion;
        }

        public String getMensajeOpcion()
        {
            return mensajeOpcion;
        }

        public String getNombreCategoria()
        {
            return nombreCategoria;
        }

        public int getNroOrdenCategoria()
        {
            return nroOrdenCategoria;
        }

        public void setAudioMensajeOpcion(String value)
        {
            this.audioMensajeOpcion = value;
        }

        public void setMensajeOpcion(String value)
        {
            this.mensajeOpcion = value;
        }

        public void setNombreCategoria(String value)
        {
            this.nombreCategoria = value;
        }

        public void setNroOrdenCategoria(int value)
        {
            this.nroOrdenCategoria = value;
        }

    }
}

