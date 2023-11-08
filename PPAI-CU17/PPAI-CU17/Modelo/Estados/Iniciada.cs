namespace PPAI_CU17.Modelo.Estados.Estado;
public class Iniciada : Estado
{
    public Iniciada(string nombre) : base(nombre)
    {
    }

    public void finalizar()
    {

    }

    public void registrarRtaOperador()
    {

    }

    public void enCurso(DateTime fechaHoraInicio, Llamada llamada)
    {
        Estado e = crearProximoEstado();
        CambiodeEstado c = crearCambioDeEstado(fechaHoraInicio, e);
        llamada.agregarCambioEstado(c);
        llamada.setEstadoActual(e);
    }

    public Estado crearProximoEstado()
    {
        return new EnCurso("enCurso");
    }


    public CambiodeEstado crearCambioDeEstado(DateTime fechaHoraInicio, Estado estado)
    {
        return  new CambiodeEstado(estado, fechaHoraInicio);
    }

    public void cancelarLlamada()
    {

    }



}