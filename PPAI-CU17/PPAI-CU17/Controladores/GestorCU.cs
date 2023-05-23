using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.Controladores
{
    // caso de uso 28
    public class GestorCU
    {
        public GestorCU() {
        }

        // Método que simula la llamada al caso de uso para registrar la acción requerida, devuelve true o false según si 
        // el valor ingresado como acción es o no un string válido (solo controla por string vacio o nulo)
        public bool registrarAccionRequerida(String accion)
        {
            if (accion == "" || accion == null)
            {
                return false;
            };

            return true;
        }
    }
}
