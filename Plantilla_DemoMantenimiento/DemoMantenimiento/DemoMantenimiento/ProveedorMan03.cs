using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoMantenimiento
{
    public partial class ProveedorMan03 : Form
    {
       

        public ProveedorMan03()
        {
            InitializeComponent();
        }

        // definimos esta propiedad publica Codigo para poder cargar el proveedor seleccionado 
        // desde el formulario ProveedorMan01
        private String _codigo;
        public String Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        
        private void ProveedorMan03_Load(object sender, EventArgs e)
        {
            try
            {
                // Codifique

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
