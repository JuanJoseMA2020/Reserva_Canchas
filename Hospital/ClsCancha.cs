using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Hospital
{
    public class ClsCancha
    {
        ClsConexion objconec = new ClsConexion();
        SqlCommand cmd = new SqlCommand();
        public DataSet consultar_cancha(string pnom_cancha)
        {
            try
            {
                cmd.Connection = objconec.abrir_base();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_cosultar_canchas";
                cmd.Parameters.Add("@pnom_cancha", pnom_cancha);
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