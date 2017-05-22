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
    public partial class VendedorMan02 : Form
    {
        
        public VendedorMan02()
        {
            InitializeComponent();
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
           try
            {
                // Codifique
            }
           catch ( Exception ex)
            {
           MessageBox .Show ("Se ha producido el error: " + ex.Message );
           }

         }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
