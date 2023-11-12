using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PPAI_CU17.Modelo;
using PPAI_CU17.Modelo.Estados.Estado;

public class EnCurso : Estado
{
    public EnCurso(string nombre) : base(nombre)
    {
    }

    public EnCurso() : base("EnCurso")
    {

    }

    public override void finalizar(DateTime fechaHoraInicio, Llamada llamada)
    {
        MessageBox.Show("Cambiando estado a finalizada");
        Estado finalizada = crearProximoEstado();
        CambiodeEstado ce = crearCambioEstado(fechaHoraInicio, finalizada);
        llamada.agregarCambioEstado(ce);
        llamada.setEstadoActual(finalizada);
    }
    
    public Estado crearProximoEstado()
    {
        return new Finalizada("Finalizada");
    }

    public CambiodeEstado crearCambioEstado(DateTime fechaHoraInicio, Estado estado)
    {
        return new CambiodeEstado(estado, fechaHoraInicio);
    }

    public override void enCurso()
    {
        throw new NotImplementedException();
    }

    public override void finalizar()
    {
        throw new NotImplementedException();
    }

    public override void enCurso(DateTime fechaHoraInicio, Llamada llamada)
    {
        throw new NotImplementedException();
    }
}