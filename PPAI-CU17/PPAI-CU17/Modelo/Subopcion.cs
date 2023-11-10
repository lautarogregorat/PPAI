using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.Modelo
{
    public class SubOpcion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idSubOpcion { get; set; }
        // Atributos de la clase SubOpcion
        [Column("nombre_subopcion", TypeName = "varchar(200)")]
        public String nombre;
        [Column("nro_orden_subopcion", TypeName = "int")]
        public int nroOrden;

        public List<Validacion> validaciones = new List<Validacion>();
        public List<Llamada> llamadas { get; set; }

        [ForeignKey("idOpcion")]
        public int idOpcion { get; set; }
        public Opcion opcionPadre;

        

        // Constructor para Subopcion
        public SubOpcion() { 
        }
        public SubOpcion(String nombreSubopcion, int nroOrdenSubopcion)
        {
            this.nombre = nombreSubopcion;
            this.nroOrden = nroOrdenSubopcion;
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
            return this.nombre;
        }

        public int getNroOrdenSubopcion()
        {
            return this.nroOrden;
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
            this.nombre = value;
        }

        public void setNroOrdenSubopcion(int value)
        {
            this.nroOrden = value;
        }

        public void setOpcionPadre(Opcion value) 
        {
            this.opcionPadre = value;
        }

    }

}
