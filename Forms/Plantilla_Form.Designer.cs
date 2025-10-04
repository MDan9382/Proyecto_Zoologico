namespace Proyecto_Zoologico.Forms
{
    partial class Plantilla_Form
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label lblBonos;
        private System.Windows.Forms.TextBox txtBonos;
        private System.Windows.Forms.Label lblDeduccion;
        private System.Windows.Forms.TextBox txtDeduccion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;

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
            this.lblSueldo = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.lblBonos = new System.Windows.Forms.Label();
            this.txtBonos = new System.Windows.Forms.TextBox();
            this.lblDeduccion = new System.Windows.Forms.Label();
            this.txtDeduccion = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panelSuperior.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.panelSuperior.Controls.Add(this.lblTitulo);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(500, 70);
            this.panelSuperior.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(369, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestión de Plantilla Salarial";
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.lblSueldo);
            this.gbDatos.Controls.Add(this.txtSueldo);
            this.gbDatos.Controls.Add(this.lblBonos);
            this.gbDatos.Controls.Add(this.txtBonos);
            this.gbDatos.Controls.Add(this.lblDeduccion);
            this.gbDatos.Controls.Add(this.txtDeduccion);
            this.gbDatos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbDatos.Location = new System.Drawing.Point(20, 90);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(460, 200);
            this.gbDatos.TabIndex = 1;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Información Salarial";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSueldo.Location = new System.Drawing.Point(15, 35);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(108, 19);
            this.lblSueldo.TabIndex = 0;
            this.lblSueldo.Text = "Sueldo Base (Q):";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSueldo.Location = new System.Drawing.Point(15, 55);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(430, 27);
            this.txtSueldo.TabIndex = 1;
            // 
            // lblBonos
            // 
            this.lblBonos.AutoSize = true;
            this.lblBonos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBonos.Location = new System.Drawing.Point(15, 95);
            this.lblBonos.Name = "lblBonos";
            this.lblBonos.Size = new System.Drawing.Size(139, 19);
            this.lblBonos.TabIndex = 2;
            this.lblBonos.Text = "Bonos (Q) [Opcional]:";
            // 
            // txtBonos
            // 
            this.txtBonos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBonos.Location = new System.Drawing.Point(15, 115);
            this.txtBonos.Name = "txtBonos";
            this.txtBonos.Size = new System.Drawing.Size(430, 27);
            this.txtBonos.TabIndex = 3;
            // 
            // lblDeduccion
            // 
            this.lblDeduccion.AutoSize = true;
            this.lblDeduccion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDeduccion.Location = new System.Drawing.Point(15, 155);
            this.lblDeduccion.Name = "lblDeduccion";
            this.lblDeduccion.Size = new System.Drawing.Size(165, 19);
            this.lblDeduccion.TabIndex = 4;
            this.lblDeduccion.Text = "Deducción (Q) [Opcional]:";
            // 
            // txtDeduccion
            // 
            this.txtDeduccion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDeduccion.Location = new System.Drawing.Point(15, 175);
            this.txtDeduccion.Name = "txtDeduccion";
            this.txtDeduccion.Size = new System.Drawing.Size(430, 27);
            this.txtDeduccion.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(20, 310);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(220, 45);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar Plantilla";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(260, 310);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(220, 45);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // Plantilla_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(500, 380);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Plantilla_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestión de Plantilla - Zoológico";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}