﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace DemoMantenimiento
{
    
    public partial class VendedorMan01 : Form
    {

        clsMiVendedor mivend = new clsMiVendedor();
       
        public VendedorMan01()
        {
            InitializeComponent();
        }

       

        private void VendedorMan01_Load(object sender, EventArgs e)
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

        private void VendedorMan01_Activated(object sender, EventArgs e)
        {
          
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            // Codifique

        }

      

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Codifique
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : "  + ex.Message );
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}