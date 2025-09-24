
using System;

namespace Proyecto_Zoologico.Datos.Modelos
{
    internal class Horarios
    {
        public int Horario_Id { get; set; }
        public TimeSpan Horario_Duracion { get; set; }
        public string Horario_Dias { get; set; }

        public Horarios() { }

        public Horarios(TimeSpan horario_Duracion, string horario_Dias)
        {
            Horario_Duracion = horario_Duracion;
            Horario_Dias = horario_Dias;
        }
    }
}
