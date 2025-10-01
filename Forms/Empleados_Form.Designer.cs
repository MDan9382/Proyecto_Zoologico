namespace Proyecto_Zoologico.Forms
{
    partial class Empleados_Form
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.TextBox txtNIT;
    private System.Windows.Forms.TextBox txtDPI;
    private System.Windows.Forms.TextBox txtNombre;
    private System.Windows.Forms.TextBox txtCargo;
    private System.Windows.Forms.Label lblNIT;
    private System.Windows.Forms.Label lblDPI;
    private System.Windows.Forms.Label lblNombre;
    private System.Windows.Forms.Label lblCargo;
    private System.Windows.Forms.Label lblPlantillaId;
    private System.Windows.Forms.Label lblHorarioId;
    private System.Windows.Forms.Button btnGuardar;
    private System.Windows.Forms.Button btnLimpiar;

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
            this.txtNIT = new System.Windows.Forms.TextBox();
            this.txtDPI = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.lblNIT = new System.Windows.Forms.Label();
            this.lblDPI = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblPlantillaId = new System.Windows.Forms.Label();
            this.lblHorarioId = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.buttonPlantilla = new System.Windows.Forms.Button();
            this.buttonHorario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNIT
            // 
            this.txtNIT.Location = new System.Drawing.Point(130, 20);
            this.txtNIT.Name = "txtNIT";
            this.txtNIT.Size = new System.Drawing.Size(200, 20);
            this.txtNIT.TabIndex = 1;
            // 
            // txtDPI
            // 
            this.txtDPI.Location = new System.Drawing.Point(130, 60);
            this.txtDPI.Name = "txtDPI";
            this.txtDPI.Size = new System.Drawing.Size(200, 20);
            this.txtDPI.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(130, 100);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(130, 140);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(200, 20);
            this.txtCargo.TabIndex = 7;
            // 
            // lblNIT
            // 
            this.lblNIT.Location = new System.Drawing.Point(20, 20);
            this.lblNIT.Name = "lblNIT";
            this.lblNIT.Size = new System.Drawing.Size(100, 23);
            this.lblNIT.TabIndex = 0;
            this.lblNIT.Text = "NIT:";
            // 
            // lblDPI
            // 
            this.lblDPI.Location = new System.Drawing.Point(20, 60);
            this.lblDPI.Name = "lblDPI";
            this.lblDPI.Size = new System.Drawing.Size(100, 23);
            this.lblDPI.TabIndex = 2;
            this.lblDPI.Text = "DPI:";
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(20, 100);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(100, 23);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCargo
            // 
            this.lblCargo.Location = new System.Drawing.Point(20, 140);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(100, 23);
            this.lblCargo.TabIndex = 6;
            this.lblCargo.Text = "Cargo:";
            // 
            // lblPlantillaId
            // 
            this.lblPlantillaId.Location = new System.Drawing.Point(20, 180);
            this.lblPlantillaId.Name = "lblPlantillaId";
            this.lblPlantillaId.Size = new System.Drawing.Size(100, 23);
            this.lblPlantillaId.TabIndex = 8;
            this.lblPlantillaId.Text = "Sueldo:";
            // 
            // lblHorarioId
            // 
            this.lblHorarioId.Location = new System.Drawing.Point(20, 220);
            this.lblHorarioId.Name = "lblHorarioId";
            this.lblHorarioId.Size = new System.Drawing.Size(100, 23);
            this.lblHorarioId.TabIndex = 10;
            this.lblHorarioId.Text = "Horario:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(130, 284);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 30);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(240, 284);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(90, 30);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.LimpiarCampos);
            // 
            // buttonPlantilla
            // 
            this.buttonPlantilla.Location = new System.Drawing.Point(126, 180);
            this.buttonPlantilla.Name = "buttonPlantilla";
            this.buttonPlantilla.Size = new System.Drawing.Size(204, 23);
            this.buttonPlantilla.TabIndex = 14;
            this.buttonPlantilla.Text = "Añadir";
            this.buttonPlantilla.UseVisualStyleBackColor = true;
            this.buttonPlantilla.Click += new System.EventHandler(this.buttonPlantilla_Click);
            // 
            // buttonHorario
            // 
            this.buttonHorario.Location = new System.Drawing.Point(126, 220);
            this.buttonHorario.Name = "buttonHorario";
            this.buttonHorario.Size = new System.Drawing.Size(204, 23);
            this.buttonHorario.TabIndex = 15;
            this.buttonHorario.Text = "Añadir";
            this.buttonHorario.UseVisualStyleBackColor = true;
            this.buttonHorario.Click += new System.EventHandler(this.buttonHorario_Click);
            // 
            // Empleados_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.buttonHorario);
            this.Controls.Add(this.buttonPlantilla);
            this.Controls.Add(this.lblNIT);
            this.Controls.Add(this.txtNIT);
            this.Controls.Add(this.lblDPI);
            this.Controls.Add(this.txtDPI);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.lblPlantillaId);
            this.Controls.Add(this.lblHorarioId);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Name = "Empleados_Form";
            this.Text = "Gestión de Empleados";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        private System.Windows.Forms.Button buttonPlantilla;
        private System.Windows.Forms.Button buttonHorario;
    }
}