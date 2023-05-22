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
        private int duracion;
        private Boolean encuestaEnviada;
        private string observacionAuditor;
        

       public Llamada(Cliente datosCliente, Opcion opcion, SubOpcion subOpcion, Estado estadoIniciada) 
       {
            this.cliente = datosCliente;
            this.opcionSeleccionada = opcion;
            this.subopcionSeleccionada = subOpcion;
            this.cambioDeEstado = new List<CambiodeEstado>();
            this.crearCambioEstado(estadoIniciada);
             
       }

        public void enCurso(Estado enCurso)
        {
            crearCambioEstado(enCurso);
        }

        public String getCliente()
        {
            return this.cliente.getNombre();
        }
        public String getOpcionyCategoria()
        {
            String datosOpcionYcategoria = "";

            datosOpcionYcategoria += "Opcion seleccionada: " + this.opcionSeleccionada.getDatos() + "\n";
            datosOpcionYcategoria += "Categoria: " + this.opcionSeleccionada.getCategoria();

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

        private void crearCambioEstado(Estado estado)
        {
            CambiodeEstado nuevoCambioDeEstado = new CambiodeEstado(estado);
            this.cambioDeEstado.Add(nuevoCambioDeEstado);

        }
    }
}