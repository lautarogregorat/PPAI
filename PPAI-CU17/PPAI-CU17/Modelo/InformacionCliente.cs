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
        private string datoAValidar;

        public InformacionCliente(string datoAValidar)
        {
            this.datoAValidar = datoAValidar;
        }

        public string getDatoAValidar()
        {
            return datoAValidar;
        }

        public Boolean esInformacionCorrecta(string informacion) => datoAValidar.Equals(informacion);
    }
}
