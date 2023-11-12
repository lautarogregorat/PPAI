using PPAI_CU17.Modelo;
using PPAI_CU17.Modelo.Estados.Estado;

public class Observada : Estado
{
    public Observada(string nombre) : base(nombre)
    {
    }

    public Observada() : base("Observada")
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