namespace Proyecto_Zoologico.Forms
{
    partial class Horarios_Form
    {
        
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

  

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDias = new System.Windows.Forms.Label();
            this.labelDuracion = new System.Windows.Forms.Label();
            this.buttonInsertar = new System.Windows.Forms.Button();
            this.Hora_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Minuto_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DiascheckedListBox = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.Hora_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minuto_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDias
            // 
            this.labelDias.AutoSize = true;
            this.labelDias.Location = new System.Drawing.Point(32, 30);
            this.labelDias.Name = "labelDias";
            this.labelDias.Size = new System.Drawing.Size(85, 13);
            this.labelDias.TabIndex = 0;
            this.labelDias.Text = "Días del horario:";
            // 
            // labelDuracion
            // 
            this.labelDuracion.AutoSize = true;
            this.labelDuracion.Location = new System.Drawing.Point(32, 140);
            this.labelDuracion.Name = "labelDuracion";
            this.labelDuracion.Size = new System.Drawing.Size(93, 13);
            this.labelDuracion.TabIndex = 2;
            this.labelDuracion.Text = "Duración (hh:mm):";
            this.labelDuracion.Click += new System.EventHandler(this.labelDuracion_Click);
            // 
            // buttonInsertar
            // 
            this.buttonInsertar.Location = new System.Drawing.Point(132, 179);
            this.buttonInsertar.Name = "buttonInsertar";
            this.buttonInsertar.Size = new System.Drawing.Size(150, 23);
            this.buttonInsertar.TabIndex = 4;
            this.buttonInsertar.Text = "Insertar";
            this.buttonInsertar.UseVisualStyleBackColor = true;
            this.buttonInsertar.Click += new System.EventHandler(this.buttonInsertar_Click);
            // 
            // Hora_numericUpDown
            // 
            this.Hora_numericUpDown.Location = new System.Drawing.Point(132, 138);
            this.Hora_numericUpDown.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.Hora_numericUpDown.Name = "Hora_numericUpDown";
            this.Hora_numericUpDown.Size = new System.Drawing.Size(65, 20);
            this.Hora_numericUpDown.TabIndex = 5;
            // 
            // Minuto_numericUpDown
            // 
            this.Minuto_numericUpDown.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.Minuto_numericUpDown.Location = new System.Drawing.Point(217, 138);
            this.Minuto_numericUpDown.Name = "Minuto_numericUpDown";
            this.Minuto_numericUpDown.Size = new System.Drawing.Size(65, 20);
            this.Minuto_numericUpDown.TabIndex = 6;
            // 
            // DiascheckedListBox
            // 
            this.DiascheckedListBox.FormattingEnabled = true;
            this.DiascheckedListBox.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado",
            "Domingo"});
            this.DiascheckedListBox.Location = new System.Drawing.Point(132, 12);
            this.DiascheckedListBox.Name = "DiascheckedListBox";
            this.DiascheckedListBox.Size = new System.Drawing.Size(150, 109);
            this.DiascheckedListBox.TabIndex = 7;
            this.DiascheckedListBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Horarios_Form
            // 
            this.ClientSize = new System.Drawing.Size(338, 237);
            this.Controls.Add(this.DiascheckedListBox);
            this.Controls.Add(this.Minuto_numericUpDown);
            this.Controls.Add(this.Hora_numericUpDown);
            this.Controls.Add(this.labelDias);
            this.Controls.Add(this.labelDuracion);
            this.Controls.Add(this.buttonInsertar);
            this.Name = "Horarios_Form";
            this.Text = "Insertar Horario";
            this.Load += new System.EventHandler(this.Horarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Hora_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minuto_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        private System.Windows.Forms.Label labelDias;
        private System.Windows.Forms.Label labelDuracion;
        private System.Windows.Forms.Button buttonInsertar;
        private System.Windows.Forms.NumericUpDown Hora_numericUpDown;
        private System.Windows.Forms.NumericUpDown Minuto_numericUpDown;
        private System.Windows.Forms.CheckedListBox DiascheckedListBox;
    }
}