using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Dasha_Almancen.Presentacion
{
    public class D_Articulos
    { 
        public DataTable ListadoArticulos(string cTexto)
        {
            MySqlDataReader res;
            DataTable dt = new DataTable();
            MySqlConnection sqlCnx = new MySqlConnection();
            try
            {
                sqlCnx = Cnx.getInstancia().CrearConexionMySQL();
                string sqlTarea = "select  a.codigo_art," +
                                  "a.descripcion_art," +
                                  "a.marca_art," +
                                  "b.descripcion_um," +
                                  "c.descripcion_cat," +
                                  "a.stock_actual," +
                                  "a.codigo_um," +
                                  "a.codigo_cat "+
                                  "from tb_articulos a " +
                                  "inner join tb_unidades_medidas b on a.codigo_um=b.codigo_um " +
                                  "inner join tb_categorias c on a.codigo_cat=c.codigo_cat " +
                                  "where a.descripcion_art like '"+cTexto+"' "+
                                  "order by a.codigo_art" ;
                MySqlCommand cmd = new MySqlCommand(sqlTarea, sqlCnx);
                cmd.CommandTimeout = 60;
                sqlCnx.Open();
                res = cmd.ExecuteReader();
                dt.Load(res);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            } 
            finally
            {
                if(sqlCnx.State != ConnectionState.Open) sqlCnx.Close();
            }
        }
    }
}
