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
            cambiodeEstado.crear (estado);
        }

    }
}