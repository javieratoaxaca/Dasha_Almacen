namespace Dasha_Almancen.Presentacion
{
    partial class Frm_Articulos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Articulos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.txtMedida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.btnLupaMedida = new System.Windows.Forms.Button();
            this.btnLupaCategoria = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStockActual = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.Pnl_Medida = new System.Windows.Forms.Panel();
            this.btnBackMedida = new System.Windows.Forms.Button();
            this.dtgvMedida = new System.Windows.Forms.DataGridView();
            this.PnlCategoria = new System.Windows.Forms.Panel();
            this.btnBackCategoria = new System.Windows.Forms.Button();
            this.dtgvCategoria = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvArticulos)).BeginInit();
            this.Pnl_Medida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMedida)).BeginInit();
            this.PnlCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Artículo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Medida";
            // 
            // txtArticulo
            // 
            this.txtArticulo.Location = new System.Drawing.Point(80, 16);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.ReadOnly = true;
            this.txtArticulo.Size = new System.Drawing.Size(237, 20);
            this.txtArticulo.TabIndex = 3;
            // 
            // txtMedida
            // 
            this.txtMedida.Location = new System.Drawing.Point(80, 67);
            this.txtMedida.Name = "txtMedida";
            this.txtMedida.ReadOnly = true;
            this.txtMedida.Size = new System.Drawing.Size(201, 20);
            this.txtMedida.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Categoría";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(383, 20);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.ReadOnly = true;
            this.txtMarca.Size = new System.Drawing.Size(272, 20);
            this.txtMarca.TabIndex = 7;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(383, 67);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.Size = new System.Drawing.Size(238, 20);
            this.txtCategoria.TabIndex = 8;
            // 
            // btnLupaMedida
            // 
            this.btnLupaMedida.Enabled = false;
            this.btnLupaMedida.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(60)))), ((int)(((byte)(82)))));
            this.btnLupaMedida.FlatAppearance.BorderSize = 2;
            this.btnLupaMedida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
            this.btnLupaMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLupaMedida.Location = new System.Drawing.Point(287, 62);
            this.btnLupaMedida.Name = "btnLupaMedida";
            this.btnLupaMedida.Size = new System.Drawing.Size(30, 25);
            this.btnLupaMedida.TabIndex = 9;
            this.btnLupaMedida.Text = ":::";
            this.btnLupaMedida.UseVisualStyleBackColor = true;
            this.btnLupaMedida.Click += new System.EventHandler(this.btnLupaMedida_Click);
            // 
            // btnLupaCategoria
            // 
            this.btnLupaCategoria.Enabled = false;
            this.btnLupaCategoria.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(60)))), ((int)(((byte)(82)))));
            this.btnLupaCategoria.FlatAppearance.BorderSize = 2;
            this.btnLupaCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
            this.btnLupaCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLupaCategoria.Location = new System.Drawing.Point(627, 67);
            this.btnLupaCategoria.Name = "btnLupaCategoria";
            this.btnLupaCategoria.Size = new System.Drawing.Size(28, 23);
            this.btnLupaCategoria.TabIndex = 10;
            this.btnLupaCategoria.Text = ":::";
            this.btnLupaCategoria.UseVisualStyleBackColor = true;
            this.btnLupaCategoria.Click += new System.EventHandler(this.btnLupaCategoria_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Stock Actual";
            // 
            // txtStockActual
            // 
            this.txtStockActual.Location = new System.Drawing.Point(80, 106);
            this.txtStockActual.Name = "txtStockActual";
            this.txtStockActual.ReadOnly = true;
            this.txtStockActual.Size = new System.Drawing.Size(63, 20);
            this.txtStockActual.TabIndex = 19;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(60)))), ((int)(((byte)(82)))));
            this.btnSearch.FlatAppearance.BorderSize = 2;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(287, 142);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(30, 23);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = ":::";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(80, 144);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(201, 20);
            this.txtSearch.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Buscar:";
            // 
            // dtgvArticulos
            // 
            this.dtgvArticulos.AllowUserToAddRows = false;
            this.dtgvArticulos.AllowUserToDeleteRows = false;
            this.dtgvArticulos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgvArticulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvArticulos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgvArticulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgvArticulos.ColumnHeadersHeight = 35;
            this.dtgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvArticulos.Location = new System.Drawing.Point(12, 177);
            this.dtgvArticulos.Name = "dtgvArticulos";
            this.dtgvArticulos.ReadOnly = true;
            this.dtgvArticulos.Size = new System.Drawing.Size(884, 230);
            this.dtgvArticulos.TabIndex = 24;
            this.dtgvArticulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvArticulos_CellClick);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.White;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(60)))), ((int)(((byte)(82)))));
            this.btnNew.FlatAppearance.BorderSize = 2;
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.ImageKey = "new (2).png";
            this.btnNew.ImageList = this.imageList1;
            this.btnNew.Location = new System.Drawing.Point(906, 19);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(99, 73);
            this.btnNew.TabIndex = 23;
            this.btnNew.Text = "Nuevo";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cancel.png");
            this.imageList1.Images.SetKeyName(1, "delete.png");
            this.imageList1.Images.SetKeyName(2, "exit.png");
            this.imageList1.Images.SetKeyName(3, "new (2).png");
            this.imageList1.Images.SetKeyName(4, "report.png");
            this.imageList1.Images.SetKeyName(5, "save.png");
            this.imageList1.Images.SetKeyName(6, "update.png");
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(111)))), ((int)(((byte)(219)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(60)))), ((int)(((byte)(82)))));
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.ImageKey = "save.png";
            this.btnSave.ImageList = this.imageList1;
            this.btnSave.Location = new System.Drawing.Point(551, 112);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 53);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Guardar";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(70)))), ((int)(((byte)(69)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(60)))), ((int)(((byte)(82)))));
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.ImageKey = "cancel.png";
            this.btnCancel.ImageList = this.imageList1;
            this.btnCancel.Location = new System.Drawing.Point(383, 112);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 53);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(60)))), ((int)(((byte)(82)))));
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.ImageKey = "exit.png";
            this.btnClose.ImageList = this.imageList1;
            this.btnClose.Location = new System.Drawing.Point(906, 335);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 73);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Salir";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.White;
            this.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(60)))), ((int)(((byte)(82)))));
            this.btnReport.FlatAppearance.BorderSize = 2;
            this.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.ImageKey = "report.png";
            this.btnReport.ImageList = this.imageList1;
            this.btnReport.Location = new System.Drawing.Point(906, 256);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(99, 73);
            this.btnReport.TabIndex = 14;
            this.btnReport.Text = "Reporte";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(60)))), ((int)(((byte)(82)))));
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.ImageKey = "delete.png";
            this.btnDelete.ImageList = this.imageList1;
            this.btnDelete.Location = new System.Drawing.Point(906, 177);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 73);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(60)))), ((int)(((byte)(82)))));
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.ImageKey = "update.png";
            this.btnUpdate.ImageList = this.imageList1;
            this.btnUpdate.Location = new System.Drawing.Point(906, 98);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 73);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Pnl_Medida
            // 
            this.Pnl_Medida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_Medida.Controls.Add(this.btnBackMedida);
            this.Pnl_Medida.Controls.Add(this.dtgvMedida);
            this.Pnl_Medida.Location = new System.Drawing.Point(12, 413);
            this.Pnl_Medida.Name = "Pnl_Medida";
            this.Pnl_Medida.Size = new System.Drawing.Size(200, 233);
            this.Pnl_Medida.TabIndex = 25;
            this.Pnl_Medida.Visible = false;
            // 
            // btnBackMedida
            // 
            this.btnBackMedida.BackColor = System.Drawing.Color.Gainsboro;
            this.btnBackMedida.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(60)))), ((int)(((byte)(82)))));
            this.btnBackMedida.FlatAppearance.BorderSize = 2;
            this.btnBackMedida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
            this.btnBackMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackMedida.ForeColor = System.Drawing.Color.White;
            this.btnBackMedida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackMedida.ImageKey = "(ninguno)";
            this.btnBackMedida.ImageList = this.imageList1;
            this.btnBackMedida.Location = new System.Drawing.Point(3, 167);
            this.btnBackMedida.Name = "btnBackMedida";
            this.btnBackMedida.Size = new System.Drawing.Size(194, 53);
            this.btnBackMedida.TabIndex = 27;
            this.btnBackMedida.Text = "Retornar";
            this.btnBackMedida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackMedida.UseVisualStyleBackColor = false;
            this.btnBackMedida.Click += new System.EventHandler(this.btnBackMedida_Click);
            // 
            // dtgvMedida
            // 
            this.dtgvMedida.AllowUserToAddRows = false;
            this.dtgvMedida.AllowUserToDeleteRows = false;
            this.dtgvMedida.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgvMedida.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvMedida.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgvMedida.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgvMedida.ColumnHeadersHeight = 35;
            this.dtgvMedida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvMedida.Location = new System.Drawing.Point(3, 3);
            this.dtgvMedida.Name = "dtgvMedida";
            this.dtgvMedida.ReadOnly = true;
            this.dtgvMedida.Size = new System.Drawing.Size(194, 158);
            this.dtgvMedida.TabIndex = 26;
            this.dtgvMedida.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMedida_CellContentDoubleClick);
            // 
            // PnlCategoria
            // 
            this.PnlCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlCategoria.Controls.Add(this.btnBackCategoria);
            this.PnlCategoria.Controls.Add(this.dtgvCategoria);
            this.PnlCategoria.Location = new System.Drawing.Point(222, 413);
            this.PnlCategoria.Name = "PnlCategoria";
            this.PnlCategoria.Size = new System.Drawing.Size(200, 233);
            this.PnlCategoria.TabIndex = 26;
            this.PnlCategoria.Visible = false;
            // 
            // btnBackCategoria
            // 
            this.btnBackCategoria.BackColor = System.Drawing.Color.Gainsboro;
            this.btnBackCategoria.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(60)))), ((int)(((byte)(82)))));
            this.btnBackCategoria.FlatAppearance.BorderSize = 2;
            this.btnBackCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
            this.btnBackCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackCategoria.ForeColor = System.Drawing.Color.White;
            this.btnBackCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackCategoria.ImageKey = "(ninguno)";
            this.btnBackCategoria.ImageList = this.imageList1;
            this.btnBackCategoria.Location = new System.Drawing.Point(3, 167);
            this.btnBackCategoria.Name = "btnBackCategoria";
            this.btnBackCategoria.Size = new System.Drawing.Size(194, 53);
            this.btnBackCategoria.TabIndex = 27;
            this.btnBackCategoria.Text = "Retornar";
            this.btnBackCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackCategoria.UseVisualStyleBackColor = false;
            this.btnBackCategoria.Click += new System.EventHandler(this.btnBackCategoria_Click);
            // 
            // dtgvCategoria
            // 
            this.dtgvCategoria.AllowUserToAddRows = false;
            this.dtgvCategoria.AllowUserToDeleteRows = false;
            this.dtgvCategoria.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgvCategoria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvCategoria.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgvCategoria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgvCategoria.ColumnHeadersHeight = 35;
            this.dtgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvCategoria.Location = new System.Drawing.Point(3, 3);
            this.dtgvCategoria.Name = "dtgvCategoria";
            this.dtgvCategoria.ReadOnly = true;
            this.dtgvCategoria.Size = new System.Drawing.Size(194, 158);
            this.dtgvCategoria.TabIndex = 26;
            this.dtgvCategoria.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCategoria_CellContentDoubleClick);
            // 
            // Frm_Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1012, 430);
            this.Controls.Add(this.PnlCategoria);
            this.Controls.Add(this.Pnl_Medida);
            this.Controls.Add(this.dtgvArticulos);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStockActual);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnLupaCategoria);
            this.Controls.Add(this.btnLupaMedida);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMedida);
            this.Controls.Add(this.txtArticulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_Articulos";
            this.Text = "Mantenimiento de Articulos ";
            this.Load += new System.EventHandler(this.Frm_Articulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvArticulos)).EndInit();
            this.Pnl_Medida.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMedida)).EndInit();
            this.PnlCategoria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.TextBox txtMedida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Button btnLupaMedida;
        private System.Windows.Forms.Button btnLupaCategoria;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStockActual;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dtgvArticulos;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel Pnl_Medida;
        private System.Windows.Forms.Button btnBackMedida;
        private System.Windows.Forms.DataGridView dtgvMedida;
        private System.Windows.Forms.Panel PnlCategoria;
        private System.Windows.Forms.Button btnBackCategoria;
        private System.Windows.Forms.DataGridView dtgvCategoria;
    }
}