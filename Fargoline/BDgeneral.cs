using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fargoline
{
    public class BDgeneral
    {

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=prueba;Data Source=DESKTOP-MKGLSNG\\SQLEXPRESS");
            conn.Open();

            return conn;
        }

    }
}
