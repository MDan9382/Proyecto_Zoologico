namespace Proyecto_Zoologico.Forms
{
    partial class Horarios_Form
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
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.labelDias = new System.Windows.Forms.Label();
            this.DiascheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.labelDuracion = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.Hora_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.Minuto_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.gbAcciones = new System.Windows.Forms.GroupBox();
            this.buttonInsertar = new System.Windows.Forms.Button();
            this.panelSuperior.SuspendLayout();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hora_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minuto_numericUpDown)).BeginInit();
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
            this.panelSuperior.Size = new System.Drawing.Size(520, 70);
            this.panelSuperior.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(294, 41);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "🕐 Insertar Horario";
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.labelDias);
            this.gbDatos.Controls.Add(this.DiascheckedListBox);
            this.gbDatos.Controls.Add(this.labelDuracion);
            this.gbDatos.Controls.Add(this.lblHoras);
            this.gbDatos.Controls.Add(this.Hora_numericUpDown);
            this.gbDatos.Controls.Add(this.lblMinutos);
            this.gbDatos.Controls.Add(this.Minuto_numericUpDown);
            this.gbDatos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbDatos.Location = new System.Drawing.Point(20, 90);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(480, 294);
            this.gbDatos.TabIndex = 1;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos del Horario";
            // 
            // labelDias
            // 
            this.labelDias.AutoSize = true;
            this.labelDias.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelDias.Location = new System.Drawing.Point(15, 30);
            this.labelDias.Name = "labelDias";
            this.labelDias.Size = new System.Drawing.Size(108, 19);
            this.labelDias.TabIndex = 0;
            this.labelDias.Text = "Días del horario:";
            // 
            // DiascheckedListBox
            // 
            this.DiascheckedListBox.CheckOnClick = true;
            this.DiascheckedListBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DiascheckedListBox.FormattingEnabled = true;
            this.DiascheckedListBox.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sábado",
            "Domingo"});
            this.DiascheckedListBox.Location = new System.Drawing.Point(15, 55);
            this.DiascheckedListBox.Name = "DiascheckedListBox";
            this.DiascheckedListBox.Size = new System.Drawing.Size(450, 158);
            this.DiascheckedListBox.TabIndex = 1;
            this.DiascheckedListBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // labelDuracion
            // 
            this.labelDuracion.AutoSize = true;
            this.labelDuracion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelDuracion.Location = new System.Drawing.Point(15, 238);
            this.labelDuracion.Name = "labelDuracion";
            this.labelDuracion.Size = new System.Drawing.Size(187, 19);
            this.labelDuracion.TabIndex = 2;
            this.labelDuracion.Text = "Duración de la jornada diaria:";
            this.labelDuracion.Click += new System.EventHandler(this.labelDuracion_Click);
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHoras.Location = new System.Drawing.Point(15, 263);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(48, 19);
            this.lblHoras.TabIndex = 3;
            this.lblHoras.Text = "Horas:";
            // 
            // Hora_numericUpDown
            // 
            this.Hora_numericUpDown.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Hora_numericUpDown.Location = new System.Drawing.Point(70, 261);
            this.Hora_numericUpDown.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.Hora_numericUpDown.Name = "Hora_numericUpDown";
            this.Hora_numericUpDown.Size = new System.Drawing.Size(80, 27);
            this.Hora_numericUpDown.TabIndex = 4;
            this.Hora_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMinutos.Location = new System.Drawing.Point(170, 263);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(63, 19);
            this.lblMinutos.TabIndex = 5;
            this.lblMinutos.Text = "Minutos:";
            // 
            // Minuto_numericUpDown
            // 
            this.Minuto_numericUpDown.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Minuto_numericUpDown.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.Minuto_numericUpDown.Location = new System.Drawing.Point(240, 261);
            this.Minuto_numericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.Minuto_numericUpDown.Name = "Minuto_numericUpDown";
            this.Minuto_numericUpDown.Size = new System.Drawing.Size(80, 27);
            this.Minuto_numericUpDown.TabIndex = 6;
            this.Minuto_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbAcciones
            // 
            this.gbAcciones.Controls.Add(this.buttonInsertar);
            this.gbAcciones.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbAcciones.Location = new System.Drawing.Point(20, 390);
            this.gbAcciones.Name = "gbAcciones";
            this.gbAcciones.Size = new System.Drawing.Size(480, 90);
            this.gbAcciones.TabIndex = 2;
            this.gbAcciones.TabStop = false;
            this.gbAcciones.Text = "Acciones";
            // 
            // buttonInsertar
            // 
            this.buttonInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.buttonInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsertar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonInsertar.ForeColor = System.Drawing.Color.White;
            this.buttonInsertar.Location = new System.Drawing.Point(15, 30);
            this.buttonInsertar.Name = "buttonInsertar";
            this.buttonInsertar.Size = new System.Drawing.Size(450, 45);
            this.buttonInsertar.TabIndex = 0;
            this.buttonInsertar.Text = "✅ Insertar Horario";
            this.buttonInsertar.UseVisualStyleBackColor = false;
            this.buttonInsertar.Click += new System.EventHandler(this.buttonInsertar_Click);
            // 
            // Horarios_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(520, 500);
            this.Controls.Add(this.gbAcciones);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Horarios_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insertar Horario - Zoológico";
            this.Load += new System.EventHandler(this.Horarios_Load);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hora_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minuto_numericUpDown)).EndInit();
            this.gbAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label labelDias;
        private System.Windows.Forms.CheckedListBox DiascheckedListBox;
        private System.Windows.Forms.Label labelDuracion;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.NumericUpDown Hora_numericUpDown;
        private System.Windows.Forms.NumericUpDown Minuto_numericUpDown;
        private System.Windows.Forms.GroupBox gbAcciones;
        private System.Windows.Forms.Button buttonInsertar;
    }
}