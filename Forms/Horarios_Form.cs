using Proyecto_Zoologico.Datos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Zoologico.Forms
{
    public partial class Horarios_Form : Form
    {

        private Empleados _empleado;
        public Horarios_Form(Empleados empleado)
        {
            InitializeComponent();
            _empleado = empleado;
        }

        private void Horarios_Load(object sender, EventArgs e)
        {

        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            string dias = string.Join(", ", DiascheckedListBox.CheckedItems.Cast<object>().Select(item => item.ToString()));
            TimeSpan duracion = new TimeSpan((int)Hora_numericUpDown.Value, (int)Minuto_numericUpDown.Value, 0);

            Datos.Modelos.Horarios horario = new Datos.Modelos.Horarios(duracion, dias);
            Datos.DAO.Horarios_DAO horarioDAO = new Datos.DAO.Horarios_DAO();
            _empleado.Horario_Id = horarioDAO.AgregarHorario(horario);
            //MessageBox.Show("Horario insertado correctamente.");
            Close();
        }

        private void labelDuracion_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
