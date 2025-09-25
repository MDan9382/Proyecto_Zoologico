using System;

namespace Proyecto_Zoologico.Datos.Modelos
{
    public class Empleados
    {
        public int Empleado_Id { get; set; }
        public string Empleado_NIT { get; set; }
        public string Empleado_DPI { get; set; }
        public string Empleado_Nombre { get; set; }
        public string Empleado_Cargo { get; set; }
        public int Plantilla_Id { get; set; }
        public int Horario_Id { get; set; }

        public Empleados() { }

        public Empleados(string empleado_NIT, string empleado_DPI, string empleado_Nombre, string empleado_Cargo, int plantilla_Id, int horario_Id)
        {
            Empleado_NIT = empleado_NIT;
            Empleado_DPI = empleado_DPI;
            Empleado_Nombre = empleado_Nombre;
            Empleado_Cargo = empleado_Cargo;
            Plantilla_Id = plantilla_Id;
            Horario_Id = horario_Id;
        }
    }
}
