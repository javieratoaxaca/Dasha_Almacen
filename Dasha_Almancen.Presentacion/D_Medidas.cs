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
    public class D_Medidas
    { 
        public DataTable ListadoMedidas()
        {
            DataTable dt = new DataTable();

            try
            {
                using (MySqlConnection sqlCnx = Cnx.getInstancia().CrearConexionMySQL())
                {
                    string sqlTarea = "select descripcion_um, codigo_um from tb_unidades_medidas";

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
