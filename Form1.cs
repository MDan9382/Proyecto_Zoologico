using Proyecto_Zoologico.Datos.DAO;
using Proyecto_Zoologico.Datos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Zoologico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            
            /*Control_Clinico controlClinico = new Control_Clinico(DateTime.Now, "Tratamiento de prueba", 1, 8);
            controlClinico.ControlClinico_Descripcion = "Descripción de prueba";
            ControlClinico_DAO controlClinicoDAO = new ControlClinico_DAO();
            controlClinicoDAO.AgregarControlClinico(controlClinico);*/

        }

        private void buttonObtener_Click(object sender, EventArgs e)
        {
            Plantilla_DAO plantillaDAO = new Plantilla_DAO();
            List<Datos.Modelos.Plantilla> plantillas = plantillaDAO.ObtenerPlantillas();
            foreach (var plantilla in plantillas)
            {
                string bonos = plantilla.Plantilla_Bonos.HasValue ? plantilla.Plantilla_Bonos.Value.ToString() : "nada";
                string deduccion = plantilla.Plantilla_Deduccion.HasValue ? plantilla.Plantilla_Deduccion.Value.ToString() : "nada";
                MessageBox.Show("Plantilla ID: " + plantilla.Plantilla_Id + ", Sueldo: " + plantilla.Plantilla_Sueldo + ", Bonos: " + bonos + ", Deduccion: " + deduccion);
            }
        }

        private void buttonBuscarParametros_Click(object sender, EventArgs e)
        {
            Plantilla_DAO plantillaDAO = new Plantilla_DAO();
            string parametro = textBoxParametro.Text;
            string valor = textBoxValor.Text;
            List<Datos.Modelos.Plantilla> plantillas = plantillaDAO.BuscarParametrosPlantilla(parametro, valor);
            foreach (var plantilla in plantillas)
            {
                string bonos = plantilla.Plantilla_Bonos.HasValue ? plantilla.Plantilla_Bonos.Value.ToString() : "nada";
                string deduccion = plantilla.Plantilla_Deduccion.HasValue ? plantilla.Plantilla_Deduccion.Value.ToString() : "nada";
                MessageBox.Show("Plantilla ID: " + plantilla.Plantilla_Id + ", Sueldo: " + plantilla.Plantilla_Sueldo + ", Bonos: " + bonos + ", Deduccion: " + deduccion);
            }
            /*Entradas_DAO entradasDAO = new Entradas_DAO();
            string parametro = textBoxParametro.Text;
            string valor = textBoxValor.Text;
            List<Datos.Modelos.Entradas> entradas = entradasDAO.buscarParametrosEntradas(parametro, valor);
            foreach (var entrada in entradas)
            {
                Console.WriteLine("Entrada ID: " + entrada.Entrada_Id + ", Tipo: " + entrada.Entrada_Tipo + ", Fecha: " + entrada.Entrada_Fecha);
                MessageBox.Show("Entrada ID: " + entrada.Entrada_Id + ", Tipo: " + entrada.Entrada_Tipo + ", Fecha: " + entrada.Entrada_Fecha);
            }
            */
        }
    }
}
