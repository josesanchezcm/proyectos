using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace DemoMantenimiento
{
    public class clsMiVendedor
    {
        SqlConnection cnx = new SqlConnection
            ("server=.;Database=VentasLeon; Integrated Security=SSPI");
        SqlCommand cmd = new SqlCommand();
        bool vexito = false;
        public struct stVendedor
        {
            public string mvarcod;
            public string mvarnom;
            public string mvarape;
            public  double mvarsue;
            public string mvartipo;
            public System.DateTime mvarfecing;
        }
        stVendedor _stVendedor = default(stVendedor);
        public bool InsertarVendedor(stVendedor stVen)
        {
            
           // Codifique
            return vexito;
        }
        public bool ActualizarVendedor(stVendedor stven)
        {
            // Codifique
            return vexito;
        }
        public bool EliminarVendedor(string vcod)
        {
            // Codifique
            return vexito;
        }

        public DataTable ListarVendedores()
        {
            DataSet dts = new DataSet();
            // Codifique
            
            return dts.Tables["Vendedores"];
        }

       
        public stVendedor ConsultarVendedor(string vcod)
        {
            // Codifique
            return _stVendedor;
        }

    }
    



}