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
            return this.nombre.Equals("En curso");

        }

        public Boolean esIniciada()
        {
            return this.nombre.Equals("Iniciada");
        }

        public Boolean esFinalizada()
        {
            return this.nombre.Equals("Finalizada");

        }
    }
}