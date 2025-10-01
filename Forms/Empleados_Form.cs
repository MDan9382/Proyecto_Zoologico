using System;
using System.Windows.Forms;
using Proyecto_Zoologico.Datos.Modelos;

namespace Proyecto_Zoologico.Forms
{

    public partial class Empleados_Form : Form
    {
        public Empleados_Form()
        {
            InitializeComponent();
            empleado = new Empleados();
        }

        public Empleados empleado;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                empleado.Empleado_NIT = txtNIT.Text;
                empleado.Empleado_DPI = txtDPI.Text;
                empleado.Empleado_Nombre = txtNombre.Text;
                empleado.Empleado_Cargo = txtCargo.Text;
                

                Datos.DAO.Empleados_DAO empleadoDAO = new Datos.DAO.Empleados_DAO();
                empleadoDAO.AgregarEmpleado(empleado);

                MessageBox.Show("Empleado guardado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos(object sender, EventArgs e)
        {
            txtNIT.Clear();
            txtDPI.Clear();
            txtNombre.Clear();
            txtCargo.Clear();
            
        }

        private void buttonPlantilla_Click(object sender, EventArgs e)
        {
            var form = new Plantilla_Form(empleado);
            form.ShowDialog();
        }

        private void buttonHorario_Click(object sender, EventArgs e)
        {
            var form = new Horarios_Form(empleado);
            form.ShowDialog();
        }
    }
}
