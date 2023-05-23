using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.Modelo
{
    public class SubOpcion
    {
        // atributos
        private string nombreSubopcion;
        private int nroOrdenSubopcion;
        private List<Validacion> validaciones;
        public Opcion opcionPadre;

        // constructor para subopcion
        public SubOpcion(string nombreSubopcion, int nroOrdenSubopcion)
        {
            this.nombreSubopcion = nombreSubopcion;
            this.nroOrdenSubopcion = nroOrdenSubopcion;
            this.validaciones = new List<Validacion>();
            opcionPadre = null;
        }
        
        public void agregarValidacion(Validacion validacion)
        {
            this.validaciones.Add(validacion);
        }

        // metodos get para subopcion
        public string getNombreSubopcion()
        {
            return this.nombreSubopcion;
        }

        public int getNroOrdenSubopcion()
        {
            return this.nroOrdenSubopcion;
        }

       public Opcion getOpcion()
        {
            return this.opcionPadre;
        }

        
        public List<String> getValidaciones()
        {
            List<String> datosValidaciones = new List<string>();

            this.validaciones.ForEach(validacion =>
            {
                datosValidaciones.Add(validacion.getNombreValidacion());
            });

            return datosValidaciones;
        }

        public List<Validacion> obtenerValidaciones()
        {
            return this.validaciones;
        }

    }


}
