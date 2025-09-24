namespace Proyecto_Zoologico
{
    partial class Form1
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
            this.buttonInsertar = new System.Windows.Forms.Button();
            this.textBoxPlantillaSueldo = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonObtener = new System.Windows.Forms.Button();
            this.textBoxParametro = new System.Windows.Forms.TextBox();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.buttonBuscarParametros = new System.Windows.Forms.Button();
            this.textBoxBono = new System.Windows.Forms.TextBox();
            this.textBoxDeduccion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonInsertar
            // 
            this.buttonInsertar.Location = new System.Drawing.Point(336, 50);
            this.buttonInsertar.Name = "buttonInsertar";
            this.buttonInsertar.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertar.TabIndex = 0;
            this.buttonInsertar.Text = "Insertar";
            this.buttonInsertar.UseVisualStyleBackColor = true;
            this.buttonInsertar.Click += new System.EventHandler(this.buttonInsertar_Click);
            // 
            // textBoxPlantillaSueldo
            // 
            this.textBoxPlantillaSueldo.Location = new System.Drawing.Point(58, 50);
            this.textBoxPlantillaSueldo.Name = "textBoxPlantillaSueldo";
            this.textBoxPlantillaSueldo.Size = new System.Drawing.Size(144, 20);
            this.textBoxPlantillaSueldo.TabIndex = 1;
            this.textBoxPlantillaSueldo.Text = "sueldo";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(58, 270);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // buttonObtener
            // 
            this.buttonObtener.Location = new System.Drawing.Point(336, 94);
            this.buttonObtener.Name = "buttonObtener";
            this.buttonObtener.Size = new System.Drawing.Size(75, 23);
            this.buttonObtener.TabIndex = 3;
            this.buttonObtener.Text = "Obtener";
            this.buttonObtener.UseVisualStyleBackColor = true;
            this.buttonObtener.Click += new System.EventHandler(this.buttonObtener_Click);
            // 
            // textBoxParametro
            // 
            this.textBoxParametro.Location = new System.Drawing.Point(58, 189);
            this.textBoxParametro.Name = "textBoxParametro";
            this.textBoxParametro.Size = new System.Drawing.Size(120, 20);
            this.textBoxParametro.TabIndex = 4;
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(223, 189);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(100, 20);
            this.textBoxValor.TabIndex = 5;
            // 
            // buttonBuscarParametros
            // 
            this.buttonBuscarParametros.Location = new System.Drawing.Point(370, 180);
            this.buttonBuscarParametros.Name = "buttonBuscarParametros";
            this.buttonBuscarParametros.Size = new System.Drawing.Size(120, 36);
            this.buttonBuscarParametros.TabIndex = 6;
            this.buttonBuscarParametros.Text = "Buscar con parametros";
            this.buttonBuscarParametros.UseVisualStyleBackColor = true;
            this.buttonBuscarParametros.Click += new System.EventHandler(this.buttonBuscarParametros_Click);
            // 
            // textBoxBono
            // 
            this.textBoxBono.Location = new System.Drawing.Point(58, 76);
            this.textBoxBono.Name = "textBoxBono";
            this.textBoxBono.Size = new System.Drawing.Size(100, 20);
            this.textBoxBono.TabIndex = 7;
            this.textBoxBono.Text = "bono";
            // 
            // textBoxDeduccion
            // 
            this.textBoxDeduccion.Location = new System.Drawing.Point(58, 102);
            this.textBoxDeduccion.Name = "textBoxDeduccion";
            this.textBoxDeduccion.Size = new System.Drawing.Size(100, 20);
            this.textBoxDeduccion.TabIndex = 8;
            this.textBoxDeduccion.Text = "deduccion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxDeduccion);
            this.Controls.Add(this.textBoxBono);
            this.Controls.Add(this.buttonBuscarParametros);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.textBoxParametro);
            this.Controls.Add(this.buttonObtener);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxPlantillaSueldo);
            this.Controls.Add(this.buttonInsertar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInsertar;
        private System.Windows.Forms.TextBox textBoxPlantillaSueldo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonObtener;
        private System.Windows.Forms.TextBox textBoxParametro;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Button buttonBuscarParametros;
        private System.Windows.Forms.TextBox textBoxBono;
        private System.Windows.Forms.TextBox textBoxDeduccion;
    }
}

