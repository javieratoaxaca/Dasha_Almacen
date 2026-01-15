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
    public class D_Articulos
    {  //este codigo ya no se utilizara se tuvo una modificacion
        /*public DataTable ListadoArticulos(string cTexto)
        {
            MySqlDataReader res;
            DataTable dt = new DataTable();
            MySqlConnection sqlCnx = new MySqlConnection();
            try
            {
                sqlCnx = Cnx.getInstancia().CrearConexionMySQL();
                string sqlTarea = "select  a.codigo_art, " +
                                  "a.descripcion_art, " +
                                  "a.marca_art, " +
                                  "b.descripcion_um, " +
                                  "c.descripcion_cat, " +
                                  "a.stock_actual, " +
                                  "a.codigo_um, " +
                                  "a.codigo_cat "+
                                  "from tb_articulos a " +
                                  "inner join tb_unidades_medidas b on a.codigo_um=b.codigo_um " +
                                  "inner join tb_categorias c on a.codigo_cat=c.codigo_cat " +
                                  "where a.descripcion_art like '"+cTexto+"' "+
                                  "order by a.codigo_art" ;
                MySqlCommand cmd = new MySqlCommand(sqlTarea, sqlCnx);
                //cmd.CommandTimeout = 60;
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
        }*/
        //con este codigo se mejoro la muestra de los datos para que se mostraran en el dtgvArticulos
        public DataTable ListadoArticulos(string cTexto)
        {
            DataTable dt = new DataTable();

            try
            {
                using (MySqlConnection sqlCnx = Cnx.getInstancia().CrearConexionMySQL())
                {
                    string sqlTarea =
                        "SELECT a.codigo_art, " +
                        "a.descripcion_art, " +
                        "a.marca_art, " +
                        "b.descripcion_um, " +
                        "c.descripcion_cat, " +
                        "a.stock_actual, " +
                        "a.codigo_um, " +
                        "a.codigo_cat " +
                        "FROM tb_articulos  a " +
                        "INNER JOIN tb_unidades_medidas b ON a.codigo_um = b.codigo_um " +
                        "INNER JOIN tb_categorias c ON a.codigo_cat = c.codigo_cat " +
                        "WHERE a.descripcion_art LIKE @texto " +
                        "ORDER BY a.codigo_art";

                    using (MySqlCommand cmd = new MySqlCommand(sqlTarea, sqlCnx))
                    {
                        cmd.Parameters.AddWithValue("@texto", "%" + cTexto + "%");

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

        public string SaveArticulos(int Opt,P_Articulos objArticulos)
        {
            string respuesta = "";
            string sqlTarea;
            MySqlConnection sqlCnx = new MySqlConnection();
            try
            {
                sqlCnx = Cnx.getInstancia().CrearConexionMySQL();
                if (Opt == 1) // nuevo registro
                {
                    
                    
                    sqlTarea = "insert into tb_articulos(descripcion_art,marca_art,codigo_um,codigo_cat,stock_actual,fecha_crea,fecha_mod)" +
                        "values('" + objArticulos.Descripcion_Ar+"', '" 
                                   + objArticulos.Marca_Ar + "', " 
                                   + objArticulos.Codigo_Um + ", " 
                                   + objArticulos.Codigo_Ca + ", " 
                                   + objArticulos.Stock_Actual + ",  '" 
                                   + objArticulos.Fecha_crea + "',  '"
                                   + objArticulos.Fecha_Modifica+ "');";
                    
                }
                else // actualizar registro
                {
                    sqlTarea =
                                "UPDATE tb_articulos SET " +
                                "descripcion_art='" + objArticulos.Descripcion_Ar + "', " +
                                "marca_art='" + objArticulos.Marca_Ar + "', " +
                                "codigo_um=" + objArticulos.Codigo_Um + ", " +
                                "codigo_cat=" + objArticulos.Codigo_Ca + ", " +
                                "stock_actual=" + objArticulos.Stock_Actual + ", " +
                                "fecha_mod='" + objArticulos.Fecha_Modifica + "' " +
                                "WHERE codigo_art=" + objArticulos.Codigo_Ar + ";";
                }

                MySqlCommand cmd = new MySqlCommand(sqlTarea, sqlCnx);
                sqlCnx.Open();
                respuesta = cmd.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo ingresar el registro";
            }
            catch (Exception ex)
            {
                respuesta=ex.Message;
            }
            finally
            {
                if (sqlCnx.State != ConnectionState.Open) sqlCnx.Close();
            }
            return respuesta;
        }

        public string DeleteArticulos(int nCodigoArticulo)
        {
            string respuesta = "";
            string sqlTarea;
            MySqlConnection sqlCnx = new MySqlConnection();
            try
            {
                sqlCnx = Cnx.getInstancia().CrearConexionMySQL();
                sqlTarea = "DELETE FROM tb_articulos WHERE codigo_art='"+nCodigoArticulo+"';";

                MySqlCommand cmd = new MySqlCommand(sqlTarea, sqlCnx);
                sqlCnx.Open();
                respuesta = cmd.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo eliminar el registro";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (sqlCnx.State != ConnectionState.Open) sqlCnx.Close();
            }
            return respuesta;
        }
    }
}
