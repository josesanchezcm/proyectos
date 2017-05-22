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
    public partial class MdiPrincipal : Form
    {
        public MdiPrincipal()
        {
            InitializeComponent();
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VendedorMan01 frmVenMan01 = new VendedorMan01();
            frmVenMan01.MdiParent = this;
            frmVenMan01.Show();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProveedorMan01 frmPrvMan01 = new ProveedorMan01();
            frmPrvMan01.MdiParent = this;
            frmPrvMan01.Show();
        }
    }
}
