using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.Modelo
{
    public class InformacionCliente
    {
        // Atributos de clase
        private string datoAValidar;
        private Validacion validacion;

        public InformacionCliente(string datoAValidar, Validacion _validacion)
        {
            this.datoAValidar = datoAValidar;
            this.validacion = _validacion;
        }

        public string getDatoAValidar()
        {
            return datoAValidar;
        }

        public Validacion getValidacion()
        {
            return this.validacion;
        }

        // Este método recibe un string de informacion que se valida contra el dato que tiene asociado el cliente, en este caso la informacion es la respuesta que se ingreso parala validacion

        public Boolean esInformacionCorrecta(string informacion) => datoAValidar.Equals(informacion);

        // Recibe un Objeto validacion y corrobora si es la misma que la validacion asociada a esta instancia de InformacionCliente
        public Boolean esValidacion(Validacion validacionRecibida) => validacion.Equals(validacionRecibida);

    }
}
