using PPAI_CU17.Modelo;

namespace PPAI_CU17.Modelo
{
    public class Llamada
        
    {
       private Cliente cliente;
       private List<CambiodeEstado> cambioDeEstado ;
       public Llamada() 
       { 
            /*
             Constructor llamada
             */ 
             
       }

        public void enCurso(Estado estado)
        {
            CambiodeEstado nuevoCambioDeEstado = new CambiodeEstado(estado);
            cambioDeEstado.Add(nuevoCambioDeEstado);
        }

        public void getCliente()
        {
            this.cliente.getNombre();
        }
        public void getOpcionyCategoria(Opcion opcion, Categoria categoria)
        {
            opcion.getDatos();
            opcion.getCategoria(categoria);
            
        }
        public void getSubOpcion(Subopcion subopcion)
        {
            /*
             subopcion.getDatos();
             */
        }

        public void getValidaciones(Subopcion subopcion) 
        { 
            /*
             subopcion.getValidaciones()
             */
        }
    }
}