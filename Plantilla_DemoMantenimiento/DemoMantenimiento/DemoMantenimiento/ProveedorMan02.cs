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
    public partial class ProveedorMan02 : Form
    {
      

       

        public ProveedorMan02()
        {
            InitializeComponent();
        }

        private void ProveedorMan02_Load(object sender, EventArgs e)
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
            // para saber el codigo del distrito seleccionado maneje
            // la propiedad SelectedValue del combo de distritos

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
