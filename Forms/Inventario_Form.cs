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
        

        public Inventario_Form()
        {
            InitializeComponent();
            inventarioDAO = new Inventario_DAO();
            CargarInventarios();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Inventario inventario = new Inventario(
                    txtNombre.Text,
                    txtTipo.Text,
                    Convert.ToInt32(txtCantidad.Text)
                );
                
                inventarioDAO.AgregarInventario(inventario);                
                LimpiarCampos();
                CargarInventarios();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {            
        if (!int.TryParse(textIdEliminar.Text, out _))
        {
                MessageBox.Show("La cantidad debe ser un número válido");                   
        }
        else if (MessageBox.Show("¿Está seguro de eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    inventarioDAO.EliminarInventario(Convert.ToInt16(textIdEliminar.Text));
                    LimpiarCampos();
                    CargarInventarios();
                }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvInventario.DataSource = inventarioDAO.BuscarParametrosInventario("Inventario_Nombre", textBoxBuscar.Text);
            
        }

        private void CargarInventarios()
        {
            dgvInventario.DataSource = null;
            dgvInventario.DataSource = inventarioDAO.ObtenerInventarios();
        }

        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textIdEliminar.Text = dgvInventario.Rows[e.RowIndex].Cells["Inventario_Id"].Value.ToString();                
                textBoxCantidadEditar.Text = dgvInventario.Rows[e.RowIndex].Cells["Inventario_Cantidad"].Value.ToString();
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El nombre es requerido");
                return false;
            }
            if (string.IsNullOrEmpty(txtTipo.Text))
            {
                MessageBox.Show("El tipo es requerido");
                return false;
            }
            if (!int.TryParse(txtCantidad.Text, out _))
            {
                MessageBox.Show("La cantidad debe ser un número válido");
                return false;
            }
            return true;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtTipo.Clear();
            txtCantidad.Clear();
            
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            Inventario inventario = new Inventario();
            int id = Convert.ToInt32(textIdEliminar.Text), cantidad = Convert.ToInt32(textBoxCantidadEditar.Text);

            inventario.Inventario_Cantidad = cantidad;            
            inventario.Inventario_Id = id;
            inventarioDAO.ActualizarInventario(inventario);
            CargarInventarios();
        }
    }
}