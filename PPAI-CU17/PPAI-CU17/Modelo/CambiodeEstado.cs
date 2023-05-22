using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.Modelo
{
    public class CambiodeEstado

    {

        private DateTime fechaHoraInicio;
        private Estado estado;
        public CambiodeEstado(Estado estado, DateTime fechaHorainicio)
        {
            this.estado = estado;
            this.fechaHoraInicio = fechaHorainicio;
        }
    }
}
