using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.Modelo
{
    public class Validacion
    {
        // atributos de validacion
        private string audioMensajeValidacion;
        private string nombreValidacion;

        // constructor de validacion
        public Validacion(string _audioMensajeValidacion, string _nombreValidacion)
        {
            this.audioMensajeValidacion = _audioMensajeValidacion;
            this.nombreValidacion = _nombreValidacion;
        }

        // metodos get para validacion
        public string getMensajeValidacion()
        {
            return this.audioMensajeValidacion;
        }

        public string getNombreValidacion()
        {
            return this.nombreValidacion;
        }

        public string getDatos()
        {
            string datosValidacion = "";

            datosValidacion += "Mensaje de validacion: " + this.getMensajeValidacion() + "\n";
            datosValidacion += "Nombre de validacion: " + this.getNombreValidacion() + "\n";


            return datosValidacion;

        }

    }
}
