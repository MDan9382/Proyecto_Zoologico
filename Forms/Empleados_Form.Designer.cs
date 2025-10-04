namespace Proyecto_Zoologico.Forms
{
    partial class Empleados_Form
    {
        private System.ComponentModel.IContainer components = null;

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
            this.gbDatosPersonales = new System.Windows.Forms.GroupBox();
            this.lblNIT = new System.Windows.Forms.Label();
            this.txtNIT = new System.Windows.Forms.TextBox();
            this.lblDPI = new System.Windows.Forms.Label();
            this.txtDPI = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.gbAsignaciones = new System.Windows.Forms.GroupBox();
            this.lblPlantillaId = new System.Windows.Forms.Label();
            this.buttonPlantilla = new System.Windows.Forms.Button();
            this.lblHorarioId = new System.Windows.Forms.Label();
            this.buttonHorario = new System.Windows.Forms.Button();
            this.gbAcciones = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.panelSuperior.SuspendLayout();
            this.gbDatosPersonales.SuspendLayout();
            this.gbAsignaciones.SuspendLayout();
            this.gbAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelSuperior.Controls.Add(this.lblTitulo);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(700, 70);
            this.panelSuperior.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(373, 41);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "👤 Gestión de Empleados";
            // 
            // gbDatosPersonales
            // 
            this.gbDatosPersonales.Controls.Add(this.cmbCargo);
            this.gbDatosPersonales.Controls.Add(this.lblNIT);
            this.gbDatosPersonales.Controls.Add(this.txtNIT);
            this.gbDatosPersonales.Controls.Add(this.lblDPI);
            this.gbDatosPersonales.Controls.Add(this.txtDPI);
            this.gbDatosPersonales.Controls.Add(this.lblNombre);
            this.gbDatosPersonales.Controls.Add(this.txtNombre);
            this.gbDatosPersonales.Controls.Add(this.lblCargo);
            this.gbDatosPersonales.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbDatosPersonales.Location = new System.Drawing.Point(20, 90);
            this.gbDatosPersonales.Name = "gbDatosPersonales";
            this.gbDatosPersonales.Size = new System.Drawing.Size(660, 214);
            this.gbDatosPersonales.TabIndex = 1;
            this.gbDatosPersonales.TabStop = false;
            this.gbDatosPersonales.Text = "Datos Personales";
            // 
            // lblNIT
            // 
            this.lblNIT.AutoSize = true;
            this.lblNIT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNIT.Location = new System.Drawing.Point(15, 35);
            this.lblNIT.Name = "lblNIT";
            this.lblNIT.Size = new System.Drawing.Size(33, 19);
            this.lblNIT.TabIndex = 0;
            this.lblNIT.Text = "NIT:";
            // 
            // txtNIT
            // 
            this.txtNIT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNIT.Location = new System.Drawing.Point(15, 55);
            this.txtNIT.Name = "txtNIT";
            this.txtNIT.Size = new System.Drawing.Size(300, 27);
            this.txtNIT.TabIndex = 1;
            // 
            // lblDPI
            // 
            this.lblDPI.AutoSize = true;
            this.lblDPI.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDPI.Location = new System.Drawing.Point(345, 35);
            this.lblDPI.Name = "lblDPI";
            this.lblDPI.Size = new System.Drawing.Size(34, 19);
            this.lblDPI.TabIndex = 2;
            this.lblDPI.Text = "DPI:";
            // 
            // txtDPI
            // 
            this.txtDPI.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDPI.Location = new System.Drawing.Point(345, 55);
            this.txtDPI.Name = "txtDPI";
            this.txtDPI.Size = new System.Drawing.Size(300, 27);
            this.txtDPI.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNombre.Location = new System.Drawing.Point(15, 100);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(126, 19);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre Completo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombre.Location = new System.Drawing.Point(15, 120);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(630, 27);
            this.txtNombre.TabIndex = 5;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCargo.Location = new System.Drawing.Point(15, 155);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(49, 19);
            this.lblCargo.TabIndex = 6;
            this.lblCargo.Text = "Cargo:";
            // 
            // gbAsignaciones
            // 
            this.gbAsignaciones.Controls.Add(this.lblPlantillaId);
            this.gbAsignaciones.Controls.Add(this.buttonPlantilla);
            this.gbAsignaciones.Controls.Add(this.lblHorarioId);
            this.gbAsignaciones.Controls.Add(this.buttonHorario);
            this.gbAsignaciones.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbAsignaciones.Location = new System.Drawing.Point(20, 310);
            this.gbAsignaciones.Name = "gbAsignaciones";
            this.gbAsignaciones.Size = new System.Drawing.Size(660, 130);
            this.gbAsignaciones.TabIndex = 2;
            this.gbAsignaciones.TabStop = false;
            this.gbAsignaciones.Text = "Asignaciones";
            // 
            // lblPlantillaId
            // 
            this.lblPlantillaId.AutoSize = true;
            this.lblPlantillaId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPlantillaId.Location = new System.Drawing.Point(15, 35);
            this.lblPlantillaId.Name = "lblPlantillaId";
            this.lblPlantillaId.Size = new System.Drawing.Size(53, 19);
            this.lblPlantillaId.TabIndex = 0;
            this.lblPlantillaId.Text = "Sueldo:";
            // 
            // buttonPlantilla
            // 
            this.buttonPlantilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.buttonPlantilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlantilla.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonPlantilla.ForeColor = System.Drawing.Color.White;
            this.buttonPlantilla.Location = new System.Drawing.Point(15, 55);
            this.buttonPlantilla.Name = "buttonPlantilla";
            this.buttonPlantilla.Size = new System.Drawing.Size(300, 35);
            this.buttonPlantilla.TabIndex = 1;
            this.buttonPlantilla.Text = "💰 Añadir Plantilla de Sueldo";
            this.buttonPlantilla.UseVisualStyleBackColor = false;
            this.buttonPlantilla.Click += new System.EventHandler(this.buttonPlantilla_Click);
            // 
            // lblHorarioId
            // 
            this.lblHorarioId.AutoSize = true;
            this.lblHorarioId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHorarioId.Location = new System.Drawing.Point(345, 35);
            this.lblHorarioId.Name = "lblHorarioId";
            this.lblHorarioId.Size = new System.Drawing.Size(58, 19);
            this.lblHorarioId.TabIndex = 2;
            this.lblHorarioId.Text = "Horario:";
            // 
            // buttonHorario
            // 
            this.buttonHorario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.buttonHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHorario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonHorario.ForeColor = System.Drawing.Color.White;
            this.buttonHorario.Location = new System.Drawing.Point(345, 55);
            this.buttonHorario.Name = "buttonHorario";
            this.buttonHorario.Size = new System.Drawing.Size(300, 35);
            this.buttonHorario.TabIndex = 3;
            this.buttonHorario.Text = "🕐 Añadir Horario";
            this.buttonHorario.UseVisualStyleBackColor = false;
            this.buttonHorario.Click += new System.EventHandler(this.buttonHorario_Click);
            // 
            // gbAcciones
            // 
            this.gbAcciones.Controls.Add(this.btnGuardar);
            this.gbAcciones.Controls.Add(this.btnLimpiar);
            this.gbAcciones.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbAcciones.Location = new System.Drawing.Point(20, 460);
            this.gbAcciones.Name = "gbAcciones";
            this.gbAcciones.Size = new System.Drawing.Size(660, 90);
            this.gbAcciones.TabIndex = 3;
            this.gbAcciones.TabStop = false;
            this.gbAcciones.Text = "Acciones";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(15, 30);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(300, 45);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "💾 Guardar Empleado";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(345, 30);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(300, 45);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "🔄 Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.LimpiarCampos);
            // 
            // cmbCargo
            // 
            this.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(15, 177);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(630, 28);
            this.cmbCargo.TabIndex = 9;
            // 
            // Empleados_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(700, 570);
            this.Controls.Add(this.gbAcciones);
            this.Controls.Add(this.gbAsignaciones);
            this.Controls.Add(this.gbDatosPersonales);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Empleados_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Empleados - Zoológico";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.gbDatosPersonales.ResumeLayout(false);
            this.gbDatosPersonales.PerformLayout();
            this.gbAsignaciones.ResumeLayout(false);
            this.gbAsignaciones.PerformLayout();
            this.gbAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbDatosPersonales;
        private System.Windows.Forms.Label lblNIT;
        private System.Windows.Forms.TextBox txtNIT;
        private System.Windows.Forms.Label lblDPI;
        private System.Windows.Forms.TextBox txtDPI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.GroupBox gbAsignaciones;
        private System.Windows.Forms.Label lblPlantillaId;
        private System.Windows.Forms.Button buttonPlantilla;
        private System.Windows.Forms.Label lblHorarioId;
        private System.Windows.Forms.Button buttonHorario;
        private System.Windows.Forms.GroupBox gbAcciones;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ComboBox cmbCargo;
    }
}