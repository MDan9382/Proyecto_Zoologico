using Proyecto_Zoologico.Datos.Modelos;
using Proyecto_Zoologico.Datos.DAO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto_Zoologico.Forms
{
    public partial class Control_Tiempo_Form : Form
    {
        private Control_TiempoDAO controlTiempoDAO;
        private Empleados_DAO empleadosDAO;

        public Control_Tiempo_Form()
        {
            InitializeComponent();
            controlTiempoDAO = new Control_TiempoDAO();
            empleadosDAO = new Empleados_DAO();
            CargarEmpleados();
            ActualizarTabla();
        }

        private void CargarEmpleados()
        {
            cmbEmpleado.DataSource = empleadosDAO.ObtenerEmpleados();
            cmbEmpleado.DisplayMember = "Empleado_Nombre";
            cmbEmpleado.ValueMember = "Empleado_Id";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                var control = new Control_Tiempo(
                    dtpInicio.Value,
                    dtpFin.Value,
                    txtTipo.Text,
                    (int)cmbEmpleado.SelectedValue
                );
                controlTiempoDAO.AgregarControlTiempo(control);
                LimpiarCampos();
                ActualizarTabla();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvControlTiempo.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvControlTiempo.SelectedRows[0].Cells["Id"].Value);
                controlTiempoDAO.EliminarControlTiempo(id);
                ActualizarTabla();
            }
        }

        private void ActualizarTabla()
        {
            dgvControlTiempo.DataSource = controlTiempoDAO.ObtenerControlesTiempo();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtTipo.Text))
            {
                MessageBox.Show("Ingrese el tipo de control de tiempo.");
                return false;
            }
            if (cmbEmpleado.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un empleado.");
                return false;
            }
            if (dtpFin.Value < dtpInicio.Value)
            {
                MessageBox.Show("La fecha de fin no puede ser menor que la de inicio.");
                return false;
            }
            return true;
        }

        private void LimpiarCampos()
        {
            txtTipo.Clear();
            dtpInicio.Value = DateTime.Now;
            dtpFin.Value = DateTime.Now;
            cmbEmpleado.SelectedIndex = -1;
        }
    }
}