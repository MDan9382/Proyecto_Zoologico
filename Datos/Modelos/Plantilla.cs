using System;

namespace Proyecto_Zoologico.Datos.Modelos
{
    internal class Plantilla
    {
        public int Plantilla_Id { get; set; }
        public float Plantilla_Sueldo { get; set; }
        public float? Plantilla_Bonos { get; set; } = null;
        public float? Plantilla_Deduccion { get; set; } = null;

        public Plantilla() { }

        public Plantilla(float plantilla_Sueldo)
        {

            Plantilla_Sueldo = plantilla_Sueldo;
        }
    }
}
