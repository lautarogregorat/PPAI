using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.Modelo
{
    public class Validacion
    {
        // Atributos de la clase validacion
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idValidacion { get; set; }
        [Column("audio_mensaje_validacion", TypeName = "varchar(200)")]
        public String audioMensajeValidacion;
        [Column("nombre_validacion", TypeName = "varchar(200)")]
        public String nombre;

        // Relaciones entre clases
        [ForeignKey("idOpcion")]
        public int? idOpcion { get; set; }
        public Opcion? opcion { get; set; }

        [ForeignKey("idSubOpcion")]
        public int? idSubOpcion { get; set; }
        public SubOpcion? subOpcion { get; set; }


        // Constructor
        public Validacion()
        {

        }

        public Validacion(String _audioMensajeValidacion, String _nombreValidacion)
        {
            this.audioMensajeValidacion = _audioMensajeValidacion;
            this.nombre = _nombreValidacion;
        }

        // Métodos get y set
        public String getMensajeValidacion()
        {
            return audioMensajeValidacion;
        }

        public String getNombreValidacion()
        {
            return nombre;
        }

        public void setAudioMensajeValidacion(String value) 
        {
            this.audioMensajeValidacion = value;
        }

        public void setNombreValidacion(String value) 
        {
            this.nombre = value;
        }

    }
}
