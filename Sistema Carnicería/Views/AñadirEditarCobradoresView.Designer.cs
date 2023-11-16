namespace Sistema_Carnicería.Presentation
{
    partial class AñadirEditarCobradoresView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AñadirEditarCobradoresView));
            tabPestañaGeneral = new TabControl();
            tabCobradoresPestaña = new TabPage();
            btnReset = new Button();
            btnBuscar = new Button();
            btnSalir = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnNuevo = new Button();
            txtBusqueda = new TextBox();
            lblBuscar = new Label();
            grdCobradores = new DataGridView();
            tabPestañaDetallesCobradores = new TabPage();
            cboPermisos = new ComboBox();
            lblPermisos = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
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
            txtUser = new TextBox();
            label1 = new Label();
            tabPestañaGeneral.SuspendLayout();
            tabCobradoresPestaña.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdCobradores).BeginInit();
            tabPestañaDetallesCobradores.SuspendLayout();
            SuspendLayout();
            // 
            // tabPestañaGeneral
            // 
            tabPestañaGeneral.Controls.Add(tabCobradoresPestaña);
            tabPestañaGeneral.Controls.Add(tabPestañaDetallesCobradores);
            tabPestañaGeneral.Location = new Point(12, 12);
            tabPestañaGeneral.Name = "tabPestañaGeneral";
            tabPestañaGeneral.SelectedIndex = 0;
            tabPestañaGeneral.Size = new Size(693, 337);
            tabPestañaGeneral.TabIndex = 1;
            tabPestañaGeneral.Click += tabPestañaGeneral_Click;
            // 
            // tabCobradoresPestaña
            // 
            tabCobradoresPestaña.Controls.Add(btnReset);
            tabCobradoresPestaña.Controls.Add(btnBuscar);
            tabCobradoresPestaña.Controls.Add(btnSalir);
            tabCobradoresPestaña.Controls.Add(btnEliminar);
            tabCobradoresPestaña.Controls.Add(btnModificar);
            tabCobradoresPestaña.Controls.Add(btnNuevo);
            tabCobradoresPestaña.Controls.Add(txtBusqueda);
            tabCobradoresPestaña.Controls.Add(lblBuscar);
            tabCobradoresPestaña.Controls.Add(grdCobradores);
            tabCobradoresPestaña.Location = new Point(4, 24);
            tabCobradoresPestaña.Name = "tabCobradoresPestaña";
            tabCobradoresPestaña.Padding = new Padding(3);
            tabCobradoresPestaña.Size = new Size(685, 309);
            tabCobradoresPestaña.TabIndex = 0;
            tabCobradoresPestaña.Text = "Cobradores";
            tabCobradoresPestaña.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(385, 8);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(47, 23);
            btnReset.TabIndex = 9;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(326, 8);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(53, 23);
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
            lblBuscar.Location = new Point(23, 14);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(45, 15);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Buscar:";
            // 
            // grdCobradores
            // 
            grdCobradores.AllowUserToAddRows = false;
            grdCobradores.AllowUserToDeleteRows = false;
            grdCobradores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdCobradores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdCobradores.Location = new Point(6, 39);
            grdCobradores.Name = "grdCobradores";
            grdCobradores.ReadOnly = true;
            grdCobradores.RowTemplate.Height = 25;
            grdCobradores.Size = new Size(573, 264);
            grdCobradores.TabIndex = 0;
            grdCobradores.CellEnter += grdCobradores_CellEnter;
            // 
            // tabPestañaDetallesCobradores
            // 
            tabPestañaDetallesCobradores.Controls.Add(label1);
            tabPestañaDetallesCobradores.Controls.Add(txtUser);
            tabPestañaDetallesCobradores.Controls.Add(cboPermisos);
            tabPestañaDetallesCobradores.Controls.Add(lblPermisos);
            tabPestañaDetallesCobradores.Controls.Add(txtPassword);
            tabPestañaDetallesCobradores.Controls.Add(lblPassword);
            tabPestañaDetallesCobradores.Controls.Add(btnCancelar);
            tabPestañaDetallesCobradores.Controls.Add(btnGuardar);
            tabPestañaDetallesCobradores.Controls.Add(txtTelefono);
            tabPestañaDetallesCobradores.Controls.Add(lblTelefono);
            tabPestañaDetallesCobradores.Controls.Add(txtDireccion);
            tabPestañaDetallesCobradores.Controls.Add(lblDireccion);
            tabPestañaDetallesCobradores.Controls.Add(txtApellido_Nombre);
            tabPestañaDetallesCobradores.Controls.Add(lblApellidoNombre);
            tabPestañaDetallesCobradores.Controls.Add(txtCodigo);
            tabPestañaDetallesCobradores.Controls.Add(lblCodigo);
            tabPestañaDetallesCobradores.Location = new Point(4, 24);
            tabPestañaDetallesCobradores.Name = "tabPestañaDetallesCobradores";
            tabPestañaDetallesCobradores.Padding = new Padding(3);
            tabPestañaDetallesCobradores.Size = new Size(685, 309);
            tabPestañaDetallesCobradores.TabIndex = 1;
            tabPestañaDetallesCobradores.Text = "Detalle Cobrador";
            tabPestañaDetallesCobradores.UseVisualStyleBackColor = true;
            // 
            // cboPermisos
            // 
            cboPermisos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPermisos.FormattingEnabled = true;
            cboPermisos.Location = new Point(241, 224);
            cboPermisos.Name = "cboPermisos";
            cboPermisos.Size = new Size(229, 23);
            cboPermisos.TabIndex = 40;
            // 
            // lblPermisos
            // 
            lblPermisos.AutoSize = true;
            lblPermisos.Location = new Point(180, 227);
            lblPermisos.Name = "lblPermisos";
            lblPermisos.Size = new Size(58, 15);
            lblPermisos.TabIndex = 39;
            lblPermisos.Text = "Permisos:";
            // 
            // txtPassword
            // 
            txtPassword.Enabled = false;
            txtPassword.Location = new Point(241, 192);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(229, 23);
            txtPassword.TabIndex = 38;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(168, 195);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 15);
            lblPassword.TabIndex = 37;
            lblPassword.Text = "Contraseña:";
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Location = new Point(395, 267);
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
            btnGuardar.Location = new Point(241, 267);
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
            txtTelefono.Location = new Point(241, 130);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(229, 23);
            txtTelefono.TabIndex = 34;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(183, 136);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(55, 15);
            lblTelefono.TabIndex = 33;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtDireccion
            // 
            txtDireccion.Enabled = false;
            txtDireccion.Location = new Point(241, 101);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(229, 23);
            txtDireccion.TabIndex = 32;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(178, 107);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(60, 15);
            lblDireccion.TabIndex = 31;
            lblDireccion.Text = "Dirección:";
            // 
            // txtApellido_Nombre
            // 
            txtApellido_Nombre.Enabled = false;
            txtApellido_Nombre.Location = new Point(241, 67);
            txtApellido_Nombre.Name = "txtApellido_Nombre";
            txtApellido_Nombre.Size = new Size(229, 23);
            txtApellido_Nombre.TabIndex = 30;
            // 
            // lblApellidoNombre
            // 
            lblApellidoNombre.AutoSize = true;
            lblApellidoNombre.Location = new Point(128, 73);
            lblApellidoNombre.Name = "lblApellidoNombre";
            lblApellidoNombre.Size = new Size(110, 15);
            lblApellidoNombre.TabIndex = 29;
            lblApellidoNombre.Text = "Apellido y Nombre:";
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(241, 32);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(229, 23);
            txtCodigo.TabIndex = 24;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(189, 38);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(49, 15);
            lblCodigo.TabIndex = 23;
            lblCodigo.Text = "Código:";
            // 
            // txtUser
            // 
            txtUser.Enabled = false;
            txtUser.Location = new Point(241, 159);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(229, 23);
            txtUser.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(185, 162);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 42;
            label1.Text = "Usuario:";
            // 
            // AñadirEditarCobradoresView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 350);
            Controls.Add(tabPestañaGeneral);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AñadirEditarCobradoresView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Añadir/Editar Cobradores";
            tabPestañaGeneral.ResumeLayout(false);
            tabCobradoresPestaña.ResumeLayout(false);
            tabCobradoresPestaña.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdCobradores).EndInit();
            tabPestañaDetallesCobradores.ResumeLayout(false);
            tabPestañaDetallesCobradores.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabPestañaGeneral;
        private TabPage tabCobradoresPestaña;
        private Button btnSalir;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnNuevo;
        private TextBox txtBusqueda;
        private Label lblBuscar;
        private DataGridView grdCobradores;
        private TabPage tabPestañaDetallesCobradores;
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
        private ComboBox cboPermisos;
        private Label lblPermisos;
        private TextBox txtPassword;
        private Label lblPassword;
        private Button btnBuscar;
        private Button btnReset;
        private Label label1;
        private TextBox txtUser;
    }
}