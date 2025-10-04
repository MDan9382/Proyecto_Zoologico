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
        private int controlSeleccionadoId = 0;

        public Control_Tiempo_Form()
        {
            InitializeComponent();
            controlTiempoDAO = new Control_TiempoDAO();
            empleadosDAO = new Empleados_DAO();
            ConfigurarDataGridView();
            CargarEmpleados();
            CargarComboBoxTipos();
            CargarComboBoxBusqueda();
            ActualizarTabla();
        }

        private void ConfigurarDataGridView()
        {
            dgvControlTiempo.AutoGenerateColumns = false;
            dgvControlTiempo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvControlTiempo.MultiSelect = false;
            dgvControlTiempo.AllowUserToAddRows = false;

            dgvControlTiempo.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ControlTiempo_Id",
                HeaderText = "ID",
                Name = "Id",
                Width = 50
            });

            dgvControlTiempo.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ControlTiempo_Inicio",
                HeaderText = "Fecha Inicio",
                Name = "FechaInicio",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            dgvControlTiempo.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ControlTiempo_Fin",
                HeaderText = "Fecha Fin",
                Name = "FechaFin",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            dgvControlTiempo.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ControlTiempo_Tipo",
                HeaderText = "Tipo de Ausencia",
                Name = "Tipo",
                Width = 150
            });

            dgvControlTiempo.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Empleado_Id",
                HeaderText = "ID Empleado",
                Name = "EmpleadoId",
                Width = 100
            });
        }

        private void CargarEmpleados()
        {
            try
            {
                List<string> empleados = empleadosDAO.BuscarEmpleados();
                cmbEmpleado.Items.Clear();
                foreach (string empleado in empleados)
                {
                    cmbEmpleado.Items.Add(empleado);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar empleados: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarComboBoxTipos()
        {
            cmbTipo.Items.Clear();
            cmbTipo.Items.Add("Vacaciones");
            cmbTipo.Items.Add("Enfermedad");
            cmbTipo.Items.Add("Permiso Personal");
            cmbTipo.Items.Add("Licencia Médica");
            cmbTipo.Items.Add("Incapacidad");
            cmbTipo.Items.Add("Permiso sin Goce");
            cmbTipo.Items.Add("Día Administrativo");
            cmbTipo.Items.Add("Capacitación");
            cmbTipo.Items.Add("Otro");
        }

        private void CargarComboBoxBusqueda()
        {
            cmbBuscarPor.Items.Clear();
            cmbBuscarPor.Items.Add("ControlTiempo_Id");
            cmbBuscarPor.Items.Add("ControlTiempo_Tipo");
            cmbBuscarPor.Items.Add("Empleado_Id");
            cmbBuscarPor.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    var control = new Control_Tiempo(
                        dtpInicio.Value,
                        dtpFin.Value,
                        cmbTipo.SelectedItem.ToString(),
                        empleadosDAO.ObtenerIdEmpleadoPorNombre(cmbEmpleado.SelectedItem.ToString())
                    );
                    controlTiempoDAO.AgregarControlTiempo(control);

                    MessageBox.Show("Control de tiempo registrado exitosamente",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    ActualizarTabla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar control de tiempo: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (controlSeleccionadoId == 0)
                {
                    MessageBox.Show("Por favor, seleccione un control de tiempo de la lista",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (ValidarCampos())
                {
                    var control = new Control_Tiempo(
                        dtpInicio.Value,
                        dtpFin.Value,
                        cmbTipo.SelectedItem.ToString(),
                        empleadosDAO.ObtenerIdEmpleadoPorNombre(cmbEmpleado.SelectedItem.ToString())
                    );
                    control.ControlTiempo_Id = controlSeleccionadoId;

                    controlTiempoDAO.ActualizarControlTiempo(control);

                    MessageBox.Show("Control de tiempo actualizado exitosamente",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    ActualizarTabla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (controlSeleccionadoId == 0)
                {
                    MessageBox.Show("Por favor, seleccione un control de tiempo de la lista",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult resultado = MessageBox.Show(
                    $"¿Está seguro de que desea eliminar el control de tiempo ID: {controlSeleccionadoId}?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    controlTiempoDAO.EliminarControlTiempo(controlSeleccionadoId);
                    MessageBox.Show("Control de tiempo eliminado exitosamente",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    ActualizarTabla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBuscar.Text))
                {
                    ActualizarTabla();
                    return;
                }

                string parametro = cmbBuscarPor.SelectedItem.ToString();
                string valor = txtBuscar.Text.Trim();

                var resultados = controlTiempoDAO.BuscarParametrosControlTiempo(parametro, valor);
                dgvControlTiempo.DataSource = null;
                dgvControlTiempo.DataSource = resultados;

                if (resultados.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados",
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
            ActualizarTabla();
        }

        private void btnCalcularDias_Click(object sender, EventArgs e)
        {
            TimeSpan diferencia = dtpFin.Value - dtpInicio.Value;
            int dias = diferencia.Days + 1; // +1 para incluir ambos días

            MessageBox.Show($"Días de ausencia: {dias} día(s)",
                "Cálculo de Días", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvControlTiempo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow fila = dgvControlTiempo.Rows[e.RowIndex];

                    controlSeleccionadoId = Convert.ToInt32(fila.Cells["Id"].Value);
                    dtpInicio.Value = Convert.ToDateTime(fila.Cells["FechaInicio"].Value);
                    dtpFin.Value = Convert.ToDateTime(fila.Cells["FechaFin"].Value);
                    cmbTipo.SelectedItem = fila.Cells["Tipo"].Value.ToString();
                    // Nota: Necesitarás ajustar esto según cómo tengas configurado el ComboBox de empleados

                    btnActualizar.Text = "✏️ Actualizar Control (ID: " + controlSeleccionadoId + ")";
                    gbDatos.Text = $"Datos del Control de Tiempo - Seleccionado: ID {controlSeleccionadoId}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarTabla()
        {
            try
            {
                var controles = controlTiempoDAO.ObtenerControlesTiempo();
                dgvControlTiempo.DataSource = null;
                dgvControlTiempo.DataSource = controles;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar tabla: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        private bool ValidarCampos()
        {
            if (cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione el tipo de ausencia",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTipo.Focus();
                return false;
            }

            if (cmbEmpleado.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un empleado",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbEmpleado.Focus();
                return false;
            }

            if (dtpFin.Value < dtpInicio.Value)
            {
                MessageBox.Show("La fecha de fin no puede ser anterior a la fecha de inicio",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFin.Focus();
                return false;
            }

            TimeSpan diferencia = dtpFin.Value - dtpInicio.Value;
            if (diferencia.Days > 365)
            {
                MessageBox.Show("El período de ausencia no puede exceder 365 días",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            controlSeleccionadoId = 0;
            cmbTipo.SelectedIndex = -1;
            dtpInicio.Value = DateTime.Now;
            dtpFin.Value = DateTime.Now;
            txtBuscar.Clear();
            dgvControlTiempo.ClearSelection();
            btnActualizar.Text = "✏️ Actualizar Control";
            gbDatos.Text = "Datos del Control de Tiempo/Ausencias";
            cmbTipo.Focus();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                ActualizarTabla();
            }
        }
    }
}