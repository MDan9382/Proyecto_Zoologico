using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Zoologico.Datos.Modelos
{
    public class Alimentacion
    {
        public int Alimentacion_Id { get; set; }
        public TimeSpan Alimentacion_Hora { get; set; }
        public string Alimentacion_Dieta { get; set; }
        public int Inventario_Id { get; set; }
        

        public Alimentacion(TimeSpan alimentacion_Hora, string alimentacion_Dieta, int inventario_Id)
        {
            Alimentacion_Hora = alimentacion_Hora;
            Alimentacion_Dieta = alimentacion_Dieta;
            Inventario_Id = inventario_Id;
        }
    }
}
