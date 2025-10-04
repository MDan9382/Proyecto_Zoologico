using MySql.Data.MySqlClient;
using Proyecto_Zoologico.Datos.DAO;
using Proyecto_Zoologico.Datos.Modelos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto_Zoologico.Formularios
{
    public partial class Animales_Form : Form
    {
        private Animales_DAO animalesDAO = new Animales_DAO();
        private int animalSeleccionadoId = 0;

        public Animales_Form()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CargarAnimales();
            CargarComboBoxDieta();
            CargarComboBoxBusqueda();
        }

        private void ConfigurarDataGridView()
        {
            dgvAnimales.AutoGenerateColumns = false;
            dgvAnimales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnimales.MultiSelect = false;
            dgvAnimales.AllowUserToAddRows = false;

            dgvAnimales.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Animal_Id",
                HeaderText = "ID",
                Name = "Animal_Id",
                Width = 50
            });

            dgvAnimales.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Animal_Especie",
                HeaderText = "Especie",
                Name = "Animal_Especie",
                Width = 150
            });

            dgvAnimales.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Animal_Tamaño",
                HeaderText = "Tamaño (m)",
                Name = "Animal_Tamaño",
                Width = 100
            });

            dgvAnimales.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Animal_Peso",
                HeaderText = "Peso (kg)",
                Name = "Animal_Peso",
                Width = 100
            });

            dgvAnimales.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Animal_Dieta",
                HeaderText = "Dieta",
                Name = "Animal_Dieta",
                Width = 120
            });           
        }

        private void CargarComboBoxDieta()
        {
            cmbDieta.Items.Clear();
            cmbDieta.Items.Add("Carnívoro");
            cmbDieta.Items.Add("Herbívoro");
            cmbDieta.Items.Add("Omnívoro");
            cmbDieta.Items.Add("Insectívoro");
            cmbDieta.Items.Add("Piscívoro");

        }

        private void CargarComboBoxBusqueda()
        {
            cmbBuscarPor.Items.Clear();
            cmbBuscarPor.Items.Add("Animal_Id");
            cmbBuscarPor.Items.Add("Animal_Especie");
            cmbBuscarPor.Items.Add("Animal_Dieta");
            cmbBuscarPor.Items.Add("Alimentacion_Id");
            cmbBuscarPor.SelectedIndex = 0;
        }

        private void CargarAnimales()
        {
            try
            {
                List<Animales> animales = animalesDAO.ObtenerAnimales();
                dgvAnimales.DataSource = null;
                dgvAnimales.DataSource = animales;
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los animales: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    string especie = txtEspecie.Text.Trim();
                    float tamaño = float.Parse(txtTamaño.Text);
                    float peso = float.Parse(txtPeso.Text);
                    string dieta = cmbDieta.SelectedItem.ToString();

                    Animales nuevoAnimal = new Animales(especie, tamaño, peso, dieta);
                    animalesDAO.AgregarAnimal(nuevoAnimal);

                    MessageBox.Show("Animal agregado exitosamente",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarAnimales();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el animal: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (animalSeleccionadoId == 0)
                {
                    MessageBox.Show("Por favor, seleccione un animal de la lista",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (ValidarCampos())
                {
                    string especie = txtEspecie.Text.Trim();
                    float tamaño = float.Parse(txtTamaño.Text);
                    float peso = float.Parse(txtPeso.Text);
                    string dieta = cmbDieta.SelectedItem.ToString();

                    Animales animal = new Animales(especie, tamaño, peso, dieta);
                    animal.Animal_Id = animalSeleccionadoId;

                    animalesDAO.ActualizarAnimal(animal);

                    MessageBox.Show("Animal actualizado exitosamente",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarAnimales();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el animal: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (animalSeleccionadoId == 0)
                {
                    MessageBox.Show("Por favor, seleccione un animal de la lista",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult resultado = MessageBox.Show(
                    "¿Está seguro de que desea eliminar este animal?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    animalesDAO.EliminarAnimal(animalSeleccionadoId);
                    MessageBox.Show("Animal eliminado exitosamente",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarAnimales();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el animal: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBuscar.Text))
                {
                    CargarAnimales();
                    return;
                }

                string parametro = cmbBuscarPor.SelectedItem.ToString();
                string valor = txtBuscar.Text;

                List<Animales> resultados = animalesDAO.BuscarParametrosAnimales(parametro, valor);
                dgvAnimales.DataSource = null;
                dgvAnimales.DataSource = resultados;

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
            CargarAnimales();
        }

        private void dgvAnimales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow fila = dgvAnimales.Rows[e.RowIndex];

                    animalSeleccionadoId = Convert.ToInt32(fila.Cells["Animal_Id"].Value);
                    txtEspecie.Text = fila.Cells["Animal_Especie"].Value.ToString();
                    txtTamaño.Text = fila.Cells["Animal_Tamaño"].Value.ToString();
                    txtPeso.Text = fila.Cells["Animal_Peso"].Value.ToString();
                    cmbDieta.SelectedItem = fila.Cells["Animal_Dieta"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar el animal: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtEspecie.Text))
            {
                MessageBox.Show("Por favor, ingrese la especie del animal",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEspecie.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTamaño.Text))
            {
                MessageBox.Show("Por favor, ingrese el tamaño del animal",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTamaño.Focus();
                return false;
            }

            if (!float.TryParse(txtTamaño.Text, out float tamaño) || tamaño <= 0)
            {
                MessageBox.Show("El tamaño debe ser un número válido mayor a 0",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTamaño.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPeso.Text))
            {
                MessageBox.Show("Por favor, ingrese el peso del animal",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPeso.Focus();
                return false;
            }

            if (!float.TryParse(txtPeso.Text, out float peso) || peso <= 0)
            {
                MessageBox.Show("El peso debe ser un número válido mayor a 0",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPeso.Focus();
                return false;
            }

            if (cmbDieta.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione el tipo de dieta",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbDieta.Focus();
                return false;
            }


            return true;
        }

        private void LimpiarCampos()
        {
            animalSeleccionadoId = 0;
            txtEspecie.Clear();
            txtTamaño.Clear();
            txtPeso.Clear();
            cmbDieta.SelectedIndex = -1;
            txtBuscar.Clear();
            dgvAnimales.ClearSelection();
        }
    }
}