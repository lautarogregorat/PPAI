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
        public Validacion validacion;

        // constructor para subopcion
        public SubOpcion(string nombreSubopcion, int nroOrdenSubopcion)
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

        public string getDatos()
        {
            return this.ToString();
        }
        
        public string getValidaciones()
        {

            String datosValidaciones = "";

            this.validaciones.ForEach(validacion =>
            {
                datosValidaciones.Concat(validacion.getMensajeValidacion());
                datosValidaciones.Concat("\n");
            });

            return datosValidaciones;
        }
    }


}
