using PPAI_CU17.Modelo;
using System.Security.Cryptography.Xml;

namespace PPAI_CU17.Modelo
{
    public class Llamada

    {
        private Cliente cliente;
        private List<CambiodeEstado> cambioDeEstado;
        private Opcion opcionSeleccionada;
        private SubOpcion subopcionSeleccionada;

        private string descripcionOperador;
        private string detalleAccionRequerida;
        private int duracion; // VER SI ES INT
        private Boolean encuestaEnviada;
        private string observacionAuditor;


        public Llamada(Cliente datosCliente, Opcion opcion, SubOpcion subOpcion, Estado estadoIniciada)
        {
            this.cliente = datosCliente;
            this.opcionSeleccionada = opcion;
            this.subopcionSeleccionada = subOpcion;

            this.crearCambioEstado(estadoIniciada, DateTime.Now); // REVISAR(no encontramos otra forma de obtener la hora sin generar una dependencia)

        }

        public void enCurso(Estado enCurso, DateTime fechaHoraInicio)
        {
            crearCambioEstado(enCurso, fechaHoraInicio);
        }

        public String getCliente()
        {
            return this.cliente.getNombre();
        }
        public String getOpcionyCategoria()
        {
            String datosOpcionYcategoria = "";

            datosOpcionYcategoria.Concat(this.opcionSeleccionada.getDatos());

            datosOpcionYcategoria.Concat(this.opcionSeleccionada.getCategoria());

            return datosOpcionYcategoria;
        }
        public String getSubOpcion()
        {
            return this.subopcionSeleccionada.getDatos();
        }

        public String getValidaciones()
        {
            return this.subopcionSeleccionada.getValidaciones();
        }

        private void crearCambioEstado(Estado estado, DateTime fechaHoraInicio)
        {
            CambiodeEstado nuevoCambioDeEstado = new CambiodeEstado(estado, fechaHoraInicio);
            this.cambioDeEstado.Add(nuevoCambioDeEstado);

        }

        public void finalizar(Estado estadoFinalizado, DateTime fechaHoraInicio)
        {
            crearCambioEstado(estadoFinalizado, fechaHoraInicio);
        }

    }
}