using Proyecto_Zoologico.Datos.Modelos;
using Proyecto_Zoologico.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Zoologico.Forms
{
    public partial class Acceso_Form : Form
    {
        public Acceso_Form()
        {
            InitializeComponent();
        }

        private void btnAlimentacion_Click(object sender, EventArgs e)
        {
            var form = new Alimentacion_Form();
            form.ShowDialog();
        }

        private void btnAnimales_Click(object sender, EventArgs e)
        {
            var form = new Animales_Form();
            form.ShowDialog();
        }

        private void btn_ControlLimpieza_Click(object sender, EventArgs e)
        {
            var form = new Control_Limpieza_Form();
            form.ShowDialog();
        }

        private void btnControlTiempo_Click(object sender, EventArgs e)
        {
            var form = new Control_Tiempo_Form();
            form.ShowDialog();
        }

        private void btnControlClinico_Click(object sender, EventArgs e)
        {
            var form = new Control_Clinico_Form();
            form.ShowDialog();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            var form = new Empleados_Form();
            form.ShowDialog();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            var form = new Inventario_Form();
            form.ShowDialog();
        }

        private void btnJaulas_Click(object sender, EventArgs e)
        {
            var form = new Jaulas_Form();                
            form.ShowDialog();
        }

        private void btnLocaciones_Click(object sender, EventArgs e)
        {
            var form = new Locaciones_Form();
            form.ShowDialog();
        }
    }
}
