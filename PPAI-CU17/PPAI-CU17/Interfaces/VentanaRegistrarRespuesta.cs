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
            Width = 800;
            Height = 600;

            /* Crear y configurar la grilla de datos de llamada
            grillaDatosLlamada = new DataGridView();
            grillaDatosLlamada.ReadOnly = true; // Configurar como de solo lectura
            grillaDatosLlamada.ColumnCount = 1; // Establecer una sola columna
            grillaDatosLlamada.Columns[0].HeaderText = "Datos de Llamada"; // Establecer encabezado de columna
            grillaDatosLlamada.Columns[0].Width = Width / 2; // Establecer el ancho al 50% de la ventana
            grillaDatosLlamada.Dock = DockStyle.Fill; // Llenar toda la ventana con la grilla
            grillaDatosLlamada.RowHeadersVisible = false; // Ocultar encabezados de fila
            grillaDatosLlamada.AllowUserToAddRows = false; // Deshabilitar agregar nuevas filas
            grillaDatosLlamada.AllowUserToDeleteRows = false; // Deshabilitar eliminar filas
            grillaDatosLlamada.AllowUserToResizeRows = false; // Deshabilitar redimensionar filas
            grillaDatosLlamada.BorderStyle = BorderStyle.None; // Sin bordes en las celdas
            grillaDatosLlamada.BackgroundColor = Color.White; // Color de fondo de la grilla
            grillaDatosLlamada.CellBorderStyle = DataGridViewCellBorderStyle.None; // Sin bordes en las celdas
            grillaDatosLlamada.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleccionar toda la fila al hacer clic
            */

            /* Crear y configurar el TextBox de los datos de llamada
            this.txtDatosLlamada = new TextBox();
            this.txtDatosLlamada.Multiline = true;
            this.txtDatosLlamada.ReadOnly = true;
            this.txtDatosLlamada.Dock = DockStyle.Top;
            */
            // Crear y configurar la lista de validaciones
            this.listaValidaciones = new ListBox();
            this.listaValidaciones.Visible = false;

            // Crear y configurar los campos de texto
            this.txtRespuesta = new TextBox();
            this.txtRespuesta.Visible = false;
            this.txtAccion = new TextBox();
            this.txtAccion.Visible = false;
            this.txtDescripcion = new TextBox();
            this.txtDescripcion.Visible = false;

            // Crear y configurar el botón de confirmación
            this.btnConfirmar = new Button();
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.Click += BtnConfirmar_Click;
            this.btnConfirmar.Visible = false;

            // Agregar los controles a la ventana
            this.Controls.Add(txtDatosLlamada);
            this.Controls.Add(listaValidaciones);
            this.Controls.Add(txtRespuesta);
            this.Controls.Add(txtAccion);
            this.Controls.Add(txtDescripcion);
            this.Controls.Add(btnConfirmar);

            InitializeComponent();
        }

        public void habilitar()
        {
            this.Show();
        }

        public void mostrarDatosLlamada(String datosLlamada)
        {
            this.txtDatosLlamada.Text = datosLlamada;
        }

        public void mostrarValidaciones(List<string> validaciones)
        {
            this.listaValidaciones.Items.Clear();
            foreach (var validacion in validaciones)
            {
                this.listaValidaciones.Items.Add(validacion);
            }
            this.txtDatosLlamada.Visible = false;
            this.listaValidaciones.Visible = true;
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

        private void VentanaRegistrarRespuesta_Load(object sender, EventArgs e)
        {

        }
    }


}
