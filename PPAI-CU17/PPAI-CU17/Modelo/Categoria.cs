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
        private String audioMensajeOpciones; 
        private String mensajeOpciones;
        private String nombre;
        private int nroOrden;
        private List<Opcion> opciones;

        // Metodos de la clase categoria
        // Constructor
        public Categoria(String audioMensajeOpcion, String mensajeOpcion, String nombreCategoria, int nroOrdenCategoria)
        {
            this.audioMensajeOpciones = audioMensajeOpcion;
            this.mensajeOpciones = mensajeOpcion;
            this.nombre = nombreCategoria;
            this.nroOrden = nroOrdenCategoria;
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
            return audioMensajeOpciones;
        }

        public String getMensajeOpciones()
        {
            return mensajeOpciones;
        }

        public String getNombreCategoria()
        {
            return nombre;
        }

        public int getNroOrdenCategoria()
        {
            return nroOrden;
        }

        public void setAudioMensajeOpcion(String value)
        {
            this.audioMensajeOpciones = value;
        }

        public void setMensajeOpcion(String value)
        {
            this.mensajeOpciones = value;
        }

        public void setNombreCategoria(String value)
        {
            this.nombre = value;
        }

        public void setNroOrdenCategoria(int value)
        {
            this.nroOrden = value;
        }

    }
}

