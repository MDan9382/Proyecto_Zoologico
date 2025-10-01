using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Zoologico.Datos.Modelos
{
    public class Locaciones
    {
        public int Locacion_Id { get; set; }
        public string Locacion_Nombre { get; set; }
        public string Locacion_Tipo { get; set; }

        public Locaciones(string locacion_Nombre, string locacion_Tipo)
        {
            Locacion_Nombre = locacion_Nombre;
            Locacion_Tipo = locacion_Tipo;
        }
    }


}
