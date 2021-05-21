using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Hospital
{
    public class ClsUser
    {
        ClsConexion objconexion = new ClsConexion();
        SqlCommand cmd = new SqlCommand();
        public DataSet consultar_user(string pnom_user)
        {
            try
            {
                cmd.Connection = objconexion.abrir_base();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_consultar_user";
                cmd.Parameters.Add("@pnom_user", pnom_user);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
            
        }
    }
}