namespace Proyecto_Zoologico.Formularios
{
    partial class Jaulas_Form
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Label lblTotalRegistros;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lblAmbiente;
        private System.Windows.Forms.ComboBox cmbAmbiente;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblLocacionId;
        private System.Windows.Forms.Label lblAnimalId;
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
        private System.Windows.Forms.DataGridView dgvJaulas;

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
            this.panelInferior = new System.Windows.Forms.Panel();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.lblAmbiente = new System.Windows.Forms.Label();
            this.cmbAmbiente = new System.Windows.Forms.ComboBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblLocacionId = new System.Windows.Forms.Label();
            this.lblAnimalId = new System.Windows.Forms.Label();
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
            this.dgvJaulas = new System.Windows.Forms.DataGridView();
            this.cmbLocacion = new System.Windows.Forms.ComboBox();
            this.cmbAnimal = new System.Windows.Forms.ComboBox();
            this.panelSuperior.SuspendLayout();
            this.panelInferior.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.gbBusqueda.SuspendLayout();
            this.gbAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJaulas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.panelSuperior.Controls.Add(this.lblTitulo);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1250, 70);
            this.panelSuperior.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(307, 41);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "🏠 Gestión de Jaulas";
            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelInferior.Controls.Add(this.lblTotalRegistros);
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(0, 670);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(1250, 40);
            this.panelInferior.TabIndex = 5;
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.AutoSize = true;
            this.lblTotalRegistros.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalRegistros.ForeColor = System.Drawing.Color.White;
            this.lblTotalRegistros.Location = new System.Drawing.Point(12, 11);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(129, 20);
            this.lblTotalRegistros.TabIndex = 0;
            this.lblTotalRegistros.Text = "Total de Jaulas: 0";
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.cmbAnimal);
            this.gbDatos.Controls.Add(this.cmbLocacion);
            this.gbDatos.Controls.Add(this.lblAmbiente);
            this.gbDatos.Controls.Add(this.cmbAmbiente);
            this.gbDatos.Controls.Add(this.lblArea);
            this.gbDatos.Controls.Add(this.txtArea);
            this.gbDatos.Controls.Add(this.lblLocacionId);
            this.gbDatos.Controls.Add(this.lblAnimalId);
            this.gbDatos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbDatos.Location = new System.Drawing.Point(20, 90);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(560, 200);
            this.gbDatos.TabIndex = 1;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos de la Jaula";
            // 
            // lblAmbiente
            // 
            this.lblAmbiente.AutoSize = true;
            this.lblAmbiente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAmbiente.Location = new System.Drawing.Point(15, 30);
            this.lblAmbiente.Name = "lblAmbiente";
            this.lblAmbiente.Size = new System.Drawing.Size(120, 19);
            this.lblAmbiente.TabIndex = 0;
            this.lblAmbiente.Text = "Tipo de Ambiente:";
            // 
            // cmbAmbiente
            // 
            this.cmbAmbiente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAmbiente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbAmbiente.FormattingEnabled = true;
            this.cmbAmbiente.Location = new System.Drawing.Point(15, 50);
            this.cmbAmbiente.Name = "cmbAmbiente";
            this.cmbAmbiente.Size = new System.Drawing.Size(250, 28);
            this.cmbAmbiente.TabIndex = 1;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblArea.Location = new System.Drawing.Point(285, 30);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(69, 19);
            this.lblArea.TabIndex = 2;
            this.lblArea.Text = "Área (m²):";
            // 
            // txtArea
            // 
            this.txtArea.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtArea.Location = new System.Drawing.Point(285, 50);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(250, 27);
            this.txtArea.TabIndex = 3;
            this.txtArea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArea_KeyPress);
            // 
            // lblLocacionId
            // 
            this.lblLocacionId.AutoSize = true;
            this.lblLocacionId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLocacionId.Location = new System.Drawing.Point(15, 95);
            this.lblLocacionId.Name = "lblLocacionId";
            this.lblLocacionId.Size = new System.Drawing.Size(65, 19);
            this.lblLocacionId.TabIndex = 4;
            this.lblLocacionId.Text = "Locación:";
            // 
            // lblAnimalId
            // 
            this.lblAnimalId.AutoSize = true;
            this.lblAnimalId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAnimalId.Location = new System.Drawing.Point(285, 95);
            this.lblAnimalId.Name = "lblAnimalId";
            this.lblAnimalId.Size = new System.Drawing.Size(54, 19);
            this.lblAnimalId.TabIndex = 6;
            this.lblAnimalId.Text = "Animal:";
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.Controls.Add(this.lblBuscarPor);
            this.gbBusqueda.Controls.Add(this.cmbBuscarPor);
            this.gbBusqueda.Controls.Add(this.txtBuscar);
            this.gbBusqueda.Controls.Add(this.btnBuscar);
            this.gbBusqueda.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbBusqueda.Location = new System.Drawing.Point(600, 90);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Size = new System.Drawing.Size(320, 200);
            this.gbBusqueda.TabIndex = 2;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Búsqueda de Jaulas";
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
            this.cmbBuscarPor.FormattingEnabled = true;
            this.cmbBuscarPor.Location = new System.Drawing.Point(15, 55);
            this.cmbBuscarPor.Name = "cmbBuscarPor";
            this.cmbBuscarPor.Size = new System.Drawing.Size(290, 28);
            this.cmbBuscarPor.TabIndex = 1;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBuscar.Location = new System.Drawing.Point(15, 95);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(290, 27);
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
            this.btnBuscar.Size = new System.Drawing.Size(290, 40);
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
            this.gbAcciones.Location = new System.Drawing.Point(940, 90);
            this.gbAcciones.Name = "gbAcciones";
            this.gbAcciones.Size = new System.Drawing.Size(290, 200);
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
            this.btnAgregar.Size = new System.Drawing.Size(260, 35);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "➕ Agregar Jaula";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(15, 73);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(260, 35);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "✏️ Actualizar Jaula";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(15, 116);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(260, 35);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "🗑️ Eliminar Jaula";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(15, 159);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(260, 30);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "🔄 Limpiar Formulario";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dgvJaulas
            // 
            this.dgvJaulas.AllowUserToAddRows = false;
            this.dgvJaulas.AllowUserToDeleteRows = false;
            this.dgvJaulas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJaulas.BackgroundColor = System.Drawing.Color.White;
            this.dgvJaulas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvJaulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJaulas.Location = new System.Drawing.Point(20, 310);
            this.dgvJaulas.Name = "dgvJaulas";
            this.dgvJaulas.ReadOnly = true;
            this.dgvJaulas.RowHeadersWidth = 51;
            this.dgvJaulas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJaulas.Size = new System.Drawing.Size(1210, 340);
            this.dgvJaulas.TabIndex = 4;
            this.dgvJaulas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJaulas_CellClick);
            // 
            // cmbLocacion
            // 
            this.cmbLocacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbLocacion.FormattingEnabled = true;
            this.cmbLocacion.Location = new System.Drawing.Point(15, 115);
            this.cmbLocacion.Name = "cmbLocacion";
            this.cmbLocacion.Size = new System.Drawing.Size(250, 28);
            this.cmbLocacion.TabIndex = 8;
            // 
            // cmbAnimal
            // 
            this.cmbAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnimal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbAnimal.FormattingEnabled = true;
            this.cmbAnimal.Location = new System.Drawing.Point(285, 115);
            this.cmbAnimal.Name = "cmbAnimal";
            this.cmbAnimal.Size = new System.Drawing.Size(250, 28);
            this.cmbAnimal.TabIndex = 9;
            // 
            // Jaulas_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1250, 710);
            this.Controls.Add(this.dgvJaulas);
            this.Controls.Add(this.gbAcciones);
            this.Controls.Add(this.gbBusqueda);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Jaulas_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Jaulas - Zoológico";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelInferior.ResumeLayout(false);
            this.panelInferior.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            this.gbAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJaulas)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ComboBox cmbAnimal;
        private System.Windows.Forms.ComboBox cmbLocacion;
    }
}