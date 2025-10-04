using MySql.Data.MySqlClient;
using Proyecto_Zoologico.Datos.DAO;
using Proyecto_Zoologico.Datos.Modelos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto_Zoologico.Formularios
{
    public partial class Control_Clinico_Form : Form
    {
        private ControlClinico_DAO controlClinicoDAO = new ControlClinico_DAO();
        private Animales_DAO animalDAO = new Animales_DAO();
        private Empleados_DAO empleadoDAO = new Empleados_DAO();

        private int controlSeleccionadoId = 0;

        public Control_Clinico_Form()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CargarControlesClinicos();
            CargarComboBoxBusqueda();
            InicializarFechaActual();
            CargarAnimales();
            CargarEmpleados();
        }

        private void ConfigurarDataGridView()
        {
            dgvControlClinicos.AutoGenerateColumns = false;
            dgvControlClinicos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvControlClinicos.MultiSelect = false;
            dgvControlClinicos.AllowUserToAddRows = false;

            dgvControlClinicos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ControlClinico_Id",
                HeaderText = "ID",
                Name = "ControlClinico_Id",
                Width = 50
            });

            dgvControlClinicos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ControlClinico_Fecha",
                HeaderText = "Fecha",
                Name = "ControlClinico_Fecha",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            dgvControlClinicos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ControlClinico_Tratamiento",
                HeaderText = "Tratamiento",
                Name = "ControlClinico_Tratamiento",
                Width = 200
            });

            dgvControlClinicos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ControlClinico_Descripcion",
                HeaderText = "Descripción",
                Name = "ControlClinico_Descripcion",
                Width = 250
            });

            dgvControlClinicos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Animal_Id",
                HeaderText = "ID Animal",
                Name = "Animal_Id",
                Width = 100
            });

            dgvControlClinicos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Empleado_Id",
                HeaderText = "ID Veterinario",
                Name = "Empleado_Id",
                Width = 120
            });
        }

        private void CargarComboBoxBusqueda()
        {
            cmbBuscarPor.Items.Clear();
            cmbBuscarPor.Items.Add("ControlClinico_Id");
            cmbBuscarPor.Items.Add("Animal_Id");
            cmbBuscarPor.Items.Add("Empleado_Id");
            cmbBuscarPor.SelectedIndex = 0;
        }

        private void CargarAnimales()
        { 
            List <string> animal = animalDAO.BuscarAnimales();
            foreach (string ani in animal)
            {
                cmbAnimal.Items.Add(ani);
            }
        }

        private void CargarEmpleados()
        {

            List<string> empleados = empleadoDAO.BuscarEmpleadosPorCargo("Veterinario");
            foreach (string emp in empleados)
            {
                cmbEmpleado.Items.Add(emp);
            }
        }

        private void InicializarFechaActual()
        {
            dtpFecha.Value = DateTime.Now;
            dtpFecha.Format = DateTimePickerFormat.Short;
        }

        private void CargarControlesClinicos()
        {
            try
            {
                List<Control_Clinico> controles = controlClinicoDAO.ObtenerControlesClinicos();
                dgvControlClinicos.DataSource = null;
                dgvControlClinicos.DataSource = controles;
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los controles clínicos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    DateTime fecha = dtpFecha.Value;
                    string tratamiento = txtTratamiento.Text.Trim();
                    string descripcion = txtDescripcion.Text.Trim();
                    string animalText = cmbAnimal.Text.Trim();
                    int animalId = animalDAO.ObtenerAnimalIdPorEspecie(animalText);
                    string empleadoText = cmbEmpleado.Text.Trim();
                    int empleadoId = empleadoDAO.ObtenerIdEmpleadoPorNombre(empleadoText);

                    Control_Clinico nuevoControl = new Control_Clinico(fecha, tratamiento, animalId, empleadoId);
                    nuevoControl.ControlClinico_Descripcion = descripcion;

                    controlClinicoDAO.AgregarControlClinico(nuevoControl);

                    MessageBox.Show("Control clínico registrado exitosamente",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarControlesClinicos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el control clínico: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (controlSeleccionadoId == 0)
                {
                    MessageBox.Show("Por favor, seleccione un control clínico de la lista",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (ValidarCampos())
                {
                    DateTime fecha = dtpFecha.Value;
                    string tratamiento = txtTratamiento.Text.Trim();
                    string descripcion = txtDescripcion.Text.Trim();
                    string animalText = cmbAnimal.Text.Trim();
                    int animalId = animalDAO.ObtenerAnimalIdPorEspecie(animalText);
                    string empleadoText = cmbEmpleado.Text.Trim();
                    int empleadoId = empleadoDAO.ObtenerIdEmpleadoPorNombre(empleadoText);

                    Control_Clinico control = new Control_Clinico(fecha, tratamiento, animalId, empleadoId);
                    control.ControlClinico_Id = controlSeleccionadoId;
                    control.ControlClinico_Descripcion = descripcion;

                    controlClinicoDAO.ActualizarControlClinico(control);

                    MessageBox.Show("Control clínico actualizado exitosamente",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarControlesClinicos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el control clínico: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (controlSeleccionadoId == 0)
                {
                    MessageBox.Show("Por favor, seleccione un control clínico de la lista",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult resultado = MessageBox.Show(
                    $"¿Está seguro de que desea eliminar el control clínico ID: {controlSeleccionadoId}?\n\n" +
                    "Se eliminará el historial médico de este registro.",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    controlClinicoDAO.EliminarControlClinico(controlSeleccionadoId);
                    MessageBox.Show("Control clínico eliminado exitosamente",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarControlesClinicos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el control clínico: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBuscar.Text))
                {
                    CargarControlesClinicos();
                    return;
                }

                string parametro = cmbBuscarPor.SelectedItem.ToString();
                string valor = txtBuscar.Text.Trim();

                List<Control_Clinico> resultados = controlClinicoDAO.BuscarControlesClinicosPorAnimal(parametro, valor);
                dgvControlClinicos.DataSource = null;
                dgvControlClinicos.DataSource = resultados;

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
            CargarControlesClinicos();
        }

        private void btnFechaHoy_Click(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Now;
            MessageBox.Show("Fecha establecida a hoy", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvControlClinicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow fila = dgvControlClinicos.Rows[e.RowIndex];

                    controlSeleccionadoId = Convert.ToInt32(fila.Cells["ControlClinico_Id"].Value);
                    dtpFecha.Value = Convert.ToDateTime(fila.Cells["ControlClinico_Fecha"].Value);
                    txtTratamiento.Text = fila.Cells["ControlClinico_Tratamiento"].Value.ToString();
                    txtDescripcion.Text = fila.Cells["ControlClinico_Descripcion"].Value.ToString();
                    cmbAnimal.Text = fila.Cells["Animal_Id"].Value.ToString();
                    cmbEmpleado.Text = fila.Cells["Empleado_Id"].Value.ToString();

                    btnActualizar.Text = "✏️ Actualizar Control (ID: " + controlSeleccionadoId + ")";
                    gbDatos.Text = $"Datos del Control Clínico - Seleccionado: ID {controlSeleccionadoId}";
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
            if (string.IsNullOrWhiteSpace(txtTratamiento.Text))
            {
                MessageBox.Show("Por favor, ingrese el tratamiento aplicado",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTratamiento.Focus();
                return false;
            }

            if (txtTratamiento.Text.Trim().Length < 5)
            {
                MessageBox.Show("El tratamiento debe tener al menos 5 caracteres",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTratamiento.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbAnimal.Text))
            {
                MessageBox.Show("Por favor, ingrese el ID del animal",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbAnimal.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbEmpleado.Text))
            {
                MessageBox.Show("Por favor, ingrese el ID del veterinario",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbEmpleado.Focus();
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            controlSeleccionadoId = 0;
            dtpFecha.Value = DateTime.Now;
            txtTratamiento.Clear();
            txtDescripcion.Clear();
            txtBuscar.Clear();
            dgvControlClinicos.ClearSelection();
            btnActualizar.Text = "✏️ Actualizar Control";
            gbDatos.Text = "Datos del Control Clínico";
            txtTratamiento.Focus();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                CargarControlesClinicos();
            }
        }

        private void txtAnimalId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEmpleadoId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}