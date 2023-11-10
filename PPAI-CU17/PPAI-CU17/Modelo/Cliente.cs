using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_CU17.Modelo
{
    public class Cliente
    {
        // Atributos de la clase cliente

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idCliente { get; set; }
        [Column("dni", TypeName = "varchar(200)")]
        public String dni;
        public String nombreCompleto;
        [Column("nro_celular", TypeName = "varchar(200)")]
        public String nroCelular;

        public List<InformacionCliente> info;

        public List<Llamada> llamadas { get; set; }

        // Metodos de la clase cliente
        // Constructor

        public Cliente()
        {
        }
        public Cliente(String nombreCompleto, String dni, String nroCelular)
        {
            this.nombreCompleto = nombreCompleto;
            this.dni = dni;
            this.nroCelular = nroCelular;
            this.info = new List<InformacionCliente>();
        }

        // Método para agregar objetos de la clase InformacionCliente a la lista de objetos de ese tipo a los que
        // referencia la clase
        public void agregarInfo(InformacionCliente informacion)
        {
            this.info.Add(informacion);
        }

        // Métodos get y set
        public String getNombre()
        { 
            return this.nombreCompleto;
        }

        public String getDni()
        {
            return this.dni;
        }

        public String getNroCelular()
        {
            return this.nroCelular;
        }

        public void setNombre(String value) 
        {
            this.nombreCompleto = value;
        }

        public void setDni(String value) 
        {
            this.dni = value;
        }

        public void setNroCelular(String value) 
        {
            this.nroCelular = value;
        }

        // Método get para obtener la lista de objetos InformacionCliente 
        public List<InformacionCliente> getInformacionCliente()
        {
            return this.info;
        }


        // Método que devuelve los datos a validar en formato de texto de cada objeto InformacionCliente que referencia la clase, 
        // como una lista de strings con cada dato
        public List<String> getDatosInformacionCliente()
        {
            List<String> informacionDelCliente = new List<String>();

            this.info.ForEach(informacionCliente =>
            {
                informacionDelCliente.Add(informacionCliente.getDatoAValidar());
            });

            return informacionDelCliente;
        }

        // Método que recibe como parámetro un string de información, que representa el dato que tiene que validar como igual
        // cada objeto InformacionCliente a su atributo datoAValidar, y a su vez validar que cada uno de esos objetos corresponda
        // a la misma validacion relacionada, con el método esValidacion. Devuelve un booleano.
        public bool esInformacionCorrecta(String informacion, List<Validacion> validaciones)
        {
            bool informacionValida = false;
            validaciones.ForEach((validacion) =>
            {
                this.info.ForEach((informacionCliente) =>
                {
                    if (informacionCliente.esValidacion(validacion) && informacionCliente.esInformacionCorrecta(informacion))
                    {
                        informacionValida = true;
                    };
                });
            });
            return informacionValida;
        }
    }
}
       

