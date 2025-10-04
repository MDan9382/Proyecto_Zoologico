using MySql.Data.MySqlClient;
using Proyecto_Zoologico.Datos.DAO;
using Proyecto_Zoologico.Datos.Modelos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto_Zoologico.Formularios
{
    public partial class Control_Limpieza_Form : Form
    {
        private Control_LimpiezaDAO controlLimpiezaDAO = new Control_LimpiezaDAO();
        private Empleados_DAO empleadoDAO = new Empleados_DAO();
        private Locaciones_DAO locacionDAO = new Locaciones_DAO();
        private int controlSeleccionadoId = 0;

        public Control_Limpieza_Form()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CargarControlesLimpieza();
            CargarComboBoxBusqueda();
            InicializarFechaActual();
            CargarEmpleados();
            CargarLocaciones();
        }

        private void ConfigurarDataGridView()
        {
            dgvControlLimpieza.AutoGenerateColumns = false;
            dgvControlLimpieza.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvControlLimpieza.MultiSelect = false;
            dgvControlLimpieza.AllowUserToAddRows = false;

            dgvControlLimpieza.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ControlLimpieza_Id",
                HeaderText = "ID",
                Name = "ControlLimpieza_Id",
                Width = 60
            });

            dgvControlLimpieza.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ControlLimpieza_Hora",
                HeaderText = "Hora",
                Name = "ControlLimpieza_Hora",
                Width = 100
            });

            dgvControlLimpieza.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ControlLimpieza_Fecha",
                HeaderText = "Día del Mes",
                Name = "ControlLimpieza_Fecha",
                Width = 100
            });

            dgvControlLimpieza.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Empleado_Id",
                HeaderText = "ID Empleado",
                Name = "Empleado_Id",
                Width = 120
            });

            dgvControlLimpieza.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Locacion_Id",
                HeaderText = "ID Locación",
                Name = "Locacion_Id",
                Width = 120
            });
        }

        private void CargarComboBoxBusqueda()
        {
            cmbBuscarPor.Items.Clear();
            cmbBuscarPor.Items.Add("ControlLimpieza_Id");
            cmbBuscarPor.Items.Add("Empleado_Id");
            cmbBuscarPor.Items.Add("Locacion_Id");
            cmbBuscarPor.Items.Add("ControlLimpieza_Fecha");
            cmbBuscarPor.SelectedIndex = 0;
        }

        private void CargarEmpleados()
        { 
            List<string> empleados = empleadoDAO.BuscarEmpleadosPorCargo("Conserje");
            foreach (string empleado in empleados)
            {
                cmbEmpleado.Items.Add(empleado);
            }
        }

        private void CargarLocaciones()
        {
            List<string> locaciones = locacionDAO.BuscarLocaciones();
            foreach (string locacion in locaciones)
            {
                cmbLocacion.Items.Add(locacion);
            }
        }

        private void InicializarFechaActual()
        {
            dtpHora.Value = DateTime.Now;

        }

        private void CargarControlesLimpieza()
        {
            try
            {
                List<Control_Limpieza> controles = controlLimpiezaDAO.ObtenerControlesLimpieza();
                dgvControlLimpieza.DataSource = null;
                dgvControlLimpieza.DataSource = controles;
                LimpiarCampos();
            }
            catch (Exception ex)
            {

            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    TimeSpan hora = dtpHora.Value.TimeOfDay;
                    string empleado = cmbEmpleado.Text;
                    int empleadoId = empleadoDAO.ObtenerIdEmpleadoPorNombre(empleado);
                    string locacion = cmbLocacion.Text;
                    int locacionId = locacionDAO.ObtenerLocacionIdPorNombre(locacion);
                    DateTime fecha = dateTimePicker1.Value;

                    Control_Limpieza nuevoControl = new Control_Limpieza(hora, empleadoId, locacionId, fecha);
                    controlLimpiezaDAO.AgregarControlLimpieza(nuevoControl);

                    MessageBox.Show("Control de limpieza registrado exitosamente",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarControlesLimpieza();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el control de limpieza: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (controlSeleccionadoId == 0)
                {
                    MessageBox.Show("Por favor, seleccione un control de limpieza de la lista",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (ValidarCampos())
                {
                    TimeSpan hora = dtpHora.Value.TimeOfDay;
                    string empleado = cmbEmpleado.Text;
                    int empleadoId = empleadoDAO.ObtenerIdEmpleadoPorNombre(empleado);
                    string locacion = cmbLocacion.Text;
                    int locacionId = locacionDAO.ObtenerLocacionIdPorNombre(locacion);
                    DateTime fecha = dateTimePicker1.Value;

                    Control_Limpieza control = new Control_Limpieza(hora, empleadoId, locacionId, fecha);
                    control.ControlLimpieza_Id = controlSeleccionadoId;

                    controlLimpiezaDAO.ActualizarControlLimpieza(control);

                    MessageBox.Show("Control de limpieza actualizado exitosamente",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarControlesLimpieza();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el control de limpieza: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (controlSeleccionadoId == 0)
                {
                    MessageBox.Show("Por favor, seleccione un control de limpieza de la lista",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult resultado = MessageBox.Show(
                    $"¿Está seguro de que desea eliminar el control de limpieza ID: {controlSeleccionadoId}?\n\n" +
                    "Esta acción no se puede deshacer.",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    controlLimpiezaDAO.EliminarControlLimpieza(controlSeleccionadoId);
                    MessageBox.Show("Control de limpieza eliminado exitosamente",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarControlesLimpieza();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el control de limpieza: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBuscar.Text))
                {
                    CargarControlesLimpieza();
                    return;
                }

                string parametro = cmbBuscarPor.SelectedItem.ToString();
                string valor = txtBuscar.Text.Trim();

                List<Control_Limpieza> resultados = controlLimpiezaDAO.BuscarParametrosControlLimpieza(parametro, valor);
                dgvControlLimpieza.DataSource = null;
                dgvControlLimpieza.DataSource = resultados;

                if (resultados.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados para la búsqueda",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarControlesLimpieza();
        }

        private void btnRegistrarHoraActual_Click(object sender, EventArgs e)
        {
            dtpHora.Value = DateTime.Now;
            MessageBox.Show("Hora actual registrada", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvControlLimpieza_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow fila = dgvControlLimpieza.Rows[e.RowIndex];

                    controlSeleccionadoId = Convert.ToInt32(fila.Cells["ControlLimpieza_Id"].Value);

                    TimeSpan hora = (TimeSpan)fila.Cells["ControlLimpieza_Hora"].Value;
                    dtpHora.Value = DateTime.Today.Add(hora);

                    dateTimePicker1.Text = fila.Cells["ControlLimpieza_Fecha"].Value.ToString();
                    cmbEmpleado.Text = fila.Cells["Empleado_Id"].Value.ToString();
                    cmbLocacion.Text = fila.Cells["Locacion_Id"].Value.ToString();

                    btnActualizar.Text = "✏️ Actualizar Control (ID: " + controlSeleccionadoId + ")";
                    gbDatos.Text = $"Datos del Control de Limpieza - Seleccionado: ID {controlSeleccionadoId}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar el control: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(cmbEmpleado.Text))
            {
                MessageBox.Show("Por favor, ingrese el ID del empleado",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbEmpleado.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbLocacion.Text))
            {
                MessageBox.Show("Por favor, ingrese el ID de la locación",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbLocacion.Focus();
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            controlSeleccionadoId = 0;
            dtpHora.Value = DateTime.Now;
            dateTimePicker1.Text = DateTime.Now.Day.ToString();
            txtBuscar.Clear();
            dgvControlLimpieza.ClearSelection();
            btnActualizar.Text = "✏️ Actualizar Control";
            gbDatos.Text = "Datos del Control de Limpieza";
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                CargarControlesLimpieza();
            }
        }

        private void txtEmpleadoId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLocacionId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}