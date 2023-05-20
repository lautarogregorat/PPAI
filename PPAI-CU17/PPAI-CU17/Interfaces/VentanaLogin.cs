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
    public partial class VentanaLogin : Form
    {

        public VentanaLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            InterfazSistema interfaz = new InterfazSistema();
            interfaz.Show();
            this.Hide();


        }

        private void VentanaLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
