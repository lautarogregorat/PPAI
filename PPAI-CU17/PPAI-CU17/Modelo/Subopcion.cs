using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.Modelo
{
    public class Subopcion
    {
        // atributos
        private string nombreSubopcion;
        private int nroOrdenSubopcion;
        public Opcion opcionPadre;
        public Validacion validacion;

        // constructor para subopcion
        public Subopcion(string nombreSubopcion, int nroOrdenSubopcion, Validacion validacion)
        {
            this.nombreSubopcion = nombreSubopcion;
            this.nroOrdenSubopcion = nroOrdenSubopcion;
            opcionPadre = null;
            this.validacion = validacion
        }

        // metodos get para subopcion
        public string getNombreSubopcion()
        {
            return nombreSubopcion;
        }

        public int getNroOrdenSubopcion()
        {
            return nroOrdenSubopcion;
        }

       public Opcion  getOpcion()
        {
            return opcionPadre;
        }

        public Validacion getValidaciones()
        {
            return validacion;
        }
    }


}
