namespace PPAI_CU17.Modelo
{
    // Atributos de la clase Estado
    public class Estado
    {
        private String nombre;

        // Constructor de la clase Estado
        public Estado(String nombre)
        {
            this.nombre = nombre;
        }

        // Metodos get y set
        public String getNombre()
        {
            return this.nombre;
        }

        public void setNombre(String value)
        {
            this.nombre = value;
        }

        // Metodo que valida si el nombre del estado es "EnCurso"
        public Boolean sosEnCurso()
        {
            return this.nombre.Equals("EnCurso");

        }

        // Metodo que valida si el nombre del estado es "Iniciada"
        public Boolean esIniciada()
        {
            return this.nombre.Equals("Iniciada");
        }
        // Metodo que valida si el nombre del estado es "Finalizada"
        public Boolean esFinalizada()
        {
            return this.nombre.Equals("Finalizada");

        }
    }
}