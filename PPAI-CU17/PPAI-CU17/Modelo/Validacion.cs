﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.Modelo
{
    public class Validacion
    {
        // Atributos de la clase validacion
        private String audioMensajeValidacion;
        private String nombreValidacion;

        // Metodos de la clase validacion
        // Constructor
        public Validacion(String _audioMensajeValidacion, String _nombreValidacion)
        {
            this.audioMensajeValidacion = _audioMensajeValidacion;
            this.nombreValidacion = _nombreValidacion;
        }

        // Métodos get y set
        public String getMensajeValidacion()
        {
            return audioMensajeValidacion;
        }

        public String getNombreValidacion()
        {
            return nombreValidacion;
        }

        public void setAudioMensajeValidacion(String value) 
        {
            this.audioMensajeValidacion = value;
        }

        public void setNombreValidacion(String value) 
        {
            this.nombreValidacion = value;
        }

    }
}
