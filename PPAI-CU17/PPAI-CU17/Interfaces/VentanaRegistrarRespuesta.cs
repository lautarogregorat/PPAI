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

        // Constructor de la clase
        public VentanaRegistrarRespuesta()
        {
            // Configurar las propiedades de la ventana
            Text = "Ventana de Registrar Respuesta";
            Width = 800;
            Height = 600;

            // Crear y configurar la grilla de datos
            /*
            grillaDatosLlamada = new DataGridView();
            grillaDatosLlamada.Dock = DockStyle.Fill;
            grillaDatosLlamada.RowHeadersVisible = true;
            grillaDatosLlamada.Columns.Add("Cliente:", "nombreCliente");
            grillaDatosLlamada.Columns.Add("Opcion seleccionada:", "nombreOpcion");
            grillaDatosLlamada.Columns.Add("SubOpcion seleccionada:", "nombreSubOpcion");
            grillaDatosLlamada.Columns.Add("Categoria seleccionada:", "nombreCategoria");
            */

            // Crear y configurar el TextBox de los datos de llamada
            txtDatosLlamada = new TextBox();
            txtDatosLlamada.Multiline = true;
            txtDatosLlamada.ReadOnly = true;
            txtDatosLlamada.Dock = DockStyle.Fill;


            // Crear y configurar la lista de validaciones
            listaValidaciones = new ListBox();
            listaValidaciones.Visible = false;

            // Crear y configurar los campos de texto
            txtRespuesta = new TextBox();
            txtAccion = new TextBox();
            txtDescripcion = new TextBox();

            // Crear y configurar el botón de confirmación
            btnConfirmar = new Button();
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.Click += BtnConfirmar_Click;

            // Agregar los controles a la ventana
            Controls.Add(txtDatosLlamada);
            Controls.Add(listaValidaciones);
            Controls.Add(txtRespuesta);
            Controls.Add(txtAccion);
            Controls.Add(txtDescripcion);
            Controls.Add(btnConfirmar);
        }

        public void habilitar()
        {
            Show();
        }

        public void mostrarDatosLlamada(String datosLlamada)
        {
            txtDatosLlamada.Text = datosLlamada;
        }

        public void mostrarValidaciones(List<string> validaciones)
        {
            listaValidaciones.Items.Clear();
            foreach (var validacion in validaciones)
            {
                listaValidaciones.Items.Add(validacion);
            }
            listaValidaciones.Visible = true;
        }

        public void tomarRespuesta()
        {
            string respuesta = txtRespuesta.Text;
            // Guardar la respuesta en alguna estructura de datos o hacer algo con ella
        }

        public void solicitarDescripcion()
        {
            MessageBox.Show("Por favor, ingrese la descripción de la consulta del cliente.");
        }

        public void solicitarAccion()
        {
            MessageBox.Show("Por favor, ingrese una la acción a realizar");
        }

        public void tomarDescripcion()
        {
            string descripcion = txtDescripcion.Text;
            // Guardar la descripción en alguna estructura de datos o hacer algo con ella
        }

        public void tomarAccion()
        {
            string accion = txtAccion.Text;
            // Guardar la acción en alguna estructura de datos o hacer algo con ella
        }

        public void tomarConfirmacion()
        {
            // Realizar alguna lógica adicional antes de mostrar el mensaje
            mostrarMsgRegistroAccion();
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

            private void VentanaRegistrarRespuesta_Load(object sender, EventArgs e)
        {

        }
    }
        

}
