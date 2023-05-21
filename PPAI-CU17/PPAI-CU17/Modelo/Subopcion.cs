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
        private string nombre;
        private int nroOrden;
        public Opcion opcionPadre;

        // constructor para subopcion
        public Subopcion(string nombre, int nroOrden)
        {
            this.nombre = nombre;
            this.nroOrden = nroOrden;
            opcionPadre = null;
        }

        // metodos get para subopcion
        public string getNombre()
        {
            return nombre;
        }

        public int getNroOrden()
        {
            return nroOrden;
        }

       public Opcion  getOpcion()
        {
            return opcionPadre;
        }

        /* public object getValidaciones()
        {
            return validacion (pero todavia no esta programada la parte de las validaciones)
        } */
    }


}
