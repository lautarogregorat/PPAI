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
        private List<InformacionCliente> info;

        public void agregarInfo(InformacionCliente informacion)
        {
            this.info.Add(informacion);
        }

        public Cliente(string nombreCompleto, string dni, string nroCelular, InformacionCliente informacionCliente)
        {
            this.nombreCompleto = nombreCompleto;
            this.dni = dni;
            this.nroCelular = nroCelular;
            this.info = new List<InformacionCliente>();

            this.info.Add(informacionCliente);
        }

        public String getNombre()
        { 
            return this.nombreCompleto;
        }

        public String getDni()
        {
            return this.dni;
        }

        public String getNroCelular()
        {
            return this.nroCelular;
        }

        public String getInformacionCliente()
        {
            String informacionDelCliente = "Informacion asociada al cliente: \n";

            this.info.ForEach(informacionCliente =>
            {
                informacionDelCliente += informacionCliente.getDatoAValidar() + "\n";
            });

            return informacionDelCliente;
        }

        public String getDatos()
        {
            String datosCliente = "";
            datosCliente += "Nombre: " + this.getNombre();
            datosCliente += "Numero de dni: " + this.getDni();
            datosCliente += "Numero de celular: " + this.getNroCelular();

            return datosCliente;
        }
        /*
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
        */

    }
}
