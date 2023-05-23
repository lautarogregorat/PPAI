using PPAI_CU17.Controladores;
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
        private TextBox txtDescripcion;
        private Button btnConfirmar;
        public ControladorRegistrarRespuesta controladorRegistrarRespuesta;

        // Constructor de la clase
        public VentanaRegistrarRespuesta()
        {
            InitializeComponent();
        }

        public void habilitar()
        {
            this.Show();
        }

        public void mostrarDatosLlamada(List<string> datosLlamada)
        {
            this.txtNombreCliente.Text = datosLlamada[0];
            this.txtCategoriaSeleccionada.Text = datosLlamada[1];
            this.txtOpcionSeleccionada.Text = datosLlamada[2];
            this.txtSubOpcionSeleccionada.Text = datosLlamada[3];
            this.panelDatosLlamada.Visible = true;
        }

        public void mostrarValidaciones(List<String> validaciones)
        {
            this.listValidaciones.Items.Clear();

            foreach (var validacion in validaciones)
            {
                this.listValidaciones.Items.Add(validacion);
            }
            this.listValidaciones.Visible = true;
        }

        public void tomarRespuesta()
        {
            string respuesta = this.txtRespuesta.Text;

            this.controladorRegistrarRespuesta.tomarRespuesta(respuesta);
        }

        public void solicitarDescripcion()
        {
            MessageBox.Show("Por favor, ingrese la descripción de la consulta del cliente.");
        }

        public void solicitarAccion()
        {
            MessageBox.Show("Por favor, ingrese una la acción a realizar");
        }

        public void solicitarRespuesta()
        {
            this.txtRespuesta.Visible = true;
            this.lblRespuesta.Visible = true;
            this.btnTomarRespuesta.Visible = true;
            this.txtRespuesta.Clear();
        }
        public void solicitarConfirmacion()
        {
            MessageBox.Show("Desea confirmar el registro de la respuesta?");
            this.btnConfirmar.Visible = true;
        }

        public void tomarDescripcion()
        {
            string descripcion = this.txtDescripcion.Text;
            this.controladorRegistrarRespuesta.tomarDescripcion(descripcion);
            // Guardar la descripción en alguna estructura de datos o hacer algo con ella
        }

        public void tomarAccion()
        {
            string accion = this.txtAccion.Text;
            controladorRegistrarRespuesta.tomarAccion(accion);
        }

        public void tomarConfirmacion()
        {
            this.controladorRegistrarRespuesta.tomarConfirmacion();
        }

        public void mostrarMsgRegistroAccion()
        {
            MessageBox.Show("La acción fue ejecutada de forma correcta");
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            // Realizar alguna lógica al hacer clic en el botón de confirmación
            tomarConfirmacion();
        }

        private void btnTomarRespuesta_Click(object sender, EventArgs e)
        {

            this.tomarRespuesta();
        }

        private void VentanaRegistrarRespuesta_Load(object sender, EventArgs e)
        {

        }

        
    }


}
