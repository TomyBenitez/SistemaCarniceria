namespace Sistema_Carnicería.Presentation
{
    partial class AñadirEditarClientesView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AñadirEditarClientesView));
            tabPestañaGeneral = new TabControl();
            tabClientesPestaña = new TabPage();
            btnBuscar = new Button();
            btnSalir = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnNuevo = new Button();
            txtBusqueda = new TextBox();
            lblBuscar = new Label();
            grdClientes = new DataGridView();
            tabPestañaDetallesClientes = new TabPage();
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            txtApellido_Nombre = new TextBox();
            lblApellidoNombre = new Label();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            btnReset = new Button();
            tabPestañaGeneral.SuspendLayout();
            tabClientesPestaña.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdClientes).BeginInit();
            tabPestañaDetallesClientes.SuspendLayout();
            SuspendLayout();
            // 
            // tabPestañaGeneral
            // 
            tabPestañaGeneral.Controls.Add(tabClientesPestaña);
            tabPestañaGeneral.Controls.Add(tabPestañaDetallesClientes);
            tabPestañaGeneral.Location = new Point(12, 12);
            tabPestañaGeneral.Name = "tabPestañaGeneral";
            tabPestañaGeneral.SelectedIndex = 0;
            tabPestañaGeneral.Size = new Size(693, 337);
            tabPestañaGeneral.TabIndex = 0;
            tabPestañaGeneral.Click += tabPestañaGeneral_Click;
            // 
            // tabClientesPestaña
            // 
            tabClientesPestaña.Controls.Add(btnReset);
            tabClientesPestaña.Controls.Add(btnBuscar);
            tabClientesPestaña.Controls.Add(btnSalir);
            tabClientesPestaña.Controls.Add(btnEliminar);
            tabClientesPestaña.Controls.Add(btnModificar);
            tabClientesPestaña.Controls.Add(btnNuevo);
            tabClientesPestaña.Controls.Add(txtBusqueda);
            tabClientesPestaña.Controls.Add(lblBuscar);
            tabClientesPestaña.Controls.Add(grdClientes);
            tabClientesPestaña.Location = new Point(4, 24);
            tabClientesPestaña.Name = "tabClientesPestaña";
            tabClientesPestaña.Padding = new Padding(3);
            tabClientesPestaña.Size = new Size(685, 309);
            tabClientesPestaña.TabIndex = 0;
            tabClientesPestaña.Text = "Clientes";
            tabClientesPestaña.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(326, 8);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(62, 23);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "&Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(585, 272);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 31);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(585, 235);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 31);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "&Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(585, 198);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 31);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "&Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(585, 161);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(94, 31);
            btnNuevo.TabIndex = 3;
            btnNuevo.Text = "&Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(71, 8);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(249, 23);
            txtBusqueda.TabIndex = 2;
            txtBusqueda.KeyDown += txtBusqueda_KeyDown;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(20, 11);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(45, 15);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Buscar:";
            // 
            // grdClientes
            // 
            grdClientes.AllowUserToAddRows = false;
            grdClientes.AllowUserToDeleteRows = false;
            grdClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdClientes.Location = new Point(6, 39);
            grdClientes.Name = "grdClientes";
            grdClientes.ReadOnly = true;
            grdClientes.RowTemplate.Height = 25;
            grdClientes.Size = new Size(573, 264);
            grdClientes.TabIndex = 0;
            grdClientes.CellEnter += grdClientes_CellEnter;
            // 
            // tabPestañaDetallesClientes
            // 
            tabPestañaDetallesClientes.Controls.Add(btnCancelar);
            tabPestañaDetallesClientes.Controls.Add(btnGuardar);
            tabPestañaDetallesClientes.Controls.Add(txtTelefono);
            tabPestañaDetallesClientes.Controls.Add(lblTelefono);
            tabPestañaDetallesClientes.Controls.Add(txtDireccion);
            tabPestañaDetallesClientes.Controls.Add(lblDireccion);
            tabPestañaDetallesClientes.Controls.Add(txtApellido_Nombre);
            tabPestañaDetallesClientes.Controls.Add(lblApellidoNombre);
            tabPestañaDetallesClientes.Controls.Add(txtCodigo);
            tabPestañaDetallesClientes.Controls.Add(lblCodigo);
            tabPestañaDetallesClientes.Location = new Point(4, 24);
            tabPestañaDetallesClientes.Name = "tabPestañaDetallesClientes";
            tabPestañaDetallesClientes.Padding = new Padding(3);
            tabPestañaDetallesClientes.Size = new Size(685, 309);
            tabPestañaDetallesClientes.TabIndex = 1;
            tabPestañaDetallesClientes.Text = "Detalle Cliente";
            tabPestañaDetallesClientes.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Location = new Point(395, 236);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 36;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Enabled = false;
            btnGuardar.Location = new Point(241, 236);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 35;
            btnGuardar.Text = "&Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Enabled = false;
            txtTelefono.Location = new Point(241, 197);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(229, 23);
            txtTelefono.TabIndex = 34;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(180, 200);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(55, 15);
            lblTelefono.TabIndex = 33;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtDireccion
            // 
            txtDireccion.Enabled = false;
            txtDireccion.Location = new Point(241, 149);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(229, 23);
            txtDireccion.TabIndex = 32;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(175, 152);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(60, 15);
            lblDireccion.TabIndex = 31;
            lblDireccion.Text = "Dirección:";
            // 
            // txtApellido_Nombre
            // 
            txtApellido_Nombre.Enabled = false;
            txtApellido_Nombre.Location = new Point(241, 102);
            txtApellido_Nombre.Name = "txtApellido_Nombre";
            txtApellido_Nombre.Size = new Size(229, 23);
            txtApellido_Nombre.TabIndex = 30;
            // 
            // lblApellidoNombre
            // 
            lblApellidoNombre.AutoSize = true;
            lblApellidoNombre.Location = new Point(125, 105);
            lblApellidoNombre.Name = "lblApellidoNombre";
            lblApellidoNombre.Size = new Size(110, 15);
            lblApellidoNombre.TabIndex = 29;
            lblApellidoNombre.Text = "Apellido y Nombre:";
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(241, 59);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(229, 23);
            txtCodigo.TabIndex = 24;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(186, 62);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(49, 15);
            lblCodigo.TabIndex = 23;
            lblCodigo.Text = "Código:";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(394, 8);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(47, 23);
            btnReset.TabIndex = 9;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // AñadirEditarClientesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 355);
            Controls.Add(tabPestañaGeneral);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AñadirEditarClientesView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Añadir/Editar Clientes";
            tabPestañaGeneral.ResumeLayout(false);
            tabClientesPestaña.ResumeLayout(false);
            tabClientesPestaña.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdClientes).EndInit();
            tabPestañaDetallesClientes.ResumeLayout(false);
            tabPestañaDetallesClientes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabPestañaGeneral;
        private TabPage tabClientesPestaña;
        private TextBox txtBusqueda;
        private Label lblBuscar;
        private DataGridView grdClientes;
        private TabPage tabPestañaDetallesClientes;
        private Button btnSalir;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnNuevo;
        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtDireccion;
        private Label lblDireccion;
        private TextBox txtApellido_Nombre;
        private Label lblApellidoNombre;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private Button btnBuscar;
        private Button btnReset;
    }
}