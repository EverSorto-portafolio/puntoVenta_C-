using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using puntoVenta.Entidad;
using puntoVenta.Datos;

namespace puntodeVenta.Negocio
{
    public class N_categoria
    {
        public static DataTable listado_ca(string cTexto) { 

            D_categoria datos = new D_categoria();

            return datos.listado_categoria(cTexto);
        }
    }
}
