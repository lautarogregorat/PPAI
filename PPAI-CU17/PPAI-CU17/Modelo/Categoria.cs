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
        private string nombreOp;
        private int nroOrdenOp;
        private List<Opcion> opciones;

        // constructor Categoria
        public Categoria(string audioMensajeOpcion, string mensajeOpcion, string nombre, int nroOrden)
        {
            this.audioMensajeOpcion = audioMensajeOpcion;
            this.mensajeOpcion = mensajeOpcion;
            this.nombreOp = nombre;
            this.nroOrdenOp = nroOrden;
            opciones = new List<Opcion>();
        }

        // Agregamos opciones a la categoria
        public void AgregarOpcion(Opcion _opcion)
        {
            _opcion.categoriaPadre = this;
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

        public string getNombreOp()
        {
            return nombreOp;
        }

        public int getNroOrdenOp()
        {
            return nroOrdenOp;
        }
    }
}

