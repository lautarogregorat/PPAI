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
        public Validacion(string audioMensajeValidacion, string nombreValidacion)
        {
            this.audioMensajeValidacion = audioMensajeValidacion;
            this.nombreValidacion = nombreValidacion;
        }
        
        // metodos get para validacion
        public string getAudioMensajeValidacion()
        {
            return audioMensajeValidacion;
        }
        
        public string nombreValidacion()
        {
            return nombreValidacion;
        }
    }
