using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.Controladores
{
    public class GestorCU
    {
        public GestorCU() {
        }

        public bool registrarAccionRequerida(string accion)
        {
            if (accion == "" || accion == null)
            {
                return false;
            };

            return true;
        }
    }
}
