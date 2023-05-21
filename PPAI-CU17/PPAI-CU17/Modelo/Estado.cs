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
            return this.nombre == "En curso";

        }

        public Boolean esFinalizada()
        {
            return this.nombre == "Finalizada";

        }
    }
}