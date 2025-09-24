using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Zoologico.Datos.Modelos
{
    internal class Entradas
    {
        public int Entrada_Id { get; set; }
        public string Entrada_Tipo { get; set; }
        public DateTime Entrada_Fecha { get; set; }

        public Entradas(string entrada_Tipo, DateTime entrada_Fecha)
        {
            Entrada_Tipo = entrada_Tipo;
            Entrada_Fecha = entrada_Fecha;
        }
    }
}
