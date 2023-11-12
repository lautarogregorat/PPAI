using PPAI_CU17.Modelo;
using PPAI_CU17.Modelo.Estados.Estado;
using System.ComponentModel.DataAnnotations;

public class PendienteEscucha : Estado
{

    public PendienteEscucha(string nombre) : base(nombre)
    {
    }

    public PendienteEscucha() : base("PendienteEscucha")
    {

    }

    public void marcarCorrecta()
    {

    }

    public void registrarObservacion()
    {

    }

    public override void finalizar()
    {
        throw new NotImplementedException();
    }

    public override void enCurso()
    {
        throw new NotImplementedException();
    }

    public override void enCurso(DateTime fechaHoraInicio, Llamada llamada)
    {
        throw new NotImplementedException();
    }

    public override void finalizar(DateTime fechaHoraInicio, Llamada llamada)
    {
        throw new NotImplementedException();
    }
}