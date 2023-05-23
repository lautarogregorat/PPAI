using PPAI_CU17.Controladores;
using PPAI_CU17.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_CU17.Interfaces
{
    public partial class VentanaRegistrarRespuesta : Form
    {
        // Atributos de la clase VentanaRegistrarRespuesta
        public ControladorRegistrarRespuesta controladorRegistrarRespuesta;

        // Constructor de la clase
        public VentanaRegistrarRespuesta()
        {
            InitializeComponent();
        }
        // Habilita la ventana para que sea visible por el operador/usuario
        public void habilitar()
        {
            this.Show();
        }

        // Muestra los datos de la llamada en la interfaz de la ventana, dentro de un panel con lbls y txtBoxs de sólo lectura
        // que contienen los datos necesarios.
        public void mostrarDatosLlamada(List<string> datosLlamada)
        {
            this.txtNombreCliente.Text = datosLlamada[0];
            this.txtCategoriaSeleccionada.Text = datosLlamada[1];
            this.txtOpcionSeleccionada.Text = datosLlamada[2];
            this.txtSubOpcionSeleccionada.Text = datosLlamada[3];
            this.panelDatosLlamada.Visible = true;
        }

        // Muestra las posibles validaciones con sus respuestas asociadas a la subOpcion seleccionada en la llamada actual, dentro
        // de un elemento de interfaz gráfica de listBox, cada dato de texto se agrega como un Item de la lista.
        // Para eso se declara (hardcodeada) una lista de respuestas posibles para simular la validacion. 
        public void mostrarValidaciones(List<String> validaciones, List<String> respuestasCorrectas)
        {
            // Declaración de posibles respuestas para las validaciones (validacion por codigo postal)

            List<String> posiblesRespuestasCantHijos = new List<String>();

            posiblesRespuestasCantHijos.Add("4");
            posiblesRespuestasCantHijos.Add("1");


            this.listValidaciones.Items.Clear();

            // Muestra las validaciones correspondientes a la validacion por Codigo Postal

            validaciones.ForEach((validacion) =>
            {
                this.listValidaciones.Items.Add(validacion);
                this.rbRespuesta1.Text = posiblesRespuestasCantHijos[0];
                this.rbRespuesta2.Text = posiblesRespuestasCantHijos[1];
                this.rbRespuesta3.Text = respuestasCorrectas[0];
            });

            this.listValidaciones.Visible = true;
            this.txtRespuesta.Visible = true;
        }

        // Método que toma la respuesta que indicó el operador para las validaciones del cliente, y llama al mismo mensaje en 
        // el controlador con el mismo objetivo
        public void tomarRespuesta(String respuesta)
        {
            this.controladorRegistrarRespuesta.tomarRespuesta(respuesta);
        }

        // hace visible los elementos para ingresar la descripcion del operador a la consulta del cliente, tanto el lbl como el
        // campo para ingresar la descripcion
        public void solicitarDescripcion()
        {
            this.lblDescripcion.Visible = true;
            this.txtDescripcion.Visible = true;
        }

        // hace visible los elementos para ingresar la accion requerida por el cliente

        public void solicitarAccion()
        {
            this.lblAccionRequerida.Visible = true;
            this.txtAccionRequerida.Visible = true;
        }
        // hace viisble los elementos de interfaz para ingresar las respuestas a las validaciones mostradas, y reinicia todos
        // los que puedan tener datos cargados de antes o por defecto
        public void solicitarRespuesta()
        {
            this.btnTomarRespuesta.Visible = true;
        }

        // hace visible el botón de confirmar, para que se confirme la operación realizada.
        public void solicitarConfirmacion()
        {
            this.btnConfirmar.Visible = true;
        }

        // método para tomar la descripción ingresada en el textBox de descripcion, y llama al método tomarDescripcion del controlador
        // pasandole la descripcion como atributo
        public void tomarDescripcion()
        {
            string descripcion = this.txtDescripcion.Text;
            this.txtDescripcion.Enabled = false;

            MessageBox.Show("Descripcion ingresada: " + descripcion, "Ingreso de datos");

            this.controladorRegistrarRespuesta.tomarDescripcion(descripcion);
        }

        // Metodo para tomar la accion requerida que se ingresa por el textBox, y llama al método tomarAccion del controlador
        public void tomarAccion()
        {
            string accion = this.txtAccionRequerida.Text;
            this.txtAccionRequerida.Enabled = false;

            MessageBox.Show("Accion requerida: " + accion, "Ingreso de datos");

            controladorRegistrarRespuesta.tomarAccion(accion);
        }

        // método que toma la confirmación del operador a la operación realizada, se ejecuta cuando se clickea el boton de
        // confirmar
        public void tomarConfirmacion()
        {
            this.controladorRegistrarRespuesta.tomarConfirmacion();
        }

        // Muestra una ventana emergente que indica que la acción del CU 28 (Gestor CU - Registrar accion requerida) fue exitosa
        public void mostrarMsgRegistroAccion()
        {
            MessageBox.Show("La acción fue ejecutada de forma correcta", "Registrar accion requerida");
        }

        // Muestra un mensaje para continuar con la siguiente validación o confirmar la operación

        public void mostrarMsgValidacionCorrecta()
        {
            MessageBox.Show("Validacion correcta, ingrese los datos para concretar la operacion", "Validacion");
            this.solicitarDescripcion();
            this.solicitarAccion();
            this.solicitarConfirmacion();

            this.btnEnviarDescripcion.Visible = true;
            this.btnEnviarAccion.Visible = true;
        }

        // Muestra una ventana que indica que alguna de las validaciones que se intentó realizar fue incorrecta.
        public void mostrarMsgValidacionIncorrecta()
        {
            MessageBox.Show("Error, una de las validaciones es incorrecta", "Error");
        }
        // Muestra una ventana que informa que la acción del CU 28 no se pudo ejecutar de forma correcta
        public void mostrarMsgRegistroAccionIncorrecta()
        {
            MessageBox.Show("Error, la acción no pudo ejecutarse correctamente", "Registrar accion requerida - Error");
        }

        public void mostrarDatosFinDeLlamada(String duracion, String descripcionRespuesta)
        {
            MessageBox.Show("Duracion de la llamada: " + duracion + "\n" + "Descripcion de la respuesta: " + descripcionRespuesta, "Datos del fin de llamada:");
        }

        // Detecta un evento de click en el botón confirmar y llama al método para tomar la confirmacion
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.tomarConfirmacion();
        }

        // Los siguientes 3 eventos corresponden a las selecciones de respuestas posibles para una validacion, corresponden
        // cada uno a un radio button que se puede elegir, luego ejecuta el método tomarRespuesta con el texto de la validacion
        private void rbRespuesta1_CheckedChanged(object sender, EventArgs e)
        {
            this.txtRespuesta.Text = rbRespuesta1.Text;
        }

        private void rbRespuesta2_CheckedChanged(object sender, EventArgs e)
        {
            this.txtRespuesta.Text = rbRespuesta2.Text;
        }

        private void rbRespuesta3_CheckedChanged(object sender, EventArgs e)
        {
            this.txtRespuesta.Text = rbRespuesta3.Text;
        }

        private void VentanaRegistrarRespuesta_Load(object sender, EventArgs e)
        {

        }

        private void btnTomarRespuesta_Click(object sender, EventArgs e)
        {
            this.tomarRespuesta(txtRespuesta.Text);
        }

        // Para efectos de la simulacion,mostrar los datos de la llamada cuando se recibe el click para cargar los datos.
        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
        }

        // Método para tomar la descripcion ingresada en txtDescripcion
        private void btnEnviarDescripcion_Click(object sender, EventArgs e)
        {
            this.tomarDescripcion();
        }

        // Método para tomar la accion registrada en txtAccionRequerida
        private void btnEnviarAccion_Click(object sender, EventArgs e)
        {
            this.tomarAccion();
        }
    }
}
