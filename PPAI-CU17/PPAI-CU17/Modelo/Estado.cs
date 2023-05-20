namespace PPAI_CU17.Modelo
{
    public class Estado
    {
        private string nombre;

        public Estado(string nombre)
        {
            this.nombre = nombre;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public Boolean sosEnCurso()
        {
            if (this.nombre == "En curso")
            {
                return true;            
            } else { return false; }

        }

        public Boolean esFinalizado()
        {
            if (this.nombre == "Finalizado")
            {
                return true;
            }
            else { return false; }

        }
    }
}