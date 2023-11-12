using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PPAI_CU17.Modelo;
using PPAI_CU17.Modelo.Estados.Estado;
public class Iniciada : Estado
{
    public Iniciada(string nombre) : base(nombre)
    {
    }

    public Iniciada() : base("Iniciada")
    {

    }


    public override void finalizar()
    {
    }

    public void registrarRtaOperador()
    {

    }


    public override void enCurso(DateTime fechaHoraInicio, Llamada llamada)
    {
        MessageBox.Show("Cambiando estado a en curso");
        Estado e = crearProximoEstado();
        CambiodeEstado c = crearCambioDeEstado(fechaHoraInicio, e);
        llamada.agregarCambioEstado(c);
        llamada.setEstadoActual(e);
    }

    public Estado crearProximoEstado()
    {
        EnCurso e = new EnCurso();
        return e;
    }

    public bool esIniciada()
    {
        return true;
    }

    public CambiodeEstado crearCambioDeEstado(DateTime fechaHoraInicio, Estado estado)
    {
        CambiodeEstado ce = new CambiodeEstado(estado, fechaHoraInicio);
        return ce;
    }

    public void cancelarLlamada()
    {

    }

    public override void enCurso()
    {
        throw new NotImplementedException();
    }

    public override void finalizar(DateTime fechaHoraInicio, Llamada llamada)
    {
        throw new NotImplementedException();
    }
}