using PPAI_CU17.Modelo;
using PPAI_CU17.Modelo.Estados.Estado;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Finalizada : Estado
{

    public Finalizada() : base("Finalizada")
    {
    }
    public Finalizada(string nombre) : base(nombre)
    {
    }

    public void escucharLlamada()
    {

    }

    public bool esFinalizada()
    {
        return true;
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