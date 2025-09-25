namespace Proyecto_Zoologico.Forms
{
    partial class Plantilla_Form
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label lblBonos;
        private System.Windows.Forms.Label lblDeduccion;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.TextBox txtBonos;
        private System.Windows.Forms.TextBox txtDeduccion;
        private System.Windows.Forms.Button btnGuardar;

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
            this.lblSueldo = new System.Windows.Forms.Label();
            this.lblBonos = new System.Windows.Forms.Label();
            this.lblDeduccion = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.txtBonos = new System.Windows.Forms.TextBox();
            this.txtDeduccion = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSueldo
            // 
            this.lblSueldo.Location = new System.Drawing.Point(20, 20);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(100, 23);
            this.lblSueldo.TabIndex = 0;
            this.lblSueldo.Text = "Sueldo:";
            // 
            // lblBonos
            // 
            this.lblBonos.Location = new System.Drawing.Point(20, 60);
            this.lblBonos.Name = "lblBonos";
            this.lblBonos.Size = new System.Drawing.Size(100, 23);
            this.lblBonos.TabIndex = 2;
            this.lblBonos.Text = "Bonos:";
            // 
            // lblDeduccion
            // 
            this.lblDeduccion.Location = new System.Drawing.Point(20, 100);
            this.lblDeduccion.Name = "lblDeduccion";
            this.lblDeduccion.Size = new System.Drawing.Size(100, 23);
            this.lblDeduccion.TabIndex = 4;
            this.lblDeduccion.Text = "Deducción:";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(130, 20);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(200, 20);
            this.txtSueldo.TabIndex = 1;
            // 
            // txtBonos
            // 
            this.txtBonos.Location = new System.Drawing.Point(130, 60);
            this.txtBonos.Name = "txtBonos";
            this.txtBonos.Size = new System.Drawing.Size(200, 20);
            this.txtBonos.TabIndex = 3;
            // 
            // txtDeduccion
            // 
            this.txtDeduccion.Location = new System.Drawing.Point(130, 100);
            this.txtDeduccion.Name = "txtDeduccion";
            this.txtDeduccion.Size = new System.Drawing.Size(200, 20);
            this.txtDeduccion.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(130, 140);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(200, 30);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Plantilla_Form
            // 
            this.ClientSize = new System.Drawing.Size(370, 200);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.lblBonos);
            this.Controls.Add(this.txtBonos);
            this.Controls.Add(this.lblDeduccion);
            this.Controls.Add(this.txtDeduccion);
            this.Controls.Add(this.btnGuardar);
            this.Name = "Plantilla_Form";
            this.Text = "Gestión de Plantilla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}