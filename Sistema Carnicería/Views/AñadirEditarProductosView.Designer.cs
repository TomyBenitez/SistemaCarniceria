namespace Sistema_Carnicería.Presentation
{
    partial class AñadirEditarProductosView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AñadirEditarProductosView));
            tabPestañaGeneral = new TabControl();
            tabProductosPestaña = new TabPage();
            btnReset = new Button();
            btnBuscar = new Button();
            btnSalir = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnNuevo = new Button();
            txtBusqueda = new TextBox();
            lblBuscar = new Label();
            grdProductos = new DataGridView();
            tabPestañaDetallesProductos = new TabPage();
            NUDMonto = new NumericUpDown();
            btnCancelar = new Button();
            btnGuardar = new Button();
            lblMonto = new Label();
            txtNombreProducto = new TextBox();
            lblProducto = new Label();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            tabPestañaGeneral.SuspendLayout();
            tabProductosPestaña.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdProductos).BeginInit();
            tabPestañaDetallesProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUDMonto).BeginInit();
            SuspendLayout();
            // 
            // tabPestañaGeneral
            // 
            tabPestañaGeneral.Controls.Add(tabProductosPestaña);
            tabPestañaGeneral.Controls.Add(tabPestañaDetallesProductos);
            tabPestañaGeneral.Location = new Point(14, 16);
            tabPestañaGeneral.Margin = new Padding(3, 4, 3, 4);
            tabPestañaGeneral.Name = "tabPestañaGeneral";
            tabPestañaGeneral.SelectedIndex = 0;
            tabPestañaGeneral.Size = new Size(792, 449);
            tabPestañaGeneral.TabIndex = 0;
            tabPestañaGeneral.Click += tabPestañaGeneral_Click;
            // 
            // tabProductosPestaña
            // 
            tabProductosPestaña.Controls.Add(btnReset);
            tabProductosPestaña.Controls.Add(btnBuscar);
            tabProductosPestaña.Controls.Add(btnSalir);
            tabProductosPestaña.Controls.Add(btnEliminar);
            tabProductosPestaña.Controls.Add(btnModificar);
            tabProductosPestaña.Controls.Add(btnNuevo);
            tabProductosPestaña.Controls.Add(txtBusqueda);
            tabProductosPestaña.Controls.Add(lblBuscar);
            tabProductosPestaña.Controls.Add(grdProductos);
            tabProductosPestaña.Location = new Point(4, 29);
            tabProductosPestaña.Margin = new Padding(3, 4, 3, 4);
            tabProductosPestaña.Name = "tabProductosPestaña";
            tabProductosPestaña.Padding = new Padding(3, 4, 3, 4);
            tabProductosPestaña.Size = new Size(784, 416);
            tabProductosPestaña.TabIndex = 0;
            tabProductosPestaña.Text = "Productos";
            tabProductosPestaña.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(446, 11);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(54, 31);
            btnReset.TabIndex = 8;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(373, 11);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(66, 33);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "&Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(669, 363);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(107, 41);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(669, 313);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(107, 41);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "&Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(669, 264);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(107, 41);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "&Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(669, 215);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(107, 41);
            btnNuevo.TabIndex = 3;
            btnNuevo.Text = "&Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(81, 11);
            txtBusqueda.Margin = new Padding(3, 4, 3, 4);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(284, 27);
            txtBusqueda.TabIndex = 2;
            txtBusqueda.KeyDown += txtBusqueda_KeyDown;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(23, 15);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(55, 20);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Buscar:";
            // 
            // grdProductos
            // 
            grdProductos.AllowUserToAddRows = false;
            grdProductos.AllowUserToDeleteRows = false;
            grdProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdProductos.Location = new Point(7, 52);
            grdProductos.Margin = new Padding(3, 4, 3, 4);
            grdProductos.Name = "grdProductos";
            grdProductos.ReadOnly = true;
            grdProductos.RowHeadersWidth = 51;
            grdProductos.RowTemplate.Height = 25;
            grdProductos.Size = new Size(655, 352);
            grdProductos.TabIndex = 0;
            grdProductos.CellEnter += grdClientes_CellEnter;
            // 
            // tabPestañaDetallesProductos
            // 
            tabPestañaDetallesProductos.Controls.Add(NUDMonto);
            tabPestañaDetallesProductos.Controls.Add(btnCancelar);
            tabPestañaDetallesProductos.Controls.Add(btnGuardar);
            tabPestañaDetallesProductos.Controls.Add(lblMonto);
            tabPestañaDetallesProductos.Controls.Add(txtNombreProducto);
            tabPestañaDetallesProductos.Controls.Add(lblProducto);
            tabPestañaDetallesProductos.Controls.Add(txtCodigo);
            tabPestañaDetallesProductos.Controls.Add(lblCodigo);
            tabPestañaDetallesProductos.Location = new Point(4, 29);
            tabPestañaDetallesProductos.Margin = new Padding(3, 4, 3, 4);
            tabPestañaDetallesProductos.Name = "tabPestañaDetallesProductos";
            tabPestañaDetallesProductos.Padding = new Padding(3, 4, 3, 4);
            tabPestañaDetallesProductos.Size = new Size(784, 416);
            tabPestañaDetallesProductos.TabIndex = 1;
            tabPestañaDetallesProductos.Text = "Detalle Producto";
            tabPestañaDetallesProductos.UseVisualStyleBackColor = true;
            // 
            // NUDMonto
            // 
            NUDMonto.DecimalPlaces = 2;
            NUDMonto.Location = new Point(275, 200);
            NUDMonto.Margin = new Padding(3, 4, 3, 4);
            NUDMonto.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            NUDMonto.Name = "NUDMonto";
            NUDMonto.Size = new Size(262, 27);
            NUDMonto.TabIndex = 37;
            NUDMonto.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Location = new Point(450, 293);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 31);
            btnCancelar.TabIndex = 36;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Enabled = false;
            btnGuardar.Location = new Point(274, 293);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 31);
            btnGuardar.TabIndex = 35;
            btnGuardar.Text = "&Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(216, 203);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(56, 20);
            lblMonto.TabIndex = 31;
            lblMonto.Text = "Monto:";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Enabled = false;
            txtNombreProducto.Location = new Point(275, 136);
            txtNombreProducto.Margin = new Padding(3, 4, 3, 4);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(261, 27);
            txtNombreProducto.TabIndex = 30;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(201, 140);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(72, 20);
            lblProducto.TabIndex = 29;
            lblProducto.Text = "Producto:";
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(275, 79);
            txtCodigo.Margin = new Padding(3, 4, 3, 4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(261, 27);
            txtCodigo.TabIndex = 24;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(213, 83);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(61, 20);
            lblCodigo.TabIndex = 23;
            lblCodigo.Text = "Código:";
            // 
            // AñadirEditarProductosView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 473);
            Controls.Add(tabPestañaGeneral);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "AñadirEditarProductosView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Añadir/Editar Productos";
            tabPestañaGeneral.ResumeLayout(false);
            tabProductosPestaña.ResumeLayout(false);
            tabProductosPestaña.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdProductos).EndInit();
            tabPestañaDetallesProductos.ResumeLayout(false);
            tabPestañaDetallesProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUDMonto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabPestañaGeneral;
        private TabPage tabProductosPestaña;
        private TextBox txtBusqueda;
        private Label lblBuscar;
        private DataGridView grdProductos;
        private TabPage tabPestañaDetallesProductos;
        private Button btnSalir;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnNuevo;
        private Button btnCancelar;
        private Button btnGuardar;
        private Label lblMonto;
        private TextBox txtNombreProducto;
        private Label lblProducto;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private NumericUpDown NUDMonto;
        private Button btnBuscar;
        private Button btnReset;
    }
}