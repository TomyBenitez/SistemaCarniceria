namespace Sistema_Carnicería.Presentation
{
    partial class AñadirEditarVentasView
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AñadirEditarVentasView));
            tabPestañaGeneral = new TabControl();
            tabVentasPestaña = new TabPage();
            btnReset = new Button();
            btnBuscar = new Button();
            DTPicker = new DateTimePicker();
            btnSalir = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnNuevo = new Button();
            lblBuscar = new Label();
            grdVentas = new DataGridView();
            tabPestañaDetallesVentas = new TabPage();
            cboProductos = new ComboBox();
            cboCliente = new ComboBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            lblProductos = new Label();
            lblCliente = new Label();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            cobradorBindingSource = new BindingSource(components);
            NUDcantidad = new NumericUpDown();
            label1 = new Label();
            tabPestañaGeneral.SuspendLayout();
            tabVentasPestaña.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdVentas).BeginInit();
            tabPestañaDetallesVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cobradorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDcantidad).BeginInit();
            SuspendLayout();
            // 
            // tabPestañaGeneral
            // 
            tabPestañaGeneral.Controls.Add(tabVentasPestaña);
            tabPestañaGeneral.Controls.Add(tabPestañaDetallesVentas);
            tabPestañaGeneral.Location = new Point(14, 16);
            tabPestañaGeneral.Margin = new Padding(3, 4, 3, 4);
            tabPestañaGeneral.Name = "tabPestañaGeneral";
            tabPestañaGeneral.SelectedIndex = 0;
            tabPestañaGeneral.Size = new Size(792, 449);
            tabPestañaGeneral.TabIndex = 1;
            tabPestañaGeneral.Click += tabPestañaGeneral_Click;
            // 
            // tabVentasPestaña
            // 
            tabVentasPestaña.Controls.Add(btnReset);
            tabVentasPestaña.Controls.Add(btnBuscar);
            tabVentasPestaña.Controls.Add(DTPicker);
            tabVentasPestaña.Controls.Add(btnSalir);
            tabVentasPestaña.Controls.Add(btnEliminar);
            tabVentasPestaña.Controls.Add(btnModificar);
            tabVentasPestaña.Controls.Add(btnNuevo);
            tabVentasPestaña.Controls.Add(lblBuscar);
            tabVentasPestaña.Controls.Add(grdVentas);
            tabVentasPestaña.Location = new Point(4, 29);
            tabVentasPestaña.Margin = new Padding(3, 4, 3, 4);
            tabVentasPestaña.Name = "tabVentasPestaña";
            tabVentasPestaña.Padding = new Padding(3, 4, 3, 4);
            tabVentasPestaña.Size = new Size(784, 416);
            tabVentasPestaña.TabIndex = 0;
            tabVentasPestaña.Text = "Ventas";
            tabVentasPestaña.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(321, 13);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(53, 32);
            btnReset.TabIndex = 9;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(235, 13);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(79, 32);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "&Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // DTPicker
            // 
            DTPicker.CustomFormat = "yyyy-MM-dd";
            DTPicker.Format = DateTimePickerFormat.Custom;
            DTPicker.Location = new Point(85, 13);
            DTPicker.Margin = new Padding(3, 4, 3, 4);
            DTPicker.MinDate = new DateTime(2022, 1, 1, 0, 0, 0, 0);
            DTPicker.Name = "DTPicker";
            DTPicker.Size = new Size(143, 27);
            DTPicker.TabIndex = 7;
            DTPicker.Value = new DateTime(2023, 3, 6, 0, 0, 0, 0);
            DTPicker.KeyDown += DTPicker_KeyDown;
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
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(26, 19);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(55, 20);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Buscar:";
            // 
            // grdVentas
            // 
            grdVentas.AllowUserToAddRows = false;
            grdVentas.AllowUserToDeleteRows = false;
            grdVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdVentas.Location = new Point(7, 52);
            grdVentas.Margin = new Padding(3, 4, 3, 4);
            grdVentas.Name = "grdVentas";
            grdVentas.ReadOnly = true;
            grdVentas.RowHeadersWidth = 51;
            grdVentas.RowTemplate.Height = 25;
            grdVentas.Size = new Size(655, 352);
            grdVentas.TabIndex = 0;
            grdVentas.CellEnter += grdCobradores_CellEnter;
            // 
            // tabPestañaDetallesVentas
            // 
            tabPestañaDetallesVentas.Controls.Add(label1);
            tabPestañaDetallesVentas.Controls.Add(NUDcantidad);
            tabPestañaDetallesVentas.Controls.Add(cboProductos);
            tabPestañaDetallesVentas.Controls.Add(cboCliente);
            tabPestañaDetallesVentas.Controls.Add(btnCancelar);
            tabPestañaDetallesVentas.Controls.Add(btnGuardar);
            tabPestañaDetallesVentas.Controls.Add(lblProductos);
            tabPestañaDetallesVentas.Controls.Add(lblCliente);
            tabPestañaDetallesVentas.Controls.Add(txtCodigo);
            tabPestañaDetallesVentas.Controls.Add(lblCodigo);
            tabPestañaDetallesVentas.Location = new Point(4, 29);
            tabPestañaDetallesVentas.Margin = new Padding(3, 4, 3, 4);
            tabPestañaDetallesVentas.Name = "tabPestañaDetallesVentas";
            tabPestañaDetallesVentas.Padding = new Padding(3, 4, 3, 4);
            tabPestañaDetallesVentas.Size = new Size(784, 416);
            tabPestañaDetallesVentas.TabIndex = 1;
            tabPestañaDetallesVentas.Text = "Detalle Venta";
            tabPestañaDetallesVentas.UseVisualStyleBackColor = true;
            // 
            // cboProductos
            // 
            cboProductos.FormattingEnabled = true;
            cboProductos.Location = new Point(275, 213);
            cboProductos.Margin = new Padding(3, 4, 3, 4);
            cboProductos.Name = "cboProductos";
            cboProductos.Size = new Size(261, 28);
            cboProductos.TabIndex = 40;
            // 
            // cboCliente
            // 
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(275, 160);
            cboCliente.Margin = new Padding(3, 4, 3, 4);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(261, 28);
            cboCliente.TabIndex = 39;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Location = new Point(451, 315);
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
            btnGuardar.Location = new Point(275, 315);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 31);
            btnGuardar.TabIndex = 35;
            btnGuardar.Text = "&Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.Location = new Point(199, 217);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(78, 20);
            lblProductos.TabIndex = 33;
            lblProductos.Text = "Productos:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(218, 164);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(58, 20);
            lblCliente.TabIndex = 31;
            lblCliente.Text = "Cliente:";
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(275, 107);
            txtCodigo.Margin = new Padding(3, 4, 3, 4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(261, 27);
            txtCodigo.TabIndex = 24;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(216, 115);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(61, 20);
            lblCodigo.TabIndex = 23;
            lblCodigo.Text = "Código:";
            // 
            // cobradorBindingSource
            // 
            cobradorBindingSource.DataSource = typeof(Models.Cobrador);
            // 
            // NUDcantidad
            // 
            NUDcantidad.Location = new Point(275, 260);
            NUDcantidad.Name = "NUDcantidad";
            NUDcantidad.Size = new Size(262, 27);
            NUDcantidad.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(197, 262);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 42;
            label1.Text = "Cantidad:";
            // 
            // AñadirEditarVentasView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 467);
            Controls.Add(tabPestañaGeneral);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "AñadirEditarVentasView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Añadir/Editar Ventas";
            tabPestañaGeneral.ResumeLayout(false);
            tabVentasPestaña.ResumeLayout(false);
            tabVentasPestaña.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdVentas).EndInit();
            tabPestañaDetallesVentas.ResumeLayout(false);
            tabPestañaDetallesVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cobradorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDcantidad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabPestañaGeneral;
        private TabPage tabVentasPestaña;
        private Button btnSalir;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnNuevo;
        private Label lblBuscar;
        private DataGridView grdVentas;
        private TabPage tabPestañaDetallesVentas;
        private Button btnCancelar;
        private Button btnGuardar;
        private Label lblProductos;
        private Label lblCliente;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private ComboBox cboProductos;
        private ComboBox cboCliente;
        private DateTimePicker DTPicker;
        private Button btnBuscar;
        private Button btnReset;
        private BindingSource cobradorBindingSource;
        private Label label1;
        private NumericUpDown NUDcantidad;
    }
}