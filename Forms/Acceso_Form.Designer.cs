namespace Proyecto_Zoologico.Forms
{
    partial class Acceso_Form
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
            this.gbModulos = new System.Windows.Forms.GroupBox();
            this.btnAlimentacion = new System.Windows.Forms.Button();
            this.btnAnimales = new System.Windows.Forms.Button();
            this.btn_ControlLimpieza = new System.Windows.Forms.Button();
            this.btnControlTiempo = new System.Windows.Forms.Button();
            this.btnControlClinico = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnJaulas = new System.Windows.Forms.Button();
            this.btnLocaciones = new System.Windows.Forms.Button();
            this.panelSuperior.SuspendLayout();
            this.gbModulos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelSuperior.Controls.Add(this.lblTitulo);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1200, 70);
            this.panelSuperior.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(566, 41);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "🦁 Sistema de Gestión de Zoológico";
            // 
            // gbModulos
            // 
            this.gbModulos.Controls.Add(this.btnAlimentacion);
            this.gbModulos.Controls.Add(this.btnAnimales);
            this.gbModulos.Controls.Add(this.btn_ControlLimpieza);
            this.gbModulos.Controls.Add(this.btnControlTiempo);
            this.gbModulos.Controls.Add(this.btnControlClinico);
            this.gbModulos.Controls.Add(this.btnEmpleados);
            this.gbModulos.Controls.Add(this.btnInventario);
            this.gbModulos.Controls.Add(this.btnJaulas);
            this.gbModulos.Controls.Add(this.btnLocaciones);
            this.gbModulos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbModulos.Location = new System.Drawing.Point(20, 90);
            this.gbModulos.Name = "gbModulos";
            this.gbModulos.Size = new System.Drawing.Size(1160, 590);
            this.gbModulos.TabIndex = 1;
            this.gbModulos.TabStop = false;
            this.gbModulos.Text = "Módulos del Sistema";
            // 
            // btnAlimentacion
            // 
            this.btnAlimentacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAlimentacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlimentacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAlimentacion.ForeColor = System.Drawing.Color.White;
            this.btnAlimentacion.Location = new System.Drawing.Point(30, 40);
            this.btnAlimentacion.Name = "btnAlimentacion";
            this.btnAlimentacion.Size = new System.Drawing.Size(350, 70);
            this.btnAlimentacion.TabIndex = 0;
            this.btnAlimentacion.Text = "🍖 Alimentación";
            this.btnAlimentacion.UseVisualStyleBackColor = false;
            this.btnAlimentacion.Click += new System.EventHandler(this.btnAlimentacion_Click);
            // 
            // btnAnimales
            // 
            this.btnAnimales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnAnimales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnimales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAnimales.ForeColor = System.Drawing.Color.White;
            this.btnAnimales.Location = new System.Drawing.Point(405, 40);
            this.btnAnimales.Name = "btnAnimales";
            this.btnAnimales.Size = new System.Drawing.Size(350, 70);
            this.btnAnimales.TabIndex = 1;
            this.btnAnimales.Text = "🐘 Animales";
            this.btnAnimales.UseVisualStyleBackColor = false;
            this.btnAnimales.Click += new System.EventHandler(this.btnAnimales_Click);
            // 
            // btn_ControlLimpieza
            // 
            this.btn_ControlLimpieza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btn_ControlLimpieza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ControlLimpieza.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_ControlLimpieza.ForeColor = System.Drawing.Color.White;
            this.btn_ControlLimpieza.Location = new System.Drawing.Point(780, 40);
            this.btn_ControlLimpieza.Name = "btn_ControlLimpieza";
            this.btn_ControlLimpieza.Size = new System.Drawing.Size(350, 70);
            this.btn_ControlLimpieza.TabIndex = 2;
            this.btn_ControlLimpieza.Text = "🧹 Control de Limpieza";
            this.btn_ControlLimpieza.UseVisualStyleBackColor = false;
            this.btn_ControlLimpieza.Click += new System.EventHandler(this.btn_ControlLimpieza_Click);
            // 
            // btnControlTiempo
            // 
            this.btnControlTiempo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnControlTiempo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControlTiempo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnControlTiempo.ForeColor = System.Drawing.Color.White;
            this.btnControlTiempo.Location = new System.Drawing.Point(30, 130);
            this.btnControlTiempo.Name = "btnControlTiempo";
            this.btnControlTiempo.Size = new System.Drawing.Size(350, 70);
            this.btnControlTiempo.TabIndex = 3;
            this.btnControlTiempo.Text = "⏰ Control de Tiempo";
            this.btnControlTiempo.UseVisualStyleBackColor = false;
            this.btnControlTiempo.Click += new System.EventHandler(this.btnControlTiempo_Click);
            // 
            // btnControlClinico
            // 
            this.btnControlClinico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnControlClinico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControlClinico.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnControlClinico.ForeColor = System.Drawing.Color.White;
            this.btnControlClinico.Location = new System.Drawing.Point(405, 130);
            this.btnControlClinico.Name = "btnControlClinico";
            this.btnControlClinico.Size = new System.Drawing.Size(350, 70);
            this.btnControlClinico.TabIndex = 4;
            this.btnControlClinico.Text = "🏥 Control Clínico";
            this.btnControlClinico.UseVisualStyleBackColor = false;
            this.btnControlClinico.Click += new System.EventHandler(this.btnControlClinico_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnEmpleados.Location = new System.Drawing.Point(780, 130);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(350, 70);
            this.btnEmpleados.TabIndex = 5;
            this.btnEmpleados.Text = "👤 Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnInventario.ForeColor = System.Drawing.Color.White;
            this.btnInventario.Location = new System.Drawing.Point(30, 220);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(350, 70);
            this.btnInventario.TabIndex = 6;
            this.btnInventario.Text = "📦 Inventario";
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnJaulas
            // 
            this.btnJaulas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnJaulas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJaulas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnJaulas.ForeColor = System.Drawing.Color.White;
            this.btnJaulas.Location = new System.Drawing.Point(405, 220);
            this.btnJaulas.Name = "btnJaulas";
            this.btnJaulas.Size = new System.Drawing.Size(350, 70);
            this.btnJaulas.TabIndex = 7;
            this.btnJaulas.Text = "🏠 Jaulas";
            this.btnJaulas.UseVisualStyleBackColor = false;
            this.btnJaulas.Click += new System.EventHandler(this.btnJaulas_Click);
            // 
            // btnLocaciones
            // 
            this.btnLocaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnLocaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocaciones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLocaciones.ForeColor = System.Drawing.Color.White;
            this.btnLocaciones.Location = new System.Drawing.Point(780, 220);
            this.btnLocaciones.Name = "btnLocaciones";
            this.btnLocaciones.Size = new System.Drawing.Size(350, 70);
            this.btnLocaciones.TabIndex = 8;
            this.btnLocaciones.Text = "📍 Locaciones";
            this.btnLocaciones.UseVisualStyleBackColor = false;
            this.btnLocaciones.Click += new System.EventHandler(this.btnLocaciones_Click);
            // 
            // Acceso_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.gbModulos);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Acceso_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestión - Zoológico";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.gbModulos.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbModulos;
        private System.Windows.Forms.Button btnAlimentacion;
        private System.Windows.Forms.Button btnAnimales;
        private System.Windows.Forms.Button btn_ControlLimpieza;
        private System.Windows.Forms.Button btnControlTiempo;
        private System.Windows.Forms.Button btnControlClinico;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnJaulas;
        private System.Windows.Forms.Button btnLocaciones;
    }
}