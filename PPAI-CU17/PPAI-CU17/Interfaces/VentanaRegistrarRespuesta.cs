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
        private TextBox txtDatosLlamada;
        private ListBox listaValidaciones;
        private TextBox txtRespuesta;
        private TextBox txtAccion;
        private TextBox txt;
        private Button btn;
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
            // Declaración de posibles respuestas para las validaciones

            List<String> posiblesRespuestasCp = new List<String>();

            posiblesRespuestasCp.Add("5000");
            posiblesRespuestasCp.Add("4500");


            this.listValidaciones.Items.Clear();

            validaciones.ForEach((validacion) =>
            {
                this.listValidaciones.Items.Add(validacion);
                this.rbRespuesta1.Text = posiblesRespuestasCp[0];
                this.rbRespuesta2.Text = posiblesRespuestasCp[1];
                this.rbRespuesta3.Text = respuestasCorrectas[0];
            });

            this.listValidaciones.Visible = true;
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
            this.txtRespuesta.Visible = true;
            this.lblRespuesta.Visible = true;
            this.btnTomarRespuesta.Visible = true;
            this.txtRespuesta.Clear();
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
            this.controladorRegistrarRespuesta.tomarDescripcion(descripcion);
        }

        // Metodo para tomar la accion requerida que se ingresa por el textBox, y llama al método tomarAccion del controlador
        public void tomarAccion()
        {
            string accion = this.txtAccion.Text;
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
            MessageBox.Show("La acción fue ejecutada de forma correcta");
        }

        // Muestra una ventana que indica que alguna de las validaciones que se intentó realizar fue incorrecta.
        public void mostrarMsgValidacionIncorrecta()
        {
            MessageBox.Show("Error, una de las validaciones es incorrecta");
        }
        // Muestra una ventana que informa que la acción del CU 28 no se pudo ejecutar de forma correcta
        public void mostrarMsgRegistroAccionIncorrecta()
        {
            MessageBox.Show("Error, la acción no pudo ejecutarse correctamente");
        }

        // Detecta un evento de click en el botón confirmar y llama al método para tomar la confirmacion
        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            this.tomarConfirmacion();
        }

        // Los siguientes 3 eventos corresponden a las selecciones de respuestas posibles para una validacion, corresponden
        // cada uno a un radio button que se puede elegir, luego ejecuta el método tomarRespuesta con el texto de la validacion
        private void rbRespuesta1_CheckedChanged(object sender, EventArgs e)
        {
            this.tomarRespuesta(rbRespuesta1.Text);
        }

        private void rbRespuesta2_CheckedChanged(object sender, EventArgs e)
        {
            this.tomarRespuesta(rbRespuesta2.Text);
        }

        private void rbRespuesta3_CheckedChanged(object sender, EventArgs e)
        {
            this.tomarRespuesta(rbRespuesta3.Text);
        }

        private void VentanaRegistrarRespuesta_Load(object sender, EventArgs e)
        {

        }




    }
}
