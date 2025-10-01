using System;

namespace Proyecto_Zoologico.Datos.Modelos
{
    public class Control_Clinico
    {
        public int ControlClinico_Id { get; set; }
        public DateTime ControlClinico_Fecha { get; set; }
        public string ControlClinico_Tratamiento { get; set; } = string.Empty;
        public string ControlClinico_Descripcion { get; set; } = string.Empty;
        public int Animal_Id { get; set; }
        public int Empleado_Id { get; set; }

        public Control_Clinico(DateTime controlClinico_Fecha, string controlClinico_Tratamiento, int animal_Id, int empleado_Id)
        {            
            ControlClinico_Fecha = controlClinico_Fecha;
            ControlClinico_Tratamiento = controlClinico_Tratamiento;
            Animal_Id = animal_Id;
            Empleado_Id = empleado_Id;
        }
    }
}
