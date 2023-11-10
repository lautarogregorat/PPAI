using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.Modelo
{
    public class InformacionCliente

    {
        [Key]
        public int idInformacionCliente { get; set; }
        // Atributos de clase
        [Column("dato_a_validar", TypeName = "varchar(200)")]
        public String datoAValidar;

        [ForeignKey("idValidacion")]
        public int idValidacion { get; set; }
        public Validacion validacion;

        [ForeignKey("idCliente")]
        public int idCliente { get; set; }
        public Cliente cliente { get; set; }


        // Constructor
        public InformacionCliente()
        {
        }
        public InformacionCliente(String datoAValidar, Validacion _validacion)
        {
            this.datoAValidar = datoAValidar;
            this.validacion = _validacion;
        }

        // Metodos get y set
        public String getDatoAValidar()
        {
            return datoAValidar;
        }

        public Validacion getValidacion()
        {
            return this.validacion;
        }

        public void setValidacion (Validacion value) 
        {
            this.validacion = value;
        }

        public void setDatoAValidar(String value) 
        {
            this.datoAValidar = value;
        }

        // Este método recibe un string de informacion que se valida contra el dato que tiene asociado el cliente,
        // en este caso la informacion es la respuesta que se ingreso para la validacion

        public Boolean esInformacionCorrecta(String informacion) {
            return datoAValidar.Equals(informacion);
                }

        // Recibe un Objeto validacion y corrobora si es la misma que la validacion asociada al objeto InformacionCliente
        public Boolean esValidacion(Validacion validacionRecibida)
        {
            return validacion.Equals(validacionRecibida);
        }
    }
}
