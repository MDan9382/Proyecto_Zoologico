using Proyecto_Zoologico.Datos.DAO;
using Proyecto_Zoologico.Datos.Modelos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto_Zoologico.Forms
{
    public partial class Inventario_Form : Form
    {
        private Inventario_DAO inventarioDAO;
        private int inventarioSeleccionadoId = 0;

        public Inventario_Form()
        {
            InitializeComponent();
            inventarioDAO = new Inventario_DAO();
            ConfigurarDataGridView();
            ActualizarTabla();
        }

        private void ConfigurarDataGridView()
        {
            dgvInventario.AutoGenerateColumns = false;
            dgvInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventario.MultiSelect = false;
            dgvInventario.AllowUserToAddRows = false;

            dgvInventario.Columns.Clear();

            dgvInventario.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Inventario_Id",
                HeaderText = "ID",
                Name = "Id",
                Width = 50
            });

            dgvInventario.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Inventario_Nombre",
                HeaderText = "Nombre del Artículo",
                Name = "Nombre",
                Width = 250
            });

            dgvInventario.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Inventario_Tipo",
                HeaderText = "Tipo",
                Name = "Tipo",
                Width = 200
            });

            dgvInventario.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Inventario_Cantidad",
                HeaderText = "Cantidad",
                Name = "Cantidad",
                Width = 100
            });
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    Inventario inventario = new Inventario(
                        txtNombre.Text.Trim(),
                        txtTipo.Text.Trim(),
                        Convert.ToInt32(txtCantidad.Text.Trim())
                    );

                    inventarioDAO.AgregarInventario(inventario);

                    MessageBox.Show("Artículo agregado exitosamente",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarCampos();
                    ActualizarTabla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar artículo: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (inventarioSeleccionadoId == 0)
                {
                    MessageBox.Show("Por favor, seleccione un artículo de la lista",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBoxCantidadEditar.Text))
                {
                    MessageBox.Show("Por favor, ingrese la nueva cantidad",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxCantidadEditar.Focus();
                    return;
                }

                if (!int.TryParse(textBoxCantidadEditar.Text, out int cantidad) || cantidad < 0)
                {
                    MessageBox.Show("La cantidad debe ser un número válido mayor o igual a 0",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxCantidadEditar.Focus();
                    return;
                }

                Inventario inventario = new Inventario();
                inventario.Inventario_Id = inventarioSeleccionadoId;
                inventario.Inventario_Cantidad = cantidad;

                inventarioDAO.ActualizarInventario(inventario);

                MessageBox.Show("Cantidad actualizada exitosamente",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
                ActualizarTabla();
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
                if (inventarioSeleccionadoId == 0)
                {
                    MessageBox.Show("Por favor, seleccione un artículo de la lista",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult resultado = MessageBox.Show(
                    $"¿Está seguro de que desea eliminar el artículo ID: {inventarioSeleccionadoId}?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    inventarioDAO.EliminarInventario(inventarioSeleccionadoId);

                    MessageBox.Show("Artículo eliminado exitosamente",
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
                if (string.IsNullOrWhiteSpace(textBoxBuscar.Text))
                {
                    ActualizarTabla();
                    return;
                }

                var resultados = inventarioDAO.BuscarParametrosInventario(
                    "Inventario_Nombre",
                    textBoxBuscar.Text.Trim());

                dgvInventario.DataSource = null;
                dgvInventario.DataSource = resultados;

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

        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow fila = dgvInventario.Rows[e.RowIndex];

                    inventarioSeleccionadoId = Convert.ToInt32(fila.Cells["Id"].Value);
                    textIdEliminar.Text = inventarioSeleccionadoId.ToString();
                    textBoxCantidadEditar.Text = fila.Cells["Cantidad"].Value.ToString();

                    buttonEditar.Text = "✏️ Editar Cantidad (ID: " + inventarioSeleccionadoId + ")";
                    gbEdicion.Text = $"Edición - Seleccionado: ID {inventarioSeleccionadoId}";
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
                var inventarios = inventarioDAO.ObtenerInventarios();
                dgvInventario.DataSource = null;
                dgvInventario.DataSource = inventarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar tabla: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre del artículo",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTipo.Text))
            {
                MessageBox.Show("Por favor, ingrese el tipo de artículo",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTipo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Por favor, ingrese la cantidad",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidad.Focus();
                return false;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad))
            {
                MessageBox.Show("La cantidad debe ser un número válido",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidad.Focus();
                return false;
            }

            if (cantidad < 0)
            {
                MessageBox.Show("La cantidad no puede ser negativa",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidad.Focus();
                return false;
            }

            if (cantidad > 999999)
            {
                MessageBox.Show("La cantidad no puede exceder 999,999 unidades",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidad.Focus();
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            inventarioSeleccionadoId = 0;
            txtNombre.Clear();
            txtTipo.Clear();
            txtCantidad.Clear();
            textIdEliminar.Clear();
            textBoxCantidadEditar.Clear();
            textBoxBuscar.Clear();
            dgvInventario.ClearSelection();
            buttonEditar.Text = "✏️ Editar Cantidad";
            gbEdicion.Text = "Edición";
            txtNombre.Focus();
        }
    }
}