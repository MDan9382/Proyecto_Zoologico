using MySql.Data.MySqlClient;
using Proyecto_Zoologico.Datos.DAO;
using Proyecto_Zoologico.Datos.Modelos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto_Zoologico.Formularios
{
    public partial class Alimentacion_Form : Form
    {
        private Alimentacion_DAO alimentacionDAO = new Alimentacion_DAO();
        private Animales_DAO animalesDAO = new Animales_DAO();
        private int alimentacionSeleccionadaId = 0;

        public Alimentacion_Form()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CargarAlimentaciones();
            CargarAnimales();
        }

        private void ConfigurarDataGridView()
        {
            dgvAlimentaciones.AutoGenerateColumns = false;
            dgvAlimentaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlimentaciones.MultiSelect = false;
            dgvAlimentaciones.AllowUserToAddRows = false;

            dgvAlimentaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Alimentacion_Id",
                HeaderText = "ID",
                Name = "Alimentacion_Id",
                Width = 50
            });

            dgvAlimentaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Alimentacion_Hora",
                HeaderText = "Hora",
                Name = "Alimentacion_Hora",
                Width = 100
            });

            dgvAlimentaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Inventario_Id",
                HeaderText = "ID Inventario",
                Name = "Inventario_Id",
                Width = 100
            });
        }

        private void CargarAlimentaciones()
        {
            try
            {
                List<Alimentacion> alimentaciones = alimentacionDAO.ObtenerAlimentaciones();
                dgvAlimentaciones.DataSource = null;
                dgvAlimentaciones.DataSource = alimentaciones;
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las alimentaciones: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarAnimales()
        {
            List<string> list = animalesDAO.BuscarAnimales();
            foreach (string item in list)
            {
                cmbAnimal.Items.Add(item);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    TimeSpan hora = dtpHora.Value.TimeOfDay;
                    int inventarioId = Convert.ToInt32(txtInventarioId.Text);
                    string animal = cmbAnimal.SelectedItem.ToString();                    
                    int animalId = animalesDAO.ObtenerAnimalIdPorEspecie(animal);

                    Alimentacion nuevaAlimentacion = new Alimentacion(hora, inventarioId, animalId);
                    alimentacionDAO.AgregarAlimentacion(nuevaAlimentacion);

                    MessageBox.Show("Alimentación agregada exitosamente",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarAlimentaciones();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la alimentación: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (alimentacionSeleccionadaId == 0)
                {
                    MessageBox.Show("Por favor, seleccione una alimentación de la lista",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (ValidarCampos())
                {
                    TimeSpan hora = dtpHora.Value.TimeOfDay;
                    int inventarioId = Convert.ToInt32(txtInventarioId.Text);
                    string animal = cmbAnimal.SelectedItem?.ToString() ?? "";
                    int animalId = animalesDAO.ObtenerAnimalIdPorEspecie(animal);

                    Alimentacion alimentacion = new Alimentacion(hora, inventarioId, animalId);
                    alimentacion.Alimentacion_Id = alimentacionSeleccionadaId;

                    alimentacionDAO.ActualizarAlimentacion(alimentacion);

                    MessageBox.Show("Alimentación actualizada exitosamente",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarAlimentaciones();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la alimentación: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (alimentacionSeleccionadaId == 0)
                {
                    MessageBox.Show("Por favor, seleccione una alimentación de la lista",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult resultado = MessageBox.Show(
                    "¿Está seguro de que desea eliminar esta alimentación?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    alimentacionDAO.EliminarAlimentacion(alimentacionSeleccionadaId);
                    MessageBox.Show("Alimentación eliminada exitosamente",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarAlimentaciones();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la alimentación: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBuscar.Text))
                {
                    CargarAlimentaciones();
                    return;
                }

                string parametro = cmbBuscarPor.SelectedItem.ToString();
                string valor = txtBuscar.Text;

                List<Alimentacion> resultados = alimentacionDAO.BuscarParametrosAlimentacion(parametro, valor);
                dgvAlimentaciones.DataSource = null;
                dgvAlimentaciones.DataSource = resultados;

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
            CargarAlimentaciones();
        }

        private void dgvAlimentaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow fila = dgvAlimentaciones.Rows[e.RowIndex];

                    alimentacionSeleccionadaId = Convert.ToInt32(fila.Cells["Alimentacion_Id"].Value);

                    TimeSpan hora = (TimeSpan)fila.Cells["Alimentacion_Hora"].Value;
                    dtpHora.Value = DateTime.Today.Add(hora);

                    txtInventarioId.Text = fila.Cells["Inventario_Id"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar la alimentación: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtInventarioId.Text))
            {
                MessageBox.Show("Por favor, ingrese el ID del inventario",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInventarioId.Focus();
                return false;
            }

            if (!int.TryParse(txtInventarioId.Text, out int inventarioId) || inventarioId <= 0)
            {
                MessageBox.Show("El ID del inventario debe ser un número válido mayor a 0",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInventarioId.Focus();
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            alimentacionSeleccionadaId = 0;
            dtpHora.Value = DateTime.Now;
            txtInventarioId.Clear();
            txtBuscar.Clear();
            dgvAlimentaciones.ClearSelection();
        }
    }
}