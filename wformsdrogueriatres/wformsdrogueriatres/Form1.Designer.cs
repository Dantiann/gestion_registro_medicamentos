namespace wformsdrogueriatres
{
    partial class frmProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblProductos = new System.Windows.Forms.Label();
            this.lblIdproducto = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblPresentacion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.lblRegistroinvima = new System.Windows.Forms.Label();
            this.txtIdproducto = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtPresentacion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtVencimiento = new System.Windows.Forms.TextBox();
            this.txtRegistroinvima = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.idProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentaciónDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vencimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registroinvimaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drogueriatresDataSet = new wformsdrogueriatres.drogueriatresDataSet();
            this.productosTableAdapter = new wformsdrogueriatres.drogueriatresDataSetTableAdapters.productosTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogueriatresDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscar.Location = new System.Drawing.Point(71, 65);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(144, 34);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregar.Location = new System.Drawing.Point(234, 66);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(144, 34);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActualizar.Location = new System.Drawing.Point(69, 126);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(144, 34);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(234, 126);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(144, 34);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProductos.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.ForeColor = System.Drawing.Color.White;
            this.lblProductos.Location = new System.Drawing.Point(479, 68);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(859, 83);
            this.lblProductos.TabIndex = 4;
            this.lblProductos.Text = "GESTIÓN DE MEDICAMENTOS";
            this.lblProductos.Click += new System.EventHandler(this.lblProductos_Click);
            // 
            // lblIdproducto
            // 
            this.lblIdproducto.AutoSize = true;
            this.lblIdproducto.BackColor = System.Drawing.Color.Transparent;
            this.lblIdproducto.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdproducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIdproducto.Location = new System.Drawing.Point(33, 271);
            this.lblIdproducto.Name = "lblIdproducto";
            this.lblIdproducto.Size = new System.Drawing.Size(126, 27);
            this.lblIdproducto.TabIndex = 5;
            this.lblIdproducto.Text = "Id Producto";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblProducto.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProducto.Location = new System.Drawing.Point(33, 320);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(101, 27);
            this.lblProducto.TabIndex = 6;
            this.lblProducto.Text = "Producto";
            // 
            // lblPresentacion
            // 
            this.lblPresentacion.AutoSize = true;
            this.lblPresentacion.BackColor = System.Drawing.Color.Transparent;
            this.lblPresentacion.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresentacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPresentacion.Location = new System.Drawing.Point(33, 369);
            this.lblPresentacion.Name = "lblPresentacion";
            this.lblPresentacion.Size = new System.Drawing.Size(135, 27);
            this.lblPresentacion.TabIndex = 7;
            this.lblPresentacion.Text = "Presentación";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrecio.Location = new System.Drawing.Point(33, 418);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(72, 27);
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.Text = "Precio";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.BackColor = System.Drawing.Color.Transparent;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStock.Location = new System.Drawing.Point(33, 466);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(66, 27);
            this.lblStock.TabIndex = 9;
            this.lblStock.Text = "Stock";
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.BackColor = System.Drawing.Color.Transparent;
            this.lblVencimiento.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencimiento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVencimiento.Location = new System.Drawing.Point(33, 514);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(132, 27);
            this.lblVencimiento.TabIndex = 10;
            this.lblVencimiento.Text = "Vencimiento";
            // 
            // lblRegistroinvima
            // 
            this.lblRegistroinvima.AutoSize = true;
            this.lblRegistroinvima.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistroinvima.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroinvima.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRegistroinvima.Location = new System.Drawing.Point(33, 563);
            this.lblRegistroinvima.Name = "lblRegistroinvima";
            this.lblRegistroinvima.Size = new System.Drawing.Size(163, 27);
            this.lblRegistroinvima.TabIndex = 11;
            this.lblRegistroinvima.Text = "Registro Invima";
            // 
            // txtIdproducto
            // 
            this.txtIdproducto.BackColor = System.Drawing.Color.Honeydew;
            this.txtIdproducto.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdproducto.Location = new System.Drawing.Point(210, 265);
            this.txtIdproducto.Name = "txtIdproducto";
            this.txtIdproducto.Size = new System.Drawing.Size(164, 31);
            this.txtIdproducto.TabIndex = 12;
            // 
            // txtProducto
            // 
            this.txtProducto.BackColor = System.Drawing.Color.Honeydew;
            this.txtProducto.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(210, 312);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(164, 31);
            this.txtProducto.TabIndex = 13;
            // 
            // txtPresentacion
            // 
            this.txtPresentacion.BackColor = System.Drawing.Color.Honeydew;
            this.txtPresentacion.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPresentacion.Location = new System.Drawing.Point(210, 362);
            this.txtPresentacion.Name = "txtPresentacion";
            this.txtPresentacion.Size = new System.Drawing.Size(164, 31);
            this.txtPresentacion.TabIndex = 14;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.Honeydew;
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(210, 411);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(164, 31);
            this.txtPrecio.TabIndex = 15;
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.Honeydew;
            this.txtStock.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(210, 459);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(164, 31);
            this.txtStock.TabIndex = 16;
            // 
            // txtVencimiento
            // 
            this.txtVencimiento.BackColor = System.Drawing.Color.Honeydew;
            this.txtVencimiento.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVencimiento.Location = new System.Drawing.Point(210, 506);
            this.txtVencimiento.Name = "txtVencimiento";
            this.txtVencimiento.Size = new System.Drawing.Size(164, 31);
            this.txtVencimiento.TabIndex = 17;
            // 
            // txtRegistroinvima
            // 
            this.txtRegistroinvima.BackColor = System.Drawing.Color.Honeydew;
            this.txtRegistroinvima.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistroinvima.Location = new System.Drawing.Point(210, 557);
            this.txtRegistroinvima.Name = "txtRegistroinvima";
            this.txtRegistroinvima.Size = new System.Drawing.Size(164, 31);
            this.txtRegistroinvima.TabIndex = 18;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AutoGenerateColumns = false;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProductoDataGridViewTextBoxColumn,
            this.producto,
            this.presentaciónDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.vencimientoDataGridViewTextBoxColumn,
            this.registroinvimaDataGridViewTextBoxColumn});
            this.dgvProductos.DataSource = this.productosBindingSource;
            this.dgvProductos.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvProductos.Location = new System.Drawing.Point(410, 263);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(1059, 368);
            this.dgvProductos.TabIndex = 19;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // idProductoDataGridViewTextBoxColumn
            // 
            this.idProductoDataGridViewTextBoxColumn.DataPropertyName = "idProducto";
            this.idProductoDataGridViewTextBoxColumn.HeaderText = "Id Producto";
            this.idProductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
            this.idProductoDataGridViewTextBoxColumn.Width = 125;
            // 
            // producto
            // 
            this.producto.DataPropertyName = "producto";
            this.producto.HeaderText = "producto";
            this.producto.MinimumWidth = 6;
            this.producto.Name = "producto";
            this.producto.Width = 125;
            // 
            // presentaciónDataGridViewTextBoxColumn
            // 
            this.presentaciónDataGridViewTextBoxColumn.DataPropertyName = "presentación";
            this.presentaciónDataGridViewTextBoxColumn.HeaderText = "Presentación";
            this.presentaciónDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.presentaciónDataGridViewTextBoxColumn.Name = "presentaciónDataGridViewTextBoxColumn";
            this.presentaciónDataGridViewTextBoxColumn.Width = 125;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.precioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioDataGridViewTextBoxColumn.Width = 125;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "stock";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.stockDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.Width = 125;
            // 
            // vencimientoDataGridViewTextBoxColumn
            // 
            this.vencimientoDataGridViewTextBoxColumn.DataPropertyName = "vencimiento";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.vencimientoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.vencimientoDataGridViewTextBoxColumn.HeaderText = "Vencimiento";
            this.vencimientoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vencimientoDataGridViewTextBoxColumn.Name = "vencimientoDataGridViewTextBoxColumn";
            this.vencimientoDataGridViewTextBoxColumn.Width = 125;
            // 
            // registroinvimaDataGridViewTextBoxColumn
            // 
            this.registroinvimaDataGridViewTextBoxColumn.DataPropertyName = "registroinvima";
            this.registroinvimaDataGridViewTextBoxColumn.HeaderText = "Registro Invima";
            this.registroinvimaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.registroinvimaDataGridViewTextBoxColumn.Name = "registroinvimaDataGridViewTextBoxColumn";
            this.registroinvimaDataGridViewTextBoxColumn.Width = 125;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "productos";
            this.productosBindingSource.DataSource = this.drogueriatresDataSet;
            // 
            // drogueriatresDataSet
            // 
            this.drogueriatresDataSet.DataSetName = "drogueriatresDataSet";
            this.drogueriatresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(450, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(990, 102);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBorrar.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBorrar.Location = new System.Drawing.Point(72, 181);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(144, 34);
            this.btnBorrar.TabIndex = 21;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1546, 690);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.txtRegistroinvima);
            this.Controls.Add(this.txtVencimiento);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtPresentacion);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txtIdproducto);
            this.Controls.Add(this.lblRegistroinvima);
            this.Controls.Add(this.lblVencimiento);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblPresentacion);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblIdproducto);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmProductos";
            this.Text = "Gestión Medicamentos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drogueriatresDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Label lblIdproducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblPresentacion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.Label lblRegistroinvima;
        private System.Windows.Forms.TextBox txtIdproducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtPresentacion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtVencimiento;
        private System.Windows.Forms.TextBox txtRegistroinvima;
        private System.Windows.Forms.DataGridView dgvProductos;
        private drogueriatresDataSet drogueriatresDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private drogueriatresDataSetTableAdapters.productosTableAdapter productosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentaciónDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vencimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registroinvimaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnBorrar;
    }
}

