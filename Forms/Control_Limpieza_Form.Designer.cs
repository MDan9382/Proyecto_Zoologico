namespace Proyecto_Zoologico.Formularios
{
    partial class Control_Limpieza_Form
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.Button btnRegistrarHoraActual;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEmpleadoId;
        private System.Windows.Forms.Label lblLocacionId;
        private System.Windows.Forms.GroupBox gbBusqueda;
        private System.Windows.Forms.Label lblBuscarPor;
        private System.Windows.Forms.ComboBox cmbBuscarPor;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbAcciones;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvControlLimpieza;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbLocacion = new System.Windows.Forms.ComboBox();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrarHoraActual = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblEmpleadoId = new System.Windows.Forms.Label();
            this.lblLocacionId = new System.Windows.Forms.Label();
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.lblBuscarPor = new System.Windows.Forms.Label();
            this.cmbBuscarPor = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbAcciones = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvControlLimpieza = new System.Windows.Forms.DataGridView();
            this.panelSuperior.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.gbBusqueda.SuspendLayout();
            this.gbAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlLimpieza)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.panelSuperior.Controls.Add(this.lblTitulo);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1260, 70);
            this.panelSuperior.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(508, 41);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "🧹 Gestión de Control de Limpieza";
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.dateTimePicker1);
            this.gbDatos.Controls.Add(this.cmbLocacion);
            this.gbDatos.Controls.Add(this.cmbEmpleado);
            this.gbDatos.Controls.Add(this.lblHora);
            this.gbDatos.Controls.Add(this.dtpHora);
            this.gbDatos.Controls.Add(this.btnRegistrarHoraActual);
            this.gbDatos.Controls.Add(this.lblFecha);
            this.gbDatos.Controls.Add(this.lblEmpleadoId);
            this.gbDatos.Controls.Add(this.lblLocacionId);
            this.gbDatos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbDatos.Location = new System.Drawing.Point(20, 90);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(662, 210);
            this.gbDatos.TabIndex = 1;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos del Control de Limpieza";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(329, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(269, 27);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // cmbLocacion
            // 
            this.cmbLocacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbLocacion.FormattingEnabled = true;
            this.cmbLocacion.Location = new System.Drawing.Point(285, 115);
            this.cmbLocacion.Name = "cmbLocacion";
            this.cmbLocacion.Size = new System.Drawing.Size(270, 28);
            this.cmbLocacion.TabIndex = 10;
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(15, 115);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(255, 28);
            this.cmbEmpleado.TabIndex = 9;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHora.Location = new System.Drawing.Point(15, 30);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(111, 19);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "Hora de Control:";
            // 
            // dtpHora
            // 
            this.dtpHora.CustomFormat = "HH:mm:ss";
            this.dtpHora.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHora.Location = new System.Drawing.Point(15, 50);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(180, 27);
            this.dtpHora.TabIndex = 1;
            // 
            // btnRegistrarHoraActual
            // 
            this.btnRegistrarHoraActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnRegistrarHoraActual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarHoraActual.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarHoraActual.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarHoraActual.Location = new System.Drawing.Point(205, 50);
            this.btnRegistrarHoraActual.Name = "btnRegistrarHoraActual";
            this.btnRegistrarHoraActual.Size = new System.Drawing.Size(110, 25);
            this.btnRegistrarHoraActual.TabIndex = 2;
            this.btnRegistrarHoraActual.Text = "⏰ Hora Actual";
            this.btnRegistrarHoraActual.UseVisualStyleBackColor = false;
            this.btnRegistrarHoraActual.Click += new System.EventHandler(this.btnRegistrarHoraActual_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFecha.Location = new System.Drawing.Point(325, 30);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(84, 19);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Día del Mes:";
            // 
            // lblEmpleadoId
            // 
            this.lblEmpleadoId.AutoSize = true;
            this.lblEmpleadoId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmpleadoId.Location = new System.Drawing.Point(15, 95);
            this.lblEmpleadoId.Name = "lblEmpleadoId";
            this.lblEmpleadoId.Size = new System.Drawing.Size(72, 19);
            this.lblEmpleadoId.TabIndex = 5;
            this.lblEmpleadoId.Text = "Empleado:";
            // 
            // lblLocacionId
            // 
            this.lblLocacionId.AutoSize = true;
            this.lblLocacionId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLocacionId.Location = new System.Drawing.Point(285, 95);
            this.lblLocacionId.Name = "lblLocacionId";
            this.lblLocacionId.Size = new System.Drawing.Size(125, 19);
            this.lblLocacionId.TabIndex = 7;
            this.lblLocacionId.Text = "Locación a Limpiar:";
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.Controls.Add(this.lblBuscarPor);
            this.gbBusqueda.Controls.Add(this.cmbBuscarPor);
            this.gbBusqueda.Controls.Add(this.txtBuscar);
            this.gbBusqueda.Controls.Add(this.btnBuscar);
            this.gbBusqueda.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbBusqueda.Location = new System.Drawing.Point(688, 90);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Size = new System.Drawing.Size(280, 210);
            this.gbBusqueda.TabIndex = 2;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Búsqueda de Controles";
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBuscarPor.Location = new System.Drawing.Point(15, 35);
            this.lblBuscarPor.Name = "lblBuscarPor";
            this.lblBuscarPor.Size = new System.Drawing.Size(77, 19);
            this.lblBuscarPor.TabIndex = 0;
            this.lblBuscarPor.Text = "Buscar por:";
            // 
            // cmbBuscarPor
            // 
            this.cmbBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarPor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbBuscarPor.FormattingEnabled = true;
            this.cmbBuscarPor.Location = new System.Drawing.Point(15, 55);
            this.cmbBuscarPor.Name = "cmbBuscarPor";
            this.cmbBuscarPor.Size = new System.Drawing.Size(250, 28);
            this.cmbBuscarPor.TabIndex = 1;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBuscar.Location = new System.Drawing.Point(15, 95);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(250, 27);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(15, 135);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(250, 40);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "🔍 Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gbAcciones
            // 
            this.gbAcciones.Controls.Add(this.btnAgregar);
            this.gbAcciones.Controls.Add(this.btnActualizar);
            this.gbAcciones.Controls.Add(this.btnEliminar);
            this.gbAcciones.Controls.Add(this.btnLimpiar);
            this.gbAcciones.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbAcciones.Location = new System.Drawing.Point(988, 90);
            this.gbAcciones.Name = "gbAcciones";
            this.gbAcciones.Size = new System.Drawing.Size(260, 210);
            this.gbAcciones.TabIndex = 3;
            this.gbAcciones.TabStop = false;
            this.gbAcciones.Text = "Acciones";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(15, 30);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(230, 38);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "➕ Registrar Control";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(15, 76);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(230, 38);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "✏️ Actualizar Control";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(15, 122);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(230, 38);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "🗑️ Eliminar Control";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(15, 168);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(230, 32);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "🔄 Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dgvControlLimpieza
            // 
            this.dgvControlLimpieza.AllowUserToAddRows = false;
            this.dgvControlLimpieza.AllowUserToDeleteRows = false;
            this.dgvControlLimpieza.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvControlLimpieza.BackgroundColor = System.Drawing.Color.White;
            this.dgvControlLimpieza.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvControlLimpieza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvControlLimpieza.Location = new System.Drawing.Point(20, 320);
            this.dgvControlLimpieza.Name = "dgvControlLimpieza";
            this.dgvControlLimpieza.ReadOnly = true;
            this.dgvControlLimpieza.RowHeadersWidth = 51;
            this.dgvControlLimpieza.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvControlLimpieza.Size = new System.Drawing.Size(1228, 320);
            this.dgvControlLimpieza.TabIndex = 4;
            this.dgvControlLimpieza.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvControlLimpieza_CellClick);
            // 
            // Control_Limpieza_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1260, 700);
            this.Controls.Add(this.dgvControlLimpieza);
            this.Controls.Add(this.gbAcciones);
            this.Controls.Add(this.gbBusqueda);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Control_Limpieza_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Control de Limpieza - Zoológico";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            this.gbAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlLimpieza)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.ComboBox cmbLocacion;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}