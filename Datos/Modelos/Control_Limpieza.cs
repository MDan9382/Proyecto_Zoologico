using System;

namespace Proyecto_Zoologico.Datos.Modelos
{
    internal class Control_Limpieza
    {
        public int ControlLimpieza_Id { get; set; }
        public TimeSpan ControlLimpieza_Hora { get; set; }
        public int Empleado_Id { get; set; }

        public int ControlLimpieza_Fecha { get; set; }
        public int Locacion_Id { get; set; }
        public Control_Limpieza(TimeSpan controlLimpieza_Hora, int empleado_Id, int locacion_Id)
        {
            ControlLimpieza_Hora = controlLimpieza_Hora;
            Empleado_Id = empleado_Id;
            ControlLimpieza_Fecha = DateTime.Now.Day;
            Locacion_Id = locacion_Id;
        }
    }
}
