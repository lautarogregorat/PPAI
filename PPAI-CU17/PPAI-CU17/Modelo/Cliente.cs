using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.Modelo
{
    public class Cliente
    {
        /* Atributos de clase */

        private string nombreCompleto;
        private string dni;
        private string nroCelular;
        private InformacionCliente informacionCliente;

        public Cliente(string nombreCompleto, string dni, string nroCelular, InformacionCliente informacionCliente)
        {
            this.nombreCompleto = nombreCompleto;
            this.dni = dni;
            this.nroCelular = nroCelular;
            this.informacionCliente = informacionCliente;
        }

        public string getNombre()
        { 
            return this.nombreCompleto;
        }

        public string getDni()
        {
            return this.dni;
        }

        public string getNroCelular()
        {
            return this.nroCelular;
        }

        public InformacionCliente getInformacionCliente()
        {
            return this.informacionCliente;
        }
        public bool esInformacionCorrecta(string informacion, List<Validacion> validaciones)

        {
             foreach (Validacion validacion in validaciones)
             {
                if (this.informacionCliente.esValidacion(validacion) && this.informacionCliente.esInformacionCorrecta(informacion))
                {
                    return true;

                }; 
                
                return false;
             }

            return false;
        }


    }
}
