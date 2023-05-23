using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.Modelo
{
    public class SubOpcion
    {
        // Atributos de la clase SubOpcion
        private String nombreSubopcion;
        private int nroOrdenSubopcion;
        private List<Validacion> validaciones;
        public Opcion opcionPadre;

        // Constructor para Subopcion
        public SubOpcion(String nombreSubopcion, int nroOrdenSubopcion)
        {
            this.nombreSubopcion = nombreSubopcion;
            this.nroOrdenSubopcion = nroOrdenSubopcion;
            this.validaciones = new List<Validacion>();
            opcionPadre = null;
        }
        
        // Metodo para agregar validaciones requeridas relacionadas al objeto SubOpcion
        public void agregarValidacion(Validacion validacion)
        {
            this.validaciones.Add(validacion);
        }

        // Metodos get y set
        public String getNombreSubopcion()
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
        // Método que devuelve una lista de validaciones requeridas que tiene la subopcion
        public List<Validacion> getValidaciones()
        {
            return this.validaciones;
        }

        // Método que devuelve una lista de strings con los nombres de todas las validaciones que tenga asociadas

        public List<String> getNombresValidaciones()
        {
            List<String> datosValidaciones = new List<String>();

            this.validaciones.ForEach(validacion =>
            {
                datosValidaciones.Add(validacion.getNombreValidacion());
            });

            return datosValidaciones;
        }

        public void setNombreSubpcion(String value)
        {
            this.nombreSubopcion = value;
        }

        public void setNroOrdenSubopcion(int value)
        {
            this.nroOrdenSubopcion = value;
        }

        public void setOpcionPadre(Opcion value) 
        {
            this.opcionPadre = value;
        }

    }

}
