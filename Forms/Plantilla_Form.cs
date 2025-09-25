using System;
using System.Windows.Forms;
using Proyecto_Zoologico.Datos.Modelos;

namespace Proyecto_Zoologico.Forms
{
    public partial class Plantilla_Form : Form
    {
        private Empleados _empleado;

        public Plantilla_Form(Empleados empleado)
        {
            InitializeComponent();
            _empleado = empleado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                float sueldo = float.Parse(txtSueldo.Text);
                float? bonos = string.IsNullOrWhiteSpace(txtBonos.Text) ? (float?)null : float.Parse(txtBonos.Text);
                float? deduccion = string.IsNullOrWhiteSpace(txtDeduccion.Text) ? (float?)null : float.Parse(txtDeduccion.Text);

                Plantilla plantilla = new Plantilla(sueldo)
                {
                    Plantilla_Bonos = bonos,
                    Plantilla_Deduccion = deduccion
                };

                Datos.DAO.Plantilla_DAO plantillaDAO = new Datos.DAO.Plantilla_DAO();
                _empleado.Plantilla_Id = plantillaDAO.AgregarPlantilla(plantilla);

                //MessageBox.Show("Plantilla Guardada Exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtSueldo.Clear();
            txtBonos.Clear();
            txtDeduccion.Clear();
        }
    }
}
