using PPAI_CU17.Modelo.Estados.Estado;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.Modelo
{
    public class CambiodeEstado

    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idCambioEstado { get; set; }
        // Atributos de la clase cambio de estado
        [Column("fecha_hora_inicio", TypeName = "datetime")]
        public DateTime fechaHoraInicio;

        [ForeignKey("idEstado")]
        public int idEstado { get; set; }
        public Estado estado;

        [ForeignKey("idLlamada")]
        public int idLlamada { get; set; }
        public Llamada llamada;
        
        // Metodos de la clase cambio de estado
        public CambiodeEstado()
        {
        }
        public CambiodeEstado(Estado estado, DateTime fechaHorainicio)
        {
            this.estado = estado;
            this.fechaHoraInicio = fechaHorainicio;
        }

        // Metodos get y set
        public String getNombreEstado() 
        {
            return estado.getNombre();
        }

        public DateTime getFechaHoraInicio()
        {
            return this.fechaHoraInicio;
        }

        public void setEstado(Estado estado) 
        {
            this.estado = estado;
        }

        public Estado getEstado()
        {
            return this.estado;
        }

        
        public void setFechaHoraInicio(DateTime value) 
        {
            this.fechaHoraInicio = value;
        }

        // Método que evalua si el estado para el cambio de estado en la llamada es "Iniciada", para ello llama al método esIniciada()
        // en el objeto estado que tiene como referencia, devuelve un true o false.
        public bool esEstadoIniciada()
        {
            return this.estado.esIniciada();
        }

        // Método que evalua si el estado para el cambio de estado en la llamada es "Finalizada", para ello llama al método esFinalizada()
        // en el objeto estado que tiene como referencia, devuelve un true o false.
        public bool esEstadoFinalizada()
        {
            return this.estado.esFinalizada();
        }
    }
}
