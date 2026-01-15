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
        int edoSave = 0;
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
            txtStockActual.Text = "";
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
                txtCategoria.Text = Convert.ToString(dtgvArticulos.CurrentRow.Cells["descripcion_cat"].Value); ;
                txtStockActual.Text = Convert.ToString(dtgvArticulos.CurrentRow.Cells["stock_actual"].Value); ;
            }
        }
        #endregion 
        private void Frm_Articulos_Load(object sender, EventArgs e)
        {
            Listado_Art("");
           /* D_Articulos d = new D_Articulos();
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
            EstadoTxt(false);
            EstadoBtnProceso(false);
            EstadoBtnPrincipal(true);
            txtSearch.Focus();
            LimpiarCajasTxt(); 
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
            string respuesta = "";
            DateTime ahora= DateTime.Now;
            P_Articulos p_Articulos = new P_Articulos();
            D_Articulos d_Articulos = new D_Articulos();
            p_Articulos.Codigo_Ar = CodArticulo;

            p_Articulos.Descripcion_Ar=txtArticulo.Text;
            p_Articulos.Marca_Ar = txtMarca.Text ;
            //p_Articulos.Codigo_Um = Convert.ToInt32(txtMedida.Text);
            //p_Articulos.Codigo_Ca = Convert.ToInt32(txtCategoria.Text);
            p_Articulos.Codigo_Um=1;           
            p_Articulos.Codigo_Ca = 1;
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
                MessageBox.Show("Los datos se grabaron correctamente","Aviso del Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Listado_Art("");
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
    }
}
