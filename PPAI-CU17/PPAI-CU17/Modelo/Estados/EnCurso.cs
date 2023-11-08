namespace PPAI_CU17.Modelo.Estados.Estado;

public class EnCurso : Estado
{
    public EnCurso(string nombre) : base(nombre)
    {
    }

    public void finalizar(DateTime fechaHoraInicio, Llamada llamada)
    {
        Estado finalizada = crearProximoEstado();
        CambiodeEstado ce = crearCambioDeEstado(fechaHoraInicio, finalizada);
        llamada.agregarCambioEstado(ce);
        llamada.setEstadoActual(finalizada);
    }
    
    public Estado crearProximoEstado()
    {
        return new Finalizada("Finalizada");
    }

    public CambiodeEstado crearCambioDeEstado(DateTime fechaHoraInicio, Estado estado)
    {
        return new CambiodeEstado(estado, fechaHoraInicio);
    }

}