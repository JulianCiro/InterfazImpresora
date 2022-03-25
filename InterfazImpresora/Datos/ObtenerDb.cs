using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace InterfazImpresora.Datos
{
    public class ObtenerDb
    {
        public static String ObtenerParametro(string parametroint)
        {
            //string parametro = "";
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConexionBd.builder.ConnectionString))
                    {
                        Console.WriteLine("Conexion a base de datos");
                        Console.WriteLine("==============");
                        string query = "select Valor from [DbMult].[dbo].[Parametros] where [Parametro]='"+parametroint+"'";
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            connection.Open();
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                reader.Read();
                                string lectura = reader.GetString(0);
                                return lectura;
                                
                            }
                        }



                     }
                 }
                catch (Exception)
                {


                }
                return "";
            }
        }
    }
}
    
