using System;
using System.Windows.Forms;
using Proyecto_Zoologico.Datos.Modelos;
using Proyecto_Zoologico.Datos.DAO;

namespace Proyecto_Zoologico.Forms
{
    public partial class Entradas_Form : Form
    {
        public Entradas_Form()
        {
            InitializeComponent();            
            dtpFecha.Value = DateTime.Now;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(comboBoxTipoEntrada.Text))
                {
                    MessageBox.Show("El tipo de entrada es requerido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Entradas entrada = new Entradas(
                    comboBoxTipoEntrada.Text,
                    dtpFecha.Value
                );

                Entradas_DAO entradasDAO = new Entradas_DAO();
                entradasDAO.AgregarEntrada(entrada);

                MessageBox.Show("Entrada registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            comboBoxTipoEntrada.Clear();
            dtpFecha.Value = DateTime.Now;
        }
    }
}
