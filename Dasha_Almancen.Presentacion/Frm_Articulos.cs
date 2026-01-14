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
        #region
        private void Formato_Art()
        {

            dtgvArticulos.Columns[0].Width = 80;
            dtgvArticulos.Columns[0].HeaderText = "Codigo";
            dtgvArticulos.Columns[1].Width = 250;
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

        private void Listado_Art(string cTexto)
        {
            D_Articulos dt = new D_Articulos();
            dtgvArticulos.DataSource = dt.ListadoArticulos(cTexto);
            this.Formato_Art();
        }
        #endregion
        private void Frm_Articulos_Load(object sender, EventArgs e)
        {
            this.Listado_Art("%");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Listado_Art("%"+txtSearch.Text.Trim()+"%");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.EstadoTxt(true);
            this.EstadoBtnProceso(true);
            this.EstadoBtnPrincipal(false);
            txtArticulo.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.EstadoTxt(false);
            this.EstadoBtnProceso(false);
            this.EstadoBtnPrincipal(true);
            txtSearch.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.EstadoTxt(true);
            this.EstadoBtnProceso(true);
            this.EstadoBtnPrincipal(false);
            txtArticulo.Focus();
        }
    }
}
