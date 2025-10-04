using MySql.Data.MySqlClient;
using Proyecto_Zoologico.Datos.DAO;
using Proyecto_Zoologico.Datos.Modelos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto_Zoologico.Formularios
{
    public partial class Locaciones_Form : Form
    {
        private Locaciones_DAO locacionesDAO = new Locaciones_DAO();
        private int locacionSeleccionadaId = 0;

        public Locaciones_Form()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CargarLocaciones();
            CargarComboBoxTipo();
            CargarComboBoxBusqueda();
        }

        private void ConfigurarDataGridView()
        {
            dgvLocaciones.AutoGenerateColumns = false;
            dgvLocaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLocaciones.MultiSelect = false;
            dgvLocaciones.AllowUserToAddRows = false;

            dgvLocaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Locacion_Id",
                HeaderText = "ID",
                Name = "Locacion_Id",
                Width = 80
            });

            dgvLocaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Locacion_Nombre",
                HeaderText = "Nombre de Locación",
                Name = "Locacion_Nombre",
                Width = 300
            });

            dgvLocaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Locacion_Tipo",
                HeaderText = "Tipo de Locación",
                Name = "Locacion_Tipo",
                Width = 200
            });
        }

        private void CargarComboBoxTipo()
        {
            cmbTipo.Items.Clear();
            cmbTipo.Items.Add("Jaula");
            cmbTipo.Items.Add("Zona Recreativa");
            cmbTipo.Items.Add("Área Administrativa");
            cmbTipo.Items.Add("Clínica");
            cmbTipo.Items.Add("Salon");
            cmbTipo.Items.Add("Baños");
            cmbTipo.Items.Add("Comedor");
            cmbTipo.Items.Add("Bodega");
        }

        private void CargarComboBoxBusqueda()
        {
            cmbBuscarPor.Items.Clear();
            cmbBuscarPor.Items.Add("Locacion_Id");
            cmbBuscarPor.Items.Add("Locacion_Nombre");
            cmbBuscarPor.Items.Add("Locacion_Tipo");
            cmbBuscarPor.SelectedIndex = 0;
        }

        private void CargarLocaciones()
        {
            try
            {
                List<Locaciones> locaciones = locacionesDAO.ObtenerLocaciones();
                dgvLocaciones.DataSource = null;
                dgvLocaciones.DataSource = locaciones;
                LimpiarCampos();
                lblTotalRegistros.Text = $"Total de Locaciones: {locaciones.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las locaciones: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    string nombre = txtNombre.Text.Trim();
                    string tipo = cmbTipo.SelectedItem.ToString();

                    Locaciones nuevaLocacion = new Locaciones(nombre, tipo);
                    locacionesDAO.AgregarLocacion(nuevaLocacion);

                    MessageBox.Show("Locación agregada exitosamente",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarLocaciones();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la locación: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (locacionSeleccionadaId == 0)
                {
                    MessageBox.Show("Por favor, seleccione una locación de la lista",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (ValidarCampos())
                {
                    string nombre = txtNombre.Text.Trim();
                    string tipo = cmbTipo.SelectedItem.ToString();

                    Locaciones locacion = new Locaciones(nombre, tipo);
                    locacion.Locacion_Id = locacionSeleccionadaId;

                    locacionesDAO.ActualizarLocacion(locacion);

                    MessageBox.Show("Locación actualizada exitosamente",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarLocaciones();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la locación: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (locacionSeleccionadaId == 0)
                {
                    MessageBox.Show("Por favor, seleccione una locación de la lista",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult resultado = MessageBox.Show(
                    "¿Está seguro de que desea eliminar esta locación?\n\nEsta acción no se puede deshacer.",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    locacionesDAO.EliminarLocacion(locacionSeleccionadaId);
                    MessageBox.Show("Locación eliminada exitosamente",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarLocaciones();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la locación: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBuscar.Text))
                {
                    CargarLocaciones();
                    return;
                }

                string parametro = cmbBuscarPor.SelectedItem.ToString();
                string valor = txtBuscar.Text.Trim();

                List<Locaciones> resultados = locacionesDAO.BuscarParamatrosLocaciones(parametro, valor);
                dgvLocaciones.DataSource = null;
                dgvLocaciones.DataSource = resultados;
                lblTotalRegistros.Text = $"Resultados encontrados: {resultados.Count}";

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
            CargarLocaciones();
        }

        private void dgvLocaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow fila = dgvLocaciones.Rows[e.RowIndex];

                    locacionSeleccionadaId = Convert.ToInt32(fila.Cells["Locacion_Id"].Value);
                    txtNombre.Text = fila.Cells["Locacion_Nombre"].Value.ToString();
                    cmbTipo.SelectedItem = fila.Cells["Locacion_Tipo"].Value.ToString();

                    
                    btnActualizar.Text = "✏️ Actualizar Locación (ID: " + locacionSeleccionadaId + ")";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar la locación: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre de la locación",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            if (txtNombre.Text.Trim().Length < 3)
            {
                MessageBox.Show("El nombre de la locación debe tener al menos 3 caracteres",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            if (cmbTipo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione el tipo de locación",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTipo.Focus();
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            locacionSeleccionadaId = 0;
            txtNombre.Clear();
            cmbTipo.SelectedIndex = -1;
            txtBuscar.Clear();
            dgvLocaciones.ClearSelection();
            btnActualizar.Text = "✏️ Actualizar Locación";
            txtNombre.Focus();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                CargarLocaciones();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                cmbTipo.Focus();
            }
        }
    }
}