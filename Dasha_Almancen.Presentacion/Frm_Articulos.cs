using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dasha_Almancen.Presentacion
{
    public partial class Frm_Articulos : Form
    {
        public Frm_Articulos()
        {
            InitializeComponent();
        }
        #region "Mis Variables"
        int CodArticulo = 0;
        int CodUdM = 0;
        int edoSave = 0;
        int CodCat = 0;
        #endregion

        #region "Mis Metodos para Categorias"
        private void Formato_Categoria()
        {
            dtgvCategoria.Columns[0].Width = 150;
            dtgvCategoria.Columns[0].HeaderText = "CATEGORIAS";
            dtgvCategoria.Columns[1].Visible = false;
        }
        private void Listado_Categoria(string cTexto)
        {

            D_Categorias dt = new D_Categorias();
            dtgvCategoria.DataSource = dt.ListadoCategoria();
            Formato_Categoria();

        }
        private void SeleccionCategoria()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dtgvCategoria.CurrentRow.Cells["codigo_cat"].Value)))
            {
                MessageBox.Show("Selecciona un Elemento de la lista", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                CodCat = Convert.ToInt32(dtgvCategoria.CurrentRow.Cells["codigo_cat"].Value);
                txtCategoria.Text = Convert.ToString(dtgvCategoria.CurrentRow.Cells["descripcion_cat"].Value); ;
            }
        }
        #endregion

        #region "Mis Metodos para Unidades de Medida"
        private void Formato_Medida()
        {
            dtgvMedida.Columns[0].Width = 150;
            dtgvMedida.Columns[0].HeaderText = "MEDIDAS";
            dtgvMedida.Columns[1].Visible = false;
        }
        private void Listado_Medida(string cTexto)
        {

            D_Medidas dt = new D_Medidas();
            dtgvMedida.DataSource = dt.ListadoMedidas();
            Formato_Medida();

        }
        private void SeleccionUdM()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dtgvMedida.CurrentRow.Cells["codigo_um"].Value)))
            {
                MessageBox.Show("Selecciona un Elemento de la lista", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                CodUdM = Convert.ToInt32(dtgvMedida.CurrentRow.Cells["codigo_um"].Value);
                txtMedida.Text = Convert.ToString(dtgvMedida.CurrentRow.Cells["descripcion_um"].Value); ;
            }
        }
        #endregion

        #region "Mis Metodos"
        private void Formato_Art()
        {

            dtgvArticulos.Columns[0].Width = 80;
            dtgvArticulos.Columns[0].HeaderText = "Codigo";
            dtgvArticulos.Columns[1].Width = 200;
            dtgvArticulos.Columns[1].HeaderText = "Articulo";
            dtgvArticulos.Columns[2].Width = 150;
            dtgvArticulos.Columns[2].HeaderText = "Marca";
            dtgvArticulos.Columns[3].Width = 80;
            dtgvArticulos.Columns[3].HeaderText = "Medida";
            dtgvArticulos.Columns[4].Width = 150;
            dtgvArticulos.Columns[4].HeaderText = "Categoria";
            dtgvArticulos.Columns[5].Width = 150;
            dtgvArticulos.Columns[5].HeaderText = "Stock Actual";
            dtgvArticulos.Columns[6].Visible =false;
            dtgvArticulos.Columns[7].Visible = false;


        }    
        private void EstadoTxt(bool lEdo)
        {
            txtArticulo.ReadOnly=!lEdo;
            txtMarca.ReadOnly=!lEdo;
            txtStockActual.ReadOnly=!lEdo;
        }
        private void EstadoBtnProceso(bool lEdo)
        {
            btnLupaCategoria.Enabled=lEdo;
            btnLupaMedida.Enabled = lEdo;
            btnCancel.Visible=lEdo;
            btnSave.Visible=lEdo;

            txtSearch.ReadOnly=lEdo;
            btnSearch.Enabled=!lEdo;
            dtgvArticulos.Enabled=!lEdo;
        }
        private void EstadoBtnPrincipal (bool lEdo)
        {
            btnNew.Enabled=lEdo;
            btnUpdate.Enabled=lEdo;
            btnDelete.Enabled=lEdo;
            btnReport.Enabled=lEdo;
            btnClose.Enabled=lEdo;
        }
        private void LimpiarCajasTxt()
        {
            txtArticulo.Text = "";
            txtCategoria.Text = "";
            txtMarca.Text = "";
            txtMedida.Text = "";
            txtStockActual.Text = "0";
        }
        private void Listado_Art(string cTexto)
        {
           
            D_Articulos dt = new D_Articulos();
            dtgvArticulos.DataSource = dt.ListadoArticulos(cTexto);
          Formato_Art();

        }
        private void SeleccionItem()
        {
            if (string.IsNullOrEmpty(Convert.ToString( dtgvArticulos.CurrentRow.Cells["codigo_art"].Value)))
            {
                MessageBox.Show("Selecciona un Registro","Aviso del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
               CodArticulo = Convert.ToInt32(dtgvArticulos.CurrentRow.Cells["codigo_art"].Value);
                txtArticulo.Text = Convert.ToString(dtgvArticulos.CurrentRow.Cells["descripcion_art"].Value);
                txtMarca.Text = Convert.ToString(dtgvArticulos.CurrentRow.Cells["marca_art"].Value);
                txtMedida.Text= Convert.ToString(dtgvArticulos.CurrentRow.Cells["descripcion_um"].Value); ;
                txtCategoria.Text = Convert.ToString(dtgvArticulos.CurrentRow.Cells["descripcion_cat"].Value); 
                txtStockActual.Text = Convert.ToString(dtgvArticulos.CurrentRow.Cells["stock_actual"].Value);
                CodUdM = Convert.ToInt32(dtgvArticulos.CurrentRow.Cells["codigo_um"].Value);
                CodCat= Convert.ToInt32(dtgvArticulos.CurrentRow.Cells["codigo_cat"].Value);
            }
        }
        #endregion 
        private void Frm_Articulos_Load(object sender, EventArgs e)
        {
            Listado_Art("");
            Listado_Medida("");
            Listado_Categoria("");
            /*D_Articulos d = new D_Articulos();
            DataTable dt = d.ListadoArticulos("");
            MessageBox.Show("Filas: " + dt.Rows.Count);
            dtgvArticulos.DataSource = dt;*/
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Listado_Art("%'"+txtSearch.Text+"'%");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CodArticulo = 0;
            edoSave = 0;
            LimpiarCajasTxt();
            EstadoTxt(false);
            EstadoBtnProceso(false);
            EstadoBtnPrincipal(true);
            txtSearch.Focus();
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            edoSave = 1;
            EstadoTxt(true);
            EstadoBtnProceso(true);
            EstadoBtnPrincipal(false);
            txtArticulo.Focus();
            LimpiarCajasTxt();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           // edoSave= 1;
            string respuesta;
            DateTime ahora= DateTime.Now;
            P_Articulos p_Articulos = new P_Articulos();
            D_Articulos d_Articulos = new D_Articulos();
           

            p_Articulos.Codigo_Ar = CodArticulo;

            p_Articulos.Descripcion_Ar=txtArticulo.Text;
            p_Articulos.Marca_Ar = txtMarca.Text ;
            p_Articulos.Codigo_Um = CodUdM;     
            p_Articulos.Codigo_Ca = CodCat; 
            p_Articulos.Stock_Actual = Convert.ToDecimal(txtStockActual.Text);
            p_Articulos.Fecha_crea=ahora.ToString("yyyy-MM-dd HH:mm:ss"); 
            p_Articulos.Fecha_Modifica= ahora.ToString("yyyy-MM-dd HH:mm:ss");
            
            respuesta=d_Articulos.SaveArticulos(edoSave, p_Articulos);
            if (respuesta.Equals("OK"))
            {
                EstadoTxt(false);
                EstadoBtnProceso(false);
                EstadoBtnPrincipal(true);        
                LimpiarCajasTxt();
                Listado_Art("");
                edoSave = 0;
                CodArticulo = 0;
                CodUdM = 0;
                CodCat = 0;
                MessageBox.Show("Los datos se grabaron correctamente","Aviso del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
             }
            else
            {
                MessageBox.Show(respuesta, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            edoSave = 2; //update
            EstadoTxt(true);
            EstadoBtnProceso(true);
            EstadoBtnPrincipal(false);
            txtArticulo.Focus();

        }

        private void dtgvArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionItem();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (CodArticulo>0)
            {
                string respuesta;
                D_Articulos d_Articulos = new D_Articulos();
                respuesta=d_Articulos.DeleteArticulos(CodArticulo);
                if (respuesta.Equals("OK"))
                {
                    LimpiarCajasTxt();
                    Listado_Art("");
                    CodArticulo = 0;
                    MessageBox.Show("Registro Eliminado Correctamente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("No se tiene ningun registro seleccionado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Frm_Rpt_Articulos oRpt = new Frm_Rpt_Articulos();
            oRpt.ShowDialog();
        }

        private void btnLupaMedida_Click(object sender, EventArgs e)
        {
            Pnl_Medida.Location = btnLupaMedida.Location;
            Pnl_Medida.Visible = true;
        }

        private void btnLupaCategoria_Click(object sender, EventArgs e)
        {
            PnlCategoria.Location =btnLupaCategoria.Location;
            PnlCategoria.Visible = true;
        }

        private void btnBackMedida_Click(object sender, EventArgs e)
        {
            Pnl_Medida.Visible=false;
        }

        private void btnBackCategoria_Click(object sender, EventArgs e)
        {
            PnlCategoria.Visible=false;
        }
        private void dtgvMedida_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionUdM();
            Pnl_Medida.Visible = false;
        }

        private void dtgvCategoria_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionCategoria();
            PnlCategoria.Visible = false;
        }
    }
}
