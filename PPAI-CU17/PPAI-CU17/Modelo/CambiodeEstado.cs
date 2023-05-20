using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.Modelo
{
    internal class CambiodeEstado

    {
        private Estado estado;
        public CambiodeEstado() 
        { 
        }
        private void setEstado(Estado estado)
        {
            this.estado = estado;
        }
        public void crear(Estado estado)
        {
            CambiodeEstado nuevoCambiodeEstado = new CambiodeEstado();
            setEstado(estado);

        }

    }
}
