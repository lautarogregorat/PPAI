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

        public void agregarValidacion(Validacion _validacion)
        {
            this.validaciones.Add(_validacion);
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

        public string getDatos()
        {
            string datosSubOpcion = "";
            datosSubOpcion += "Nro. orden de subopcion: " + this.getNroOrdenSubopcion() + "\n";
            datosSubOpcion += "Nombre de subopcion: " + this.getNombreSubopcion() + "\n";

            return datosSubOpcion;
        }
        
        public string getValidaciones()
        {
            String datosValidaciones = "";

            this.validaciones.ForEach(validacion =>
            {
                datosValidaciones += validacion.getDatos();
                datosValidaciones += "\n";
            });

            return datosValidaciones;
        }

    }


}
