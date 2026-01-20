using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;
using Microsoft.Reporting.WinForms;

namespace Dasha_Almancen.Presentacion
{
    public partial class Frm_Rpt_Articulos : Form
    {
        public Frm_Rpt_Articulos()
        {
            InitializeComponent();
        }
        #region "Mis Metodos"

        private void Listado()
        {
            
            MySqlConnection conn = new MySqlConnection();
            try
            {
                string cTexto = "%";
                conn =Cnx.getInstancia().CrearConexionMySQL();
                string sqlTarea = " SELECT a.codigo_art, " +
                       "a.descripcion_art, " +
                       "a.marca_art, " +
                       "b.descripcion_um, " +
                       "c.descripcion_cat, " +
                       "a.stock_actual " +
                       " FROM tb_articulos  a " +
                       " INNER JOIN tb_unidades_medidas b ON a.codigo_um = b.codigo_um " +
                       " INNER JOIN tb_categorias c ON a.codigo_cat = c.codigo_cat " +
                       " WHERE  a.descripcion_art LIKE '"+ cTexto + "' "+
                       " AND a.estado=1 " +
                       " ORDER BY a.codigo_art";
                
                    MySqlDataAdapter da = new MySqlDataAdapter(sqlTarea, conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    ReportDataSource rds=new ReportDataSource("DataSet1", ds.Tables[0]);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.ReportEmbeddedResource = "Dasha_Almancen.Presentacion.rpt_Articulos.rdlc";
                reportViewer1.LocalReport.Refresh();
                reportViewer1.Refresh();
                reportViewer1.RefreshReport();
                    
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
             
            }
         
        }
        #endregion

        private void Frm_Rpt_Articulos_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
            this.Listado();
        }
    }
}
