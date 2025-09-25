using System.Windows.Forms;

namespace Proyecto_Zoologico.Forms
{
    partial class Entradas_Form
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
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
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.comboBoxTipoEntrada = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTipo
            // 
            this.lblTipo.Location = new System.Drawing.Point(20, 20);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(100, 23);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo de Entrada:";
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(20, 60);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(100, 23);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(130, 60);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(130, 112);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(200, 30);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Comprar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // comboBoxTipoEntrada
            // 
            this.comboBoxTipoEntrada.AutoCompleteCustomSource.AddRange(new string[] {
            "Adultos",
            "Estudiantes",
            "Niños"});
            this.comboBoxTipoEntrada.FormattingEnabled = true;
            this.comboBoxTipoEntrada.Items.AddRange(new object[] {
            "Adultos",
            "Estudiantes",
            "Niños"});
            this.comboBoxTipoEntrada.Location = new System.Drawing.Point(130, 20);
            this.comboBoxTipoEntrada.Name = "comboBoxTipoEntrada";
            this.comboBoxTipoEntrada.Size = new System.Drawing.Size(200, 21);
            this.comboBoxTipoEntrada.TabIndex = 6;
            // 
            // Entradas_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.comboBoxTipoEntrada);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnGuardar);
            this.Name = "Entradas_Form";
            this.Text = "Registro de Entradas";
            this.ResumeLayout(false);

        }

        private ComboBox comboBoxTipoEntrada;
    }
}