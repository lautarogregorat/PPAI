using PPAI_CU17.Entidades;

namespace PPAI_CU17.Modelo
{
    public class Llamada
        
    {
       private CambiodeEstado cambiodeEstado;
       public Llamada() 
       { 
            
       }

        public void enCurso(Estado estado)
        {
            this.cambiodeEstado = new CambiodeEstado (estado);   
        }

        public void getCliente(Cliente cliente)
        {
            cliente.getNombre();
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