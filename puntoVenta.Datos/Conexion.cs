using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace puntoVenta.Datos
{
    public class Conexion
    {
        private string dataBase;
        private string servidor;
        private string usuario;
        private string clave;
        private bool seguridad;
        private static Conexion con = null;

        private Conexion(){
            this.dataBase = "DB_puntoVenta";
            this.servidor = "DESKTOP-JUKRMDJ\\SQLEXPRESS";
            this.usuario = "unab";
            this.clave = "1234";
            this.seguridad = false;
        }
        public SqlConnection conectar()
        { 
            SqlConnection con = new SqlConnection(); //cadena 

            String cadena = $"server={this.servidor}; database={this.dataBase};";
            String datoUser = $"User Id=`{this.usuario}; Password={this.clave}"; 

            // "server=" + this.servidor + ";database=" + this.dataBase + ";";
            //"User Id =" + this.Usuario + "; Password="+this,clave;

            try {
                con.ConnectionString = cadena;
                if (seguridad)
                {
                    con.ConnectionString = con.ConnectionString + "Integrated Security = SSPI";
                }
                else {
                    con.ConnectionString = con.ConnectionString + datoUser;
                }
            }catch(Exception ex){
                con = null;
                throw ex;
            }
            return con;
        }

        //metodo para ejecutar las instancias creadas anteriormente.
        public static Conexion getInstans() {
            if (con == null) { 
                con = new Conexion();
            }        
            return con;
        }
    }
}
