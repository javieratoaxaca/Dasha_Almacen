using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using MySql.Data;
using MySql.Data.MySqlClient;


namespace Dasha_Almancen.Presentacion
{
    public class D_Categorias
    { 
        public DataTable ListadoCategoria()
        {
            DataTable dt = new DataTable();

            try
            {
                using (MySqlConnection sqlCnx = Cnx.getInstancia().CrearConexionMySQL())
                {
                    string sqlTarea = "select descripcion_cat, codigo_cat from tb_categorias";

                    using (MySqlCommand cmd = new MySqlCommand(sqlTarea, sqlCnx))
                    {
                        
                        sqlCnx.Open();
                        using (MySqlDataReader res = cmd.ExecuteReader())
                        {
                            dt.Load(res);
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return dt;
        }

        
    }
}
