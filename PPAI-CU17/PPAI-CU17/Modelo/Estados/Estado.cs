using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PPAI_CU17.Modelo.Estados.Estado
{   
    public abstract class Estado
    {
        // Atributos de la clase Estado

        [Key]
        public int idEstado { get; set; }

        protected Llamada llamada { get; set; }

        private string nombre;
        public List<CambiodeEstado> cambiosDeEstado { get; set; }

        // Constructor de la clase Estado
        public Estado(string nombre)
        {
            this.nombre = nombre;
        }

        // Metodos get y set
        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string value)
        {
            nombre = value;
        }


        // Metodo que valida si el nombre del estado es "Iniciada"
        public bool esIniciada()
        {
            return false;
        }
        // Metodo que valida si el nombre del estado es "Finalizada"
        public bool esFinalizada()
        {
            return false;

        }

        public bool esEnCurso()
        {
            return false;
        }

        public bool esPendienteEscucha()
        {
            return false;
        }

        public bool esObservada()
        {
            return false;
        }

        public bool esCorrecta()
        {
            return false;
        }

        public bool esCancelada()
        {
            return false;
        }

        public void registrarRtaOperador()
        {
            
        }

        public void registrarObservacion()
        {

        }

        public void escucharLlamada()
        {

        }

        public void marcarCorrecta()
        {

        }

        public void cancelarLlamada()
        {
        }

        public abstract void finalizar();

        public abstract void enCurso();

        public abstract void enCurso(DateTime fechaHoraInicio, Llamada llamada);

        public abstract void finalizar(DateTime fechaHoraInicio, Llamada llamada);

    }
}