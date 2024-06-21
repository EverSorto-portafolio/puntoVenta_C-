using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using puntoVenta.Entidad;
namespace puntoVenta.Datos
{
    public class D_categoria
    {
        public DataTable listado_categoria(string) {
            SqlDataReader resultado; 
            DataTable tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();
            try {
                SQLCon = Conexion.getInstans().conectar();
                SqlCommand comando = new SqlCommand("", SQLCon);

            } catch (Exception ex) {

                throw ex;
            }
            finally {
                if (SQLCon.State == ConnectionState.Open) SQLCon.Close();
            }

            return
        }

    }
}
