using System;

namespace Proyecto_Zoologico.Datos.Modelos
{
    internal class Control_Tiempo
    {
        public int ControlTiempo_Id { get; set; }
        public DateTime ControlTiempo_Inicio { get; set; }
        public DateTime ControlTiempo_Fin { get; set; }
        public string ControlTiempo_Tipo { get; set; }
        public int Empleado_Id { get; set; }

        public Control_Tiempo(DateTime controlTiempo_Inicio, DateTime controlTiempo_Fin, string controlTiempo_Tipo, int empleado_Id)
        {
            ControlTiempo_Inicio = controlTiempo_Inicio;
            ControlTiempo_Fin = controlTiempo_Fin;
            ControlTiempo_Tipo = controlTiempo_Tipo;
            Empleado_Id = empleado_Id;
        }
    }
}
