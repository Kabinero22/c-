using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Fargoline
{
    public class ContenedorDAL
    {
        public static int AgregaConte(Contenedor contenedor)
        {
            int retorna = 0;

            using (SqlConnection conn = BDgeneral.ObtenerConexion())
            {
                /* FORMA CONVENCIONAL */
                /*string query = "INSERT INTO contenedor (NumeroC, TipoC, TamanoC, PesoC, TaraC) VALUES ('" + contenedor.NumeroC + "' , '" + contenedor.TipoC + "' , '" + contenedor.TamanoC + "' , " + contenedor.PesoC + " , " + contenedor.TaraC + " );";*/

                /* PROCEDIMIENTOS ALMACENADO "SP_agrega" */
                string query = "EXECUTE SP_agrega '"+contenedor.NumeroC+"','"+contenedor.TipoC+"','"+contenedor.TamanoC+"',"+contenedor.PesoC+","+contenedor.TaraC;
                
                SqlCommand comando = new SqlCommand(query, conn);

                retorna = comando.ExecuteNonQuery();
            }
            return retorna;
        }

        public static List<Contenedor> PresentarRegistro()
        {
            List<Contenedor> lista = new List<Contenedor>();
            using (SqlConnection conn = BDgeneral.ObtenerConexion())
            {
                string query = "Select * from contenedor";
                SqlCommand comando = new SqlCommand(query, conn);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Contenedor contenedor = new Contenedor();
                    contenedor.id = reader.GetInt32(0);
                    contenedor.NumeroC = reader.GetString(1);
                    contenedor.TipoC = reader.GetString(2);
                    contenedor.TamanoC = reader.GetString(3);
                    contenedor.PesoC = reader.GetDecimal(4);
                    contenedor.TaraC = reader.GetDecimal(5);
                    lista.Add(contenedor);
                }
                conn.Close();
                return lista;
            }

        }



        public static int modificar(Contenedor contenedor)
        {
            int result = 0;
            using (SqlConnection conn = BDgeneral.ObtenerConexion())
            {
                /* FORMA TRADICIONAL */
                /*string query = "UPDATE contenedor SET NumeroC='" +contenedor.NumeroC+ "', TipoC ="+contenedor.TipoC+ "', TamanoC ='"+contenedor.TamanoC+ "', PesoC="+contenedor.PesoC+ ", TaraC="+contenedor.TaraC+" WHERE id="+contenedor.id;*/

                string query = "EXECUTE SP_modifica '"+contenedor.id+"','"+contenedor.NumeroC+"','"+ contenedor.TipoC+"','"+ contenedor.TamanoC+"',"+ contenedor.PesoC+","+ contenedor.TaraC;
                /* EXECUTE SP_Modifica '1','C01111', 'HIG CUBE','20',888,777 */
                SqlCommand comando = new SqlCommand(query, conn);

                result = comando.ExecuteNonQuery();
                conn.Close();
            }
            return result;
        }






        public static int elimina(int id)
        {
            int retorna = 0;

            using (SqlConnection conn = BDgeneral.ObtenerConexion())
            {
                /*FORMA TRADICIONAL*/
                /*string query = "DELETE FROM contenedor WHERE id="+id+" ";*/


                string query = "EXECUTE SP_elimina '"+id+"'";
                /*EXECUTE SP_elimina '5'*/
                SqlCommand comando = new SqlCommand(query, conn);

                retorna = comando.ExecuteNonQuery();
            }
            return retorna;
        }



    }
}