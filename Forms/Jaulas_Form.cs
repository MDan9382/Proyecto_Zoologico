using MySql.Data.MySqlClient;
using Proyecto_Zoologico.Datos.DAO;
using Proyecto_Zoologico.Datos.Modelos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace Proyecto_Zoologico.Formularios
{
    public partial class Jaulas_Form : Form
    {
        private Jaulas_DAO jaulasDAO = new Jaulas_DAO();
        private int jaulaSeleccionadaId = 0;
        private Animales_DAO animalesDAO = new Animales_DAO();
        private Locaciones_DAO locaionesDAO = new Locaciones_DAO();

        public Jaulas_Form()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CargarJaulas();
            CargarComboBoxAmbiente();
            CargarComboBoxBusqueda();
            CargarAnimales();
            CargarLocaciones();
        }

        private void ConfigurarDataGridView()
        {
            dgvJaulas.AutoGenerateColumns = false;
            dgvJaulas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvJaulas.MultiSelect = false;
            dgvJaulas.AllowUserToAddRows = false;

            dgvJaulas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Jaula_Id",
                HeaderText = "ID",
                Name = "Jaula_Id",
                Width = 60
            });

            dgvJaulas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Jaula_Ambiente",
                HeaderText = "Ambiente",
                Name = "Jaula_Ambiente",
                Width = 180
            });

            dgvJaulas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Jaula_Area",
                HeaderText = "Área (m²)",
                Name = "Jaula_Area",
                Width = 120
            });

            dgvJaulas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Locacion_Id",
                HeaderText = "ID Locación",
                Name = "Locacion_Id",
                Width = 120
            });

            dgvJaulas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Animal_Id",
                HeaderText = "ID Animal",
                Name = "Animal_Id",
                Width = 120
            });
        }

        private void CargarComboBoxAmbiente()
        {
            cmbAmbiente.Items.Clear();
            cmbAmbiente.Items.Add("Tropical Húmedo");
            cmbAmbiente.Items.Add("Tropical Seco");
            cmbAmbiente.Items.Add("Desértico");
            cmbAmbiente.Items.Add("Templado");
            cmbAmbiente.Items.Add("Frío");
            cmbAmbiente.Items.Add("Polar");
            cmbAmbiente.Items.Add("Acuático Dulce");
            cmbAmbiente.Items.Add("Acuático Marino");
            cmbAmbiente.Items.Add("Montañoso");
            cmbAmbiente.Items.Add("Sabana");
            cmbAmbiente.Items.Add("Bosque");
            cmbAmbiente.Items.Add("Selva");
        }

        private void CargarComboBoxBusqueda()
        {
            cmbBuscarPor.Items.Clear();
            cmbBuscarPor.Items.Add("Jaula_Id");
            cmbBuscarPor.Items.Add("Jaula_Ambiente");
            cmbBuscarPor.Items.Add("Locacion_Id");
            cmbBuscarPor.Items.Add("Animal_Id");
            cmbBuscarPor.SelectedIndex = 0;
        }

        private void CargarJaulas()
        {
            try
            {
                List<Jaulas> jaulas = jaulasDAO.ObtenerJaulas();
                dgvJaulas.DataSource = null;
                dgvJaulas.DataSource = jaulas;
                LimpiarCampos();
                lblTotalRegistros.Text = $"Total de Jaulas: {jaulas.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las jaulas: " + ex.Message,
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

        private void CargarLocaciones()
        {
            List<string> list = locaionesDAO.BuscarJaulas();
            foreach (string item in list)
            {
                cmbLocacion.Items.Add(item);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    string ambiente = cmbAmbiente.SelectedItem.ToString();
                    float area = float.Parse(txtArea.Text);
                    string locacion = cmbLocacion.SelectedItem.ToString();
                    int locacionId = locaionesDAO.ObtenerLocacionIdPorNombre(locacion);
                    string animal = cmbAnimal.SelectedItem.ToString();
                    int animalId = animalesDAO.ObtenerAnimalIdPorEspecie(animal);

                    Jaulas nuevaJaula = new Jaulas(ambiente, area, locacionId, animalId);
                    jaulasDAO.AgregarJaula(nuevaJaula);

                    MessageBox.Show("Jaula agregada exitosamente",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarJaulas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la jaula: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (jaulaSeleccionadaId == 0)
                {
                    MessageBox.Show("Por favor, seleccione una jaula de la lista",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (ValidarCampos())
                {
                    string ambiente = cmbAmbiente.SelectedItem.ToString();
                    float area = float.Parse(txtArea.Text);
                    string locacion = cmbLocacion.SelectedItem.ToString();
                    int locacionId = locaionesDAO.ObtenerLocacionIdPorNombre(locacion);
                    string animal = cmbAnimal.SelectedItem.ToString();
                    int animalId = animalesDAO.ObtenerAnimalIdPorEspecie(animal);

                    Jaulas jaula = new Jaulas(ambiente, area, locacionId, animalId);
                    jaula.Jaula_Id = jaulaSeleccionadaId;

                    jaulasDAO.ActualizarJaula(jaula);

                    MessageBox.Show("Jaula actualizada exitosamente",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarJaulas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la jaula: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (jaulaSeleccionadaId == 0)
                {
                    MessageBox.Show("Por favor, seleccione una jaula de la lista",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult resultado = MessageBox.Show(
                    $"¿Está seguro de que desea eliminar la jaula ID: {jaulaSeleccionadaId}?\n\n" +
                    "Esta acción eliminará también la asignación del animal a esta jaula.",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    jaulasDAO.EliminarJaula(jaulaSeleccionadaId);
                    MessageBox.Show("Jaula eliminada exitosamente",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarJaulas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la jaula: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBuscar.Text))
                {
                    CargarJaulas();
                    return;
                }

                string parametro = cmbBuscarPor.SelectedItem.ToString();
                string valor = txtBuscar.Text.Trim();

                List<Jaulas> resultados = jaulasDAO.BuscarParametrosJaulas(parametro, valor);
                dgvJaulas.DataSource = null;
                dgvJaulas.DataSource = resultados;
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
            CargarJaulas();
        }

        private void dgvJaulas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow fila = dgvJaulas.Rows[e.RowIndex];

                    jaulaSeleccionadaId = Convert.ToInt32(fila.Cells["Jaula_Id"].Value);
                    cmbAmbiente.SelectedItem = fila.Cells["Jaula_Ambiente"].Value.ToString();
                    txtArea.Text = fila.Cells["Jaula_Area"].Value.ToString();                  

                    btnActualizar.Text = "✏️ Actualizar Jaula (ID: " + jaulaSeleccionadaId + ")";
                    gbDatos.Text = $"Datos de la Jaula - Seleccionada: ID {jaulaSeleccionadaId}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar la jaula: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            if (cmbAmbiente.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione el tipo de ambiente",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbAmbiente.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtArea.Text))
            {
                MessageBox.Show("Por favor, ingrese el área de la jaula",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtArea.Focus();
                return false;
            }

            if (!float.TryParse(txtArea.Text, out float area) || area <= 0)
            {
                MessageBox.Show("El área debe ser un número válido mayor a 0",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtArea.Focus();
                return false;
            }

            if (area > 10000)
            {
                MessageBox.Show("El área parece demasiado grande. Verifique el valor (máximo 10,000 m²)",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtArea.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbLocacion.Text))
            {
                MessageBox.Show("Por favor, ingrese la locación",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbLocacion.Focus();
                return false;
            }            

            if (string.IsNullOrWhiteSpace(cmbAnimal.Text))
            {
                MessageBox.Show("Por favor, ingrese el animal",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbAnimal.Focus();
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            jaulaSeleccionadaId = 0;
            cmbAmbiente.SelectedIndex = -1;
            txtArea.Clear();
            txtBuscar.Clear();
            dgvJaulas.ClearSelection();
            btnActualizar.Text = "✏️ Actualizar Jaula";
            gbDatos.Text = "Datos de la Jaula";
            cmbAmbiente.Focus();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                CargarJaulas();
            }
        }

        private void txtArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números, punto decimal y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtLocacionId_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAnimalId_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}