using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DemoMantenimiento
{
    class clsMiProveedor
    {
        SqlConnection cnx = new SqlConnection
            ("server=.;Database=VentasLeon; Integrated Security=SSPI");
        SqlCommand cmd = new SqlCommand();
        bool vexito = false;
        public struct stProveedor
        {
            public string mvarcod;
            public string mvarraz;
            public string mvardir;
            public string mvartel;
            public string mvarcoddis;
            public string mvarcodrep;
        }
        stProveedor _stProveedor = new stProveedor();
        public bool InsertarProveedor(stProveedor stProv)
        {
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_InsertarProveedor";
            //Agregamos parametros 
            try
            {
                cmd.Parameters.Add(new SqlParameter("@vraz", SqlDbType.VarChar, 25));
                cmd.Parameters["@vraz"].Value = stProv.mvarraz;
                cmd.Parameters.Add(new SqlParameter("@vdir", SqlDbType.VarChar, 25));
                cmd.Parameters["@vdir"].Value = stProv.mvardir;
                cmd.Parameters.Add(new SqlParameter("@vtel", SqlDbType.Char, 8));
                cmd.Parameters["@vtel"].Value = stProv.mvartel;
                cmd.Parameters.Add(new SqlParameter("@vdis", SqlDbType.Char, 3));
                cmd.Parameters["@vdis"].Value = stProv.mvarcoddis;
                cmd.Parameters.Add(new SqlParameter("@vrep", SqlDbType.VarChar, 30));
                cmd.Parameters["@vrep"].Value = stProv.mvarcodrep;
                cnx.Open();
                cmd.ExecuteNonQuery();
                vexito = true;
            }
            catch (SqlException x)
            {
                vexito = false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
                cmd.Parameters.Clear();
            }
            return vexito;

        }
       

        public bool ActualizarProveedor(stProveedor stProv)
        {
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ActualizarProveedor";
            //Agregamos parametros para la instruccion SQL
            try
            {
                cmd.Parameters.Add(new SqlParameter("@vcod", SqlDbType.Char, 4));
                cmd.Parameters["@vcod"].Value = stProv.mvarcod;
                cmd.Parameters.Add(new SqlParameter("@vraz", SqlDbType.VarChar, 25));
                cmd.Parameters["@vraz"].Value = stProv.mvarraz;
                cmd.Parameters.Add(new SqlParameter("@vdir", SqlDbType.VarChar, 25));
                cmd.Parameters["@vdir"].Value = stProv.mvardir;
                cmd.Parameters.Add(new SqlParameter("@vtel", SqlDbType.Char, 8));
                cmd.Parameters["@vtel"].Value = stProv.mvartel;
                cmd.Parameters.Add(new SqlParameter("@vdis", SqlDbType.Char, 3));
                cmd.Parameters["@vdis"].Value = stProv.mvarcoddis;
                cmd.Parameters.Add(new SqlParameter("@vrep", SqlDbType.VarChar, 30));
                cmd.Parameters["@vrep"].Value = stProv.mvarcodrep;
                cnx.Open();
                cmd.ExecuteNonQuery();
                vexito = true;
            }
            catch (SqlException x)
            {
                vexito = false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
                cmd.Parameters.Clear();
            }
            return vexito;
        }

     
        public bool EliminarProveedor(string vcod)
        {
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_EliminarProveedor";
            //Agregamos parametros
            try
            {
                cmd.Parameters.Add(new SqlParameter("@vcod", SqlDbType.Char, 4));
                cmd.Parameters["@vcod"].Value = vcod;
                cnx.Open();
                cmd.ExecuteNonQuery();
                vexito = true;
            }
            catch (SqlException x)
            {
                vexito = false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
                cmd.Parameters.Clear();
            }
            return vexito;
        }

       public DataTable ListarProveedor()
        {
            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarProveedor";
                SqlDataAdapter miada = default(SqlDataAdapter);
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "Proveedores");
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el listado:" + ex.Message);
            }
            return dts.Tables["Proveedores"];
        }

        public stProveedor ConsultarProveedor(string vcod)
        {
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarProveedor";
                cmd.Parameters.Add(new SqlParameter("@vcod", SqlDbType.Char, 4));
                cmd.Parameters["@vcod"].Value = vcod;
                cnx.Open();
                SqlDataReader dtr = cmd.ExecuteReader();
                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    _stProveedor.mvarcod = dtr.GetValue(dtr.GetOrdinal("Cod_prv")).ToString();
                    _stProveedor.mvarraz = dtr.GetValue(dtr.GetOrdinal("Raz_soc_prv")).ToString();
                    _stProveedor.mvardir = dtr.GetValue(dtr.GetOrdinal("Dir_prv")).ToString();
                    _stProveedor.mvartel = dtr.GetValue(dtr.GetOrdinal("Tel_prv")).ToString();
                    _stProveedor.mvarcoddis = dtr.GetValue(dtr.GetOrdinal("Cod_dis")).ToString();
                    _stProveedor.mvarcodrep = dtr.GetValue(dtr.GetOrdinal("Rep_ven")).ToString();

                }
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
                cmd.Parameters.Clear();
            }
            return _stProveedor;
        }

    }
}
