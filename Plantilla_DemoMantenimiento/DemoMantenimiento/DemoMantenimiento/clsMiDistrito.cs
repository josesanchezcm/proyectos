using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DemoMantenimiento
{
    class clsMiDistrito
    {
        SqlConnection cnx = new SqlConnection
           ("server=.;Database=VentasLeon; Integrated Security=SSPI");
        SqlCommand cmd = new SqlCommand();

        public struct stDistrito
        {
            public string mvarcod;
            public string mvarnom;
            public string mvarven;
        }
        stDistrito _stDistrito = new stDistrito();


        public DataTable ListarDistrito()
        {
            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarDistrito";
                SqlDataAdapter miada = default(SqlDataAdapter);
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "Distritos");
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el listado:" + ex.Message);
            }
            return dts.Tables["Distritos"];
        
        
        }
    }
}
